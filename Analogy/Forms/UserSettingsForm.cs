using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Managers;
using Analogy.Types;
using Syncfusion.Windows.Forms.Tools;

namespace Analogy
{

    public partial class UserSettingsForm : Form
    {
        private struct FactoryCheckItem
        {
            public string Name;
            public Guid ID;

            public FactoryCheckItem(string name, Guid id)
            {
                Name = name;
                ID = id;
            }

            public override string ToString() => $"{Name} ({ID})";
        }

        private UserSettingsManager Settings { get; } = UserSettingsManager.UserSettings;
        private int InitialSelection = -1;

        public UserSettingsForm()
        {
            InitializeComponent();

        }

        public UserSettingsForm(int tabIndex) : this()
        {
            InitialSelection = tabIndex;
        }
        public UserSettingsForm(string tabName) : this()
        {
            var tab = tabControlMain.TabPages.Cast<TabPage>().SingleOrDefault<TabPage>(t => t.Name == tabName);
            if (tab != null)
                InitialSelection = tab.TabIndex;
        }
        private void LoadSettings()
        {
            //Filter tab
            tbFilteringLastEntries.ToggleState =
                Settings.SaveSearchFilters ? ToggleButtonState.Active : ToggleButtonState.Inactive;
            tbDataTimeAscendDescend.ToggleState =
                Settings.DefaultDescendOrder ? ToggleButtonState.Active : ToggleButtonState.Inactive;
            tbErrorLevelAsDefault.ToggleState =
                Settings.StartupErrorLogLevel ? ToggleButtonState.Active : ToggleButtonState.Inactive;

            tbAutoComplete.ToggleState =
                Settings.RememberLastSearches ? ToggleButtonState.Active : ToggleButtonState.Inactive;

            tbHistory.ToggleState =
                Settings.ShowHistoryOfClearedMessages ? ToggleButtonState.Active : ToggleButtonState.Inactive;


            cbPaging.Checked = Settings.PagingEnabled;
            nudPageLength.Enabled = Settings.PagingEnabled;

            tbFileCaching.ToggleState =
                Settings.EnableFileCaching ? ToggleButtonState.Active : ToggleButtonState.Inactive;

            nudRecent.Value = Settings.RecentFilesCount;
            tbUserStatistics.ToggleState =
                Settings.EnableUserStatistics ? ToggleButtonState.Active : ToggleButtonState.Inactive;
            //tsSimpleMode.IsOn = Settings.SimpleMode;
            tbExtensionsStartup.ToggleState = Settings.LoadExtensionsOnStartup ? ToggleButtonState.Active : ToggleButtonState.Inactive;
            if (Settings.PagingEnabled)
            {
                nudPageLength.Value = Settings.PagingSize;
            }
            else
            {
                nudPageLength.Enabled = false;
            }

            tbIdleMode.ToggleState = Settings.IdleMode? ToggleButtonState.Active:ToggleButtonState.Inactive;
            nudIdleTime.Value = Settings.IdleTimeMinutes;
            var manager = ExtensionsManager.Instance;
            var extensions = manager.GetExtensions().ToList();
            foreach (var extension in extensions)
            {

                clExtensionslItems.Items.Add(extension, Settings.StartupExtensions.Contains(extension.ExtensionID));
                clExtensionslItems.DisplayMember = "DisplayName";

            }

            var startup = Settings.AutoStartDataProviders;
            var loaded = FactoriesManager.Instance.GetRealTimeDataSourcesNamesAndIds();
            foreach (var realTime in loaded)
            {
                FactoryCheckItem itm = new FactoryCheckItem(realTime.Name, realTime.ID);
                chkLstItemRealTimeDataSources.Items.Add(itm, startup.Contains(itm.ID));
            }



            foreach (var setting in Settings.FactoriesOrder)
            {
                FactorySettings factory = Settings.GetFactorySetting(setting);
                if (factory == null) continue;
                FactoryCheckItem itm = new FactoryCheckItem(factory.FactoryName, factory.FactoryGuid);
                chkLstDataProviderStatus.Items.Add(itm, factory.Status == DataProviderFactoryStatus.Enabled);
            }
            //add missing:
            foreach (var factory in Settings.FactoriesSettings.Where(itm => !Settings.FactoriesOrder.Contains(itm.FactoryGuid)))
            {

                FactoryCheckItem itm = new FactoryCheckItem(factory.FactoryName, factory.FactoryGuid);
                chkLstDataProviderStatus.Items.Add(itm, factory.Status != DataProviderFactoryStatus.Disabled);
            }

            //file associations:
            cbDataProviderAssociation.DataSource = Settings.FactoriesSettings;
            cbDataProviderAssociation.DisplayMember = "FactoryName";
            tbRememberLastOpenedDataProvider.ToggleState = Settings.RememberLastOpenedDataProvider
                ? ToggleButtonState.Active
                : ToggleButtonState.Inactive;
            lboxHighlightItems.DataSource = Settings.PreDefinedQueries.Highlights;
            lboxAlerts.DataSource = Settings.PreDefinedQueries.Alerts;
            lboxFilters.DataSource = Settings.PreDefinedQueries.Filters;
            LoadColorSettings();
        }
        private void SaveSetting()
        {
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Unknown, tbLogLevelUnknown.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Disabled, tbLogLevelDisabled.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Trace, tbLogLevelTrace.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Verbose, tbLogLevelVerbose.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Debug, tbLogLevelDebug.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Event, tbLogLevelEvent.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Warning, tbLogLevelWarning.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Error, tbLogLevelError.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.Critical, tbLogLevelCritical.BackColor);
            Settings.ColorSettings.SetColorForLogLevel(AnalogyLogLevel.AnalogyInformation, tbLogLevelAnalogyInformation.BackColor);
            Settings.ColorSettings.SetHighlightColor(tbHighlightColor.BackColor);

            List<Guid> order = (from FactoryCheckItem itm in chkLstDataProviderStatus.Items select (itm.ID)).ToList();
            var checkedItem = chkLstDataProviderStatus.CheckedItems.Cast<FactoryCheckItem>().ToList();
            foreach (Guid guid in order)
            {
                var factory = Settings.FactoriesSettings.SingleOrDefault(f => f.FactoryGuid == guid);
                if (factory != null)
                {
                    factory.Status = checkedItem.Exists(f => f.ID == guid)
                        ? DataProviderFactoryStatus.Enabled
                        : DataProviderFactoryStatus.Disabled;
                }
            }
            Settings.RememberLastOpenedDataProvider = tbRememberLastOpenedDataProvider.ToggleState == ToggleButtonState.Active;
            Settings.UpdateOrder(order);
            Settings.Save();
        }

        private void LoadColorSettings()
        {
            tbLogLevelUnknown.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Unknown);
            tbLogLevelDisabled.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Disabled);
            tbLogLevelTrace.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Trace);
            tbLogLevelVerbose.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Verbose);
            tbLogLevelDebug.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Debug);
            tbLogLevelEvent.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Event);
            tbLogLevelWarning.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Warning);
            tbLogLevelError.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Error);
            tbLogLevelCritical.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.Critical);
            tbLogLevelAnalogyInformation.BackColor = Settings.ColorSettings.GetColorForLogLevel(AnalogyLogLevel.AnalogyInformation);
            tbHighlightColor.BackColor = Settings.ColorSettings.GetHighlightColor();
        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            SetupEventsHandlers();
            LoadSettings();
            if (InitialSelection >= 0)
                tabControlMain.SelectedIndex = InitialSelection;

        }

        private void SetupEventsHandlers()
        {
            #region filter tab
            tbFilteringLastEntries.ToggleStateChanged += (s, e) =>
                 {
                     Settings.SaveSearchFilters = e.ToggleState == ToggleButtonState.Active;
                 };
            tbDataTimeAscendDescend.ToggleStateChanged += (s, e) =>
            {
                Settings.DefaultDescendOrder = e.ToggleState == ToggleButtonState.Active;
            };
            tbErrorLevelAsDefault.ToggleStateChanged += (s, e) =>
            {
                Settings.StartupErrorLogLevel = tbErrorLevelAsDefault.ToggleState == ToggleButtonState.Active;
            };
            tbAutoComplete.ToggleStateChanged += (s, e) =>
            {
                Settings.RememberLastSearches = e.ToggleState == ToggleButtonState.Active;
            };
            tbHistory.ToggleStateChanged += (s, e) =>
            {
                Settings.ShowHistoryOfClearedMessages = e.ToggleState == ToggleButtonState.Active;
            };

            cbPaging.CheckedChanged += (s, e) =>
            {
                Settings.PagingEnabled = cbPaging.Checked;
                nudPageLength.Enabled = Settings.PagingEnabled;
            };

            nudPageLength.ValueChanged += (s, e) => { Settings.PagingSize = (int)nudPageLength.Value; };
            tbFileCaching.ToggleStateChanged += (s, e) =>
            {
                Settings.EnableFileCaching = e.ToggleState == ToggleButtonState.Active;
            };
            #endregion

            #region Pre-Defined Query

            sfBtnPreDefinedSelectColor.Click += (s, e) =>
            {
                if (colorDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    tbHighlighColor.BackColor = colorDialog1.Color;
                }
            };
            btnDeleteHighlight.Click += (s, e) =>
            {
                if (lboxHighlightItems.SelectedItem is PreDefineHighlight highlight)
                {
                    lboxHighlightItems.DataSource = null;
                    lboxHighlightItems.Items.Clear();
                    Settings.PreDefinedQueries.RemoveHighlight(highlight);
                    lboxHighlightItems.DataSource = Settings.PreDefinedQueries.Highlights;
                }
            };

            btnAddFilter.Click += (s, e) =>
            {
                lboxFilters.DataSource = null;
                Settings.PreDefinedQueries.AddFilter(tbIncludeTextFilter.Text, tbExcludeFilter.Text, tbSourcesFilter.Text, tbModulesFilter.Text);
                lboxFilters.DataSource = Settings.PreDefinedQueries.Filters;
            };
            btnDeleteFilter.Click += (s, e) =>
            {
                if (lboxFilters.SelectedItem is PreDefineFilter filter)
                {
                    lboxFilters.DataSource = null;
                    Settings.PreDefinedQueries.RemoveFilter(filter);
                    lboxFilters.DataSource = Settings.PreDefinedQueries.Filters;
                }
            };
            btnAddAlerts.Click += (s, e) =>
            {
                lboxAlerts.DataSource = null;
                Settings.PreDefinedQueries.AddAlert(tbIncludeTextAlert.Text, tbExcludeAlert.Text,
                    tbSourcesAlert.Text, tbModulesAlert.Text);
                lboxAlerts.DataSource = Settings.PreDefinedQueries.Alerts;
                lboxAlerts.Refresh();
            };
            btnDeleteAlerts.Click += (s, e) =>
            {
                if (lboxAlerts.SelectedItem is PreDefineAlert alert)
                {
                    lboxAlerts.DataSource = null;
                    Settings.PreDefinedQueries.RemoveAlert(alert);
                    lboxAlerts.DataSource = Settings.PreDefinedQueries.Alerts;
                    lboxAlerts.Refresh();
                }
            };

            #endregion

            #region Look and feel tab

            btnExportColors.Click += (s, e) =>
            {
                SaveSetting();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Analogy Color Settings (*.json)|*.json";
                saveFileDialog.Title = @"Export Analogy Color settings";

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {

                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, Settings.ColorSettings.AsJson());
                        MessageBox.Show("File Saved", @"Export settings", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        AnalogyLogManager.Instance.LogError("Error during save to file: " + e);
                        MessageBox.Show("Error Export: " + ex.Message, @"Error Saving file", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
            };
            btnImportColors.Click += (s, e) =>
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Analogy Color Settings (*.json)|*.json";
                openFileDialog1.Title = @"Import NLog settings";
                openFileDialog1.Multiselect = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var json = File.ReadAllText(openFileDialog1.FileName);
                        ColorSettings color = ColorSettings.FromJson(json);
                        Settings.ColorSettings = color;
                        LoadColorSettings();
                        MessageBox.Show("File Imported. Save settings if desired", @"Import settings",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        AnalogyLogManager.Instance.LogError("Error during import data: " + e);
                        MessageBox.Show("Error Import: " + ex.Message, @"Error Import file", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            };

            void SelectColor(TextBoxExt targetTextBox)
            {
                if (colorDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    targetTextBox.BackColor = colorDialog1.Color;
                }
            }

            sfBtnLogLevelUnknown.Click += (s, e) => SelectColor(tbLogLevelUnknown);
            sfBtnLogLevelDisabled.Click += (s, e) => SelectColor(tbLogLevelDisabled);
            sfBtnLogLevelTrace.Click += (s, e) => SelectColor(tbLogLevelTrace);
            sfBtnLogLevelVerbose.Click += (s, e) => SelectColor(tbLogLevelVerbose);
            sfBtnLogLevelDebug.Click += (s, e) => SelectColor(tbLogLevelDebug);
            sfBtnLogLevelEvent.Click += (s, e) => SelectColor(tbLogLevelEvent);
            sfBtnLogLevelWarning.Click += (s, e) => SelectColor(tbLogLevelWarning);
            sfBtnLogLevelError.Click += (s, e) => SelectColor(tbLogLevelError);
            sfBtnLogLevelCritical.Click += (s, e) => SelectColor(tbLogLevelCritical);
            sfBtnLogLevelAnalogyInformation.Click += (s, e) => SelectColor(tbLogLevelAnalogyInformation);
            sfBtnHighlightColor.Click += (s, e) => SelectColor(tbHighlightColor);
            #endregion

            #region User Statistics tab

            tbUserStatistics.ToggleStateChanged += (s, e) =>
            {
                EnableDisableUserStatistics(e.ToggleState == ToggleButtonState.Active);
                Settings.EnableUserStatistics = e.ToggleState == ToggleButtonState.Active;
            };
            btnClearStatistics.Click += (s, e) =>
            {
                var result = MessageBox.Show(@"Clear statistics?", @"Confirmation Required", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Settings.ClearStatistics();
                }
            };

            #endregion

            #region Extensions tab

            tbExtensionsStartup.ToggleStateChanged += (s, e) =>
            {
                Settings.LoadExtensionsOnStartup = e.ToggleState == ToggleButtonState.Active;
                clExtensionslItems.Enabled = e.ToggleState == ToggleButtonState.Active;
            };

            clExtensionslItems.SelectedIndexChanged += (s, e) =>
            {
                Settings.StartupExtensions = clExtensionslItems.CheckedItems.Cast<IAnalogyExtension>()
                    .Select(ex => ex.ExtensionID).ToList();
            };

            #endregion

            nudRecent.ValueChanged += (s, e) => Settings.RecentFilesCount = (int)nudRecent.Value;

            #region Resource Tab
            tbIdleMode.ToggleStateChanged += (s, e) => Settings.IdleMode = e.ToggleState == ToggleButtonState.Active;
            nudIdleTime.ValueChanged += (s, e) => Settings.IdleTimeMinutes = (int)nudIdleTime.Value;

            #endregion
        }


        private void EnableDisableUserStatistics(bool isOn)
        {
            if (isOn)
            {
                lblLaunchCount.Text = $@"Number of Analogy Launches: {Settings.AnalogyLaunches}";
                lblTotalTime.Text = $@"Total Time: {Settings.DisplayRunningTime}";
                lblOpenedFiles.Text = $@"Number Of Opened Files: {Settings.AnalogyOpenedFiles}";
            }
            else
            {
                lblLaunchCount.Text = @"Number of Analogy Launches: 0";
                lblTotalTime.Text = @"Total Time: 0";
                lblOpenedFiles.Text = @"Number Of Opened Files: N/A";
            }
        }

 

        private void ChkLstItemRealTimeDataSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.AutoStartDataProviders =
                chkLstItemRealTimeDataSources.CheckedItems.Cast<FactoryCheckItem>().Select(r => r.ID).ToList();
        }

        private void UserSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }



        private void sBtnImportColors_Click(object sender, EventArgs e)
        {

        }

        private void btnDataProviderCustomSettings_Click(object sender, EventArgs e)
        {
            UserSettingsDataProvidersForm user = new UserSettingsDataProvidersForm();
            user.ShowDialog(this);
        }

        private void sBtnMoveUp_Click(object sender, EventArgs e)
        {
            if (chkLstDataProviderStatus.SelectedIndex <= 0) return;
            var selectedIndex = chkLstDataProviderStatus.SelectedIndex;
            var currentValue = chkLstDataProviderStatus.Items[selectedIndex];
            chkLstDataProviderStatus.Items[selectedIndex] = chkLstDataProviderStatus.Items[selectedIndex - 1];
            chkLstDataProviderStatus.Items[selectedIndex - 1] = currentValue;
            chkLstDataProviderStatus.SelectedIndex = chkLstDataProviderStatus.SelectedIndex - 1;
        }

        private void sBtnMoveDown_Click(object sender, EventArgs e)
        {
            if (chkLstDataProviderStatus.SelectedIndex == chkLstDataProviderStatus.Items.Count - 1) return;
            var selectedIndex = chkLstDataProviderStatus.SelectedIndex;
            var currentValue = chkLstDataProviderStatus.Items[selectedIndex + 1];
            chkLstDataProviderStatus.Items[selectedIndex + 1] = chkLstDataProviderStatus.Items[selectedIndex];
            chkLstDataProviderStatus.Items[selectedIndex] = currentValue;
            chkLstDataProviderStatus.SelectedIndex = chkLstDataProviderStatus.SelectedIndex + 1;
        }

        private void cbDataProviderAssociation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDataProviderAssociation.SelectedItem is FactorySettings setting && setting.UserSettingFileAssociations.Any())
                txtbDataProviderAssociation.Text = string.Join(",", setting.UserSettingFileAssociations);
            else
                txtbDataProviderAssociation.Text = string.Empty;

        }

        private void btnSetFileAssociation_Click(object sender, EventArgs e)
        {
            if (cbDataProviderAssociation.SelectedItem is FactorySettings setting)
                setting.UserSettingFileAssociations = txtbDataProviderAssociation.Text
                    .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private void rbtnHighlightContains_CheckedChanged(object sender, EventArgs e)
        {
            tbHighlightContains.Enabled = rbtnHighlightContains.Checked;
            tbHighlightEquals.Enabled = rbtnHighlightEquals.Checked;
        }

        private void rbtnHighlightEquals_CheckedChanged(object sender, EventArgs e)
        {
            tbHighlightContains.Enabled = rbtnHighlightContains.Checked;
            tbHighlightEquals.Enabled = rbtnHighlightEquals.Checked;
        }

        private void sbtnAddHighlight_Click(object sender, EventArgs e)
        {
            if (rbtnHighlightContains.Checked)
            {
                lboxHighlightItems.DataSource = null;
                lboxHighlightItems.BeginUpdate();
                Settings.PreDefinedQueries.AddHighlight(tbHighlightContains.Text, PreDefinedQueryType.Contains, tbHighlighColor.BackColor);
                lboxHighlightItems.DataSource = Settings.PreDefinedQueries.Highlights;
                lboxHighlightItems.EndUpdate();
                lboxHighlightItems.Refresh();
            }

            if (rbtnHighlightEquals.Checked)
            {
                lboxHighlightItems.DataSource = null;
                lboxHighlightItems.BeginUpdate();
                Settings.PreDefinedQueries.AddHighlight(tbHighlightEquals.Text, PreDefinedQueryType.Equals, tbHighlighColor.BackColor);
                lboxHighlightItems.DataSource = Settings.PreDefinedQueries.Highlights;
                lboxHighlightItems.EndUpdate();
                lboxHighlightItems.Refresh();

            }
        }



        private void sbtnDeleteFilter_Click(object sender, EventArgs e)
        {
            if (lboxFilters.SelectedItem is PreDefineFilter filter)
            {
                Settings.PreDefinedQueries.RemoveFilter(filter);
                lboxFilters.DataSource = Settings.PreDefinedQueries.Filters;
                lboxFilters.Refresh();
            }
        }
    }
}

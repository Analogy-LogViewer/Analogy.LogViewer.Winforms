﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.DataSources;
using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.Managers;
using Analogy.Properties;
using Analogy.Tools;
using Analogy.Types;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Workspace;

namespace Analogy
{
    public partial class MainForm : KryptonForm
    {
        private string filePoolingTitle = "File Pooling";
        private string offlineTitle = "Offline log";
        private string onlineTitle = "Online log";
        private Dictionary<Guid, KryptonRibbonTab> Mapping = new Dictionary<Guid, KryptonRibbonTab>();

        private Dictionary<OnlineUCLogs, IAnalogyRealTimeDataProvider> onlineDataSourcesMapping =
            new Dictionary<OnlineUCLogs, IAnalogyRealTimeDataProvider>();

        private List<Task<bool>> OnlineSources = new List<Task<bool>>();
        private int offline;
        private int online;
        private int filePooling;
        private bool disableOnlineDueToFileOpen;
        private UserSettingsManager settings => UserSettingsManager.UserSettings;
        private bool Initialized { get; set; }
        private int _count = 1;
        private Random _random = new Random(DateTime.Now.Millisecond);
        private NavigatorMode _mode = NavigatorMode.HeaderBarCheckButtonHeaderGroup;
        private PaletteButtonSpecStyle[] _buttonSpecStyles = { PaletteButtonSpecStyle.ArrowDown, PaletteButtonSpecStyle.ArrowLeft,
                                                                                           PaletteButtonSpecStyle.ArrowRight, PaletteButtonSpecStyle.ArrowUp,
                                                                                           PaletteButtonSpecStyle.Close, PaletteButtonSpecStyle.Context,
                                                                                           PaletteButtonSpecStyle.DropDown };

        public MainForm()
        {
            InitializeComponent();
            AnalogyLogManager.Instance.OnNewError += (s, e) => BeginInvoke(new MethodInvoker(() => { tsslblError.Visible = true; }));

        }

        private KryptonPage NewDocument(Control control,string name)
        {
            KryptonPage page = NewPage(name, 0, control);

            // Document pages cannot be docked or auto hidden
            page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden | KryptonPageFlags.DockingAllowDocked);
            return page;
        }

        private KryptonPage NewInput()
        {
            return NewPage("Input ", 1, new ContentInput());
        }

        private KryptonPage NewPropertyGrid()
        {
            return NewPage("Properties ", 2, new ContentPropertyGrid());
        }

        private KryptonPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name + _count;
            p.TextTitle = name + _count;
            p.TextDescription = name + _count;
            p.Font = this.Font;
            // Add the control for display inside the page
            content.Font = this.Font;
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            _count++;
            return p;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KryptonDockingWorkspace w = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace);
            kryptonDockingManager.ManageControl(kryptonPanel, w);
            kryptonDockingManager.ManageFloating(this);


            // kryptonDockingManager.AddDockspace("Control", DockingEdge.Right, new[] { NewPropertyGrid(), NewInput(), NewPropertyGrid(), NewInput() });
            // kryptonDockingManager.AddDockspace("Control", DockingEdge.Bottom, new[] { NewInput(), NewPropertyGrid(), NewInput(), NewPropertyGrid() });

            UpdateModeButtons();



            tsslFileCaching.Text = $@"File caching is {(settings.EnableFileCaching ? "on" : "off")}";
            SetupEventHandlers();
            string[] arguments = Environment.GetCommandLineArgs();
            disableOnlineDueToFileOpen = arguments.Length == 2;
            if (DesignMode) return;

            ribbonControlMain.MinimizedMode = UserSettingsManager.UserSettings.StartupRibbonMinimized;

            await FactoriesManager.Instance.AddExternalDataSources();

            CreateDataSources();

            //set Default page:
            Guid defaultPage = new Guid(UserSettingsManager.UserSettings.InitialSelectedDataProvider);
            if (Mapping.ContainsKey(defaultPage))
            {
                ribbonControlMain.SelectedTab = Mapping[defaultPage];
            }

            if (OnlineSources.Any())
                TmrAutoConnect.Start();

            Initialized = true;
            //todo: fine handler for file
            if (arguments.Length == 2)
            {
                string[] fileNames = { arguments[1] };
                await OpenOfflineFileWithSpecificDataProvider(fileNames);

            }
            else
                TmrAutoConnect.Enabled = true;

            if (UserSettingsManager.UserSettings.ShowChangeLogAtStartUp)
            {
                var change = new ChangeLog();
                change.ShowDialog(this);
            }
            if (UserSettingsManager.UserSettings.RememberLastOpenedDataProvider && Mapping.ContainsKey(UserSettingsManager.UserSettings.LastOpenedDataProvider))
            {
                ribbonControlMain.SelectedTab = Mapping[UserSettingsManager.UserSettings.LastOpenedDataProvider];
            }
            ribbonControlMain.SelectedTabChanged += (s, arg) =>
            {
                if (Mapping.ContainsValue(ribbonControlMain.SelectedTab))
                {
                    Guid id = Mapping.Single(kv => kv.Value == ribbonControlMain.SelectedTab).Key;
                    UserSettingsManager.UserSettings.LastOpenedDataProvider = id;
                }
            };
            if (AnalogyLogManager.Instance.HasErrorMessages || AnalogyLogManager.Instance.HasWarningMessages)
                tsslblError.Visible = true;
        }

        private void kryptonDockingManager_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            // Set all new dockspace controls to a larger than default size
            e.DockspaceControl.Size = new Size(250, 250);
        }

        private void kryptonDockingManager_FloatingWindowAdding(object sender, FloatingWindowEventArgs e)
        {
            // Set all new floating windows to a larger than default size
            e.FloatingWindow.ClientSize = new Size(400, 400);
        }

        private void kryptonDockingManager_DockspaceCellAdding(object sender, DockspaceCellEventArgs e)
        {
            Console.WriteLine("DockspaceCellAdding");

            // Set the correct appearance of the dockspace cell based on current settings
            UpdateCell(e.CellControl);
        }

        private void kryptonDockingManager_FloatspaceCellAdding(object sender, FloatspaceCellEventArgs e)
        {
            // Set the correct appearance of the floatspace cell based on current settings
            UpdateCell(e.CellControl);
        }

        private void kryptonDockingManager_ShowPageContextMenu(object sender, ContextPageEventArgs e)
        {
            // Create a set of custom menu items
            KryptonContextMenuItems customItems = new KryptonContextMenuItems();
            KryptonContextMenuSeparator customSeparator = new KryptonContextMenuSeparator();
            KryptonContextMenuItem customItem1 = new KryptonContextMenuItem("Custom Item 1", OnCustomMenuItem);
            KryptonContextMenuItem customItem2 = new KryptonContextMenuItem("Custom Item 2", OnCustomMenuItem);
            customItem1.Tag = e.Page;
            customItem2.Tag = e.Page;
            customItems.Items.AddRange(new KryptonContextMenuItemBase[] { customSeparator, customItem1, customItem2 });

            // Add set of custom items into the provided menu
            e.KryptonContextMenu.Items.Add(customItems);
        }

        private void kryptonDockingManager_ShowWorkspacePageContextMenu(object sender, ContextPageEventArgs e)
        {
            // Create a set of custom menu items
            KryptonContextMenuItems customItems = new KryptonContextMenuItems();
            KryptonContextMenuSeparator customSeparator = new KryptonContextMenuSeparator();
            KryptonContextMenuItem customItem1 = new KryptonContextMenuItem("Custom Item 3", OnCustomMenuItem);
            KryptonContextMenuItem customItem2 = new KryptonContextMenuItem("Custom Item 4", OnCustomMenuItem);
            customItem1.Tag = e.Page;
            customItem2.Tag = e.Page;
            customItems.Items.AddRange(new KryptonContextMenuItemBase[] { customSeparator, customItem1, customItem2 });

            // Add set of custom items into the provided menu
            e.KryptonContextMenu.Items.Add(customItems);
        }

        private void OnCustomMenuItem(object sender, EventArgs e)
        {
            KryptonContextMenuItem menuItem = (KryptonContextMenuItem)sender;
            KryptonPage page = (KryptonPage)menuItem.Tag;
            MessageBox.Show("Clicked menu option '" + menuItem.Text + "' for the page '" + page.Text + "'.", "Page Context Menu");
        }

        private void colorsRandom_Click(object sender, EventArgs e)
        {
            foreach (KryptonPage page in kryptonDockingManager.Pages)
            {
                page.StateNormal.Tab.Content.ShortText.Color1 = RandomColor();
                page.StateNormal.Tab.Back.Color1 = RandomColor();
                page.StateNormal.Tab.Back.ColorStyle = PaletteColorStyle.Solid;

                page.StateNormal.RibbonTab.TabDraw.TextColor = RandomColor();
                page.StateNormal.RibbonTab.TabDraw.BackColor1 = RandomColor();
                page.StateNormal.RibbonTab.TabDraw.BackColor2 = RandomColor();

                page.StateNormal.CheckButton.Content.ShortText.Color1 = RandomColor();
                page.StateNormal.CheckButton.Back.Color1 = RandomColor();
                page.StateNormal.CheckButton.Back.ColorStyle = PaletteColorStyle.Solid;
            }
        }

        private void colorsReset_Click(object sender, EventArgs e)
        {
            foreach (KryptonPage page in kryptonDockingManager.Pages)
            {
                page.StateNormal.Tab.Content.ShortText.Color1 = Color.Empty;
                page.StateNormal.Tab.Back.Color1 = Color.Empty;
                page.StateNormal.Tab.Back.ColorStyle = PaletteColorStyle.Inherit;

                page.StateNormal.RibbonTab.TabDraw.TextColor = Color.Empty;
                page.StateNormal.RibbonTab.TabDraw.BackColor1 = Color.Empty;
                page.StateNormal.RibbonTab.TabDraw.BackColor2 = Color.Empty;

                page.StateNormal.CheckButton.Content.ShortText.Color1 = Color.Empty;
                page.StateNormal.CheckButton.Back.Color1 = Color.Empty;
                page.StateNormal.CheckButton.Back.ColorStyle = PaletteColorStyle.Inherit;
            }
        }

        private void buttonSpecsAdd_Click(object sender, EventArgs e)
        {
            foreach (KryptonPage page in kryptonDockingManager.Pages)
            {
                // Create a button spec and make it a random style so we get a random image
                ButtonSpecAny bs = new ButtonSpecAny();
                bs.Type = _buttonSpecStyles[_random.Next(_buttonSpecStyles.Length)];
                page.ButtonSpecs.Add(bs);
            }
        }

        private void buttonSpecsClear_Click(object sender, EventArgs e)
        {
            foreach (KryptonPage page in kryptonDockingManager.Pages)
                page.ButtonSpecs.Clear();
        }

        private void kryptonRibbonModeButton_Click(object sender, EventArgs e)
        {
            // Extract the navigator mode from the tag field of the ribbon button
            KryptonRibbonGroupButton button = (KryptonRibbonGroupButton)sender;
            _mode = (NavigatorMode)Enum.Parse(typeof(NavigatorMode), (string)button.Tag);

            UpdateModeButtons();
            UpdateAllCells();
        }

        private void UpdateModeButtons()
        {
            modeHeaderGroupTab.Checked = (_mode == NavigatorMode.HeaderGroupTab);
            modeHeaderBarHeaderGroup.Checked = (_mode == NavigatorMode.HeaderBarCheckButtonHeaderGroup);
            modeHeaderBarGroup.Checked = (_mode == NavigatorMode.HeaderBarCheckButtonGroup);
            modeTabGroup.Checked = (_mode == NavigatorMode.BarTabGroup);
            modeBarGroupInside.Checked = (_mode == NavigatorMode.BarCheckButtonGroupInside);
            modeBarGroupOutside.Checked = (_mode == NavigatorMode.BarCheckButtonGroupOutside);
            modeBarRibbonTabGroup.Checked = (_mode == NavigatorMode.BarRibbonTabGroup);
            modeStackGroup.Checked = (_mode == NavigatorMode.StackCheckButtonGroup);
            modeStackHeaderGroup.Checked = (_mode == NavigatorMode.StackCheckButtonHeaderGroup);
        }

        private void UpdateAllCells()
        {
            foreach (KryptonWorkspaceCell cell in kryptonDockingManager.CellsDocked)
                UpdateCell(cell);

            foreach (KryptonWorkspaceCell cell in kryptonDockingManager.CellsFloating)
                UpdateCell(cell);
        }

        private void UpdateCell(KryptonWorkspaceCell cell)
        {
            cell.NavigatorMode = _mode;
        }

        private Color RandomColor()
        {
            return Color.FromArgb(_random.Next(255), _random.Next(255), _random.Next(255));
        }

        private void SetupEventHandlers()
        {
            IAnalogyFactory analogy = FactoriesManager.Instance.Get(AnalogyBuiltInFactory.AnalogyGuid);
            var offlineAnalogy = analogy.DataProviders.Items.Where(f => f is IAnalogyOfflineDataProvider)
                .Cast<IAnalogyOfflineDataProvider>().First();
            //if (settings.GetFactorySetting(analogy.FactoryID).Status != DataProviderFactoryStatus.Disabled)

            tsbtnAnalogyOpenFolder.Click += (sender, e) => { OpenOffline(RibbonTabAnalogy, offlineAnalogy, offlineAnalogy.OptionalTitle, offlineAnalogy.InitialFolderFullPath); };
            tsbtnAnalogyOpenFiles.Click += (sender, e) =>
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Filter = offlineAnalogy.FileOpenDialogFilters,
                    Title = @"Open Files",
                    Multiselect = true
                };
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    OpenOffline(RibbonTabAnalogy, offlineAnalogy, offlineAnalogy.OptionalTitle, offlineAnalogy.InitialFolderFullPath,
                        openFileDialog1.FileNames);
                    AddRecentFiles(RibbonTabAnalogy, contextMenuStripRecentFiles, offlineAnalogy, offlineAnalogy.OptionalTitle,
                        openFileDialog1.FileNames.ToList());
                }
            };


            tmrStatusUpdates.Tick += TmrStatusUpdates_Tick;
            tsslFileCaching.Click += (s, e) =>
            {
                settings.EnableFileCaching = !settings.EnableFileCaching;
                tsslFileCaching.Text = $@"File caching is {(settings.EnableFileCaching ? "on" : "off")}";
            };
            tsbSettingsFiltering.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(0);
                user.ShowDialog(this);
            };
            tsbSettingsPreDefined.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(1);
                user.ShowDialog(this);
            };
            tsbSettingsLookAndFeel.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(2);
                user.ShowDialog(this);
            };
            tsbSettingsUserStatistics.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(3);
                user.ShowDialog(this);
            };
            tsbSettingsExtension.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(4);
                user.ShowDialog(this);
            };
            tsbSettingsShortcuts.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(5);
                user.ShowDialog(this);
            };
            tsbSettingsMRU.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(6);
                user.ShowDialog(this);
            };
            tsbSettingsResources.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(7);
                user.ShowDialog(this);
            };
            tsbSettingsDataProviders.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(8);
                user.ShowDialog(this);
            };
            tsbSettingsCustomDataProviders.Click += (s, e) =>
            {
                UserSettingsForm user = new UserSettingsForm(9);
                user.ShowDialog(this);
            };
        }

        private void TmrStatusUpdates_Tick(object sender, EventArgs e)
        {
            tmrStatusUpdates.Stop();
            tsslMemoryUsage.Text = Process.GetCurrentProcess().PrivateMemorySize64 / 1024 / 1024 + " [MB]";
            if (settings.IdleMode)
            {
                tsslIdleMessage.Text = $@"Idle mode is on. User idle: {Utils.IdleTime():hh\:mm\:ss}. Missed messages: {PagingManager.TotalMissedMessages}";
            }
            else
                tsslIdleMessage.Text = "Idle mode is off";

            tmrStatusUpdates.Start();
        }
        private void CreateDataSources()
        {
            foreach (IAnalogyFactory factory in FactoriesManager.Instance.GetFactories()
                .Where(factory => !FactoriesManager.Instance.IsBuiltInFactory(factory) &&
                                  settings.GetFactorySetting(factory.FactoryID).Status != DataProviderFactoryStatus.Disabled))
            {
                CreateDataSource(factory, 3);
            }

        }

        private void CreateDataSource(IAnalogyFactory factory, int position)
        {
            if (factory.Title == null) return;

            KryptonRibbonTab ribbonPage = new KryptonRibbonTab { Text = factory.Title };
            ribbonControlMain.RibbonTabs.Add(ribbonPage);
            Mapping.Add(factory.FactoryID, ribbonPage);

            //todo:move logic to factory manager
            var dataSourceFactory = factory.DataProviders;
            if (dataSourceFactory?.Items != null && dataSourceFactory.Items.Any() &&
                !string.IsNullOrEmpty(dataSourceFactory.Title))
            {
                CreateDataSourceRibbonGroup(dataSourceFactory, ribbonPage);
            }

            var actionFactory = factory.Actions;
            if (actionFactory?.Items != null && actionFactory.Items.Any() && !string.IsNullOrEmpty(actionFactory.Title))
            {
                KryptonRibbonGroup groupActionSource = new KryptonRibbonGroup
                {
                    Tag = actionFactory.Title,

                };
                ribbonPage.Groups.Add(groupActionSource);
                foreach (IAnalogyCustomAction action in actionFactory.Items)
                {
                    ToolStripButton actionBtn = new ToolStripButton(action.Title, Resources.PageSetup_32x32)
                    {
                        DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                        TextImageRelation = TextImageRelation.ImageAboveText
                    };
                    groupActionSource.Items.Add(actionBtn);
                    actionBtn.Click += (sender, e) => { action.Action(); };
                }
            }

            KryptonRibbonGroup groupInfoSource = new KryptonRibbonGroup
            {
                TextLine1 = "About",

            };
            ribbonPage.Groups.Add(groupInfoSource);
            var aboutBtn = new KryptonRibbonGroupButton()
            {
                TextLine1 = "Data Source Information",
                ImageLarge = Resources.About_32x32
            };
            KryptonRibbonGroupTriple container = new KryptonRibbonGroupTriple();
            container.Items.AddRange(new KryptonRibbonGroupItem[] { aboutBtn });
            groupInfoSource.Items.AddRange(new KryptonRibbonGroupContainer[] { container });
            aboutBtn.Click += (sender, e) => { new AboutDataSourceBox(factory).ShowDialog(this); };
        }

        private void CreateDataSourceRibbonGroup(IAnalogyDataProvidersFactory dataSourceFactory, KryptonRibbonTab ribbonPage)
        {
            KryptonRibbonGroup ribbonPageGroup = new KryptonRibbonGroup { TextLine1 = dataSourceFactory.Title };
            ribbonPage.Groups.Add(ribbonPageGroup);

            AddRealTimeDataSource(ribbonPage, dataSourceFactory, ribbonPageGroup);
            AddOfflineDataSource(ribbonPage, dataSourceFactory, ribbonPageGroup);


            //add bookmark
            var bookmarkBtn = new KryptonRibbonGroupButton()
            {
                TextLine1 = "Bookmarks",
                ImageLarge = Resources.RichEditBookmark_32x32
            };
            KryptonRibbonGroupTriple container = new KryptonRibbonGroupTriple();
            container.Items.AddRange(new KryptonRibbonGroupItem[] { bookmarkBtn });
            ribbonPageGroup.Items.AddRange(new[] { container });
            bookmarkBtn.Click += (sender, e) => { OpenBookmarkLog(); };
        }

        private void AddToDockingManager(Control control, string title)
        {
            var page = NewDocument(control,title);
            var workspace = kryptonDockingManager.AddToWorkspace("Workspace", new[] { page });


        }
        private void AddRealTimeDataSource(KryptonRibbonTab ribbonPage, IAnalogyDataProvidersFactory dataSourceFactory, KryptonRibbonGroup group)
        {
            var realtimes = dataSourceFactory.Items.Where(f => f is IAnalogyRealTimeDataProvider)
                .Cast<IAnalogyRealTimeDataProvider>().ToList();
            if (realtimes.Count == 0) return;
            if (realtimes.Count == 1)
            {
                AddSingleRealTimeDataSource(ribbonPage, realtimes.First(), dataSourceFactory.Title, group);
            }
            else
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                KryptonRibbonGroupButton realTimeButton =
                    new KryptonRibbonGroupButton()
                    {
                        ImageLarge = Resources.Database_off,
                        TextLine1 = "Real Time Logs",
                    };
                realTimeButton.ContextMenuStrip = menu;
                KryptonRibbonGroupTriple container = new KryptonRibbonGroupTriple();
                container.Items.AddRange(new KryptonRibbonGroupItem[] { realTimeButton });
                group.Items.AddRange(new[] { container });
                foreach (var realTime in realtimes)
                {
                    ToolStripMenuItem realTimeBtn = new ToolStripMenuItem()
                    {
                        Image = Resources.Database_off,
                        Text = "Real Time Logs" + (!string.IsNullOrEmpty(realTime.OptionalTitle)
                                   ? $" - {realTime.OptionalTitle}"
                                   : string.Empty)
                    };
                    menu.Items.Add(realTimeBtn);
                    async Task<bool> OpenRealTime()
                    {
                        realTimeBtn.Enabled = false;
                        bool canStartReceiving = false;
                        try
                        {
                            canStartReceiving = await realTime.CanStartReceiving();
                        }
                        catch (Exception e)
                        {
                            AnalogyLogManager.Instance.LogError("Error during call to canStartReceiving: " + e);
                        }

                        if (canStartReceiving) //connected
                        {
                            online++;
                            realTimeBtn.Image = Resources.Database_on;
                            var onlineUC = new OnlineUCLogs(realTime);

                            void OnRealTimeOnMessageReady(object sender, AnalogyLogMessageArgs e) =>
                                onlineUC.AppendMessage(e.Message, Environment.MachineName);

                            void OnRealTimeOnOnManyMessagesReady(object sender, AnalogyLogMessagesArgs e) =>
                                onlineUC.AppendMessages(e.Messages, Environment.MachineName);

                            void OnRealTimeDisconnected(object sender, AnalogyDataSourceDisconnectedArgs e)
                            {
                                AnalogyLogMessage disconnected = new AnalogyLogMessage(
                                    $"Source {dataSourceFactory.Title} Disconnected. Reason: {e.DisconnectedReason}",
                                    AnalogyLogLevel.AnalogyInformation, AnalogyLogClass.General, dataSourceFactory.Title, "Analogy");
                                onlineUC.AppendMessage(disconnected, Environment.MachineName);
                                realTimeBtn.Image = Resources.Database_off;
                            }

                            onlineUC.Tag = ribbonPage;
                            ribbonControlMain.SelectedTab = ribbonPage;
                            onlineUC.Dock = DockStyle.Fill;
                            onlineUC.Text = $"{onlineTitle} #{online} ({dataSourceFactory.Title})";
                            AddToDockingManager(onlineUC, onlineUC.Text);
                            //xtcLogs.TabPages.Add(page);
                            realTime.OnMessageReady += OnRealTimeOnMessageReady;
                            realTime.OnManyMessagesReady += OnRealTimeOnOnManyMessagesReady;
                            realTime.OnDisconnected += OnRealTimeDisconnected;
                            realTime.StartReceiving();
                            onlineDataSourcesMapping.Add(onlineUC, realTime);

                            //todo
                            //dockingManager1.ActivateControl(onlineUC);
                            //void OnXtcLogsOnControlRemoved(object sender, DockVisibilityChangedEventArgs arg)
                            //{
                            //    if (arg.Control == onlineUC)
                            //    {
                            //        try
                            //        {
                            //            onlineUC.Enable = false;
                            //            realTime.StopReceiving();
                            //            realTime.OnMessageReady -= OnRealTimeOnMessageReady;
                            //            realTime.OnManyMessagesReady -= OnRealTimeOnOnManyMessagesReady;
                            //            realTime.OnDisconnected -= OnRealTimeDisconnected;
                            //            //page.Controls.Remove(onlineUC);
                            //        }
                            //        catch (Exception e)
                            //        {
                            //            AnalogyLogManager.Instance.LogError(
                            //                "Error during call to Stop receiving: " + e);
                            //        }
                            //        finally
                            //        {
                            //            dockingManager1.DockVisibilityChanged -= OnXtcLogsOnControlRemoved;
                            //        }
                            //    }
                            //}
                            //dockingManager1.DockVisibilityChanged += OnXtcLogsOnControlRemoved;
                            ////xtcLogs.ControlRemoved += OnXtcLogsOnControlRemoved;
                            realTimeBtn.Enabled = true;
                            return true;
                        }

                        realTimeBtn.Enabled = true;
                        return false;
                    }

                    realTimeBtn.Click += async (s, be) => await OpenRealTime();
                    if (settings.AutoStartDataProviders.Contains(realTime.ID)
                        && !disableOnlineDueToFileOpen)
                    {
                        async Task<bool> AutoOpenRealTime()
                        {
                            while (!await OpenRealTime())
                            {
                                await Task.Delay(1000);
                            }

                            return true;
                        }

                        OnlineSources.Add(AutoOpenRealTime());

                    }

                }
            }
        }

        private void AddOfflineDataSource(KryptonRibbonTab ribbonPage, IAnalogyDataProvidersFactory factory, KryptonRibbonGroup group)
        {

            var offlineProviders = factory.Items.Where(f => f is IAnalogyOfflineDataProvider)
                .Cast<IAnalogyOfflineDataProvider>().ToList();

            if (!offlineProviders.Any()) return;
            if (offlineProviders.Count == 1)
            {
                var offlineAnalogy = offlineProviders.First();
                string optionalText = !string.IsNullOrEmpty(offlineAnalogy.OptionalTitle)
                    ? " for" + offlineAnalogy.OptionalTitle
                    : string.Empty;
                KryptonRibbonGroup groupOfflineFileTools = new KryptonRibbonGroup { TextLine1 = $"Tools{optionalText}" };
                AddSingleOfflineDataSource(ribbonPage, offlineAnalogy, factory.Title, group, groupOfflineFileTools);
                // groupOfflineFileTools.AllowMenuTextAlignment = true;
                ribbonPage.Groups.Add(groupOfflineFileTools);

                //int width = 0;

                //foreach (ToolStripItem control in groupOfflineFileTools.Items)
                //{
                //    width += control.Size.Width;
                //}
                //groupOfflineFileTools.Size = new Size(width + 70, groupOfflineFileTools.Size.Height);
            }
            else
            {
                AddMultiplesOfflineDataSource(ribbonPage, offlineProviders, factory.Title, group);
            }

        }

        private void AddMultiplesOfflineDataSource(KryptonRibbonTab ribbonPage,
            List<IAnalogyOfflineDataProvider> offlineProviders, string factoryTitle, KryptonRibbonGroup group)
        {
            void OpenOffline(string titleOfDataSource, IAnalogyOfflineDataProvider dataProvider, string initialFolder,
                string[] files = null)
            {
                offline++;
                UserControl offlineUC = new OfflineUCLogs(dataProvider, files, initialFolder)
                {
                    Tag = ribbonPage
                };
                offlineUC.Dock = DockStyle.Fill;
                offlineUC.Text = $"{offlineTitle} #{offline} ({titleOfDataSource})";

                AddToDockingManager(offlineUC, offlineUC.Text);
                //todo
                //dockingManager1.ActivateControl(offlineUC);
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
            }

            void OpenExternalDataSource(string titleOfDataSource, IAnalogyOfflineDataProvider analogy)
            {
                offline++;
                var ClientServerUCLog = new ClientServerUCLog(analogy);


                ClientServerUCLog.Tag = ribbonPage;
                ClientServerUCLog.Controls.Add(ClientServerUCLog);
                ClientServerUCLog.Dock = DockStyle.Fill;
                ClientServerUCLog.Text = $"Client/Server logs #{offline}. {titleOfDataSource}";
                AddToDockingManager(ClientServerUCLog, ClientServerUCLog.Text);
                //dockingManager1.ActivateControl(ClientServerUCLog);
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
            }

            void OpenFilePooling(string titleOfDataSource, IAnalogyOfflineDataProvider dataProvider,
                string initialFolder, string file)
            {

                offline++;
                UserControl filepoolingUC = new FilePoolingUCLogs(dataProvider, file, initialFolder);

                //todo
                //void OnXtcLogsOnControlRemoved(object sender, DockVisibilityChangedEventArgs arg)
                //{
                //    if (arg.Control == filepoolingUC)
                //    {
                //        try
                //        {
                //            filepoolingUC.Dispose();
                //        }
                //        catch (Exception e)
                //        {
                //            AnalogyLogManager.Instance.LogError("Error during dispose: " + e);
                //        }
                //        finally
                //        {
                //            dockingManager1.DockVisibilityChanged -= OnXtcLogsOnControlRemoved;
                //        }
                //    }
                //}

                filepoolingUC.Tag = ribbonPage;
                filepoolingUC.Dock = DockStyle.Fill;
                filepoolingUC.Text = $"{filePoolingTitle} #{filePooling} ({titleOfDataSource})";
                AddToDockingManager(filepoolingUC, filepoolingUC.Text);
                //dockingManager1.ActivateControl(filepoolingUC);
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
                //dockingManager1.DockVisibilityChanged += OnXtcLogsOnControlRemoved;
            }

            //local folder
            if (offlineProviders.Any(i => !string.IsNullOrEmpty(i.InitialFolderFullPath) &&
                                          Directory.Exists(i.InitialFolderFullPath)))
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                KryptonRibbonGroupButton folderBar = new KryptonRibbonGroupButton()
                {
                    TextLine1 = "Open Folder",
                    ImageLarge = Resources.Open2_32x32,
                };
                folderBar.ContextMenuStrip = menu;
                KryptonRibbonGroupTriple container = new KryptonRibbonGroupTriple();
                container.Items.AddRange(new KryptonRibbonGroupItem[] { folderBar });
                group.Items.AddRange(new[] { container });

                foreach (var dataProvider in offlineProviders)
                {

                    //add local folder button:
                    if (!string.IsNullOrEmpty(dataProvider.InitialFolderFullPath) &&
                        Directory.Exists(dataProvider.InitialFolderFullPath))
                    {
                        ToolStripMenuItem btn = new ToolStripMenuItem { Text = dataProvider.InitialFolderFullPath };
                        btn.Click += (s, be) =>
                        {
                            OpenOffline(dataProvider.OptionalTitle, dataProvider,
                                dataProvider.InitialFolderFullPath);
                        };

                        menu.Items.Add(btn);
                    }
                }
            }

            //recent bar
            var recentButton = new KryptonRibbonGroupButton();
            recentButton.TextLine1 = "Recently Used";
            recentButton.TextLine2 = "Files";
            recentButton.ImageLarge = Resources.RecentlyUse_32x32;
            var recentBar = new ContextMenuStrip();
            recentButton.ContextMenuStrip = recentBar;

            //add Files open buttons
            if (offlineProviders.Any(i => !string.IsNullOrEmpty(i.FileOpenDialogFilters)))
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                //add Open files entry
                var openFiles = new KryptonRibbonGroupButton()
                {
                    TextLine1 = "Open Files",
                    ImageLarge = Resources.Article_32x32
                };
                openFiles.ContextMenuStrip = menu;
                KryptonRibbonGroupTriple container = new KryptonRibbonGroupTriple();
                container.Items.AddRange(new KryptonRibbonGroupItem[] { openFiles });
                group.Items.AddRange(new[] { container });
                foreach (var dataProvider in offlineProviders)
                {

                    if (!string.IsNullOrEmpty(dataProvider.FileOpenDialogFilters))
                    {
                        ToolStripMenuItem btnOpenFile = new ToolStripMenuItem { Text = $"{factoryTitle} ({dataProvider.OptionalTitle})" };
                        btnOpenFile.Click += (sender, e) =>
                        {
                            OpenFileDialog openFileDialog1 = new OpenFileDialog
                            {
                                Filter = dataProvider.FileOpenDialogFilters,
                                Title = @"Open Files",
                                Multiselect = true
                            };
                            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                OpenOffline(dataProvider.OptionalTitle, dataProvider,
                                    dataProvider.InitialFolderFullPath, openFileDialog1.FileNames);
                                AddRecentFiles(ribbonPage, recentBar, dataProvider, dataProvider.OptionalTitle,
                                    openFileDialog1.FileNames.ToList());
                            }
                        };
                        menu.Items.Add(btnOpenFile);
                    }
                }


                ContextMenuStrip menu2 = new ContextMenuStrip();
                //add Open Pooled file entry
                KryptonRibbonGroupButton filePoolingBtn =
                    new KryptonRibbonGroupButton
                    {
                        TextLine1 = "File Pooling",
                        ImageLarge = Resources.FilePooling_32x32,
                        ContextMenuStrip = menu2
                    };

                KryptonRibbonGroupTriple container2 = new KryptonRibbonGroupTriple();
                container2.Items.AddRange(new KryptonRibbonGroupItem[] { openFiles });
                group.Items.AddRange(new[] { container2 });


                foreach (var dataProvider in offlineProviders)
                {
                    ToolStripMenuItem btnOpenFile = new ToolStripMenuItem { Text = $"{factoryTitle} ({dataProvider.OptionalTitle})" };
                    btnOpenFile.Click += (sender, e) =>
                    {
                        OpenFileDialog openFileDialog1 = new OpenFileDialog
                        {
                            Filter = dataProvider.FileOpenDialogFilters,
                            Title = @"Open File for pooling",
                            Multiselect = false
                        };
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            OpenFilePooling(dataProvider.OptionalTitle, dataProvider,
                                dataProvider.InitialFolderFullPath, openFileDialog1.FileName);
                            AddRecentFiles(ribbonPage, recentBar, dataProvider, dataProvider.OptionalTitle,
                                new List<string> { openFileDialog1.FileName });
                        }
                    };
                    menu2.Items.Add(btnOpenFile);
                }
            }



            KryptonRibbonGroupTriple containerRecent = new KryptonRibbonGroupTriple();
            containerRecent.Items.AddRange(new KryptonRibbonGroupItem[] { recentButton });
            group.Items.AddRange(new[] { containerRecent });
            //add recent
            foreach (var dataProvider in offlineProviders)
            {
                var recents = UserSettingsManager.UserSettings.RecentFiles.Where(itm => itm.ID == dataProvider.ID)
                    .Select(itm => itm.FileName).ToList();
                AddRecentFiles(ribbonPage, recentBar, dataProvider, dataProvider.OptionalTitle, recents);
            }

            ContextMenuStrip menu3 = new ContextMenuStrip();
            KryptonRibbonGroupButton externalSources = new KryptonRibbonGroupButton()
            {
                TextLine1 = "Known Locations",
                ImageLarge = Resources.ServerMode_32x32,
                ContextMenuStrip = menu3
            };
            KryptonRibbonGroupTriple container3 = new KryptonRibbonGroupTriple();
            container3.Items.AddRange(new KryptonRibbonGroupItem[] { externalSources });
            group.Items.AddRange(new[] { container3 });
            //add client/server  button:
            foreach (var dataProvider in offlineProviders)
            {
                ToolStripMenuItem btnOpenLocation = new ToolStripMenuItem { Text = $"{factoryTitle} ({dataProvider.OptionalTitle})" };
                btnOpenLocation.Click += (sender, e) =>
                {
                    OpenExternalDataSource(dataProvider.OptionalTitle, dataProvider);
                };
                menu3.Items.Add(btnOpenLocation);
            }
            //todo:add tools

            //add tools
            //ContextMenuStrip menu4 = new ContextMenuStrip();
            //KryptonRibbonGroupButton groupOfflineFileTools = new KryptonRibbonGroupButton()
            //{
            //    TextLine1 = $"Tools for {factoryTitle}",
            //  };

            //var searchFiles = new KryptonRibbonGroupButton()
            //{
            //    TextLine1 ="Search in Files",
            //    ImageLarge = Resources.Lookup_Reference_32x32
            //};
            //groupOfflineFileTools.Items.Add(searchFiles);
            //foreach (var dataProvider in offlineProviders)
            //{
            //    var btnSearching = new ToolStripMenuItem { Text = $" search in: {factoryTitle} ({dataProvider.OptionalTitle})" };
            //    btnSearching.Click += (sender, e) =>
            //    {
            //        var search = new SearchForm(dataProvider);
            //        search.Show(this);
            //    };
            //    searchFiles.DropDownItems.Add(btnSearching);
            //}


            //var combineFiles = new ToolStripDropDownButton("Combine Files", Resources.Sutotal_32x32)
            //{
            //    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
            //    TextImageRelation = TextImageRelation.ImageAboveText
            //};
            //groupOfflineFileTools.Items.Add(combineFiles);

            //foreach (var dataProvider in offlineProviders)
            //{
            //    var btnCombine = new ToolStripMenuItem { Text = $"Combine files for: {factoryTitle} ({dataProvider.OptionalTitle})" };
            //    btnCombine.Click += (sender, e) =>
            //    {
            //        var combined = new FormCombineFiles(dataProvider);
            //        combined.Show(this);
            //    };
            //    combineFiles.DropDownItems.Add(btnCombine);
            //}



            //var compareFiles = new ToolStripDropDownButton("Compare Files", Resources.TwoColumns)
            //{
            //    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
            //    TextImageRelation = TextImageRelation.ImageAboveText
            //};
            //groupOfflineFileTools.Items.Add(compareFiles);
            //foreach (var dataProvider in offlineProviders)
            //{
            //    var btnCombine = new ToolStripMenuItem { Text = $"Compare files for: {factoryTitle} ({dataProvider.OptionalTitle})" };
            //    btnCombine.Click += (sender, e) =>
            //    {
            //        FileComparerForm compare = new FileComparerForm(dataProvider);
            //        compare.ShowDialog(this);
            //    };
            //    compareFiles.DropDownItems.Add(btnCombine);
            //}
        }

        private void OpenOffline(KryptonRibbonTab ribbonPage, IAnalogyOfflineDataProvider offlineAnalogy, string titleOfDataSource, string initialFolder, string[] files = null)
        {
            offline++;
            UserControl page = new OfflineUCLogs(offlineAnalogy, files, initialFolder);
            page.Tag = ribbonPage;
            page.Text = $"{offlineTitle} #{offline} ({titleOfDataSource})";
            AddToDockingManager(page, page.Text);
        }
        private void AddSingleOfflineDataSource(KryptonRibbonTab ribbonPage, IAnalogyOfflineDataProvider offlineAnalogy,
           string title, KryptonRibbonGroup group, KryptonRibbonGroup groupOfflineFileTools)
        {
            void OpenExternalDataSource(string titleOfDataSource, IAnalogyOfflineDataProvider analogy)
            {
                offline++;
                var page = new ClientServerUCLog(analogy);
                page.Tag = ribbonPage;
                page.Text = $"Client/Server logs #{offline}. {titleOfDataSource}";

                AddToDockingManager(page, page.Text);
                //dockingManager1.ActivateControl(page);
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
            }
            void OpenFilePooling(string titleOfDataSource, string initialFolder, string file)
            {

                offline++;
                UserControl page = new FilePoolingUCLogs(offlineAnalogy, file, initialFolder);
                //todo
                //void OnXtcLogsOnControlRemoved(object sender, DockVisibilityChangedEventArgs arg)
                //{
                //    if (arg.Control == page)
                //    {
                //        try
                //        {
                //            page.Dispose();
                //        }
                //        catch (Exception e)
                //        {
                //            AnalogyLogManager.Instance.LogError("Error during dispose: " + e);
                //        }
                //        finally
                //        {
                //            dockingManager1.DockVisibilityChanged -= OnXtcLogsOnControlRemoved;
                //        }
                //    }
                //}

                page.Tag = ribbonPage;
                page.Text = $"{filePoolingTitle} #{filePooling} ({titleOfDataSource})";
                AddToDockingManager(page, page.Text);
                //dockingManager1.ActivateControl(page);
                //dockingManager1.DockVisibilityChanged += OnXtcLogsOnControlRemoved;
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
                //xtcLogs.ControlRemoved += OnXtcLogsOnControlRemoved;
            }

            //add local folder button:
            if (!string.IsNullOrEmpty(offlineAnalogy.InitialFolderFullPath) &&
                Directory.Exists(offlineAnalogy.InitialFolderFullPath))
            {
                var localfolder = new KryptonRibbonGroupButton()
                {
                    TextLine1 = "Open Folder",
                    ImageLarge = Resources.Open2_32x32
                };
                KryptonRibbonGroupTriple container = new KryptonRibbonGroupTriple();
                container.Items.AddRange(new KryptonRibbonGroupItem[] { localfolder });
                group.Items.AddRange(new KryptonRibbonGroupContainer[] { container });

                localfolder.Click += (sender, e) => { OpenOffline(ribbonPage, offlineAnalogy, title, offlineAnalogy.InitialFolderFullPath); };
            }
            var recentButton = new KryptonRibbonGroupButton();
            recentButton.TextLine1 = "Recently Used";
            recentButton.TextLine2 = "Files";
            recentButton.ImageLarge = Resources.RecentlyUse_32x32;
            var recentBar = new ContextMenuStrip();
            recentButton.ContextMenuStrip = recentBar;

            KryptonRibbonGroupTriple containerRecent = new KryptonRibbonGroupTriple();
            containerRecent.Items.AddRange(new KryptonRibbonGroupItem[] { recentButton });
            group.Items.AddRange(new KryptonRibbonGroupContainer[] { containerRecent });

            //add Files open buttons
            if (!string.IsNullOrEmpty(offlineAnalogy.FileOpenDialogFilters))
            {
                //add Open files entry
                var openFiles = new KryptonRibbonGroupButton()
                {
                    TextLine1 = "Open Files",
                    ImageLarge = Resources.Article_32x32
                };
                KryptonRibbonGroupTriple container = new KryptonRibbonGroupTriple();
                container.Items.AddRange(new KryptonRibbonGroupItem[] { openFiles });
                group.Items.AddRange(new KryptonRibbonGroupContainer[] { container });
                openFiles.Click += (sender, e) =>
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog
                    {
                        Filter = offlineAnalogy.FileOpenDialogFilters,
                        Title = @"Open Files",
                        Multiselect = true
                    };
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        OpenOffline(ribbonPage, offlineAnalogy, title, offlineAnalogy.InitialFolderFullPath, openFileDialog1.FileNames);
                        AddRecentFiles(ribbonPage, recentBar, offlineAnalogy, title,
                            openFileDialog1.FileNames.ToList());
                    }
                };

                //add Open Pooled file entry
                var filePoolingBtn = new KryptonRibbonGroupButton()
                {
                    TextLine1 = "File Pooling",
                    ImageLarge = Resources.FilePooling_32x32
                };

                KryptonRibbonGroupTriple container2 = new KryptonRibbonGroupTriple();
                container2.Items.AddRange(new KryptonRibbonGroupItem[] { filePoolingBtn });
                group.Items.AddRange(new KryptonRibbonGroupContainer[] { container2 });

                filePoolingBtn.Click += (sender, e) =>
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog
                    {
                        Filter = offlineAnalogy.FileOpenDialogFilters,
                        Title = @"Open File for pooling",
                        Multiselect = false
                    };
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        OpenFilePooling(title, offlineAnalogy.InitialFolderFullPath, openFileDialog1.FileName);
                        AddRecentFiles(ribbonPage, recentBar, offlineAnalogy, title,
                                                    new List<string> { openFileDialog1.FileName });
                    }

                };
            }

            //add recent
            var recents = UserSettingsManager.UserSettings.RecentFiles.Where(itm => itm.ID == offlineAnalogy.ID)
                .Select(itm => itm.FileName).ToList();
            AddRecentFiles(ribbonPage, recentBar, offlineAnalogy, title, recents);

            //add client/server  button:
            var externalSources = new KryptonRibbonGroupButton()
            {
                TextLine1 = "Known Locations",
                ImageLarge = Resources.ServerMode_32x32
            };
            KryptonRibbonGroupTriple containerExternalSources = new KryptonRibbonGroupTriple();
            containerExternalSources.Items.AddRange(new KryptonRibbonGroupItem[] { externalSources });
            group.Items.AddRange(new KryptonRibbonGroupContainer[] { containerExternalSources });


            externalSources.Click += (sender, e) => { OpenExternalDataSource(title, offlineAnalogy); };

            //add tools
            var searchFiles = new KryptonRibbonGroupButton()
            {
                TextLine1 = "Search in Files",
                ImageLarge = Resources.Lookup_Reference_32x32
            };
            searchFiles.Click += (sender, e) =>
            {
                var search = new SearchForm(offlineAnalogy);
                search.Show(this);
            };

            var combineFiles = new KryptonRibbonGroupButton()
            {
                TextLine1 = "Combine Files",
                ImageLarge = Resources.Sutotal_32x32
            };

            combineFiles.Click += (sender, e) =>
            {
                var combined = new FormCombineFiles(offlineAnalogy);
                combined.Show(this);
            };


            var compareFiles = new KryptonRibbonGroupButton()
            {
                TextLine1 = "Compare Files",
                ImageLarge = Resources.TwoColumns
            };

            compareFiles.Click += (sender, e) =>
            {
                FileComparerForm compare = new FileComparerForm(offlineAnalogy);
                compare.ShowDialog(this);
            };


            KryptonRibbonGroupTriple containerTools = new KryptonRibbonGroupTriple();
            containerTools.Items.AddRange(new KryptonRibbonGroupItem[] { searchFiles, combineFiles, compareFiles });
            groupOfflineFileTools.Items.AddRange(new KryptonRibbonGroupContainer[] { containerTools });

        }


        private void AddSingleRealTimeDataSource(KryptonRibbonTab ribbonPage, IAnalogyRealTimeDataProvider realTime, string title,
            KryptonRibbonGroup group)
        {
            string text = "Real Time Logs" + (!string.IsNullOrEmpty(realTime.OptionalTitle) ? $" - {realTime.OptionalTitle}" : string.Empty);
            var realTimeBtn = new KryptonRibbonGroupButton()
            {
                TextLine1 = text,
                ImageLarge = Resources.Database_off
            };
            KryptonRibbonGroupTriple container = new KryptonRibbonGroupTriple();
            container.Items.AddRange(new KryptonRibbonGroupItem[] { realTimeBtn });
            group.Items.AddRange(new KryptonRibbonGroupContainer[] { container });

            async Task<bool> OpenRealTime()
            {
                realTimeBtn.Enabled = false;
                bool canStartReceiving = false;
                try
                {
                    canStartReceiving = await realTime.CanStartReceiving();
                }
                catch (Exception e)
                {
                    AnalogyLogManager.Instance.LogError("Error during call to canStartReceiving: " + e);
                }

                if (canStartReceiving) //connected
                {
                    online++;
                    realTimeBtn.ImageLarge = Resources.Database_on;
                    var onlineUC = new OnlineUCLogs(realTime);

                    void OnRealTimeOnMessageReady(object sender, AnalogyLogMessageArgs e) =>
                        onlineUC.AppendMessage(e.Message, Environment.MachineName);

                    void OnRealTimeOnOnManyMessagesReady(object sender, AnalogyLogMessagesArgs e) =>
                        onlineUC.AppendMessages(e.Messages, Environment.MachineName);

                    void OnRealTimeDisconnected(object sender, AnalogyDataSourceDisconnectedArgs e)
                    {
                        AnalogyLogMessage disconnected = new AnalogyLogMessage(
                            $"Source {title} Disconnected. Reason: {e.DisconnectedReason}",
                            AnalogyLogLevel.AnalogyInformation, AnalogyLogClass.General, title, "Analogy");
                        onlineUC.AppendMessage(disconnected, Environment.MachineName);
                        realTimeBtn.ImageLarge = Resources.Database_off;
                    }


                    onlineUC.Tag = ribbonPage;
                    ribbonControlMain.SelectedTab = ribbonPage;
                    onlineUC.Dock = DockStyle.Fill;
                    onlineUC.Text = $"{onlineTitle} #{online} ({title})";

                    AddToDockingManager(onlineUC, onlineUC.Text);
                    //dockingManager1.ActivateControl(onlineUC);
                    realTime.OnMessageReady += OnRealTimeOnMessageReady;
                    realTime.OnManyMessagesReady += OnRealTimeOnOnManyMessagesReady;
                    realTime.OnDisconnected += OnRealTimeDisconnected;
                    realTime.StartReceiving();
                    onlineDataSourcesMapping.Add(onlineUC, realTime);

                    //todo
                    //void OnXtcLogsOnControlRemoved(object sender, DockVisibilityChangedEventArgs arg)
                    //{
                    //    if (arg.Control == onlineUC)
                    //    {
                    //        try
                    //        {
                    //            onlineUC.Enable = false;
                    //            realTime.StopReceiving();
                    //            realTime.OnMessageReady -= OnRealTimeOnMessageReady;
                    //            realTime.OnManyMessagesReady -= OnRealTimeOnOnManyMessagesReady;
                    //            realTime.OnDisconnected -= OnRealTimeDisconnected;
                    //            //page.Controls.Remove(onlineUC);
                    //        }
                    //        catch (Exception e)
                    //        {
                    //            AnalogyLogManager.Instance.LogError("Error during call to Stop receiving: " + e);
                    //        }
                    //        finally
                    //        {
                    //            dockingManager1.DockVisibilityChanged -= OnXtcLogsOnControlRemoved;
                    //        }
                    //    }
                    //}

                    //dockingManager1.DockVisibilityChanged += OnXtcLogsOnControlRemoved;
                    realTimeBtn.Enabled = true;
                    return true;
                }

                realTimeBtn.Enabled = true;
                return false;
            }

            realTimeBtn.Click += async (s, be) => await OpenRealTime();
            if (settings.AutoStartDataProviders.Contains(realTime.ID)
            && !disableOnlineDueToFileOpen)
            {
                async Task<bool> AutoOpenRealTime()
                {
                    while (!await OpenRealTime())
                    {
                        await Task.Delay(1000);
                    }

                    return true;
                }

                OnlineSources.Add(AutoOpenRealTime());

            }

        }

        private void OpenBookmarkLog()
        {
            offline++;
            var bookmarkLog = new BookmarkLog();
            bookmarkLog.Controls.Add(bookmarkLog);
            bookmarkLog.Dock = DockStyle.Fill;
            bookmarkLog.Text = $"Analogy Bookmarked logs #{offline}";
            AddToDockingManager(bookmarkLog, bookmarkLog.Text);
        }

        private async Task OpenOfflineFileWithSpecificDataProvider(string[] files)
        {
            while (!Initialized)
                await Task.Delay(250);
            var supported = FactoriesManager.Instance.GetSupportedOfflineDataSources(files).ToList();
            if (supported.Count == 1)
            {
                var parser = supported.First();
                var page = (Mapping.ContainsKey(parser.FactoryID)) ? Mapping[parser.FactoryID] : null;
                OpenOfflineLogs(page, files, parser.DataProvider);
            }
            else
            {
                supported = FactoriesManager.Instance.GetSupportedOfflineDataSources(files).Where(itm =>
                    !FactoriesManager.Instance.IsBuiltInFactory(itm.FactoryID)).ToList();
                if (supported.Count == 1)
                {
                    var parser = supported.First();
                    var page = (Mapping.ContainsKey(parser.FactoryID)) ? Mapping[parser.FactoryID] : null;
                    OpenOfflineLogs(page, files, parser.DataProvider);
                }
                else
                {
                    //try  from file association:
                    var supportedAssociation = settings.GetFactoriesThatHasFileAssociation(files).ToList();
                    if (supportedAssociation.Count == 1)
                    {
                        var factory = supportedAssociation.First();
                        var parser = FactoriesManager.Instance
                            .GetSupportedOfflineDataSourcesFromFactory(factory.FactoryGuid, files).ToList();
                        var page = (Mapping.ContainsKey(factory.FactoryGuid)) ? Mapping[factory.FactoryGuid] : null;
                        if (parser.Count == 1)
                            OpenOfflineLogs(page, files, parser.First());
                        else
                        {
                            MessageBox.Show(
                                $@"More than one data provider detected for this file for {factory.FactoryName}." + Environment.NewLine +
                                "Please open it directly from the data provider menu", "Unable to open file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }

                    }
                    else

                        MessageBox.Show(
                            "Zero or more than one data provider detected for this file." + Environment.NewLine +
                            "Please open it directly from the data provider menu", "Unable to open file",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }

            }
        }
        private void OpenOfflineLogs(KryptonRibbonTab ribbonPage, string[] filenames,
            IAnalogyOfflineDataProvider dataProvider,
            string title = null)
        {
            offline++;
            UserControl offlineUC = new OfflineUCLogs(dataProvider, filenames);


            offlineUC.Tag = ribbonPage;
            offlineUC.Controls.Add(offlineUC);
            offlineUC.Dock = DockStyle.Fill;
            offlineUC.Text = $"{offlineTitle} #{offline}{(title == null ? "" : $" ({title})")}";
            AddToDockingManager(offlineUC, offlineUC.Text);
        }


        private void AddRecentFiles(KryptonRibbonTab ribbonPage, ContextMenuStrip bar, IAnalogyOfflineDataProvider offlineAnalogy,
            string title, List<string> files)
        {

            if (files.Any())
            {
                foreach (string file in files)
                {
                    if (!File.Exists(file)) continue;
                    var btn = new ToolStripMenuItem(file);
                    btn.Click += (s, be) =>
                    {
                        OpenOfflineLogs(ribbonPage, new[] { file }, offlineAnalogy, title);
                    };
                    bar.Items.Add(btn);
                }
            }
        }

        private async void TmrAutoConnect_Tick(object sender, EventArgs e)
        {
            TmrAutoConnect.Enabled = false;
            if (!OnlineSources.Any())
                return;
            var onlines = OnlineSources.ToList();
            foreach (var onlineSource in onlines)
            {
                if (await onlineSource)
                {
                    OnlineSources.Remove(onlineSource);
                }
            }

            TmrAutoConnect.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.UpdateRunningTime();
            settings.Save();
            BookmarkPersistManager.Instance.SaveFile();
        }
    }
}

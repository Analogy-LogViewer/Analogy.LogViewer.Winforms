using Syncfusion.WinForms.DataGridConverter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.DataSources;
using Analogy.Interfaces;
using Analogy.Types;
using Syncfusion.Windows.Forms.Tools.Enums;
using Syncfusion.WinForms.DataGrid.Serialization;

namespace Analogy
{

    public partial class UCLogs : UserControl, ILogMessageCreatedHandler
    {
        private string timeDiffColumnName = "TimeDiff";
        public bool ForceNoFileCaching { get; set; } = false;
        public bool DoNotAddToRecentHistory { get; set; } = false;
        private PagingManager PagingManager { get; set; }
        private FileProcessor fileProcessor { get; set; }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public event EventHandler<AnalogyClearedHistoryEventArgs> OnHistoryCleared;
        public event EventHandler<(string, AnalogyLogMessage)> OnFocusedRowChanged;
        private Dictionary<string, List<AnalogyLogMessage>> groupingByChars;
        private string OldTextInclude = string.Empty;
        private string OldTextExclude = string.Empty;
        public int fileLoadingCount;
        private bool LoadingInProgress => fileLoadingCount > 0;
        private UserSettingsManager Settings => UserSettingsManager.UserSettings;
        private IExtensionsManager ExtensionManager { get; set; } = ExtensionsManager.Instance;
        private IEnumerable<IAnalogyExtension> InPlaceRegisteredExtensions { get; set; }
        private List<IAnalogyExtension> UserControlRegisteredExtensions { get; set; }
        private ToolTip Tip { get; set; }
        private List<string> _excludeMostCommon = new List<string>();
        public const string DataGridDateColumnName = "Date";
        private bool _realtimeUpdate = true;

        private ReaderWriterLockSlim lockExternalWindowsObject = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);
        private ReaderWriterLockSlim lockSlim;
        private DataTable _messageData;
        private DataTable _bookmarkedMessages;
        private IProgress<AnalogyProgressReport> ProgressReporter { get; set; }
        private readonly List<LogGridForm> _externalWindows = new List<LogGridForm>();
        private List<LogGridForm> ExternalWindows
        {
            get
            {
                lockExternalWindowsObject.EnterReadLock();
                var items = _externalWindows.ToList();
                lockExternalWindowsObject.ExitReadLock();
                return items;
            }
        }

        private int ExternalWindowsCount;
        private List<AnalogyLogMessage> Messages
        {
            get
            {
                var filterDatatable = GetFilteredDataTable();
                return filterDatatable.Rows.OfType<DataRow>().Select(r => (AnalogyLogMessage)r["Object"]).ToList();
            }
        }
        private List<AnalogyLogMessage> BookmarkedMessages
        {
            get { return _bookmarkedMessages.Rows.OfType<DataRow>().Select(r => (AnalogyLogMessage)r["Object"]).ToList(); }
        }

        private bool EnableOTA { get; } = false;//GeneralUtils.UseDebugMode("AnalogyOTA");
        private AnalogyLogMessage _currentMassage;
        private FilterCriteriaObject _filterCriteria = new FilterCriteriaObject();
        public bool OnlineMode { get; set; }

        // private bool FilterHasChanged { get; set; }
        private bool NewDataExist { get; set; }
        private bool hasAnyInPlaceExtensions;
        private bool hasAnyUserControlExtensions;
        private DateTime diffStartTime = DateTime.MinValue;
        private string LayoutFileNameMain;
        private bool BookmarkView;
        private int pageNumber = 1;
        private CancellationTokenSource filterTokenSource;
        private CancellationToken filterToken;

        private int TotalPages => PagingManager.TotalPages;
        private IAnalogyOfflineDataProvider FileDataProvider { get; set; }
        private IAnalogyOfflineDataProvider AnalogyOfflineDataProvider { get; } = new AnalogyOfflineDataProvider();

        public UCLogs()
        {
            InitializeComponent();
            filterTokenSource = new CancellationTokenSource();
            filterToken = filterTokenSource.Token;
            fileProcessor = new FileProcessor(this);
            if (DesignMode) return;
            //splitContainerMain.IsSplitterFixed = false;
            //splitContainerMain.FixedPanel = SplitFixedPanel.None;
            //ClientSizeChanged += (s, e) => { splitContainerMain.SplitterPosition = (int)0.8 * splitContainerMain.Height; };
            LayoutFileNameMain = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "layoutMain.xml");
            PagingManager = new PagingManager(this);
            lockSlim = PagingManager.lockSlim;
            _messageData = PagingManager.CurrentPage();
            //SfDataPager sfDataPager1 = new SfDataPager();
            //sfDataPager1.DataSource = _messageData.AsEnumerable();
            //sfDataPager1.PageSize = 1000;
            sfDataGridMain.DataSource = _messageData;
            _bookmarkedMessages = Utils.DataTableConstructor();
            sfDataGridBookmarks.DataSource = _bookmarkedMessages;
            SetupControlEvents();
        }

        private void SetupControlEvents()
        {
            #region Filters/search controls
            deNewerThanFilter.ValueChanged += async (s, e) =>
            {
                chkDateNewerThan.Checked = true;
                await FilterHasChanged();
            };
            deOlderThanFilter.ValueChanged += async (s, e) =>
            {
                chkDateOlderThan.Checked = true;
                await FilterHasChanged();
            };
            cbHighlights.TextBox.KeyUp += async (s, e) =>
            {
                chkbHighlight.Checked = !string.IsNullOrEmpty(cbHighlights.TextBox.Text);
                await FilterHasChanged(); //todo-refresh noly style
            };
            //include combobox
            //cbInclude. txtbInclude.SelectAll();
            cbInclude.TextBox.TextChanged += async (s, e) =>
             {
                 if (OldTextInclude.Equals(cbInclude.Text)) return;
                 OldTextInclude = cbInclude.Text;
                 cbHighlights.TextBox.Text = cbInclude.Text;
                 if (string.IsNullOrEmpty(cbInclude.Text))
                 {
                     chkbIncludeText.Checked = false;
                     return;
                 }

                 chkbHighlight.Checked = false;
                 chkbIncludeText.Checked = true;
                 await FilterHasChanged();
             };
            cbInclude.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var added = Settings.AddNewSearchesEntryToLists(cbInclude.Text, true);
                    if (added)
                        cbInclude.DataSource = Settings.LastSearchesInclude;
                }
            };

            cbExclude.TextBox.TextChanged += async (s, e) =>
            {
                if (OldTextExclude.Equals(cbExclude.Text)) return;
                Settings.ExcludedText = cbExclude.Text;
                OldTextExclude = cbExclude.Text;
                if (string.IsNullOrEmpty(cbExclude.Text))
                {
                    chkExclude.Checked = false;
                    return;
                }

                chkExclude.Checked = true;
                await FilterHasChanged();
            };
            cbExclude.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var added = Settings.AddNewSearchesEntryToLists(cbExclude.Text, false);
                    if (added)
                        cbExclude.DataSource = Settings.LastSearchesExclude;
                }
            };

            cbSource.TextBox.TextChanged += async (s, e) =>
            {
                if (string.IsNullOrEmpty(cbSource.Text))
                {
                    chkbSources.Checked = false;
                }
                else
                {
                    if (!chkbSources.Checked)
                        chkbSources.Checked = true;
                }

                await FilterHasChanged();
                Settings.SourceText = cbSource.Text;
            };

            cbModule.TextBox.TextChanged += async (s, e) =>
            {
                if (string.IsNullOrEmpty(cbModule.Text))
                {
                    chkbModules.Checked = false;
                }
                else
                {
                    if (!chkbModules.Checked)
                        chkbModules.Checked = true;
                }

                await FilterHasChanged();
                Settings.ModuleText = cbModule.Text;
            };

            btnTextInclude.Click += (s, e) => cbInclude.TextBox.Text = "";
            btnTextExclude.Click += (s, e) => cbExclude.TextBox.Text = "";
            btnSources.Click += (s, e) => cbSource.TextBox.Text = "";
            btnModules.Click += (s, e) => cbModule.TextBox.Text = "";
            btnCancel.Click += (s, e) =>
            {
                cancellationTokenSource.Cancel(false);
                Interlocked.Exchange(ref fileLoadingCount, 0);
                cancellationTokenSource = new CancellationTokenSource();
                btnCancel.Visible = false;
            };

            #endregion

            #region sfDataGrid Main

            //sfDataGridMain.CurrentCellActivating += (s, e) =>
            //{
            //    if (Syncfusion.WinForms.DataGrid.DataGridIndexResolver.IsAddNewRowIndex(sfDataGridMain, sfDataGridMain.CurrentCell.RowIndex) && sfDataGridMain.View.IsAddingNew && e.DataRow.RowIndex == Syncfusion.WinForms.DataGrid.DataGridIndexResolver.GetAddNewRowIndex(sfDataGridMain) + 1)
            //    {
            //        // To cancel the current cell moving to the start row index after adding the new row.   
            //        e.Cancel = true;
            //    }
            //};
            // sfDataGridMain.View.Records.CollectionChanged += (s, e) =>
            // {

            //     if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            //     {
            //         // To scroll the grid to the newly added row position.  
            //         var scrollValue = sfDataGridMain.TableControl.ScrollRows.Distances.GetCumulatedDistanceAt(e.NewStartingIndex);
            //         sfDataGridMain.TableControl.ScrollRows.ScrollInView(e.NewStartingIndex);
            //         sfDataGridMain.TableControl.VerticalScroll.Value = (int)scrollValue;
            //     }
            // };
            //sfDataGridMain.SelectionChanging += (s, e) => { };

            sfDataGridMain.QueryRowStyle += (s, e) =>
            {
                if (e.RowIndex >= 0 && (e.RowData is DataRowView drv) && drv.Row.ItemArray[9] is AnalogyLogMessage message)
                {
                    var data = e.RowData;
                    e.Style.BackColor = Settings.ColorSettings.GetColorForLogLevel(message.Level);
                    string text = message.Text;
                    if (chkbHighlight.Checked && FilterCriteriaObject.Match(text, cbHighlights.TextBox.Text, PreDefinedQueryType.Contains))
                    {
                        e.Style.BackColor = Settings.ColorSettings.GetHighlightColor();
                    }

                    foreach (PreDefineHighlight preDefineHighlight in Settings.PreDefinedQueries.Highlights)
                    {
                        if (FilterCriteriaObject.Match(text, preDefineHighlight.Text, preDefineHighlight.PreDefinedQueryType))
                        {
                            e.Style.BackColor = preDefineHighlight.Color;
                        }
                    }
                }
            };
            sfDataGridMain.CellClick += (s, e) =>
            {
                if (tsTopAutoScrollToLast.Checked)
                    tsTopAutoScrollToLast.Checked = false;

                var selectedItems = sfDataGridMain.SelectedItems.Cast<DataRowView>().ToList();
                if (!selectedItems.Any()) return;
                DataRow dataRow = selectedItems.First().Row;
                _currentMassage = GetMessageFromRow(dataRow);
                if (hasAnyInPlaceExtensions)
                {
                    var column = sfDataGridMain.Columns[e.DataColumn.ColumnIndex];
                    if (column == null) return;
                    foreach (IAnalogyExtension extension in InPlaceRegisteredExtensions)
                    {
                        var columns = extension.GetColumnsInfo();
                        foreach (AnalogyColumnInfo exColumn in columns)
                        {
                            if (column.MappingName.Equals(exColumn.ColumnName) &&
                                column.HeaderText.Equals(exColumn.ColumnCaption))
                            {

                                var cellValue = sfDataGridMain.GetSelectedCells().First().ToString();
                                AnalogyCellClickedEventArgs argsForEx =
                                    new AnalogyCellClickedEventArgs(exColumn.ColumnName, cellValue, _currentMassage);
                                extension.CellClicked(s, argsForEx);
                            }
                        }
                    }
                }

            };
            sfDataGridMain.SelectionChanged += (s, e) =>
            {

                (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
                if (message == null) return;
                LoadTextBoxes(message);
            };

            sfDataGridMain.CellDoubleClick += (s, e) =>
            {
                OpenMessageDetails();
            };
            sfDataGridMain.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)13)
                {
                    OpenMessageDetails();
                }
            };
            sfDataGridMain.SelectionChanged += (s, e) =>
            {
                //int row = e.FocusedRowHandle;
                //if (row < 0) return;
                //AnalogyLogMessage m = (AnalogyLogMessage)LogGrid.GetRowCellValue(e.FocusedRowHandle, "Object");
                //LoadTextBoxes(m);
                //string dataProvider = (string)LogGrid.GetRowCellValue(e.FocusedRowHandle, "DataProvider");
                //if (!LoadingInProgress)
                //{
                //    OnFocusedRowChanged?.Invoke(this, (dataProvider, m));
                //}
            };
            #endregion

            #region Radio buttons log level

            rbAllLevel.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbErrorCritical.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbDebug.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbVerbose.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbWarning.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbTrace.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            #endregion

            #region toolstrip menus

            tsmiSaveFullLogDataProvider.Click += (s, e) =>
            {
                var messages = PagingManager.GetAllMessages();
                SaveMessagesToLog(FileDataProvider, messages);
            };
            tsmiSaveFullLogAnalogy.Click += (s, e) =>
            {
                var messages = PagingManager.GetAllMessages();
                SaveMessagesToLog(AnalogyOfflineDataProvider, messages);
            };

            tsmiSaveCurrentViewDataProvider.Click += (s, e) =>
            {
                var messages = Messages;
                SaveMessagesToLog(FileDataProvider, messages);
            };
            tsmiSaveCurrentViewDataProvider.Click += (s, e) =>
            {
                var messages = Messages;
                SaveMessagesToLog(AnalogyOfflineDataProvider, messages);
            };
            tsmiUndockView.Click += (s, e) => UndockView();
            tsmiUndockPerModule.Click += (s, e) => UndockViewPerProcess();
            tsmiExportExcel.Click += (s, e) => ExportToExcel();
            tsTopPauseRefresh.CheckedChanged += (s, e) =>
            {
                _realtimeUpdate = !tsTopPauseRefresh.Checked;
                AcceptChanges(false);
            };
            tsTopAutoScrollToLast.CheckedChanged += (s, e) =>
            {
                //todo:complete this
                Settings.AutoScrollToLastMessage = tsTopAutoScrollToLast.Checked;
            };
            tsTopClear.Click += (s, e) => ClearLogs(true);


            #endregion

            #region Toolstrip Buttons

            tsBookmark.Click += (s, e) =>
            {
                Bitmap image = takeComponentScreenShot(sfDataGridMain);
                Clipboard.SetImage(image);
                MessageBox.Show("Screenshot of messages was copied to clipboard.", "Image was taken",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            };
            tsBtnMessageInfoCopy.Click += (s, e) => Clipboard.SetText(tbMessageInfo.Text);
            tsBtnBookmarkCopySingle.Click += (s, e) =>
            {
                //todo: check this
                if (!sfDataGridBookmarks.SelectedItems.Any()) return;
                var selectedItems = sfDataGridBookmarks.SelectedItems.Cast<DataRowView>();
                DataRow dataRow = selectedItems.First().Row;
                AnalogyLogMessage message = GetMessageFromRow(dataRow);
                Clipboard.SetText(message.Text);

            };
            tsBtnBookmarkCopyAll.Click += (s, e) =>
            {
                var messages = BookmarkedMessages;
                if (!messages.Any()) return;
                string all = string.Join(Environment.NewLine, messages.Select(m => $"{m.Date.ToString()}: {m.Text}"));
                Clipboard.SetText(all);
            };
            tsBtnBookmarkClear.Click += (s, e) =>
            {
                _bookmarkedMessages.Clear();
            };
            tsBtnBookmarkGoToOriginal.Click += (s, e) => { GoToMessage(); };

            #endregion
        }


        private static AnalogyLogMessage GetMessageFromRow(DataRow row) => row[9] as AnalogyLogMessage;

        private void UCLogs_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            sfDataGridMain.Columns[timeDiffColumnName].Visible = false;
            PagingManager.OnPageChanged += (s, arg) =>
            {
                if (IsDisposed) return;
                BeginInvoke(new MethodInvoker(() =>
                    lblPageNumber.Text = $"Page {pageNumber} / {arg.AnalogyPage.PageNumber}"));

            };
            LoadUISettings();
            BookmarkModeUI();

            hasAnyInPlaceExtensions = ExtensionManager.HasAnyInPlace;
            hasAnyUserControlExtensions = ExtensionManager.HasAnyInPlace;
            InPlaceRegisteredExtensions = ExtensionManager.InPlaceRegisteredExtensions.ToList();
            UserControlRegisteredExtensions = ExtensionManager.UserControlRegisteredExtensions.ToList();
            InitializeExtensionsColumns();
            ProgressReporter = new Progress<AnalogyProgressReport>((value) =>
            {
                progressBar1.Maximum = value.Total;
                if (value.Processed < progressBar1.Maximum && value.Total > 1)
                    progressBar1.Value = value.Processed;
                if (value.Processed == value.Total)
                    progressBar1.Visible = false;
            });

            //todo: auto scroll to last
            //LogGrid.RowCountChanged += (s, arg) =>
            //{
            //    if (Settings.AutoScrollToLastMessage && !IsDisposed)
            //    {
            //        BeginInvoke(new MethodInvoker(() =>
            //        {
            //            LogGrid.MoveLast();
            //            LogGrid.MakeRowVisible(LogGrid.FocusedRowHandle);
            //        }));

            //    }
            //};

        }

        public void SetFileDataSource(IAnalogyOfflineDataProvider fileDataProvider)
        {
            FileDataProvider = fileDataProvider;
            if (FileDataProvider is EventLogDataProvider eventDataSource)
                eventDataSource.LogWindow = this;
            if (FileDataProvider == null)
            {
                //disable specific saving
                tsmiSaveCurrentViewDataProvider.Visible = false;
                tsmiSaveFullLogDataProvider.Visible = false;
            }
        }


        public void ProcessCmdKeyFromParent(Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.Control && e.KeyCode == Keys.F)
            {
                cbInclude.Focus();
            }
            if (e.Shift && e.KeyCode == Keys.F)

            {
                cbExclude.Focus();
            }

            if (e.Alt && e.KeyCode == Keys.E)
            {
                rbErrorCritical.Checked = !rbErrorCritical.Checked;
            }
            if (e.Alt && e.KeyCode == Keys.W)
            {
                rbWarning.Checked = !rbWarning.Checked;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.Control && e.KeyCode == Keys.F)

            {
                cbInclude.Focus();
                return true;
            }
            if (e.Shift && e.KeyCode == Keys.F)

            {
                cbExclude.Focus();
                return true;
            }

            if (e.Alt && e.KeyCode == Keys.E)
            {
                rbErrorCritical.Checked = !rbErrorCritical.Checked;
                return true;
            }
            if (e.Alt && e.KeyCode == Keys.W)
            {
                rbWarning.Checked = !rbWarning.Checked;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void LoadUISettings()
        {
            Tip = new ToolTip();
            Tip.SetToolTip(pboxInfo, "Use & or + for AND operations. Use | for OR operations");
            Tip.SetToolTip(pboxInfoExclude, "Use , to separate values. to exclude source or module prefix it with -");

            spltFilteringBoth.SplitterDistance = spltFilteringBoth.Width - 150;
            pnlFilteringLeft.Dock = DockStyle.Fill;
            cbInclude.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbExclude.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            if (Settings.RememberLastSearches)
            {
                cbInclude.DataSource = Settings.LastSearchesInclude;
                cbExclude.DataSource = Settings.LastSearchesExclude;
            }

            if (File.Exists(LayoutFileNameMain))
            {
                using (FileStream fileStream = File.OpenRead(LayoutFileNameMain))
                {
                    sfDataGridMain.Deserialize(fileStream, Deserialization());
                }
            }
            if (Settings.SaveSearchFilters)
            {
                cbInclude.Text = Settings.IncludeText;
                cbExclude.Text = Settings.ExcludedText;
            }

            splitContainerMain.CollapsedPanel = CollapsedPanel.Panel2;
            if (Settings.StartupErrorLogLevel)
                rbErrorCritical.Checked = true;

            //todo:font
            //LogGrid.Appearance.Row.Font = new Font(LogGrid.Appearance.Row.Font.Name, Settings.FontSize);

            tsTopAutoScrollToLast.Checked = Settings.AutoScrollToLastMessage;
        }

        private void BookmarkModeUI()
        {
            if (BookmarkView)
            {
                sfDataGridMain.ContextMenuStrip = cmsBookmarked;
            }
        }

        private void InitializeExtensionsColumns()
        {
            foreach (IAnalogyExtension extension in InPlaceRegisteredExtensions)
            {
                var columns = extension.GetColumnsInfo();
                foreach (AnalogyColumnInfo column in columns)
                {
                    var gridColumn = new Syncfusion.WinForms.DataGrid.GridColumn();
                    gridColumn.HeaderText = column.ColumnCaption;
                    gridColumn.MappingName = column.ColumnName;
                    //todo:index?
                    //gridColumn.index = ExtensionManager.GetIndexForExtension(extension);
                    sfDataGridMain.Columns.Add(gridColumn);
                    gridColumn.Visible = true;
                }

            }
        }



        private void UCLogs_DragEnter(object sender, DragEventArgs e) =>
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

        private async void UCLogs_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            await LoadFilesAsync(files.ToList(), false);

        }

        #region UI events

        private void LogGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                OpenMessageDetails();
            }
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage m, _) = GetMessageFromSelectedRowInGrid();
            if (m != null)
                Clipboard.SetText(m.Text);
        }

        private void tsmiEmail_Click(object sender, EventArgs e)
        {

            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;
            try
            {
                Process.Start($"mailto:?Subject=Analogy message&Body={message.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error opening mail client", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Clipboard.SetText(message.Text);

        }

        private async Task FilterHasChanged()
        {
            async Task RefreshData(CancellationToken token)
            {
                await Task.Delay(500);
                if (token.IsCancellationRequested) return;
                FilterResults();

            }

            filterTokenSource.Cancel();
            filterTokenSource = new CancellationTokenSource();
            filterToken = filterTokenSource.Token;
            await RefreshData(filterToken);
        }
        private async void tsmiExclude_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;
            var ef = new AnalogyExcludeMessage(message);
            if (ef.ShowDialog(this) == DialogResult.OK)
            {
                string exclude = ef.Exclude;
                cbExclude.Text = cbExclude.Text + "|" + exclude;
                chkExclude.Checked = true;
                await FilterHasChanged();
            }
        }

        private async void chkbInclude_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        private async void chkbExclude_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        #endregion

        #region Messages logic



        internal DataTable GetFilteredDataTable()
        {

            // Create a data view by applying the grid view row filter
            try
            {
                lockSlim.EnterReadLock();
                string filter = _messageData.DefaultView.RowFilter;
                return new DataView(_messageData, filter, null, DataViewRowState.CurrentRows).ToTable();
            }
            finally
            {
                lockSlim.ExitReadLock();
            }
        }

        private (int total, int error, int warning, int critical, int alerts) GetRowsCount()
        {

            // Create a data view by applying the grid view row filter
            try
            {
                lockSlim.EnterReadLock();

                string filter = _messageData.DefaultView.RowFilter;
                var rows = _messageData.Select(filter);
                var total = rows.Length;
                var error = rows.Count(r => r["Level"].ToString() == AnalogyLogLevel.Error.ToString());
                var warning = rows.Count(r => r["Level"].ToString() == AnalogyLogLevel.Warning.ToString());
                var critical = rows.Count(r => r["Level"].ToString() == AnalogyLogLevel.Critical.ToString());
                var alertCount = 0;
                if (Settings.PreDefinedQueries.Alerts.Any())
                {
                    var messages = rows.Select(r => (AnalogyLogMessage)r["Object"]).ToList();
                    alertCount = messages.Count(m =>
                        Settings.PreDefinedQueries.Alerts.Any(a => FilterCriteriaObject.MatchAlert(m, a)));

                }

                return (total, error, warning, critical, alertCount);
            }
            finally
            {
                lockSlim.ExitReadLock();
            }
        }
        private string GetFilterDisplayText(DateRangeFilter filterType)
        {
            string displayText = string.Empty;
            switch (filterType)
            {
                case DateRangeFilter.None:
                    displayText = Utils.DateFilterNone;
                    break;
                case DateRangeFilter.Today:
                    displayText = Utils.DateFilterToday;
                    break;
                case DateRangeFilter.Last2Days:
                    displayText = Utils.DateFilterLast2Days;
                    break;
                case DateRangeFilter.Last3Days:
                    displayText = Utils.DateFilterLast3Days;
                    break;
                case DateRangeFilter.LastWeek:
                    displayText = Utils.DateFilterLastWeek;
                    break;
                case DateRangeFilter.Last2Weeks:
                    displayText = Utils.DateFilterLast2Weeks;
                    break;
                case DateRangeFilter.LastMonth:
                    displayText = Utils.DateFilterLastMonth;
                    break;
            }

            return displayText;
        }

        /// <summary>
        /// Get the filter string for Quick filter
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="filterType"></param>
        /// <returns></returns>
        private string GetFilterString(string columnName, DateRangeFilter filterType)
        {
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today;

            switch (filterType)
            {
                // The filter expression for the TODAY item.
                case DateRangeFilter.Today:
                    startDate = DateTime.Today;
                    endDate = startDate.AddDays(1);
                    break;

                // The filter expression for the last 2 days item.
                case DateRangeFilter.Last2Days:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddDays(-1);
                    break;

                // The filter expression for the last 3 days item.
                case DateRangeFilter.Last3Days:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddDays(-2);
                    break;

                // The filter expression for the last week item.
                case DateRangeFilter.LastWeek:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddDays(-7);
                    break;

                // The filter expression for the last 2 weeks item.
                case DateRangeFilter.Last2Weeks:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddDays(-14);
                    break;

                // The filter expression for the last month item.
                case DateRangeFilter.LastMonth:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddMonths(-1);
                    break;
            }

            string startDateStr = "#" + startDate.ToString("g", CultureInfo.CreateSpecificCulture("en-US")) + "#";
            string endDateStr = "#" + endDate.ToString("g", CultureInfo.CreateSpecificCulture("en-US")) + "#";
            var filter = "([" + columnName + "] >= " + startDateStr + " AND [" + columnName + "] < " + endDateStr + ")";
            return filter;
        }


        #endregion


        public void AppendMessage(AnalogyLogMessage message, string dataSource)
        {
            if (message.Level == AnalogyLogLevel.Disabled)
                return; //ignore those messages

            if (Settings.IdleMode && Utils.IdleTime().TotalMinutes > Settings.IdleTimeMinutes)
            {
                PagingManager.IncrementTotalMissedMessages();
            }
            lockSlim.EnterWriteLock();
            if (ExternalWindowsCount > 0)
            {
                foreach (LogGridForm grid in ExternalWindows)
                {
                    grid.AppendMessage(message, dataSource);
                }
            }


            DataRow dtr = PagingManager.AppendMessage(message, dataSource);
            if (diffStartTime > DateTime.MinValue)
            {
                dtr["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
            }

            if (hasAnyInPlaceExtensions)
            {
                foreach (IAnalogyExtension extension in InPlaceRegisteredExtensions)
                {
                    var columns = extension.GetColumnsInfo();
                    foreach (AnalogyColumnInfo column in columns)
                    {
                        dtr[column.ColumnName] = extension.GetValueForCellColumn(message, column.ColumnName);
                    }
                }
            }

            if (hasAnyUserControlExtensions)
            {
                foreach (IAnalogyExtension extension in UserControlRegisteredExtensions)
                {
                    extension.NewMessage(message);
                }
            }
            lockSlim.ExitWriteLock();
            if (PagingManager.IsCurrentPageInView(_messageData))
                NewDataExist = true;
        }

        public void AppendMessages(List<AnalogyLogMessage> messages, string dataSource)
        {

            if (Settings.IdleMode && Utils.IdleTime().TotalMinutes > Settings.IdleTimeMinutes)
            {
                PagingManager.IncrementTotalMissedMessages();
            }
            lockSlim.EnterWriteLock();
            if (ExternalWindowsCount > 0)
            {
                foreach (LogGridForm grid in ExternalWindows)
                {
                    grid.AppendMessages(messages, dataSource);
                }
            }

            foreach (var (dtr, message) in PagingManager.AppendMessages(messages, dataSource))
            {
                if (diffStartTime > DateTime.MinValue)
                {
                    dtr["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
                }

                if (hasAnyInPlaceExtensions)
                {
                    foreach (IAnalogyExtension extension in InPlaceRegisteredExtensions)
                    {
                        var columns = extension.GetColumnsInfo();
                        foreach (AnalogyColumnInfo column in columns)
                        {
                            dtr[column.ColumnName] = extension.GetValueForCellColumn(message, column.ColumnName);
                        }
                    }
                }

                dtr.EndEdit();
            }
            lockSlim.ExitWriteLock();
            if (PagingManager.IsCurrentPageInView(_messageData))
                NewDataExist = true;

            if (hasAnyUserControlExtensions)
            {
                foreach (IAnalogyExtension extension in UserControlRegisteredExtensions)
                {
                    extension.NewMessages(messages);
                }
            }

        }

        public void AcceptChanges(bool forceRefresh)
        {
            if (!IsHandleCreated) return;
            if (_realtimeUpdate || forceRefresh)

                BeginInvoke(new MethodInvoker(() =>
                {
                    lockSlim.EnterWriteLock();
                    try
                    {
                        sfDataGridMain.BeginUpdate();
                        _messageData.AcceptChanges();
                        RefreshUIMessagesCount();
                        sfDataGridMain.EndUpdate();
                    }
                    finally
                    {
                        lockSlim.ExitWriteLock();
                    }

                }));
        }

        private void UpdatePage(DataTable page)
        {

            _messageData = page;
            lockSlim.EnterWriteLock();
            try
            {
                sfDataGridMain.DataSource = _messageData;
                //NewDataExist = true;
                //FilterHasChanged = true;
                lblPageNumber.Text = $"Page {pageNumber} / {TotalPages}";
                NewDataExist = true;
                FilterResults();
            }
            finally
            {
                lockSlim.ExitWriteLock();
            }
        }

        public void FilterResults(string module)
        {
            cbModule.Text = module;
            FilterResults();
        }


        private void FilterResults()
        {
            _filterCriteria.NewerThan = chkDateNewerThan.Checked && deNewerThanFilter.Value.HasValue ? deNewerThanFilter.Value.Value : DateTime.MinValue;
            _filterCriteria.OlderThan = chkDateOlderThan.Checked && deOlderThanFilter.Value.HasValue ? deOlderThanFilter.Value.Value : DateTime.MaxValue;
            _filterCriteria.TextInclude = chkbIncludeText.Checked ? cbInclude.Text : string.Empty;
            _filterCriteria.TextExclude = chkExclude.Checked ? cbExclude.Text + "|" + string.Join("|", _excludeMostCommon) : string.Empty;


            Settings.IncludeText = Settings.SaveSearchFilters ? _filterCriteria.TextInclude : string.Empty;
            Settings.ExcludedText = Settings.SaveSearchFilters ? _filterCriteria.TextExclude : string.Empty;


            _filterCriteria.Levels = null;
            if (rbTrace.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Trace, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };
            if (rbErrorCritical.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Error, AnalogyLogLevel.Critical, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };
            else if (rbWarning.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Warning, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };
            else if (rbDebug.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Debug, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };
            else if (rbVerbose.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Verbose, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };



            if (chkbSources.Checked && !string.IsNullOrEmpty(cbSource.Text))
            {
                var items = cbSource.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var includeItems = items.Where(i => !i.StartsWith("-"));
                var excludeItems = items.Where(i => i.StartsWith("-") && i.Length > 1)
                    .Select(i => i.Substring(1, i.Length - 1));

                _filterCriteria.Sources = includeItems.Select(val => val.Trim()).ToArray();
                _filterCriteria.ExcludedSources = excludeItems.Select(val => val.Trim()).ToArray();
            }
            else
            {
                _filterCriteria.Sources = null;
                _filterCriteria.ExcludedSources = null;
            }

            Settings.SourceText = Settings.SaveSearchFilters ? cbSource.Text : string.Empty;

            if (chkbModules.Checked && !string.IsNullOrEmpty(cbSource.Text))
            {

                var items = cbSource.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var includeItems = items.Where(i => !i.StartsWith("-"));
                var excludeItems = items.Where(i => i.StartsWith("-") && i.Length > 1)
                      .Select(i => i.Substring(1, i.Length - 1));

                _filterCriteria.Modules = includeItems.Select(val => val.Trim()).ToArray();
                _filterCriteria.ExcludedModules = excludeItems.Select(val => val.Trim()).ToArray();


            }
            else
            {
                _filterCriteria.Modules = null;
                _filterCriteria.ExcludedModules = null;
            }
            Settings.ModuleText = Settings.SaveSearchFilters ? cbModule.Text : string.Empty;
            string filter = _filterCriteria.GetSqlExpression();
            lockSlim.EnterWriteLock();
            try
            {

                //var rows = _messageData.Select(filter);
                //var dt = _messageData.Clone();
                //foreach (DataRow row in rows)
                //{
                //    dt.ImportRow(row);
                //}
                //gridControl.DataSource = dt;
                _messageData.DefaultView.RowFilter = _filterCriteria.GetSqlExpression();
            }
            finally
            {
                lockSlim.ExitWriteLock();
            }

            //todo: selectin of current message
            //var location = LocateByValue(0, gridColumnObject, _currentMassage);
            //if (location >= 0)
            //    LogGrid.FocusedRowHandle = location;

            RefreshUIMessagesCount();

        }
        private void RefreshUIMessagesCount()
        {
            if (!IsHandleCreated) return;
            BeginInvoke(new MethodInvoker(() =>
            {
                var result = GetRowsCount();
                lblTotalMessages.Text = $"Total messages:{result.total}. Errors:{result.error}. Warnings:{result.warning}. Criticals:{result.critical}.";
                if (result.alerts > 0)
                {
                    lblTotalMessagesAlert.Text = $" ALERTS EXISTS: {result.alerts}!";
                    lblTotalMessagesAlert.Visible = true;
                }
                else
                {
                    lblTotalMessagesAlert.Visible = false;
                }

            }));
        }

        public void RefreshUI()
        {
            //gridColumnDataSource.VisibleIndex = 0;
            //gridColumnDate.VisibleIndex = 1;
            //gridColumnText.VisibleIndex = 2;
            //gridColumnSource.VisibleIndex = 3;
            //gridColumnLevel.VisibleIndex = 4;
            //gridColumnClass.VisibleIndex = 5;
            //gridColumnModule.VisibleIndex = 6;
            //gridColumnProcessID.VisibleIndex = 7;
            //gridColumnUser.VisibleIndex = 8;
            //gridColumnCategory.VisibleIndex = 9;
            //gridColumnAudit.VisibleIndex = 10;

        }

        public async Task LoadFilesAsync(List<string> fileNames, bool clearLogBeforeLoading)
        {
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            if (clearLogBeforeLoading)
                ClearLogs(false);
            btnCancel.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = fileNames.Count;
            progressBar1.Style = fileNames.Count > 1 ? ProgressBarStyle.Continuous : ProgressBarStyle.Marquee;
            fileLoadingCount = +fileNames.Count;
            progressBar1.Visible = true;
            int processed = 0;
            foreach (string filename in fileNames)
            {
                if (!File.Exists(filename))
                {
                    AnalogyLogMessage m = new AnalogyLogMessage($"File {filename} does not exist", AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None");
                    AppendMessage(m, "Analogy");
                    continue;
                }

                Text = @"File: " + filename;
                await fileProcessor.Process(FileDataProvider, filename, cancellationTokenSource.Token);
                processed++;
                ProgressReporter.Report(new AnalogyProgressReport("Processed", processed, fileNames.Count, filename));
                if (token.IsCancellationRequested)
                {
                    progressBar1.Visible = false;
                    break;
                }
            }

            btnCancel.Visible = false;
        }

        private void ClearLogs(bool raiseEvent)
        {

            lockSlim.EnterWriteLock();

            if (raiseEvent)
            {
                OnHistoryCleared?.Invoke(this, new AnalogyClearedHistoryEventArgs(PagingManager.GetAllMessages()));
            }

            PagingManager.ClearLogs();
            pageNumber = 1;
            UpdatePage(PagingManager.FirstPage());
            AcceptChanges(true);
            tbMessageInfo.Text = string.Empty;
            if (BookmarkView)
                BookmarkPersistManager.Instance.ClearBookmarks();
            lockSlim.ExitWriteLock();

        }


        private void LoadTextBoxes(AnalogyLogMessage m)
        {
            if (InvokeRequired)
                BeginInvoke(new MethodInvoker(() => tbMessageInfo.Text = m.Text));
            else
            {
                tbMessageInfo.Text = m.Text;
            }

        }

        private void tsmiOTAFull_Click(object sender, EventArgs e)
        {
            if (EnableOTA)
            {
                AnalogyOTAClient client = new AnalogyOTAClient(GetFilteredDataTable());
                client.Show(this);
            }
            else
            {
                MessageBox.Show("Sending logs feature has been disabled", "Operation Is Not allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsBtnShare_Click(object sender, EventArgs e)
        {
            if (EnableOTA)
            {
                AnalogyOTAClient client = new AnalogyOTAClient(GetFilteredDataTable());
                client.Show(this);
            }
            else
            {
                MessageBox.Show("Sharing logs feature has been disabled", "Operation Is Not allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void tmrNewData_Tick(object sender, EventArgs e)
        {
            if (NewDataExist)
            {
                NewDataExist = false;
                AcceptChanges(false);
            }
        }

        private void OpenMessageDetails()
        {
            (AnalogyLogMessage message, string dataSource) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;
            FormMessageDetails details = new FormMessageDetails(message, Messages, dataSource);
            details.Show(this);
        }

        private void tsmiBookmark_Click(object sender, EventArgs e)
        {
            CreateBookmark(false);
        }

        private void CreateBookmark(bool persists)
        {

            (AnalogyLogMessage message, string dataprovider) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;

            lockSlim.EnterWriteLock();
            DataRow dtr = _bookmarkedMessages.NewRow();
            dtr["Date"] = message.Date;
            dtr["Text"] = message.Text ?? "";
            dtr["Source"] = message.Source ?? "";
            dtr["Level"] = message.Level.ToString();
            dtr["Class"] = message.Class.ToString();
            dtr["Category"] = message.Category ?? "";
            dtr["User"] = message.User ?? "";
            dtr["Module"] = message.Module ?? "";
            dtr["Object"] = message;
            dtr["ProcessID"] = message.ProcessID;
            dtr["DataProvider"] = dataprovider;
            if (diffStartTime > DateTime.MinValue)
            {
                dtr["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
            }

            _bookmarkedMessages.Rows.Add(dtr);
            _bookmarkedMessages.AcceptChanges();
            splitContainerMain.CollapsedPanel = CollapsedPanel.None;
            tcBottom.SelectedTab = tabPageBookmarks;
            if (persists)
                BookmarkPersistManager.Instance.AddBookmarkedMessage(message, dataprovider);
            lockSlim.ExitWriteLock();
        }

        private void GoToMessage()
        {
            //int[] selRows = gridViewBookmarkedMessages.GetSelectedRows();
            //if (selRows == null || selRows.Length != 1) return;
            //int rownum = selRows.First();
            //var currentRow = (DataRowView)gridViewBookmarkedMessages.GetRow(rownum);
            //try
            //{
            //    var LogMessage = currentRow["Object"] as AnalogyLogMessage;
            //    var location = LocateByValue(0, gridColumnObject, LogMessage);
            //    if (location >= 0)
            //        LogGrid.FocusedRowHandle = location;
            //    else
            //        XtraMessageBox.Show("Cannot go to message", "Message not found", MessageBoxButtons.OK,
            //            MessageBoxIcon.Error);
            //}
            //catch (Exception)
            //{

            //    XtraMessageBox.Show("Cannot go to message", "Message not found", MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
        }



        private async void chkbHighlight_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        private void tsmiExcludeSource_Click(object sender, EventArgs e)
        {

            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (!string.IsNullOrEmpty(message?.Source))
                cbSource.Text = cbSource.Text + ",-" + message.Source;
        }

        private void tsmiExcludeModule_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (!string.IsNullOrEmpty(message?.Module))
                cbModule.Text = cbModule.Text + ",-" + message.Module;
        }


        private void tsmiTimeDiff_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message != null)
            {
                diffStartTime = message.Date;
                UpdateTimes();
            }
        }

        private void UpdateTimes()
        {
            sfDataGridMain.Columns[timeDiffColumnName].Visible = false;
            try
            {


                lockSlim.EnterWriteLock();
                sfDataGridMain.BeginUpdate();
                foreach (DataRow row in _messageData.Rows)
                {
                    AnalogyLogMessage message = (AnalogyLogMessage)row["Object"];
                    //row["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString("d\\.hh\\:mm\\:ss\\.fff");
                    row["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
                }

                sfDataGridMain.EndUpdate();
                AcceptChanges(true);
            }
            finally
            {
                lockSlim.ExitWriteLock();
            }


        }

        private async void SaveMessagesToLog(IAnalogyOfflineDataProvider fileHandler, List<AnalogyLogMessage> messages)
        {

            if (fileHandler != null && fileHandler.CanSaveToLogFile)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = fileHandler.FileSaveDialogFilters;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        await fileHandler.SaveAsync(messages, saveFileDialog.FileName);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, @"Error Saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                if (MessageBox.Show("Current Data Source does not support Save Operation" + Environment.NewLine + "Do you want to Save in Analogy XML Format?", @"Save not Supported", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    SaveMessagesToLog(AnalogyOfflineDataProvider, messages);
                    //SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //saveFileDialog.Filter = "Plain XML log file - Analogy Data format (*.xml)| *.xml";

                    //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    //{
                    //    try
                    //    {
                    //        AnalogyXmlLogFile save = new AnalogyXmlLogFile();
                    //        save.Save(Messages, saveFileDialog.FileName);
                    //        XtraMessageBox.Show("Operation Completed", $"Messages were saved to {saveFileDialog.FileName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }
                    //    catch (Exception e)
                    //    {
                    //        XtraMessageBox.Show(e.Message, @"Error Saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                }
                else
                {
                    MessageBox.Show("Operation Aborted", @"Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private async void sBtnMostCommon_Click(object sender, EventArgs e)
        {
            List<string> items;

            lockSlim.EnterReadLock();
            items = Messages.Select(r => r.Text).ToList();
            lockSlim.ExitReadLock();

            AnalogyExclude ef = new AnalogyExclude(items, _excludeMostCommon);
            if (ef.ShowDialog(this) == DialogResult.OK)
            {
                _excludeMostCommon = AnalogyExclude.GlobalExclusion;
                chkExclude.Checked = true;
                await FilterHasChanged();
            }
        }

        private void tsmiSaveLayout_Click(object sender, EventArgs e)
        {
            SaveGridLayout();
        }

        private void SaveGridLayout()
        {
            try
            {
                using (FileStream fileStream = File.Create(LayoutFileNameMain))
                {
                    sfDataGridMain.Serialize(fileStream, Serialization());
                }
            }
            catch (Exception exception)
            {
                AnalogyLogger.Intance.LogException(exception, nameof(UCLogs), "Error saving layout");
                throw;
            }
        }
        private void tsmiBookmarkPersist_Click(object sender, EventArgs e)
        {
            CreateBookmark(true);
        }

        private void tsmiRemoveBookmark_Click(object sender, EventArgs e)
        {
            RemoveBookmark();
        }
        private void RemoveBookmark()
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message != null)
                BookmarkPersistManager.Instance.RemoveBookmark(message);

        }
        //private void logGrid_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        //{
        //    if (e.Column.FieldName == "gridColumnLevelImage")
        //    {
        //        string severity = logGrid.GetListSourceRowCellValue(e.ListSourceRowIndex, gridView1.Columns["Level"])
        //            .ToString();
        //        LogLevel level = Utils.GetLogLevel(severity);
        //        switch (level)
        //        {
        //            case LogLevel.Critical:
        //            case LogLevel.Error:
        //                e.Value = imageList.Images[0];
        //                break;
        //            case LogLevel.Warning:
        //                e.Value = imageList.Images[1];
        //                break;
        //            case LogLevel.Event:
        //                e.Value = imageList.Images[2];
        //                break;
        //            case LogLevel.Verbose:
        //                e.Value = imageList.Images[2];
        //                break;
        //            case LogLevel.Debug:
        //                e.Value = imageList.Images[1];
        //                break;
        //            case LogLevel.Disabled:
        //                e.Value = imageList.Images[1];
        //                break;
        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }

        //    }
        //}

        public void SetBookmarkMode()
        {
            BookmarkView = true;
            BookmarkModeUI();
        }

        public void RemoveMessage(AnalogyLogMessage msgMessage)
        {
            var row = _messageData.AsEnumerable().SingleOrDefault(r => r["Object"] == msgMessage);
            if (row != null)
                _messageData.Rows.Remove(row);
        }

        private void cmsMessageOperation_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message != null)
            {
                tsmiExcludeModule.Text = $"Exclude Process: {message.Module}";
                tsmiExcludeSource.Text = $"Exclude Source: {message.Source}";
                tsmiDateFilterNewer.Text = $"Show all messages after {message.Date}";
                tsmiDateFilterOlder.Text = $"Show all messages Before {message.Date}";
                tsmiDateFilterNewer.Visible = true;
                tsmiDateFilterOlder.Visible = true;
            }
            else
            {
                tsmiDateFilterNewer.Visible = false;
                tsmiDateFilterOlder.Visible = false;

            }
        }

        private (AnalogyLogMessage, string) GetMessageFromSelectedRowInGrid()
        {
            if (!sfDataGridMain.SelectedItems.Any()) return (null, string.Empty);
            var selectedItems = sfDataGridMain.SelectedItems.Cast<DataRowView>();
            DataRow dataRow = selectedItems.First().Row;
            AnalogyLogMessage message = GetMessageFromRow(dataRow);
            string datasource = (string)dataRow["DataProvider"].ToString();
            return (message, datasource);

        }

        private void cmsBookmarked_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message != null)
            {
                tsmiExcludeModuleBookmark.Text = $"Exclude Process: {message.Module}";
                tsmiExcludeSourceBookmark.Text = $"Exclude Source: {message.Source}";
                tsmiBookmarkDateFilterNewer.Text = $"Show all messages after {message.Date}";
                tsmiBookmarkDateFilterOlder.Text = $"Show all messages Before {message.Date}";
                tsmiBookmarkDateFilterNewer.Visible = true;
                tsmiBookmarkDateFilterOlder.Visible = true;
            }
            else
            {
                tsmiDateFilterNewer.Visible = false;
                tsmiBookmarkDateFilterOlder.Visible = false;

            }
        }

        private void tsmiCopyMessages_Click(object sender, EventArgs e)
        {
            var messages = Messages;
            string all = string.Join(Environment.NewLine, messages.Select(m => $"{m.Date.ToString()}: {m.Text}"));
            Clipboard.SetText(all);
        }



        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            UpdatePage(PagingManager.FirstPage());
        }

        private void btnPagePrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1) return;
            pageNumber--;
            UpdatePage(PagingManager.PrevPage().Data);
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            if (pageNumber == TotalPages) return;
            pageNumber++;
            UpdatePage(PagingManager.NextPage().Data);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = TotalPages;
            UpdatePage(PagingManager.LastPage());
        }

        private void ExportToExcel()
        {
            var count = sfDataGridMain.RowCount;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel file XLSX (*.xlsx)|*.xlsx|Excel file XLS (*.XLS)|*.xls";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveFileDialog.FilterIndex == 1)
                {
                    if (count > 1048576)
                    {
                        MessageBox.Show($"XLSX files are limited to 1,048,576 rows (and 16,384 columns). You have {count} rows", "Export Aborted");
                    }
                    else
                    {
                        var options = new ExcelExportingOptions();
                        var excelEngine = sfDataGridMain.ExportToExcel(sfDataGridMain.View, options);
                        var workBook = excelEngine.Excel.Workbooks[0];
                        workBook.SaveAs(saveFileDialog.FileName);
                        OpenFolder(saveFileDialog.FileName);
                    }
                }
                if (saveFileDialog.FilterIndex == 2)
                {
                    if (count > 65536)
                    {
                        MessageBox.Show($"XLS files are limited to 65,536 rows (and 256 columns). You have {count} rows", "Export Aborted");
                    }
                    else
                    {
                        var options = new ExcelExportingOptions();
                        var excelEngine = sfDataGridMain.ExportToExcel(sfDataGridMain.View, options);
                        var workBook = excelEngine.Excel.Workbooks[0];
                        workBook.SaveAs(saveFileDialog.FileName);
                        OpenFolder(saveFileDialog.FileName);
                    }
                }
            }
        }
        private void OpenFolder(string filename)
        {
            try
            {
                Process.Start("explorer.exe", "/select, \"" + filename + "\"");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Opening file location", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void UndockView()
        {
            var msg = Messages;
            if (!msg.Any()) return;
            var source = GetFilteredDataTable().Rows[0]?["DataProvider"]?.ToString();
            if (source == null) return;
            LogGridForm grid = new LogGridForm(msg, source);
            lockExternalWindowsObject.EnterWriteLock();
            _externalWindows.Add(grid);
            Interlocked.Increment(ref ExternalWindowsCount);
            lockExternalWindowsObject.ExitWriteLock();
            grid.FormClosing += (s, arg) =>
            {
                lockExternalWindowsObject.EnterWriteLock();
                Interlocked.Decrement(ref ExternalWindowsCount);
                _externalWindows.Remove(grid);
                lockExternalWindowsObject.ExitWriteLock();
            };
            grid.Show(this);
        }


        private void tsmiIncreaseFont_Click(object sender, EventArgs e)
        {
            Settings.FontSize = sfDataGridMain.Font.Size + 2;
            sfDataGridMain.Font = new Font(sfDataGridMain.Font.Name, Settings.FontSize);
            //todo:
            /// gridViewBookmarkedMessages.Appearance.Row.Font = new Font(LogGrid.Appearance.Row.Font.Name, Settings.FontSize);
            SaveGridLayout();
        }

        private void tsmiDecreaseFont_Click(object sender, EventArgs e)
        {
            if (sfDataGridMain.Font.Size < 5) return;
            {
                Settings.FontSize = sfDataGridMain.Font.Size - 2;
                sfDataGridMain.Font = new Font(sfDataGridMain.Font.Name, Settings.FontSize);
                //todo:
                //gridViewBookmarkedMessages.Appearance.Row.Font = new Font(LogGrid.Appearance.Row.Font.Name, Settings.FontSize);
                SaveGridLayout();
            }
        }

        private void tsmiClearLog_Click(object sender, EventArgs e)
        {
            ClearLogs(true);
        }

        private void tsmiREmoveAllPreviousMessages_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage current, _) = GetMessageFromSelectedRowInGrid();
            if (current == null) return;

            lockSlim.EnterWriteLock();
            while (_messageData.Rows.Count > 0)
            {
                if (_messageData.Rows[0]["Object"] != current)
                    _messageData.Rows.RemoveAt(0);
                else
                {
                    break;
                }
            }
            lockSlim.ExitWriteLock();
            RefreshUIMessagesCount();

        }
        private static Bitmap takeComponentScreenShot(Control control)
        {
            // find absolute position of the control in the screen.
            Control ctrl = control;
            Rectangle rect = new Rectangle(Point.Empty, ctrl.Size);
            do
            {
                rect.Offset(ctrl.Location);
                ctrl = ctrl.Parent;
            }
            while (ctrl != null);

            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);

            return bmp;
        }

        private void UndockViewPerProcess()
        {
            var msg = Messages;
            if (!msg.Any()) return;
            var source = GetFilteredDataTable().Rows[0]?["DataProvider"]?.ToString();
            if (source == null) return;

            var processes = msg.Select(m => m.Module).Distinct().ToList();
            foreach (string process in processes)
            {
                LogGridForm grid = new LogGridForm(msg, source, process);
                lockExternalWindowsObject.EnterWriteLock();
                _externalWindows.Add(grid);
                Interlocked.Increment(ref ExternalWindowsCount);
                lockExternalWindowsObject.ExitWriteLock();
                grid.FormClosing += (s, arg) =>
                {
                    lockExternalWindowsObject.EnterWriteLock();
                    Interlocked.Decrement(ref ExternalWindowsCount);
                    _externalWindows.Remove(grid);
                    lockExternalWindowsObject.ExitWriteLock();
                };
                grid.Show(this);
            }
        }

        private void sbtnTextInclude_Click(object sender, EventArgs e)
        {
            //txtbInclude.Text = "";
        }

        private void sbtnTextExclude_Click(object sender, EventArgs e)
        {
            // txtbExclude.Text = "";
        }

        private void sbtnIncludeSources_Click(object sender, EventArgs e)
        {
            cbSource.Text = "";
        }

        private async void txtbIncludeSource_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSource.Text))
            {
                chkbSources.Checked = false;
            }
            else
            {
                if (!chkbSources.Checked)
                    chkbSources.Checked = true;
            }

            await FilterHasChanged();
            Settings.SourceText = chkbSources.Text;
        }


        private void sbtnIncludeModules_Click(object sender, EventArgs e)
        {
            cbModule.Text = "";
        }

        private async void txtbIncludeModule_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbModule.Text))
            {
                chkbModules.Checked = false;
            }
            else
            {
                if (!chkbModules.Checked)
                    chkbModules.Checked = true;
            }

            await FilterHasChanged();
            Settings.ModuleText = chkbModules.Text;
        }

        private void sbtnUndockPerProcess_Click(object sender, EventArgs e)
        {
            UndockViewPerProcess();
        }

        private async void deNewerThanFilter_EditValueChanged(object sender, EventArgs e)
        {
            chkDateNewerThan.Checked = true;
            await FilterHasChanged();
        }
        private async void deNewerThanFilter_Properties_EditValueChanged(object sender, EventArgs e)
        {
            chkDateNewerThan.Checked = true;
            await FilterHasChanged();
        }

        private async void deOlderThanFilter_EditValueChanged(object sender, EventArgs e)
        {
            chkDateOlderThan.Checked = true;
            await FilterHasChanged();
        }

        private async void deOlderThanFilter_Properties_EditValueChanged(object sender, EventArgs e)
        {
            chkDateOlderThan.Checked = true;
            await FilterHasChanged();
        }

        private async void chkDateOlderThan_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        private async void chkDateNewerThan_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        private void tsmiDateFilterNewer_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            deNewerThanFilter.Value = message.Date;
            chkDateNewerThan.Checked = true;
        }

        private void tsmiDateFilterOlder_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            deOlderThanFilter.Value = message.Date;
            chkDateOlderThan.Checked = true;
        }

        private void tsmiBookmarkDateFilterNewer_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            deNewerThanFilter.Value = message.Date;
            chkDateNewerThan.Checked = true;
        }

        private void tsmiBookmarkDateFilterOlder_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            deOlderThanFilter.Value = message.Date;
            chkDateOlderThan.Checked = true;
        }

        private void sbtnMoreHighlight_Click(object sender, EventArgs e)
        {
            UserSettingsForm user = new UserSettingsForm(1);
            user.ShowDialog(this);
        }

        private void sbtnPreDefinedFilters_Click(object sender, EventArgs e)
        {
            if (!Settings.PreDefinedQueries.Filters.Any()) return;
            contextMenuStripFilters.Items.Clear();
            foreach (PreDefineFilter filter in Settings.PreDefinedQueries.Filters)
            {

                ToolStripMenuItem item = new ToolStripMenuItem(filter.ToString());
                item.Click += (s, arg) =>
                {
                    cbInclude.Text = filter.IncludeText;
                    cbExclude.Text = filter.ExcludeText;
                    cbSource.Text = filter.Sources;
                    cbModule.Text = filter.Modules;
                };
                contextMenuStripFilters.Items.Add(item);
            }

            contextMenuStripFilters.Show(sbtnPreDefinedFilters.PointToScreen(sbtnPreDefinedFilters.Location));
        }
        
        private SerializationOptions Serialization()
        {
            SerializationOptions serializationOptions = new SerializationOptions
            {
                SerializeStyle = true,
                SerializeCaptionSummaries = true,
                SerializeColumns = true,
                SerializeFiltering = true,
                SerializeGrouping = true,
                SerializeGroupSummaries = true,
                SerializeSorting = true,
                SerializeStackedHeaders = true,
                SerializeTableSummaries = true,
                SerializeUnboundRows = true
            };
            return serializationOptions;
        }
        private DeserializationOptions Deserialization()
        {
            DeserializationOptions deserializationOptions = new DeserializationOptions
            {
                DeserializeCaptionSummary = true,
                DeserializeColumns = true,
                DeserializeFiltering = true,
                DeserializeGrouping = true,
                DeserializeGroupSummaries = true,
                DeserializeSorting = true,
                DeserializeStackedHeaders = true,
                DeserializeStyle = true,
                DeserializeTableSummaries = true,
                DeserializeUnboundRows = true
            };

            return deserializationOptions;
        }

        private void sfDataGridMain_StyleChanged(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fileStream = File.Create(LayoutFileNameMain))
                {
                    sfDataGridMain.Serialize(fileStream, Serialization());
                }
            }
            catch (Exception exception)
            {
                AnalogyLogger.Intance.LogException(exception, nameof(UCLogs), "Error saving layout");

            }
        }

    }
}




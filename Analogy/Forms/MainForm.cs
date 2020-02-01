using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.IO;
using System.Threading.Tasks;
using Analogy.DataSources;
using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.Managers;
using Analogy.Properties;
using Analogy.Tools;
using Analogy.Types;

namespace Analogy
{
    public partial class MainForm : RibbonForm
    {
        private string filePoolingTitle = "File Pooling";
        private string offlineTitle = "Offline log";
        private string onlineTitle = "Online log";
        private Dictionary<Guid, ToolStripTabItem> Mapping = new Dictionary<Guid, ToolStripTabItem>();

        private Dictionary<OnlineUCLogs, IAnalogyRealTimeDataProvider> onlineDataSourcesMapping =
            new Dictionary<OnlineUCLogs, IAnalogyRealTimeDataProvider>();

        private List<Task<bool>> OnlineSources = new List<Task<bool>>();
        private int offline;
        private int online;
        private int filePooling;
        private bool disableOnlineDueToFileOpen;
        private UserSettingsManager settings => UserSettingsManager.UserSettings;
        private bool Initialized { get; set; }

        TouchStyleColorTable touch = new TouchStyleColorTable();

        public MainForm()
        {
            InitializeComponent();
            AnalogyLogManager.Instance.OnNewError += (s, e) => BeginInvoke(new MethodInvoker(() => { tsslblError.Visible = true; }));
                
            //  ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            touch.HeaderColor = Color.White;//ColorTranslator.FromHtml("#f5f6f7");
            touch.ActiveToolStripTabItemBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.RibbonPanelBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.BackStageNavigationButtonBackColor = ColorTranslator.FromHtml("#1979ca");
            touch.ToolStripBorderColor = ColorTranslator.FromHtml("#dadbdc");
            touch.ToolstripSelectedTabItemBorder = ColorTranslator.FromHtml("#dadbdc");
            touch.ToolstripTabItemBorder = Color.Transparent;
            touch.ToolstripTabItemForeColor = ColorTranslator.FromHtml("#3c3c3c");
            touch.HoverTabBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.BottomToolStripBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.ToolstripActiveTabItemForeColor = Color.Black;
            touch.HoverTabForeColor = Color.Black;
            touch.MinimizeButtonForeColor = Color.Black;
            touch.MaximizeButtonForeColor = Color.Black;

            ribbonControlMain.ApplyTouchStyleColorTable(touch);


            ribbonControlMain.SelectedTab = toolStripTabItem1;

            dockingManager1.EnableDocumentMode = true;
            dockingManager1.DockTabAlignment = DockTabAlignmentStyle.Top;


        }

        private void DockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {

            //dockingManager1.DockControl(panel1, this, DockingStyle.Bottom, 250);
            //dockingManager1.DockControl(panel3, this, DockingStyle.Top, 250);
            //  dockingManager1.DockControl(gradientPanel1,this,DockingStyle.Left,250);
            //dockingManager1.DockControl(gradientPanel2, this, DockingStyle.Right, 250);
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            tsslFileCaching.Text = $@"File caching is {(settings.EnableFileCaching ? "on" : "off")}";
            SetupEventHandlers();
            string[] arguments = Environment.GetCommandLineArgs();
            disableOnlineDueToFileOpen = arguments.Length == 2;
            if (DesignMode) return;

            MainStatusStrip.Text = "File caching is " + (settings.EnableFileCaching ? "on" : "off");
            //bbtnCloseCurrentTabPage.ItemClick += (object s, ItemClickEventArgs ea) => { CloseCurrentTabPage(); };
            //bbtnCloseAllTabPage.ItemClick += (object s, ItemClickEventArgs ea) =>
            //{
            //    var pages = xtcLogs.TabPages.ToList();
            //    foreach (var page in pages)
            //    {
            //        if (onlineDataSourcesMapping.ContainsKey(page))
            //        {
            //            onlineDataSourcesMapping[page].StopReceiving();
            //            onlineDataSourcesMapping.Remove(page);
            //        }

            //        xtcLogs.TabPages.Remove(page);

            //    }
            //};
            //bbtnCloseOtherTabPages.ItemClick += (object s, ItemClickEventArgs ea) =>
            //{
            //    var pages = xtcLogs.TabPages.Where(p => p != currentContextPage).ToList();
            //    foreach (var page in pages)
            //    {
            //        if (onlineDataSourcesMapping.ContainsKey(page))
            //        {
            //            onlineDataSourcesMapping[page].StopReceiving();
            //            onlineDataSourcesMapping.Remove(page);
            //        }

            //        xtcLogs.TabPages.Remove(page);

            //    }

            //};
            ribbonControlMain.MinimizePanel = UserSettingsManager.UserSettings.StartupRibbonMinimized;

   
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
            ribbonControlMain.SelectedTabItemChanged += (s, arg) =>
            {
                if (Mapping.ContainsValue(arg.NewSelectedTab))
                {
                    Guid id = Mapping.Single(kv => kv.Value == arg.NewSelectedTab).Key;
                    UserSettingsManager.UserSettings.LastOpenedDataProvider = id;
                }
            };
            if (AnalogyLogManager.Instance.HasErrorMessages || AnalogyLogManager.Instance.HasWarningMessages)
                tsslblError.Visible = true;
            


            ribbonControlMain.MenuButtonText = "FILE";
            ribbonControlMain.BackStageNavigationButtonStyle = BackStageNavigationButtonStyles.Office2013;
            ribbonControlMain.QuickPanelAlignment = QuickPanelAlignment.Top;
            touch.CloseButtonForeColor = Color.Black;
            touch.RestoreButtonForeColor = Color.Black;
            touch.BottomToolStripBackColor = ColorTranslator.FromHtml("#ffffff");
            touch.QATDownArrowColor = Color.Black;
            touch.ToolStripSpliterColor = ColorTranslator.FromHtml("#e2e3e4");
            superAccelerator1.BackColor = ColorTranslator.FromHtml("#eaf0f8");
            superAccelerator1.SetMenuButtonAccelerator(ribbonControlMain, "F");

        }

        private void SetupEventHandlers()
        {
            IAnalogyFactory analogy = FactoriesManager.Instance.Get(AnalogyBuiltInFactory.AnalogyGuid);
            var offlineAnalogy = analogy.DataProviders.Items.Where(f => f is IAnalogyOfflineDataProvider)
                .Cast<IAnalogyOfflineDataProvider>().First();
            //if (settings.GetFactorySetting(analogy.FactoryID).Status != DataProviderFactoryStatus.Disabled)

            tsbtnAnalogyOpenFolder.Click += (sender, e) => { OpenOffline(tstitmAnalogy, offlineAnalogy, offlineAnalogy.OptionalTitle, offlineAnalogy.InitialFolderFullPath); };
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
                    OpenOffline(tstitmAnalogy, offlineAnalogy, offlineAnalogy.OptionalTitle, offlineAnalogy.InitialFolderFullPath,
                        openFileDialog1.FileNames);
                    AddRecentFiles(tstitmAnalogy, tsbtnAnalogyRecentlyOpenFiles, offlineAnalogy, offlineAnalogy.OptionalTitle,
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

            ToolStripTabItem ribbonPage = new ToolStripTabItem { Text = factory.Title };
            ribbonControlMain.Header.AddMainItem(ribbonPage);
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
                ToolStripEx groupActionSource = new ToolStripEx
                {
                    Text = actionFactory.Title,
                    AllowMenuTextAlignment = true,
                    AutoSize = true
                };
                ribbonPage.Panel.Controls.Add(groupActionSource);
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

            ToolStripEx groupInfoSource = new ToolStripEx
            {
                Text = "About",
                AutoSize = true
            };
            ribbonPage.Panel.Controls.Add(groupInfoSource);
            ToolStripButton aboutBtn = new ToolStripButton("Data Source Information", Resources.About_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };

            groupInfoSource.Items.Add(aboutBtn);
            aboutBtn.Click += (sender, e) => { new AboutDataSourceBox(factory).ShowDialog(this); };
        }

        private void CreateDataSourceRibbonGroup(IAnalogyDataProvidersFactory dataSourceFactory, ToolStripTabItem ribbonPage)
        {
            ToolStripEx ribbonPageGroup = new ToolStripEx { Text = dataSourceFactory.Title, AutoSize = true };
            ribbonPage.Panel.Controls.Add(ribbonPageGroup);

            AddRealTimeDataSource(ribbonPage, dataSourceFactory, ribbonPageGroup);
            AddOfflineDataSource(ribbonPage, dataSourceFactory, ribbonPageGroup);


            //add bookmark
            ToolStripButton bookmarkBtn = new ToolStripButton("Bookmarks", Resources.RichEditBookmark_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText,
                AutoSize = true,
            };

            ribbonPageGroup.Items.Add(bookmarkBtn);
            bookmarkBtn.Click += (sender, e) => { OpenBookmarkLog(); };
        }

        private void AddToDockingManager(Control control, string title)
        {
            dockingManager1.SetDockLabel(control, title);
            dockingManager1.SetCustomCaptionButtons(control, new CaptionButtonsCollection());
            dockingManager1.DockAsDocument(control);

        }
        private void AddRealTimeDataSource(ToolStripTabItem ribbonPage, IAnalogyDataProvidersFactory dataSourceFactory, ToolStripEx group)
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
                ToolStripDropDownButton realTimeMenu =
                    new ToolStripDropDownButton("Real Time Logs", Resources.Database_off)
                    {
                        DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                        TextImageRelation = TextImageRelation.ImageAboveText
                    };
                group.Items.Add(realTimeMenu);

                foreach (var realTime in realtimes)
                {
                    ToolStripMenuItem realTimeBtn = new ToolStripMenuItem()
                    {
                        Image = Resources.Database_off,
                        Text = "Real Time Logs" + (!string.IsNullOrEmpty(realTime.OptionalTitle)
                                   ? $" - {realTime.OptionalTitle}"
                                   : string.Empty)
                    };
                    realTimeMenu.DropDownItems.Add(realTimeBtn);
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
                            dockingManager1.ActivateControl(onlineUC);
                            //xtcLogs.SelectedTabPage = page;

                            void OnXtcLogsOnControlRemoved(object sender, DockVisibilityChangedEventArgs arg)
                            {
                                if (arg.Control == onlineUC)
                                {
                                    try
                                    {
                                        onlineUC.Enable = false;
                                        realTime.StopReceiving();
                                        realTime.OnMessageReady -= OnRealTimeOnMessageReady;
                                        realTime.OnManyMessagesReady -= OnRealTimeOnOnManyMessagesReady;
                                        realTime.OnDisconnected -= OnRealTimeDisconnected;
                                        //page.Controls.Remove(onlineUC);
                                    }
                                    catch (Exception e)
                                    {
                                        AnalogyLogManager.Instance.LogError(
                                            "Error during call to Stop receiving: " + e);
                                    }
                                    finally
                                    {
                                        dockingManager1.DockVisibilityChanged -= OnXtcLogsOnControlRemoved;
                                    }
                                }
                            }
                            dockingManager1.DockVisibilityChanged += OnXtcLogsOnControlRemoved;
                            //xtcLogs.ControlRemoved += OnXtcLogsOnControlRemoved;
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

        private void AddOfflineDataSource(ToolStripTabItem ribbonPage, IAnalogyDataProvidersFactory factory, ToolStripEx group)
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
                ToolStripEx groupOfflineFileTools = new ToolStripEx { Text = $"Tools{optionalText}", AutoSize = true };
                AddSingleOfflineDataSource(ribbonPage, offlineAnalogy, factory.Title, group, groupOfflineFileTools);
                groupOfflineFileTools.AllowMenuTextAlignment = true;
                ribbonPage.Panel.Controls.Add(groupOfflineFileTools);

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

        private void AddMultiplesOfflineDataSource(ToolStripTabItem ribbonPage,
            List<IAnalogyOfflineDataProvider> offlineProviders, string factoryTitle, ToolStripEx group)
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
                dockingManager1.ActivateControl(offlineUC);
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
                dockingManager1.ActivateControl(ClientServerUCLog);
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
            }

            void OpenFilePooling(string titleOfDataSource, IAnalogyOfflineDataProvider dataProvider,
                string initialFolder, string file)
            {

                offline++;
                UserControl filepoolingUC = new FilePoolingUCLogs(dataProvider, file, initialFolder);

                void OnXtcLogsOnControlRemoved(object sender, DockVisibilityChangedEventArgs arg)
                {
                    if (arg.Control == filepoolingUC)
                    {
                        try
                        {
                            filepoolingUC.Dispose();
                        }
                        catch (Exception e)
                        {
                            AnalogyLogManager.Instance.LogError("Error during dispose: " + e);
                        }
                        finally
                        {
                            dockingManager1.DockVisibilityChanged -= OnXtcLogsOnControlRemoved;
                        }
                    }
                }

                filepoolingUC.Tag = ribbonPage;
                filepoolingUC.Dock = DockStyle.Fill;
                filepoolingUC.Text = $"{filePoolingTitle} #{filePooling} ({titleOfDataSource})";
                AddToDockingManager(filepoolingUC, filepoolingUC.Text);
                dockingManager1.ActivateControl(filepoolingUC);
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
                dockingManager1.DockVisibilityChanged += OnXtcLogsOnControlRemoved;
            }


            //recent bar
            var recentBar = new ToolStripDropDownButton("Recently Used Files", Resources.RecentlyUse_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };
            //local folder
            if (offlineProviders.Any(i => !string.IsNullOrEmpty(i.InitialFolderFullPath) &&
                                          Directory.Exists(i.InitialFolderFullPath)))
            {
                ToolStripDropDownButton folderBar = new ToolStripDropDownButton("Open Folder", Resources.Open2_32x32)
                {
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    TextImageRelation = TextImageRelation.ImageAboveText
                };
                group.Items.Add(folderBar);

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

                        folderBar.DropDownItems.Add(btn);
                    }
                }
            }


            //add Files open buttons
            if (offlineProviders.Any(i => !string.IsNullOrEmpty(i.FileOpenDialogFilters)))
            {
                //add Open files entry
                var openFiles = new ToolStripDropDownButton("Open Files", Resources.Article_32x32)
                {
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    TextImageRelation = TextImageRelation.ImageAboveText
                };
                group.Items.Add(openFiles);
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
                        openFiles.DropDownItems.Add(btnOpenFile);
                    }
                }



                //add Open Pooled file entry
                ToolStripDropDownButton filePoolingBtn =
                    new ToolStripDropDownButton("File Pooling", Resources.FilePooling_32x32)
                    {
                        DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                        TextImageRelation = TextImageRelation.ImageAboveText
                    };
                group.Items.Add(filePoolingBtn);
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
                    filePoolingBtn.DropDownItems.Add(btnOpenFile);
                }
            }


            //add recent
            group.Items.Add(recentBar);
            foreach (var dataProvider in offlineProviders)
            {
                var recents = UserSettingsManager.UserSettings.RecentFiles.Where(itm => itm.ID == dataProvider.ID)
                    .Select(itm => itm.FileName).ToList();
                AddRecentFiles(ribbonPage, recentBar, dataProvider, dataProvider.OptionalTitle, recents);
            }

            ToolStripDropDownButton externalSources = new ToolStripDropDownButton("Known Locations", Resources.ServerMode_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };

            group.Items.Add(externalSources);
            //add client/server  button:
            foreach (var dataProvider in offlineProviders)
            {
                ToolStripMenuItem btnOpenLocation = new ToolStripMenuItem { Text = $"{factoryTitle} ({dataProvider.OptionalTitle})" };
                btnOpenLocation.Click += (sender, e) =>
                {
                    OpenExternalDataSource(dataProvider.OptionalTitle, dataProvider);
                };
                externalSources.DropDownItems.Add(btnOpenLocation);
            }


            //add tools

            ToolStripEx groupOfflineFileTools = new ToolStripEx()
            {
                Text = $"Tools for {factoryTitle}",
                AutoSize = true
            };
            ribbonPage.Panel.Controls.Add(groupOfflineFileTools);


            var searchFiles = new ToolStripDropDownButton("Search in Files", Resources.Lookup_Reference_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };
            groupOfflineFileTools.Items.Add(searchFiles);
            foreach (var dataProvider in offlineProviders)
            {
                var btnSearching = new ToolStripMenuItem { Text = $" search in: {factoryTitle} ({dataProvider.OptionalTitle})" };
                btnSearching.Click += (sender, e) =>
                {
                    var search = new SearchForm(dataProvider);
                    search.Show(this);
                };
                searchFiles.DropDownItems.Add(btnSearching);
            }


            var combineFiles = new ToolStripDropDownButton("Combine Files", Resources.Sutotal_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };
            groupOfflineFileTools.Items.Add(combineFiles);

            foreach (var dataProvider in offlineProviders)
            {
                var btnCombine = new ToolStripMenuItem { Text = $"Combine files for: {factoryTitle} ({dataProvider.OptionalTitle})" };
                btnCombine.Click += (sender, e) =>
                {
                    var combined = new FormCombineFiles(dataProvider);
                    combined.Show(this);
                };
                combineFiles.DropDownItems.Add(btnCombine);
            }



            var compareFiles = new ToolStripDropDownButton("Compare Files", Resources.TwoColumns)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };
            groupOfflineFileTools.Items.Add(compareFiles);
            foreach (var dataProvider in offlineProviders)
            {
                var btnCombine = new ToolStripMenuItem { Text = $"Compare files for: {factoryTitle} ({dataProvider.OptionalTitle})" };
                btnCombine.Click += (sender, e) =>
                {
                    FileComparerForm compare = new FileComparerForm(dataProvider);
                    compare.ShowDialog(this);
                };
                compareFiles.DropDownItems.Add(btnCombine);
            }
        }

       private void OpenOffline(ToolStripTabItem ribbonPage, IAnalogyOfflineDataProvider offlineAnalogy,string titleOfDataSource, string initialFolder, string[] files = null)
        {
            offline++;
            UserControl page = new OfflineUCLogs(offlineAnalogy, files, initialFolder);
            page.Tag = ribbonPage;
            page.Text = $"{offlineTitle} #{offline} ({titleOfDataSource})";
            AddToDockingManager(page, page.Text);
            dockingManager1.ActivateControl(page);
        }
        private void AddSingleOfflineDataSource(ToolStripTabItem ribbonPage, IAnalogyOfflineDataProvider offlineAnalogy,
           string title, ToolStripEx group, ToolStripEx groupOfflineFileTools)
        {
            void OpenExternalDataSource(string titleOfDataSource, IAnalogyOfflineDataProvider analogy)
            {
                offline++;
                var page = new ClientServerUCLog(analogy);
                page.Tag = ribbonPage;
                page.Text = $"Client/Server logs #{offline}. {titleOfDataSource}";

                AddToDockingManager(page, page.Text);
                dockingManager1.ActivateControl(page);
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
            }
            void OpenFilePooling(string titleOfDataSource, string initialFolder, string file)
            {

                offline++;
                UserControl page = new FilePoolingUCLogs(offlineAnalogy, file, initialFolder);
                void OnXtcLogsOnControlRemoved(object sender, DockVisibilityChangedEventArgs arg)
                {
                    if (arg.Control == page)
                    {
                        try
                        {
                            page.Dispose();
                        }
                        catch (Exception e)
                        {
                            AnalogyLogManager.Instance.LogError("Error during dispose: " + e);
                        }
                        finally
                        {
                            dockingManager1.DockVisibilityChanged -= OnXtcLogsOnControlRemoved;
                        }
                    }
                }

                page.Tag = ribbonPage;
                page.Text = $"{filePoolingTitle} #{filePooling} ({titleOfDataSource})";
                AddToDockingManager(page, page.Text);
                dockingManager1.ActivateControl(page);
                dockingManager1.DockVisibilityChanged += OnXtcLogsOnControlRemoved;
                //xtcLogs.TabPages.Add(page);
                //xtcLogs.SelectedTabPage = page;
                //xtcLogs.ControlRemoved += OnXtcLogsOnControlRemoved;
            }

            //add local folder button:
            if (!string.IsNullOrEmpty(offlineAnalogy.InitialFolderFullPath) &&
                Directory.Exists(offlineAnalogy.InitialFolderFullPath))
            {
                var localfolder = new ToolStripButton("Open Folder", Resources.Open2_32x32)
                {
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    TextImageRelation = TextImageRelation.ImageAboveText,
                    AutoSize = true
                };
                group.Items.Add(localfolder);
                localfolder.Click += (sender, e) => { OpenOffline(ribbonPage,offlineAnalogy,title, offlineAnalogy.InitialFolderFullPath); };
            }

            //recent bar
            var recentBar = new ToolStripDropDownButton("Recently Used Files", Resources.RecentlyUse_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText,
                AutoSize = true
            };

            //add Files open buttons
            if (!string.IsNullOrEmpty(offlineAnalogy.FileOpenDialogFilters))
            {
                //add Open files entry
                var openFiles = new ToolStripButton("Open Files", Resources.Article_32x32)
                {
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    TextImageRelation = TextImageRelation.ImageAboveText,
                    AutoSize = true
                };
                group.Items.Add(openFiles);
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
                        OpenOffline( ribbonPage,offlineAnalogy, title, offlineAnalogy.InitialFolderFullPath, openFileDialog1.FileNames);
                        AddRecentFiles(ribbonPage, recentBar, offlineAnalogy, title,
                            openFileDialog1.FileNames.ToList());
                    }
                };

                //add Open Pooled file entry
                var filePoolingBtn = new ToolStripButton("File Pooling", Resources.FilePooling_32x32)
                {
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    TextImageRelation = TextImageRelation.ImageAboveText
                };
                group.Items.Add(filePoolingBtn);
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
            group.Items.Add(recentBar);
            var recents = UserSettingsManager.UserSettings.RecentFiles.Where(itm => itm.ID == offlineAnalogy.ID)
                .Select(itm => itm.FileName).ToList();
            AddRecentFiles(ribbonPage, recentBar, offlineAnalogy, title, recents);

            //add client/server  button:
            var externalSources = new ToolStripButton("Known Locations", Resources.ServerMode_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };

            group.Items.Add(externalSources);
            externalSources.Click += (sender, e) => { OpenExternalDataSource(title, offlineAnalogy); };

            //add tools
            var searchFiles = new ToolStripButton("Search in Files", Resources.Lookup_Reference_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };
            groupOfflineFileTools.Items.Add(searchFiles);
            searchFiles.Click += (sender, e) =>
            {
                var search = new SearchForm(offlineAnalogy);
                search.Show(this);
            };

            var combineFiles = new ToolStripButton("Combine Files", Resources.Sutotal_32x32)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };

            groupOfflineFileTools.Items.Add(combineFiles);
            combineFiles.Click += (sender, e) =>
                      {
                          var combined = new FormCombineFiles(offlineAnalogy);
                          combined.Show(this);
                      };


            var compareFiles = new ToolStripButton("Compare Files", Resources.TwoColumns)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText
            };

            groupOfflineFileTools.Items.Add(compareFiles);
            compareFiles.Click += (sender, e) =>
            {
                FileComparerForm compare = new FileComparerForm(offlineAnalogy);
                compare.ShowDialog(this);
            };
        }


        private void AddSingleRealTimeDataSource(ToolStripTabItem ribbonPage, IAnalogyRealTimeDataProvider realTime, string title,
            ToolStripEx group)
        {
            string text = "Real Time Logs" + (!string.IsNullOrEmpty(realTime.OptionalTitle) ? $" - {realTime.OptionalTitle}" : string.Empty);
            var realTimeBtn = new ToolStripButton(text, Resources.Database_off)
            {
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageAboveText,
                AutoSize = true,
            };
            group.Items.Add(realTimeBtn);
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
                            $"Source {title} Disconnected. Reason: {e.DisconnectedReason}",
                            AnalogyLogLevel.AnalogyInformation, AnalogyLogClass.General, title, "Analogy");
                        onlineUC.AppendMessage(disconnected, Environment.MachineName);
                        realTimeBtn.Image = Resources.Database_off;
                    }


                    onlineUC.Tag = ribbonPage;
                    ribbonControlMain.SelectedTab = ribbonPage;
                    onlineUC.Dock = DockStyle.Fill;
                    onlineUC.Text = $"{onlineTitle} #{online} ({title})";

                    AddToDockingManager(onlineUC, onlineUC.Text);
                    dockingManager1.ActivateControl(onlineUC);
                    realTime.OnMessageReady += OnRealTimeOnMessageReady;
                    realTime.OnManyMessagesReady += OnRealTimeOnOnManyMessagesReady;
                    realTime.OnDisconnected += OnRealTimeDisconnected;
                    realTime.StartReceiving();
                    onlineDataSourcesMapping.Add(onlineUC, realTime);


                    void OnXtcLogsOnControlRemoved(object sender, DockVisibilityChangedEventArgs arg)
                    {
                        if (arg.Control == onlineUC)
                        {
                            try
                            {
                                onlineUC.Enable = false;
                                realTime.StopReceiving();
                                realTime.OnMessageReady -= OnRealTimeOnMessageReady;
                                realTime.OnManyMessagesReady -= OnRealTimeOnOnManyMessagesReady;
                                realTime.OnDisconnected -= OnRealTimeDisconnected;
                                //page.Controls.Remove(onlineUC);
                            }
                            catch (Exception e)
                            {
                                AnalogyLogManager.Instance.LogError("Error during call to Stop receiving: " + e);
                            }
                            finally
                            {
                                dockingManager1.DockVisibilityChanged -= OnXtcLogsOnControlRemoved;
                            }
                        }
                    }

                    dockingManager1.DockVisibilityChanged += OnXtcLogsOnControlRemoved;
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
            dockingManager1.ActivateControl(bookmarkLog);
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
        private void OpenOfflineLogs(ToolStripTabItem ribbonPage, string[] filenames,
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
            dockingManager1.ActivateControl(offlineUC);
        }


        private void AddRecentFiles(ToolStripTabItem ribbonPage, ToolStripDropDownButton bar, IAnalogyOfflineDataProvider offlineAnalogy,
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
                    bar.DropDownItems.Add(btn);
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

namespace Analogy
{
    partial class UCLogs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (DesignMode) return;
            tmrNewData.Stop();
            tmrNewData.Dispose();
            if (disposing)
            {

                if (components != null)
                {
                    components.Dispose();

                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLogs));
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn25 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn3 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn26 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn27 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn28 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn29 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn30 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn31 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn32 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn33 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn34 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn35 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn36 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.cmsMessageOperation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiREmoveAllPreviousMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimeDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDateFilterNewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDateFilterOlder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookmarkPersist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCommentToMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExclude = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcludeSource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcludeModule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOTAFull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncreaseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDecreaseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHighlights = new Syncfusion.WinForms.ListView.SfComboBox();
            this.sbtnMoreHighlight = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlButtonsHighlight = new System.Windows.Forms.Panel();
            this.btnPageFirst = new Syncfusion.WinForms.Controls.SfButton();
            this.btnPagePrevious = new Syncfusion.WinForms.Controls.SfButton();
            this.lblPageNumber = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnPageNext = new Syncfusion.WinForms.Controls.SfButton();
            this.btnLastPage = new Syncfusion.WinForms.Controls.SfButton();
            this.chkbHighlight = new System.Windows.Forms.CheckBox();
            this.pnlTopFiltering = new System.Windows.Forms.Panel();
            this.spltFilteringBoth = new System.Windows.Forms.SplitContainer();
            this.pnlFilteringLeft = new System.Windows.Forms.Panel();
            this.spltcDateFiltering = new System.Windows.Forms.SplitContainer();
            this.deOlderThanFilter = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.chkDateOlderThan = new System.Windows.Forms.CheckBox();
            this.deNewerThanFilter = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.chkDateNewerThan = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spltcProcessesModule = new System.Windows.Forms.SplitContainer();
            this.cbModule = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnModules = new Syncfusion.WinForms.Controls.SfButton();
            this.sbtnUndockPerProcess = new Syncfusion.WinForms.Controls.SfButton();
            this.chkbModules = new System.Windows.Forms.CheckBox();
            this.spltcSources = new System.Windows.Forms.SplitContainer();
            this.cbSource = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnSources = new Syncfusion.WinForms.Controls.SfButton();
            this.chkbSources = new System.Windows.Forms.CheckBox();
            this.pboxInfoExclude = new System.Windows.Forms.PictureBox();
            this.spltTextExclude = new System.Windows.Forms.SplitContainer();
            this.cbExclude = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnTextExclude = new Syncfusion.WinForms.Controls.SfButton();
            this.sBtnMostCommon = new Syncfusion.WinForms.Controls.SfButton();
            this.chkExclude = new System.Windows.Forms.CheckBox();
            this.spltText = new System.Windows.Forms.SplitContainer();
            this.cbInclude = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnTextInclude = new Syncfusion.WinForms.Controls.SfButton();
            this.chkbIncludeText = new System.Windows.Forms.CheckBox();
            this.pboxInfo = new System.Windows.Forms.PictureBox();
            this.sbtnPreDefinedFilters = new Syncfusion.WinForms.Controls.SfButton();
            this.rbVerbose = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbDebug = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbWarning = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbErrorCritical = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbTrace = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbAllLevel = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.tbMessageInfo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tsMessageInfo = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsBtnMessageInfoCopy = new System.Windows.Forms.ToolStripButton();
            this.sfDataGridBookmarks = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tsBookmark = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsBtnBookmarkCopySingle = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkCopyAll = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkClear = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkGoToOriginal = new System.Windows.Forms.ToolStripButton();
            this.imageListBottom = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrNewData = new System.Windows.Forms.Timer(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTotalMessagesAlert = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblTotalMessages = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.splitContainerMain = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.sfDataGridMain = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tcBottom = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageMessageInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageBookmarks = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.cmsBookmarked = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCalcDiffBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookmarkDateFilterNewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookmarkDateFilterOlder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRemoveBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyMessagesBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExcludeBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcludeSourceBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcludeModuleBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEmailBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOTAFullBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveLayoutBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncreaseFontBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDecreaseFontBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripFilters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlMain = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageLogs = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tsTop = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsTopClear = new System.Windows.Forms.ToolStripButton();
            this.tsTopPauseRefresh = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.tsTopAutoScrollToLast = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.tsddbSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiSaveFullLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveFullLogDataProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveFullLogAnalogy = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveCurrentViewDataProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveCurrentViewAnalogy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbUndock = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiUndockView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndockPerModule = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbScreenshot = new System.Windows.Forms.ToolStripButton();
            this.tsddbExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBDataVisualizer = new System.Windows.Forms.ToolStripButton();
            this.cmsMessageOperation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlights)).BeginInit();
            this.pnlButtonsHighlight.SuspendLayout();
            this.pnlTopFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltFilteringBoth)).BeginInit();
            this.spltFilteringBoth.Panel1.SuspendLayout();
            this.spltFilteringBoth.Panel2.SuspendLayout();
            this.spltFilteringBoth.SuspendLayout();
            this.pnlFilteringLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcDateFiltering)).BeginInit();
            this.spltcDateFiltering.Panel1.SuspendLayout();
            this.spltcDateFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltcProcessesModule)).BeginInit();
            this.spltcProcessesModule.Panel1.SuspendLayout();
            this.spltcProcessesModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltcSources)).BeginInit();
            this.spltcSources.Panel1.SuspendLayout();
            this.spltcSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfoExclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltTextExclude)).BeginInit();
            this.spltTextExclude.Panel1.SuspendLayout();
            this.spltTextExclude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbExclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltText)).BeginInit();
            this.spltText.Panel1.SuspendLayout();
            this.spltText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbInclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbVerbose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDebug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbErrorCritical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessageInfo)).BeginInit();
            this.tsMessageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBookmarks)).BeginInit();
            this.tsBookmark.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcBottom)).BeginInit();
            this.tcBottom.SuspendLayout();
            this.tabPageMessageInfo.SuspendLayout();
            this.tabPageBookmarks.SuspendLayout();
            this.cmsBookmarked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            this.tsTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMessageOperation
            // 
            this.cmsMessageOperation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMessageOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearLog,
            this.tsmiREmoveAllPreviousMessages,
            this.tsmiTimeDiff,
            this.tsmiDateFilterNewer,
            this.tsmiDateFilterOlder,
            this.toolStripSeparator4,
            this.tsmiBookmark,
            this.tsmiBookmarkPersist,
            this.tsmiCopy,
            this.tsmiCopyMessages,
            this.tsmiAddCommentToMessage,
            this.toolStripSeparator2,
            this.tsmiExclude,
            this.tsmiExcludeSource,
            this.tsmiExcludeModule,
            this.toolStripSeparator3,
            this.tsmiEmail,
            this.tsmiOTAFull,
            this.toolStripSeparator1,
            this.tsmiSaveLayout,
            this.tsmiIncreaseFont,
            this.tsmiDecreaseFont});
            this.cmsMessageOperation.Name = "cmsMessageOperation";
            this.cmsMessageOperation.Size = new System.Drawing.Size(416, 496);
            this.cmsMessageOperation.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMessageOperation_Opening);
            // 
            // tsmiClearLog
            // 
            this.tsmiClearLog.Image = global::Analogy.Properties.Resources.Delete_16x16;
            this.tsmiClearLog.Name = "tsmiClearLog";
            this.tsmiClearLog.Size = new System.Drawing.Size(415, 26);
            this.tsmiClearLog.Text = "Clear Log";
            this.tsmiClearLog.Click += new System.EventHandler(this.tsmiClearLog_Click);
            // 
            // tsmiREmoveAllPreviousMessages
            // 
            this.tsmiREmoveAllPreviousMessages.Image = global::Analogy.Properties.Resources.FitNone_16x16;
            this.tsmiREmoveAllPreviousMessages.Name = "tsmiREmoveAllPreviousMessages";
            this.tsmiREmoveAllPreviousMessages.Size = new System.Drawing.Size(415, 26);
            this.tsmiREmoveAllPreviousMessages.Text = "Remove all messages before selected message";
            this.tsmiREmoveAllPreviousMessages.Click += new System.EventHandler(this.tsmiREmoveAllPreviousMessages_Click);
            // 
            // tsmiTimeDiff
            // 
            this.tsmiTimeDiff.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiTimeDiff.Name = "tsmiTimeDiff";
            this.tsmiTimeDiff.Size = new System.Drawing.Size(415, 26);
            this.tsmiTimeDiff.Text = "Calculate Time Difference from this entry";
            this.tsmiTimeDiff.Click += new System.EventHandler(this.tsmiTimeDiff_Click);
            // 
            // tsmiDateFilterNewer
            // 
            this.tsmiDateFilterNewer.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiDateFilterNewer.Name = "tsmiDateFilterNewer";
            this.tsmiDateFilterNewer.Size = new System.Drawing.Size(415, 26);
            this.tsmiDateFilterNewer.Text = "DateTime filter: After";
            this.tsmiDateFilterNewer.Click += new System.EventHandler(this.tsmiDateFilterNewer_Click);
            // 
            // tsmiDateFilterOlder
            // 
            this.tsmiDateFilterOlder.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiDateFilterOlder.Name = "tsmiDateFilterOlder";
            this.tsmiDateFilterOlder.Size = new System.Drawing.Size(415, 26);
            this.tsmiDateFilterOlder.Text = "DateTime filter: before ";
            this.tsmiDateFilterOlder.Click += new System.EventHandler(this.tsmiDateFilterOlder_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiBookmark
            // 
            this.tsmiBookmark.Image = global::Analogy.Properties.Resources.RichEditBookmark_16x16;
            this.tsmiBookmark.Name = "tsmiBookmark";
            this.tsmiBookmark.Size = new System.Drawing.Size(415, 26);
            this.tsmiBookmark.Text = "Bookmark this message (current Analogy instance)";
            this.tsmiBookmark.Click += new System.EventHandler(this.tsmiBookmark_Click);
            // 
            // tsmiBookmarkPersist
            // 
            this.tsmiBookmarkPersist.Image = global::Analogy.Properties.Resources.RichEditBookmark_16x16;
            this.tsmiBookmarkPersist.Name = "tsmiBookmarkPersist";
            this.tsmiBookmarkPersist.Size = new System.Drawing.Size(415, 26);
            this.tsmiBookmarkPersist.Text = "Bookmark this message for later use (persistent)";
            this.tsmiBookmarkPersist.Click += new System.EventHandler(this.tsmiBookmarkPersist_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(415, 26);
            this.tsmiCopy.Text = "Copy selected message to clipboard";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiCopyMessages
            // 
            this.tsmiCopyMessages.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsmiCopyMessages.Name = "tsmiCopyMessages";
            this.tsmiCopyMessages.Size = new System.Drawing.Size(415, 26);
            this.tsmiCopyMessages.Text = "Copy all messages in view to clipboard";
            this.tsmiCopyMessages.Click += new System.EventHandler(this.tsmiCopyMessages_Click);
            // 
            // tsmiAddCommentToMessage
            // 
            this.tsmiAddCommentToMessage.Enabled = false;
            this.tsmiAddCommentToMessage.Image = global::Analogy.Properties.Resources.EditComment_16x16;
            this.tsmiAddCommentToMessage.Name = "tsmiAddCommentToMessage";
            this.tsmiAddCommentToMessage.Size = new System.Drawing.Size(415, 26);
            this.tsmiAddCommentToMessage.Text = "Add message/comment at this timestamp";
            this.tsmiAddCommentToMessage.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiExclude
            // 
            this.tsmiExclude.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExclude.Name = "tsmiExclude";
            this.tsmiExclude.Size = new System.Drawing.Size(415, 26);
            this.tsmiExclude.Text = "Exclude selected message ";
            this.tsmiExclude.Click += new System.EventHandler(this.tsmiExclude_Click);
            // 
            // tsmiExcludeSource
            // 
            this.tsmiExcludeSource.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeSource.Name = "tsmiExcludeSource";
            this.tsmiExcludeSource.Size = new System.Drawing.Size(415, 26);
            this.tsmiExcludeSource.Text = "Exclude Source";
            this.tsmiExcludeSource.Click += new System.EventHandler(this.tsmiExcludeSource_Click);
            // 
            // tsmiExcludeModule
            // 
            this.tsmiExcludeModule.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeModule.Name = "tsmiExcludeModule";
            this.tsmiExcludeModule.Size = new System.Drawing.Size(415, 26);
            this.tsmiExcludeModule.Text = "Exclude Process";
            this.tsmiExcludeModule.Click += new System.EventHandler(this.tsmiExcludeModule_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiEmail
            // 
            this.tsmiEmail.Image = global::Analogy.Properties.Resources.Send_16x16;
            this.tsmiEmail.Name = "tsmiEmail";
            this.tsmiEmail.Size = new System.Drawing.Size(415, 26);
            this.tsmiEmail.Text = "Send selected message by mail";
            this.tsmiEmail.Click += new System.EventHandler(this.tsmiEmail_Click);
            // 
            // tsmiOTAFull
            // 
            this.tsmiOTAFull.Enabled = false;
            this.tsmiOTAFull.Image = global::Analogy.Properties.Resources.logIcon;
            this.tsmiOTAFull.Name = "tsmiOTAFull";
            this.tsmiOTAFull.Size = new System.Drawing.Size(415, 26);
            this.tsmiOTAFull.Text = "Send Log to another Analogy";
            this.tsmiOTAFull.Visible = false;
            this.tsmiOTAFull.Click += new System.EventHandler(this.tsmiOTAFull_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiSaveLayout
            // 
            this.tsmiSaveLayout.Image = global::Analogy.Properties.Resources.Save_16x16;
            this.tsmiSaveLayout.Name = "tsmiSaveLayout";
            this.tsmiSaveLayout.Size = new System.Drawing.Size(415, 26);
            this.tsmiSaveLayout.Text = "Save columns layout";
            this.tsmiSaveLayout.Click += new System.EventHandler(this.tsmiSaveLayout_Click);
            // 
            // tsmiIncreaseFont
            // 
            this.tsmiIncreaseFont.Image = global::Analogy.Properties.Resources.IncreaseFontSize_16x16;
            this.tsmiIncreaseFont.Name = "tsmiIncreaseFont";
            this.tsmiIncreaseFont.Size = new System.Drawing.Size(415, 26);
            this.tsmiIncreaseFont.Text = "Increase Font Size";
            this.tsmiIncreaseFont.Click += new System.EventHandler(this.tsmiIncreaseFont_Click);
            // 
            // tsmiDecreaseFont
            // 
            this.tsmiDecreaseFont.Image = global::Analogy.Properties.Resources.DecreaseFontSize_16x16;
            this.tsmiDecreaseFont.Name = "tsmiDecreaseFont";
            this.tsmiDecreaseFont.Size = new System.Drawing.Size(415, 26);
            this.tsmiDecreaseFont.Text = "Decrease Font Size";
            this.tsmiDecreaseFont.Click += new System.EventHandler(this.tsmiDecreaseFont_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Error_16x16.png");
            this.imageList.Images.SetKeyName(1, "Warning_16x16.png");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "folder32x32.gif");
            this.imageList.Images.SetKeyName(4, "Error_32x32.png");
            this.imageList.Images.SetKeyName(5, "Warning_32x32.png");
            this.imageList.Images.SetKeyName(6, "debug.gif");
            this.imageList.Images.SetKeyName(7, "New_16x16.png");
            this.imageList.Images.SetKeyName(8, "log16x16.ico");
            this.imageList.Images.SetKeyName(9, "Question_16x16.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbHighlights);
            this.panel1.Controls.Add(this.sbtnMoreHighlight);
            this.panel1.Controls.Add(this.pnlButtonsHighlight);
            this.panel1.Controls.Add(this.chkbHighlight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 26);
            this.panel1.TabIndex = 4;
            // 
            // cbHighlights
            // 
            this.cbHighlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHighlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.Location = new System.Drawing.Point(207, 0);
            this.cbHighlights.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbHighlights.Name = "cbHighlights";
            this.cbHighlights.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cbHighlights.Size = new System.Drawing.Size(384, 26);
            this.cbHighlights.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHighlights.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.TabIndex = 44;
            // 
            // sbtnMoreHighlight
            // 
            this.sbtnMoreHighlight.AccessibleName = "Button";
            this.sbtnMoreHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnMoreHighlight.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnMoreHighlight.Location = new System.Drawing.Point(591, 0);
            this.sbtnMoreHighlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtnMoreHighlight.Name = "sbtnMoreHighlight";
            this.sbtnMoreHighlight.Size = new System.Drawing.Size(95, 26);
            this.sbtnMoreHighlight.TabIndex = 43;
            this.sbtnMoreHighlight.Text = "More ...";
            this.sbtnMoreHighlight.Click += new System.EventHandler(this.sbtnMoreHighlight_Click);
            // 
            // pnlButtonsHighlight
            // 
            this.pnlButtonsHighlight.Controls.Add(this.btnPageFirst);
            this.pnlButtonsHighlight.Controls.Add(this.btnPagePrevious);
            this.pnlButtonsHighlight.Controls.Add(this.lblPageNumber);
            this.pnlButtonsHighlight.Controls.Add(this.btnPageNext);
            this.pnlButtonsHighlight.Controls.Add(this.btnLastPage);
            this.pnlButtonsHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonsHighlight.Location = new System.Drawing.Point(686, 0);
            this.pnlButtonsHighlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonsHighlight.Name = "pnlButtonsHighlight";
            this.pnlButtonsHighlight.Size = new System.Drawing.Size(584, 26);
            this.pnlButtonsHighlight.TabIndex = 12;
            // 
            // btnPageFirst
            // 
            this.btnPageFirst.AccessibleName = "Button";
            this.btnPageFirst.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPageFirst.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnPageFirst.Location = new System.Drawing.Point(27, 0);
            this.btnPageFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPageFirst.Name = "btnPageFirst";
            this.btnPageFirst.Size = new System.Drawing.Size(99, 26);
            this.btnPageFirst.TabIndex = 42;
            this.btnPageFirst.Text = "First Page ";
            this.btnPageFirst.Click += new System.EventHandler(this.btnPageFirst_Click);
            // 
            // btnPagePrevious
            // 
            this.btnPagePrevious.AccessibleName = "Button";
            this.btnPagePrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPagePrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnPagePrevious.Location = new System.Drawing.Point(126, 0);
            this.btnPagePrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagePrevious.Name = "btnPagePrevious";
            this.btnPagePrevious.Size = new System.Drawing.Size(146, 26);
            this.btnPagePrevious.TabIndex = 43;
            this.btnPagePrevious.Text = "previous page";
            this.btnPagePrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPagePrevious.Click += new System.EventHandler(this.btnPagePrevious_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblPageNumber.BeforeTouchSize = new System.Drawing.Size(118, 26);
            this.lblPageNumber.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblPageNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPageNumber.Location = new System.Drawing.Point(272, 0);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(118, 26);
            this.lblPageNumber.TabIndex = 6;
            this.lblPageNumber.Text = "Page 1 / 1";
            this.lblPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPageNext
            // 
            this.btnPageNext.AccessibleName = "Button";
            this.btnPageNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPageNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnPageNext.Location = new System.Drawing.Point(390, 0);
            this.btnPageNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(99, 26);
            this.btnPageNext.TabIndex = 45;
            this.btnPageNext.Text = "Next Page";
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.AccessibleName = "Button";
            this.btnLastPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLastPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLastPage.Location = new System.Drawing.Point(489, 0);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(95, 26);
            this.btnLastPage.TabIndex = 44;
            this.btnLastPage.Text = "Last Page";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // chkbHighlight
            // 
            this.chkbHighlight.AutoSize = true;
            this.chkbHighlight.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbHighlight.Location = new System.Drawing.Point(0, 0);
            this.chkbHighlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbHighlight.Name = "chkbHighlight";
            this.chkbHighlight.Size = new System.Drawing.Size(207, 26);
            this.chkbHighlight.TabIndex = 11;
            this.chkbHighlight.Text = "Highlight lines that contains:";
            this.chkbHighlight.UseVisualStyleBackColor = true;
            this.chkbHighlight.CheckedChanged += new System.EventHandler(this.chkbHighlight_CheckedChanged);
            // 
            // pnlTopFiltering
            // 
            this.pnlTopFiltering.Controls.Add(this.spltFilteringBoth);
            this.pnlTopFiltering.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFiltering.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFiltering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopFiltering.Name = "pnlTopFiltering";
            this.pnlTopFiltering.Size = new System.Drawing.Size(1270, 153);
            this.pnlTopFiltering.TabIndex = 3;
            // 
            // spltFilteringBoth
            // 
            this.spltFilteringBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltFilteringBoth.Location = new System.Drawing.Point(0, 0);
            this.spltFilteringBoth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltFilteringBoth.Name = "spltFilteringBoth";
            // 
            // spltFilteringBoth.Panel1
            // 
            this.spltFilteringBoth.Panel1.Controls.Add(this.pnlFilteringLeft);
            // 
            // spltFilteringBoth.Panel2
            // 
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbVerbose);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbDebug);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbWarning);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbErrorCritical);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbTrace);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbAllLevel);
            this.spltFilteringBoth.Panel2MinSize = 150;
            this.spltFilteringBoth.Size = new System.Drawing.Size(1270, 153);
            this.spltFilteringBoth.SplitterDistance = 1083;
            this.spltFilteringBoth.SplitterWidth = 3;
            this.spltFilteringBoth.TabIndex = 19;
            // 
            // pnlFilteringLeft
            // 
            this.pnlFilteringLeft.Controls.Add(this.spltcDateFiltering);
            this.pnlFilteringLeft.Controls.Add(this.spltcProcessesModule);
            this.pnlFilteringLeft.Controls.Add(this.spltcSources);
            this.pnlFilteringLeft.Controls.Add(this.spltTextExclude);
            this.pnlFilteringLeft.Controls.Add(this.spltText);
            this.pnlFilteringLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilteringLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlFilteringLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilteringLeft.Name = "pnlFilteringLeft";
            this.pnlFilteringLeft.Size = new System.Drawing.Size(1083, 153);
            this.pnlFilteringLeft.TabIndex = 20;
            // 
            // spltcDateFiltering
            // 
            this.spltcDateFiltering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcDateFiltering.Location = new System.Drawing.Point(3, 124);
            this.spltcDateFiltering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltcDateFiltering.Name = "spltcDateFiltering";
            // 
            // spltcDateFiltering.Panel1
            // 
            this.spltcDateFiltering.Panel1.Controls.Add(this.deOlderThanFilter);
            this.spltcDateFiltering.Panel1.Controls.Add(this.chkDateOlderThan);
            this.spltcDateFiltering.Panel1.Controls.Add(this.deNewerThanFilter);
            this.spltcDateFiltering.Panel1.Controls.Add(this.chkDateNewerThan);
            this.spltcDateFiltering.Panel1.Controls.Add(this.pictureBox1);
            this.spltcDateFiltering.Panel2Collapsed = true;
            this.spltcDateFiltering.Size = new System.Drawing.Size(1071, 25);
            this.spltcDateFiltering.SplitterDistance = 138;
            this.spltcDateFiltering.SplitterWidth = 3;
            this.spltcDateFiltering.TabIndex = 27;
            // 
            // deOlderThanFilter
            // 
            this.deOlderThanFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.deOlderThanFilter.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.deOlderThanFilter.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.deOlderThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.deOlderThanFilter.Format = "yyyy.MM.dd HH:mm:ss";
            this.deOlderThanFilter.Location = new System.Drawing.Point(662, 0);
            this.deOlderThanFilter.Name = "deOlderThanFilter";
            this.deOlderThanFilter.Size = new System.Drawing.Size(269, 25);
            this.deOlderThanFilter.TabIndex = 28;
            // 
            // chkDateOlderThan
            // 
            this.chkDateOlderThan.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDateOlderThan.Location = new System.Drawing.Point(534, 0);
            this.chkDateOlderThan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDateOlderThan.Name = "chkDateOlderThan";
            this.chkDateOlderThan.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.chkDateOlderThan.Size = new System.Drawing.Size(128, 25);
            this.chkDateOlderThan.TabIndex = 26;
            this.chkDateOlderThan.Text = "And:";
            this.chkDateOlderThan.UseVisualStyleBackColor = true;
            this.chkDateOlderThan.CheckedChanged += new System.EventHandler(this.chkDateOlderThan_CheckedChanged);
            // 
            // deNewerThanFilter
            // 
            this.deNewerThanFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.deNewerThanFilter.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.deNewerThanFilter.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.deNewerThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.deNewerThanFilter.Format = "yyyy.MM.dd HH:mm:ss";
            this.deNewerThanFilter.Location = new System.Drawing.Point(265, 0);
            this.deNewerThanFilter.Name = "deNewerThanFilter";
            this.deNewerThanFilter.Size = new System.Drawing.Size(269, 25);
            this.deNewerThanFilter.TabIndex = 27;
            // 
            // chkDateNewerThan
            // 
            this.chkDateNewerThan.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDateNewerThan.Location = new System.Drawing.Point(22, 0);
            this.chkDateNewerThan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDateNewerThan.Name = "chkDateNewerThan";
            this.chkDateNewerThan.Size = new System.Drawing.Size(243, 25);
            this.chkDateNewerThan.TabIndex = 23;
            this.chkDateNewerThan.Text = "Time between:";
            this.chkDateNewerThan.UseVisualStyleBackColor = true;
            this.chkDateNewerThan.CheckedChanged += new System.EventHandler(this.chkDateNewerThan_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Analogy.Properties.Resources.Info_16x16;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // spltcProcessesModule
            // 
            this.spltcProcessesModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcProcessesModule.Location = new System.Drawing.Point(8, 94);
            this.spltcProcessesModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltcProcessesModule.Name = "spltcProcessesModule";
            // 
            // spltcProcessesModule.Panel1
            // 
            this.spltcProcessesModule.Panel1.Controls.Add(this.cbModule);
            this.spltcProcessesModule.Panel1.Controls.Add(this.btnModules);
            this.spltcProcessesModule.Panel1.Controls.Add(this.sbtnUndockPerProcess);
            this.spltcProcessesModule.Panel1.Controls.Add(this.chkbModules);
            this.spltcProcessesModule.Panel2Collapsed = true;
            this.spltcProcessesModule.Size = new System.Drawing.Size(1071, 25);
            this.spltcProcessesModule.SplitterDistance = 138;
            this.spltcProcessesModule.SplitterWidth = 3;
            this.spltcProcessesModule.TabIndex = 26;
            // 
            // cbModule
            // 
            this.cbModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModule.Location = new System.Drawing.Point(314, 0);
            this.cbModule.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbModule.Name = "cbModule";
            this.cbModule.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cbModule.Size = new System.Drawing.Size(454, 25);
            this.cbModule.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModule.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModule.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbModule.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModule.TabIndex = 27;
            // 
            // btnModules
            // 
            this.btnModules.AccessibleName = "Button";
            this.btnModules.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModules.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnModules.Location = new System.Drawing.Point(768, 0);
            this.btnModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(26, 25);
            this.btnModules.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnModules.TabIndex = 24;
            // 
            // sbtnUndockPerProcess
            // 
            this.sbtnUndockPerProcess.AccessibleName = "Button";
            this.sbtnUndockPerProcess.AutoSize = true;
            this.sbtnUndockPerProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnUndockPerProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnUndockPerProcess.Location = new System.Drawing.Point(794, 0);
            this.sbtnUndockPerProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnUndockPerProcess.Name = "sbtnUndockPerProcess";
            this.sbtnUndockPerProcess.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.sbtnUndockPerProcess.Size = new System.Drawing.Size(277, 25);
            this.sbtnUndockPerProcess.TabIndex = 24;
            this.sbtnUndockPerProcess.Text = "Split view per Process/Module";
            this.sbtnUndockPerProcess.Click += new System.EventHandler(this.sbtnUndockPerProcess_Click);
            // 
            // chkbModules
            // 
            this.chkbModules.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbModules.Location = new System.Drawing.Point(0, 0);
            this.chkbModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbModules.Name = "chkbModules";
            this.chkbModules.Size = new System.Drawing.Size(314, 25);
            this.chkbModules.TabIndex = 25;
            this.chkbModules.Text = "Include/Exclude Processes/Modules:";
            this.chkbModules.UseVisualStyleBackColor = true;
            // 
            // spltcSources
            // 
            this.spltcSources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcSources.Location = new System.Drawing.Point(8, 65);
            this.spltcSources.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltcSources.Name = "spltcSources";
            // 
            // spltcSources.Panel1
            // 
            this.spltcSources.Panel1.Controls.Add(this.cbSource);
            this.spltcSources.Panel1.Controls.Add(this.btnSources);
            this.spltcSources.Panel1.Controls.Add(this.chkbSources);
            this.spltcSources.Panel1.Controls.Add(this.pboxInfoExclude);
            this.spltcSources.Panel2Collapsed = true;
            this.spltcSources.Size = new System.Drawing.Size(1071, 25);
            this.spltcSources.SplitterDistance = 138;
            this.spltcSources.SplitterWidth = 3;
            this.spltcSources.TabIndex = 25;
            // 
            // cbSource
            // 
            this.cbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.Location = new System.Drawing.Point(261, 0);
            this.cbSource.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbSource.Name = "cbSource";
            this.cbSource.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cbSource.Size = new System.Drawing.Size(784, 25);
            this.cbSource.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSource.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.TabIndex = 27;
            // 
            // btnSources
            // 
            this.btnSources.AccessibleName = "Button";
            this.btnSources.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSources.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSources.Location = new System.Drawing.Point(1045, 0);
            this.btnSources.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSources.Name = "btnSources";
            this.btnSources.Size = new System.Drawing.Size(26, 25);
            this.btnSources.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnSources.TabIndex = 24;
            // 
            // chkbSources
            // 
            this.chkbSources.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbSources.Location = new System.Drawing.Point(22, 0);
            this.chkbSources.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbSources.Name = "chkbSources";
            this.chkbSources.Size = new System.Drawing.Size(239, 25);
            this.chkbSources.TabIndex = 23;
            this.chkbSources.Text = "Include/Exclude Sources:";
            this.chkbSources.UseVisualStyleBackColor = true;
            // 
            // pboxInfoExclude
            // 
            this.pboxInfoExclude.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxInfoExclude.Image = global::Analogy.Properties.Resources.Info_16x16;
            this.pboxInfoExclude.Location = new System.Drawing.Point(0, 0);
            this.pboxInfoExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxInfoExclude.Name = "pboxInfoExclude";
            this.pboxInfoExclude.Size = new System.Drawing.Size(22, 25);
            this.pboxInfoExclude.TabIndex = 15;
            this.pboxInfoExclude.TabStop = false;
            // 
            // spltTextExclude
            // 
            this.spltTextExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltTextExclude.Location = new System.Drawing.Point(8, 37);
            this.spltTextExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltTextExclude.Name = "spltTextExclude";
            // 
            // spltTextExclude.Panel1
            // 
            this.spltTextExclude.Panel1.Controls.Add(this.cbExclude);
            this.spltTextExclude.Panel1.Controls.Add(this.btnTextExclude);
            this.spltTextExclude.Panel1.Controls.Add(this.sBtnMostCommon);
            this.spltTextExclude.Panel1.Controls.Add(this.chkExclude);
            this.spltTextExclude.Panel2Collapsed = true;
            this.spltTextExclude.Size = new System.Drawing.Size(1071, 25);
            this.spltTextExclude.SplitterDistance = 138;
            this.spltTextExclude.SplitterWidth = 3;
            this.spltTextExclude.TabIndex = 24;
            // 
            // cbExclude
            // 
            this.cbExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbExclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclude.Location = new System.Drawing.Point(126, 0);
            this.cbExclude.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbExclude.Name = "cbExclude";
            this.cbExclude.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cbExclude.Size = new System.Drawing.Size(782, 25);
            this.cbExclude.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclude.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclude.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbExclude.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclude.TabIndex = 27;
            // 
            // btnTextExclude
            // 
            this.btnTextExclude.AccessibleName = "Button";
            this.btnTextExclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTextExclude.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTextExclude.Location = new System.Drawing.Point(908, 0);
            this.btnTextExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextExclude.Name = "btnTextExclude";
            this.btnTextExclude.Size = new System.Drawing.Size(26, 25);
            this.btnTextExclude.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnTextExclude.TabIndex = 20;
            // 
            // sBtnMostCommon
            // 
            this.sBtnMostCommon.AccessibleName = "Button";
            this.sBtnMostCommon.Dock = System.Windows.Forms.DockStyle.Right;
            this.sBtnMostCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnMostCommon.Location = new System.Drawing.Point(934, 0);
            this.sBtnMostCommon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtnMostCommon.Name = "sBtnMostCommon";
            this.sBtnMostCommon.Size = new System.Drawing.Size(137, 25);
            this.sBtnMostCommon.TabIndex = 8;
            this.sBtnMostCommon.Text = "Most Common";
            this.sBtnMostCommon.Click += new System.EventHandler(this.sBtnMostCommon_Click);
            // 
            // chkExclude
            // 
            this.chkExclude.AutoSize = true;
            this.chkExclude.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkExclude.Location = new System.Drawing.Point(0, 0);
            this.chkExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExclude.Name = "chkExclude";
            this.chkExclude.Size = new System.Drawing.Size(126, 25);
            this.chkExclude.TabIndex = 10;
            this.chkExclude.Text = "Exclude Text:   ";
            this.chkExclude.UseVisualStyleBackColor = true;
            this.chkExclude.CheckedChanged += new System.EventHandler(this.chkbExclude_CheckedChanged);
            // 
            // spltText
            // 
            this.spltText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltText.Location = new System.Drawing.Point(8, 7);
            this.spltText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltText.Name = "spltText";
            // 
            // spltText.Panel1
            // 
            this.spltText.Panel1.Controls.Add(this.cbInclude);
            this.spltText.Panel1.Controls.Add(this.btnTextInclude);
            this.spltText.Panel1.Controls.Add(this.chkbIncludeText);
            this.spltText.Panel1.Controls.Add(this.pboxInfo);
            this.spltText.Panel1.Controls.Add(this.sbtnPreDefinedFilters);
            this.spltText.Panel2Collapsed = true;
            this.spltText.Size = new System.Drawing.Size(1071, 25);
            this.spltText.SplitterDistance = 138;
            this.spltText.SplitterWidth = 3;
            this.spltText.TabIndex = 22;
            // 
            // cbInclude
            // 
            this.cbInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInclude.Location = new System.Drawing.Point(128, 0);
            this.cbInclude.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbInclude.Name = "cbInclude";
            this.cbInclude.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cbInclude.Size = new System.Drawing.Size(891, 25);
            this.cbInclude.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInclude.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInclude.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbInclude.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInclude.TabIndex = 26;
            // 
            // btnTextInclude
            // 
            this.btnTextInclude.AccessibleName = "Button";
            this.btnTextInclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTextInclude.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTextInclude.Location = new System.Drawing.Point(1019, 0);
            this.btnTextInclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextInclude.Name = "btnTextInclude";
            this.btnTextInclude.Size = new System.Drawing.Size(26, 25);
            this.btnTextInclude.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnTextInclude.TabIndex = 20;
            // 
            // chkbIncludeText
            // 
            this.chkbIncludeText.AutoSize = true;
            this.chkbIncludeText.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbIncludeText.Location = new System.Drawing.Point(18, 0);
            this.chkbIncludeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbIncludeText.Name = "chkbIncludeText";
            this.chkbIncludeText.Size = new System.Drawing.Size(110, 25);
            this.chkbIncludeText.TabIndex = 9;
            this.chkbIncludeText.Text = "Include Text:";
            this.chkbIncludeText.UseVisualStyleBackColor = true;
            this.chkbIncludeText.CheckedChanged += new System.EventHandler(this.chkbInclude_CheckedChanged);
            // 
            // pboxInfo
            // 
            this.pboxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxInfo.Image = global::Analogy.Properties.Resources.Info_16x16;
            this.pboxInfo.Location = new System.Drawing.Point(0, 0);
            this.pboxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxInfo.Name = "pboxInfo";
            this.pboxInfo.Size = new System.Drawing.Size(18, 25);
            this.pboxInfo.TabIndex = 12;
            this.pboxInfo.TabStop = false;
            // 
            // sbtnPreDefinedFilters
            // 
            this.sbtnPreDefinedFilters.AccessibleName = "Button";
            this.sbtnPreDefinedFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnPreDefinedFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnPreDefinedFilters.Location = new System.Drawing.Point(1045, 0);
            this.sbtnPreDefinedFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnPreDefinedFilters.Name = "sbtnPreDefinedFilters";
            this.sbtnPreDefinedFilters.Size = new System.Drawing.Size(26, 25);
            this.sbtnPreDefinedFilters.Style.Image = global::Analogy.Properties.Resources.SingleMasterFilter_16x16;
            this.sbtnPreDefinedFilters.TabIndex = 21;
            this.sbtnPreDefinedFilters.Click += new System.EventHandler(this.sbtnPreDefinedFilters_Click);
            // 
            // rbVerbose
            // 
            this.rbVerbose.BeforeTouchSize = new System.Drawing.Size(184, 20);
            this.rbVerbose.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbVerbose.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbVerbose.Location = new System.Drawing.Point(0, 100);
            this.rbVerbose.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbVerbose.Name = "rbVerbose";
            this.rbVerbose.Size = new System.Drawing.Size(184, 20);
            this.rbVerbose.TabIndex = 28;
            this.rbVerbose.TabStop = false;
            this.rbVerbose.Text = "Verbose";
            // 
            // rbDebug
            // 
            this.rbDebug.BeforeTouchSize = new System.Drawing.Size(184, 20);
            this.rbDebug.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbDebug.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbDebug.Location = new System.Drawing.Point(0, 80);
            this.rbDebug.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbDebug.Name = "rbDebug";
            this.rbDebug.Size = new System.Drawing.Size(184, 20);
            this.rbDebug.TabIndex = 27;
            this.rbDebug.TabStop = false;
            this.rbDebug.Text = "Debug";
            // 
            // rbWarning
            // 
            this.rbWarning.BeforeTouchSize = new System.Drawing.Size(184, 20);
            this.rbWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbWarning.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbWarning.Location = new System.Drawing.Point(0, 60);
            this.rbWarning.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbWarning.Name = "rbWarning";
            this.rbWarning.Size = new System.Drawing.Size(184, 20);
            this.rbWarning.TabIndex = 26;
            this.rbWarning.TabStop = false;
            this.rbWarning.Text = "Warning";
            // 
            // rbErrorCritical
            // 
            this.rbErrorCritical.BeforeTouchSize = new System.Drawing.Size(184, 20);
            this.rbErrorCritical.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbErrorCritical.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbErrorCritical.Location = new System.Drawing.Point(0, 40);
            this.rbErrorCritical.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbErrorCritical.Name = "rbErrorCritical";
            this.rbErrorCritical.Size = new System.Drawing.Size(184, 20);
            this.rbErrorCritical.TabIndex = 25;
            this.rbErrorCritical.TabStop = false;
            this.rbErrorCritical.Text = "Errors + Critical";
            // 
            // rbTrace
            // 
            this.rbTrace.BeforeTouchSize = new System.Drawing.Size(184, 20);
            this.rbTrace.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbTrace.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbTrace.Location = new System.Drawing.Point(0, 20);
            this.rbTrace.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbTrace.Name = "rbTrace";
            this.rbTrace.Size = new System.Drawing.Size(184, 20);
            this.rbTrace.TabIndex = 24;
            this.rbTrace.TabStop = false;
            this.rbTrace.Text = "Trace";
            // 
            // rbAllLevel
            // 
            this.rbAllLevel.BeforeTouchSize = new System.Drawing.Size(184, 20);
            this.rbAllLevel.Checked = true;
            this.rbAllLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAllLevel.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbAllLevel.Location = new System.Drawing.Point(0, 0);
            this.rbAllLevel.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbAllLevel.Name = "rbAllLevel";
            this.rbAllLevel.Size = new System.Drawing.Size(184, 20);
            this.rbAllLevel.TabIndex = 23;
            this.rbAllLevel.Text = "All";
            // 
            // tbMessageInfo
            // 
            this.tbMessageInfo.BackColor = System.Drawing.Color.White;
            this.tbMessageInfo.BeforeTouchSize = new System.Drawing.Size(1267, 154);
            this.tbMessageInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMessageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbMessageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbMessageInfo.Location = new System.Drawing.Point(0, 27);
            this.tbMessageInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessageInfo.Multiline = true;
            this.tbMessageInfo.Name = "tbMessageInfo";
            this.tbMessageInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessageInfo.Size = new System.Drawing.Size(1267, 154);
            this.tbMessageInfo.TabIndex = 14;
            this.tbMessageInfo.ThemeName = "";
            // 
            // tsMessageInfo
            // 
            this.tsMessageInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsMessageInfo.Image = null;
            this.tsMessageInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMessageInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnMessageInfoCopy});
            this.tsMessageInfo.Location = new System.Drawing.Point(0, 0);
            this.tsMessageInfo.Name = "tsMessageInfo";
            this.tsMessageInfo.ShowCaption = false;
            this.tsMessageInfo.ShowLauncher = false;
            this.tsMessageInfo.Size = new System.Drawing.Size(1267, 27);
            this.tsMessageInfo.TabIndex = 4;
            this.tsMessageInfo.ThemeName = "Default";
            // 
            // tsBtnMessageInfoCopy
            // 
            this.tsBtnMessageInfoCopy.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsBtnMessageInfoCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMessageInfoCopy.Name = "tsBtnMessageInfoCopy";
            this.tsBtnMessageInfoCopy.Size = new System.Drawing.Size(67, 24);
            this.tsBtnMessageInfoCopy.Text = "Copy";
            // 
            // sfDataGridBookmarks
            // 
            this.sfDataGridBookmarks.AccessibleName = "Table";
            this.sfDataGridBookmarks.AllowDraggingColumns = true;
            this.sfDataGridBookmarks.AllowEditing = false;
            this.sfDataGridBookmarks.AllowResizingColumns = true;
            this.sfDataGridBookmarks.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.ColumnHeader;
            gridTextColumn25.AllowDragging = true;
            gridTextColumn25.AllowEditing = false;
            gridTextColumn25.AllowResizing = true;
            gridTextColumn25.HeaderText = "Data Source/File Name";
            gridTextColumn25.MappingName = "DataProvider";
            gridDateTimeColumn3.AllowDragging = true;
            gridDateTimeColumn3.AllowEditing = false;
            gridDateTimeColumn3.AllowResizing = true;
            gridDateTimeColumn3.Format = "yyyy.MM.dd HH:mm:ss.ff";
            gridDateTimeColumn3.HeaderText = "Date";
            gridDateTimeColumn3.MappingName = "Date";
            gridDateTimeColumn3.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn3.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            gridTextColumn26.AllowDragging = true;
            gridTextColumn26.AllowEditing = false;
            gridTextColumn26.AllowResizing = true;
            gridTextColumn26.HeaderText = "Time Differenace";
            gridTextColumn26.MappingName = "TimeDiff";
            gridTextColumn26.Visible = false;
            gridTextColumn27.AllowDragging = true;
            gridTextColumn27.AllowEditing = false;
            gridTextColumn27.AllowResizing = true;
            gridTextColumn27.HeaderText = "Text";
            gridTextColumn27.MappingName = "Text";
            gridTextColumn28.AllowDragging = true;
            gridTextColumn28.AllowEditing = false;
            gridTextColumn28.AllowResizing = true;
            gridTextColumn28.HeaderText = "Source";
            gridTextColumn28.MappingName = "Source";
            gridTextColumn29.AllowDragging = true;
            gridTextColumn29.AllowEditing = false;
            gridTextColumn29.AllowResizing = true;
            gridTextColumn29.HeaderText = "Level";
            gridTextColumn29.MappingName = "Level";
            gridTextColumn30.AllowDragging = true;
            gridTextColumn30.AllowEditing = false;
            gridTextColumn30.AllowResizing = true;
            gridTextColumn30.HeaderText = "Class";
            gridTextColumn30.MappingName = "Class";
            gridTextColumn31.AllowDragging = true;
            gridTextColumn31.AllowEditing = false;
            gridTextColumn31.AllowResizing = true;
            gridTextColumn31.HeaderText = "Category";
            gridTextColumn31.MappingName = "Category";
            gridTextColumn32.AllowDragging = true;
            gridTextColumn32.AllowEditing = false;
            gridTextColumn32.AllowResizing = true;
            gridTextColumn32.HeaderText = "User";
            gridTextColumn32.MappingName = "User";
            gridTextColumn33.AllowDragging = true;
            gridTextColumn33.AllowEditing = false;
            gridTextColumn33.AllowResizing = true;
            gridTextColumn33.HeaderText = "Module";
            gridTextColumn33.MappingName = "Module";
            gridTextColumn34.AllowDragging = true;
            gridTextColumn34.AllowEditing = false;
            gridTextColumn34.AllowResizing = true;
            gridTextColumn34.HeaderText = "Object";
            gridTextColumn34.MappingName = "Object";
            gridTextColumn34.Visible = false;
            gridTextColumn35.AllowDragging = true;
            gridTextColumn35.AllowEditing = false;
            gridTextColumn35.AllowResizing = true;
            gridTextColumn35.HeaderText = "Process ID";
            gridTextColumn35.MappingName = "ProcessID";
            gridTextColumn36.AllowDragging = true;
            gridTextColumn36.AllowEditing = false;
            gridTextColumn36.AllowResizing = true;
            gridTextColumn36.HeaderText = "Thread id";
            gridTextColumn36.MappingName = "ThreadID";
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn25);
            this.sfDataGridBookmarks.Columns.Add(gridDateTimeColumn3);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn26);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn27);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn28);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn29);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn30);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn31);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn32);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn33);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn34);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn35);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn36);
            this.sfDataGridBookmarks.ContextMenuStrip = this.cmsMessageOperation;
            this.sfDataGridBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridBookmarks.Location = new System.Drawing.Point(0, 27);
            this.sfDataGridBookmarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfDataGridBookmarks.Name = "sfDataGridBookmarks";
            this.sfDataGridBookmarks.PreviewRowHeight = 35;
            this.sfDataGridBookmarks.RowHeight = 20;
            this.sfDataGridBookmarks.ShowRowHeader = true;
            this.sfDataGridBookmarks.Size = new System.Drawing.Size(1267, 154);
            this.sfDataGridBookmarks.TabIndex = 6;
            this.sfDataGridBookmarks.Text = "Bookmarks";
            this.sfDataGridBookmarks.UsePLINQ = true;
            // 
            // tsBookmark
            // 
            this.tsBookmark.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsBookmark.Image = null;
            this.tsBookmark.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBookmark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBookmarkCopySingle,
            this.tsBtnBookmarkCopyAll,
            this.tsBtnBookmarkClear,
            this.tsBtnBookmarkGoToOriginal});
            this.tsBookmark.Location = new System.Drawing.Point(0, 0);
            this.tsBookmark.Name = "tsBookmark";
            this.tsBookmark.ShowCaption = false;
            this.tsBookmark.ShowLauncher = false;
            this.tsBookmark.Size = new System.Drawing.Size(1267, 27);
            this.tsBookmark.TabIndex = 5;
            this.tsBookmark.ThemeName = "Default";
            // 
            // tsBtnBookmarkCopySingle
            // 
            this.tsBtnBookmarkCopySingle.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsBtnBookmarkCopySingle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBookmarkCopySingle.Name = "tsBtnBookmarkCopySingle";
            this.tsBtnBookmarkCopySingle.Size = new System.Drawing.Size(190, 24);
            this.tsBtnBookmarkCopySingle.Text = "Copy Selected Message";
            // 
            // tsBtnBookmarkCopyAll
            // 
            this.tsBtnBookmarkCopyAll.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsBtnBookmarkCopyAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBookmarkCopyAll.Name = "tsBtnBookmarkCopyAll";
            this.tsBtnBookmarkCopyAll.Size = new System.Drawing.Size(202, 24);
            this.tsBtnBookmarkCopyAll.Text = "Copy all messages in grid";
            // 
            // tsBtnBookmarkClear
            // 
            this.tsBtnBookmarkClear.Image = global::Analogy.Properties.Resources.Clear_16x16;
            this.tsBtnBookmarkClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBookmarkClear.Name = "tsBtnBookmarkClear";
            this.tsBtnBookmarkClear.Size = new System.Drawing.Size(144, 24);
            this.tsBtnBookmarkClear.Text = "Clear Bookmarks";
            // 
            // tsBtnBookmarkGoToOriginal
            // 
            this.tsBtnBookmarkGoToOriginal.Image = global::Analogy.Properties.Resources.Stop_32x32;
            this.tsBtnBookmarkGoToOriginal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBookmarkGoToOriginal.Name = "tsBtnBookmarkGoToOriginal";
            this.tsBtnBookmarkGoToOriginal.Size = new System.Drawing.Size(134, 24);
            this.tsBtnBookmarkGoToOriginal.Text = "Go To Message";
            // 
            // imageListBottom
            // 
            this.imageListBottom.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBottom.ImageStream")));
            this.imageListBottom.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBottom.Images.SetKeyName(0, "Info_16x16.png");
            this.imageListBottom.Images.SetKeyName(1, "RichEditBookmark_16x16.png");
            this.imageListBottom.Images.SetKeyName(2, "RichEditBookmark_32x32.png");
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(271, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(778, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // tmrNewData
            // 
            this.tmrNewData.Enabled = true;
            this.tmrNewData.Interval = 1000;
            this.tmrNewData.Tick += new System.EventHandler(this.tmrNewData_Tick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.progressBar1);
            this.pnlBottom.Controls.Add(this.lblTotalMessagesAlert);
            this.pnlBottom.Controls.Add(this.lblTotalMessages);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 560);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1270, 23);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblTotalMessagesAlert
            // 
            this.lblTotalMessagesAlert.AutoSize = true;
            this.lblTotalMessagesAlert.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.Red);
            this.lblTotalMessagesAlert.BeforeTouchSize = new System.Drawing.Size(145, 21);
            this.lblTotalMessagesAlert.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblTotalMessagesAlert.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMessagesAlert.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMessagesAlert.Location = new System.Drawing.Point(126, 0);
            this.lblTotalMessagesAlert.Name = "lblTotalMessagesAlert";
            this.lblTotalMessagesAlert.Size = new System.Drawing.Size(145, 21);
            this.lblTotalMessagesAlert.TabIndex = 8;
            this.lblTotalMessagesAlert.Text = "ALERTS EXISTS: !";
            this.lblTotalMessagesAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMessages
            // 
            this.lblTotalMessages.AutoSize = true;
            this.lblTotalMessages.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblTotalMessages.BeforeTouchSize = new System.Drawing.Size(126, 21);
            this.lblTotalMessages.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblTotalMessages.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMessages.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMessages.Location = new System.Drawing.Point(0, 0);
            this.lblTotalMessages.Name = "lblTotalMessages";
            this.lblTotalMessages.Size = new System.Drawing.Size(126, 21);
            this.lblTotalMessages.TabIndex = 7;
            this.lblTotalMessages.Text = "Total Messages";
            this.lblTotalMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Button";
            this.btnCancel.AutoSize = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1049, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnCancel.Size = new System.Drawing.Size(221, 23);
            this.btnCancel.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel Processing";
            this.btnCancel.Visible = false;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BeforeTouchSize = 13;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel2;
            this.splitContainerMain.HotExpandLine = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainerMain.Location = new System.Drawing.Point(0, 27);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.splitContainerMain.Panel1.Controls.Add(this.pnlMessages);
            this.splitContainerMain.Panel1.Controls.Add(this.panel1);
            this.splitContainerMain.Panel1.Controls.Add(this.pnlTopFiltering);
            this.splitContainerMain.Panel1.Text = "Panel1";
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.splitContainerMain.Panel2.Controls.Add(this.tcBottom);
            this.splitContainerMain.Panel2.Text = "Panel2";
            this.splitContainerMain.Size = new System.Drawing.Size(1270, 533);
            this.splitContainerMain.SplitterDistance = 309;
            this.splitContainerMain.SplitterWidth = 13;
            this.splitContainerMain.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Metro;
            this.splitContainerMain.TabIndex = 21;
            this.splitContainerMain.Text = "splitContainerControl1";
            this.splitContainerMain.ThemeName = "Metro";
            // 
            // pnlMessages
            // 
            this.pnlMessages.Controls.Add(this.sfDataGridMain);
            this.pnlMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessages.Location = new System.Drawing.Point(0, 153);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(1270, 130);
            this.pnlMessages.TabIndex = 7;
            // 
            // sfDataGridMain
            // 
            this.sfDataGridMain.AccessibleName = "Table";
            this.sfDataGridMain.AllowDraggingColumns = true;
            this.sfDataGridMain.AllowEditing = false;
            this.sfDataGridMain.AllowResizingColumns = true;
            this.sfDataGridMain.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.ColumnHeader;
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "Data Source/File Name";
            gridTextColumn1.MappingName = "DataProvider";
            gridDateTimeColumn1.AllowDragging = true;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowResizing = true;
            gridDateTimeColumn1.Format = "yyyy.MM.dd HH:mm:ss.ff";
            gridDateTimeColumn1.HeaderText = "Date";
            gridDateTimeColumn1.MappingName = "Date";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Time Differenace";
            gridTextColumn2.MappingName = "TimeDiff";
            gridTextColumn2.Visible = false;
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Text";
            gridTextColumn3.MappingName = "Text";
            gridTextColumn4.AllowDragging = true;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.HeaderText = "Source";
            gridTextColumn4.MappingName = "Source";
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowResizing = true;
            gridTextColumn5.HeaderText = "Level";
            gridTextColumn5.MappingName = "Level";
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowResizing = true;
            gridTextColumn6.HeaderText = "Class";
            gridTextColumn6.MappingName = "Class";
            gridTextColumn7.AllowDragging = true;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowResizing = true;
            gridTextColumn7.HeaderText = "Category";
            gridTextColumn7.MappingName = "Category";
            gridTextColumn8.AllowDragging = true;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowResizing = true;
            gridTextColumn8.HeaderText = "User";
            gridTextColumn8.MappingName = "User";
            gridTextColumn9.AllowDragging = true;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowResizing = true;
            gridTextColumn9.HeaderText = "Module";
            gridTextColumn9.MappingName = "Module";
            gridTextColumn10.AllowDragging = true;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowResizing = true;
            gridTextColumn10.HeaderText = "Object";
            gridTextColumn10.MappingName = "Object";
            gridTextColumn10.Visible = false;
            gridTextColumn11.AllowDragging = true;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowResizing = true;
            gridTextColumn11.HeaderText = "Process ID";
            gridTextColumn11.MappingName = "ProcessID";
            gridTextColumn12.AllowDragging = true;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowResizing = true;
            gridTextColumn12.HeaderText = "Thread id";
            gridTextColumn12.MappingName = "ThreadID";
            this.sfDataGridMain.Columns.Add(gridTextColumn1);
            this.sfDataGridMain.Columns.Add(gridDateTimeColumn1);
            this.sfDataGridMain.Columns.Add(gridTextColumn2);
            this.sfDataGridMain.Columns.Add(gridTextColumn3);
            this.sfDataGridMain.Columns.Add(gridTextColumn4);
            this.sfDataGridMain.Columns.Add(gridTextColumn5);
            this.sfDataGridMain.Columns.Add(gridTextColumn6);
            this.sfDataGridMain.Columns.Add(gridTextColumn7);
            this.sfDataGridMain.Columns.Add(gridTextColumn8);
            this.sfDataGridMain.Columns.Add(gridTextColumn9);
            this.sfDataGridMain.Columns.Add(gridTextColumn10);
            this.sfDataGridMain.Columns.Add(gridTextColumn11);
            this.sfDataGridMain.Columns.Add(gridTextColumn12);
            this.sfDataGridMain.ContextMenuStrip = this.cmsMessageOperation;
            this.sfDataGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridMain.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfDataGridMain.Name = "sfDataGridMain";
            this.sfDataGridMain.PreviewRowHeight = 35;
            this.sfDataGridMain.RowHeight = 20;
            this.sfDataGridMain.ShowRowHeader = true;
            this.sfDataGridMain.Size = new System.Drawing.Size(1270, 130);
            this.sfDataGridMain.TabIndex = 5;
            this.sfDataGridMain.Text = "sfDataGridMain";
            this.sfDataGridMain.UsePLINQ = true;
            this.sfDataGridMain.StyleChanged += new System.EventHandler(this.sfDataGridMain_StyleChanged);
            // 
            // tcBottom
            // 
            this.tcBottom.BeforeTouchSize = new System.Drawing.Size(1270, 211);
            this.tcBottom.Controls.Add(this.tabPageMessageInfo);
            this.tcBottom.Controls.Add(this.tabPageBookmarks);
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.Size = new System.Drawing.Size(1270, 211);
            this.tcBottom.TabIndex = 7;
            // 
            // tabPageMessageInfo
            // 
            this.tabPageMessageInfo.Controls.Add(this.tbMessageInfo);
            this.tabPageMessageInfo.Controls.Add(this.tsMessageInfo);
            this.tabPageMessageInfo.Image = null;
            this.tabPageMessageInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageMessageInfo.Location = new System.Drawing.Point(1, 29);
            this.tabPageMessageInfo.Name = "tabPageMessageInfo";
            this.tabPageMessageInfo.ShowCloseButton = true;
            this.tabPageMessageInfo.Size = new System.Drawing.Size(1267, 181);
            this.tabPageMessageInfo.TabIndex = 1;
            this.tabPageMessageInfo.Text = "Message Info";
            this.tabPageMessageInfo.ThemesEnabled = false;
            // 
            // tabPageBookmarks
            // 
            this.tabPageBookmarks.Controls.Add(this.sfDataGridBookmarks);
            this.tabPageBookmarks.Controls.Add(this.tsBookmark);
            this.tabPageBookmarks.Image = null;
            this.tabPageBookmarks.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageBookmarks.Location = new System.Drawing.Point(1, 29);
            this.tabPageBookmarks.Name = "tabPageBookmarks";
            this.tabPageBookmarks.ShowCloseButton = true;
            this.tabPageBookmarks.Size = new System.Drawing.Size(1267, 181);
            this.tabPageBookmarks.TabIndex = 2;
            this.tabPageBookmarks.Text = "Bookmarks";
            this.tabPageBookmarks.ThemesEnabled = false;
            // 
            // cmsBookmarked
            // 
            this.cmsBookmarked.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBookmarked.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalcDiffBookmark,
            this.tsmiBookmarkDateFilterNewer,
            this.tsmiBookmarkDateFilterOlder,
            this.toolStripSeparator5,
            this.tsmiRemoveBookmark,
            this.tsmiCopyBookmark,
            this.tsmiCopyMessagesBookmark,
            this.toolStripMenuItem5,
            this.toolStripSeparator6,
            this.tsmiExcludeBookmark,
            this.tsmiExcludeSourceBookmark,
            this.tsmiExcludeModuleBookmark,
            this.toolStripSeparator7,
            this.tsmiEmailBookmark,
            this.tsmiOTAFullBookmark,
            this.toolStripSeparator8,
            this.tsmiSaveLayoutBookmark,
            this.tsmiIncreaseFontBookmark,
            this.tsmiDecreaseFontBookmark});
            this.cmsBookmarked.Name = "cmsMessageOperation";
            this.cmsBookmarked.Size = new System.Drawing.Size(361, 418);
            this.cmsBookmarked.Opening += new System.ComponentModel.CancelEventHandler(this.cmsBookmarked_Opening);
            // 
            // tsmiCalcDiffBookmark
            // 
            this.tsmiCalcDiffBookmark.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiCalcDiffBookmark.Name = "tsmiCalcDiffBookmark";
            this.tsmiCalcDiffBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiCalcDiffBookmark.Text = "Calculate Time Difference from this entry";
            this.tsmiCalcDiffBookmark.Click += new System.EventHandler(this.tsmiTimeDiff_Click);
            // 
            // tsmiBookmarkDateFilterNewer
            // 
            this.tsmiBookmarkDateFilterNewer.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiBookmarkDateFilterNewer.Name = "tsmiBookmarkDateFilterNewer";
            this.tsmiBookmarkDateFilterNewer.Size = new System.Drawing.Size(360, 26);
            this.tsmiBookmarkDateFilterNewer.Text = "dateTime filtering:after";
            this.tsmiBookmarkDateFilterNewer.Click += new System.EventHandler(this.tsmiBookmarkDateFilterNewer_Click);
            // 
            // tsmiBookmarkDateFilterOlder
            // 
            this.tsmiBookmarkDateFilterOlder.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiBookmarkDateFilterOlder.Name = "tsmiBookmarkDateFilterOlder";
            this.tsmiBookmarkDateFilterOlder.Size = new System.Drawing.Size(360, 26);
            this.tsmiBookmarkDateFilterOlder.Text = "dateTime filtering:before";
            this.tsmiBookmarkDateFilterOlder.Click += new System.EventHandler(this.tsmiBookmarkDateFilterOlder_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(357, 6);
            // 
            // tsmiRemoveBookmark
            // 
            this.tsmiRemoveBookmark.Image = global::Analogy.Properties.Resources.Clear_16x16;
            this.tsmiRemoveBookmark.Name = "tsmiRemoveBookmark";
            this.tsmiRemoveBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiRemoveBookmark.Text = "Remove this message";
            this.tsmiRemoveBookmark.Click += new System.EventHandler(this.tsmiRemoveBookmark_Click);
            // 
            // tsmiCopyBookmark
            // 
            this.tsmiCopyBookmark.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsmiCopyBookmark.Name = "tsmiCopyBookmark";
            this.tsmiCopyBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiCopyBookmark.Text = "Copy selected message to clipboard";
            this.tsmiCopyBookmark.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiCopyMessagesBookmark
            // 
            this.tsmiCopyMessagesBookmark.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsmiCopyMessagesBookmark.Name = "tsmiCopyMessagesBookmark";
            this.tsmiCopyMessagesBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiCopyMessagesBookmark.Text = "Copy all messages in view to clipboard";
            this.tsmiCopyMessagesBookmark.Click += new System.EventHandler(this.tsmiCopyMessages_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Image = global::Analogy.Properties.Resources.EditComment_16x16;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(360, 26);
            this.toolStripMenuItem5.Text = "Add message/comment at this timestamp";
            this.toolStripMenuItem5.Visible = false;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(357, 6);
            // 
            // tsmiExcludeBookmark
            // 
            this.tsmiExcludeBookmark.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeBookmark.Name = "tsmiExcludeBookmark";
            this.tsmiExcludeBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiExcludeBookmark.Text = "Exclude selected message ";
            this.tsmiExcludeBookmark.Click += new System.EventHandler(this.tsmiExclude_Click);
            // 
            // tsmiExcludeSourceBookmark
            // 
            this.tsmiExcludeSourceBookmark.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeSourceBookmark.Name = "tsmiExcludeSourceBookmark";
            this.tsmiExcludeSourceBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiExcludeSourceBookmark.Text = "Exclude Source";
            this.tsmiExcludeSourceBookmark.Click += new System.EventHandler(this.tsmiExcludeSource_Click);
            // 
            // tsmiExcludeModuleBookmark
            // 
            this.tsmiExcludeModuleBookmark.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeModuleBookmark.Name = "tsmiExcludeModuleBookmark";
            this.tsmiExcludeModuleBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiExcludeModuleBookmark.Text = "Exclude Module";
            this.tsmiExcludeModuleBookmark.Click += new System.EventHandler(this.tsmiExcludeModule_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(357, 6);
            // 
            // tsmiEmailBookmark
            // 
            this.tsmiEmailBookmark.Image = global::Analogy.Properties.Resources.Send_16x16;
            this.tsmiEmailBookmark.Name = "tsmiEmailBookmark";
            this.tsmiEmailBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiEmailBookmark.Text = "Send selected message by mail";
            this.tsmiEmailBookmark.Click += new System.EventHandler(this.tsmiEmail_Click);
            // 
            // tsmiOTAFullBookmark
            // 
            this.tsmiOTAFullBookmark.Image = global::Analogy.Properties.Resources.logIcon;
            this.tsmiOTAFullBookmark.Name = "tsmiOTAFullBookmark";
            this.tsmiOTAFullBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiOTAFullBookmark.Text = "Send Log to another Analogy";
            this.tsmiOTAFullBookmark.Visible = false;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(357, 6);
            // 
            // tsmiSaveLayoutBookmark
            // 
            this.tsmiSaveLayoutBookmark.Image = global::Analogy.Properties.Resources.Save_16x16;
            this.tsmiSaveLayoutBookmark.Name = "tsmiSaveLayoutBookmark";
            this.tsmiSaveLayoutBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiSaveLayoutBookmark.Text = "Save columns layout";
            this.tsmiSaveLayoutBookmark.Click += new System.EventHandler(this.tsmiSaveLayout_Click);
            // 
            // tsmiIncreaseFontBookmark
            // 
            this.tsmiIncreaseFontBookmark.Image = global::Analogy.Properties.Resources.IncreaseFontSize_16x16;
            this.tsmiIncreaseFontBookmark.Name = "tsmiIncreaseFontBookmark";
            this.tsmiIncreaseFontBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiIncreaseFontBookmark.Text = "Increase Font Size";
            this.tsmiIncreaseFontBookmark.Click += new System.EventHandler(this.tsmiIncreaseFont_Click);
            // 
            // tsmiDecreaseFontBookmark
            // 
            this.tsmiDecreaseFontBookmark.Image = global::Analogy.Properties.Resources.DecreaseFontSize_16x16;
            this.tsmiDecreaseFontBookmark.Name = "tsmiDecreaseFontBookmark";
            this.tsmiDecreaseFontBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiDecreaseFontBookmark.Text = "Decrease Font Size";
            this.tsmiDecreaseFontBookmark.Click += new System.EventHandler(this.tsmiDecreaseFont_Click);
            // 
            // contextMenuStripFilters
            // 
            this.contextMenuStripFilters.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripFilters.Name = "contextMenuStripFilters";
            this.contextMenuStripFilters.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControlMain
            // 
            this.tabControlMain.BeforeTouchSize = new System.Drawing.Size(1277, 618);
            this.tabControlMain.Controls.Add(this.tabPageLogs);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Size = new System.Drawing.Size(1277, 618);
            this.tabControlMain.TabIndex = 27;
            this.tabControlMain.ThemesEnabled = true;
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.splitContainerMain);
            this.tabPageLogs.Controls.Add(this.pnlBottom);
            this.tabPageLogs.Controls.Add(this.tsTop);
            this.tabPageLogs.Image = null;
            this.tabPageLogs.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageLogs.Location = new System.Drawing.Point(3, 31);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.ShowCloseButton = true;
            this.tabPageLogs.Size = new System.Drawing.Size(1270, 583);
            this.tabPageLogs.TabIndex = 1;
            this.tabPageLogs.Text = "Logs";
            this.tabPageLogs.ThemesEnabled = true;
            // 
            // tsTop
            // 
            this.tsTop.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsTop.Image = null;
            this.tsTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTopClear,
            this.tsTopPauseRefresh,
            this.tsTopAutoScrollToLast,
            this.tsddbSave,
            this.tsddbUndock,
            this.tsbScreenshot,
            this.tsddbExport,
            this.tsBDataVisualizer});
            this.tsTop.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Office12Mode = false;
            this.tsTop.ShowCaption = false;
            this.tsTop.ShowLauncher = false;
            this.tsTop.Size = new System.Drawing.Size(1270, 27);
            this.tsTop.TabIndex = 5;
            this.tsTop.ThemeName = "Default";
            // 
            // tsTopClear
            // 
            this.tsTopClear.Image = global::Analogy.Properties.Resources.Delete_16x16;
            this.tsTopClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTopClear.Name = "tsTopClear";
            this.tsTopClear.Size = new System.Drawing.Size(96, 24);
            this.tsTopClear.Text = "Clear Log";
            // 
            // tsTopPauseRefresh
            // 
            this.tsTopPauseRefresh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsTopPauseRefresh.Name = "tsTopPauseRefresh";
            this.tsTopPauseRefresh.Size = new System.Drawing.Size(145, 24);
            this.tsTopPauseRefresh.Text = "Pause Refreshing:";
            // 
            // tsTopAutoScrollToLast
            // 
            this.tsTopAutoScrollToLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsTopAutoScrollToLast.Name = "tsTopAutoScrollToLast";
            this.tsTopAutoScrollToLast.Size = new System.Drawing.Size(179, 24);
            this.tsTopAutoScrollToLast.Text = "Auto scroll to last row:";
            // 
            // tsddbSave
            // 
            this.tsddbSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveFullLog,
            this.saveCurrentViewToolStripMenuItem});
            this.tsddbSave.Image = global::Analogy.Properties.Resources.Save_16x16;
            this.tsddbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbSave.Name = "tsddbSave";
            this.tsddbSave.Size = new System.Drawing.Size(103, 24);
            this.tsddbSave.Text = "Save Log";
            // 
            // tsmiSaveFullLog
            // 
            this.tsmiSaveFullLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveFullLogDataProvider,
            this.tsmiSaveFullLogAnalogy});
            this.tsmiSaveFullLog.Name = "tsmiSaveFullLog";
            this.tsmiSaveFullLog.Size = new System.Drawing.Size(211, 26);
            this.tsmiSaveFullLog.Text = "Save Entire Log";
            // 
            // tsmiSaveFullLogDataProvider
            // 
            this.tsmiSaveFullLogDataProvider.Name = "tsmiSaveFullLogDataProvider";
            this.tsmiSaveFullLogDataProvider.Size = new System.Drawing.Size(572, 26);
            this.tsmiSaveFullLogDataProvider.Text = "Save Entire Log (Data Provider Format)";
            // 
            // tsmiSaveFullLogAnalogy
            // 
            this.tsmiSaveFullLogAnalogy.Name = "tsmiSaveFullLogAnalogy";
            this.tsmiSaveFullLogAnalogy.Size = new System.Drawing.Size(572, 26);
            this.tsmiSaveFullLogAnalogy.Text = "Save Entire Log in Analogy Format (agnostic to specific implementation)";
            // 
            // saveCurrentViewToolStripMenuItem
            // 
            this.saveCurrentViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveCurrentViewDataProvider,
            this.tsmiSaveCurrentViewAnalogy});
            this.saveCurrentViewToolStripMenuItem.Name = "saveCurrentViewToolStripMenuItem";
            this.saveCurrentViewToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.saveCurrentViewToolStripMenuItem.Text = "Save Current View";
            // 
            // tsmiSaveCurrentViewDataProvider
            // 
            this.tsmiSaveCurrentViewDataProvider.Name = "tsmiSaveCurrentViewDataProvider";
            this.tsmiSaveCurrentViewDataProvider.Size = new System.Drawing.Size(589, 26);
            this.tsmiSaveCurrentViewDataProvider.Text = "Save Current View (Data Provider Format)";
            // 
            // tsmiSaveCurrentViewAnalogy
            // 
            this.tsmiSaveCurrentViewAnalogy.Name = "tsmiSaveCurrentViewAnalogy";
            this.tsmiSaveCurrentViewAnalogy.Size = new System.Drawing.Size(589, 26);
            this.tsmiSaveCurrentViewAnalogy.Text = "Save Current View in Analogy Format (agnostic to specific implementation)";
            // 
            // tsddbUndock
            // 
            this.tsddbUndock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndockView,
            this.tsmiUndockPerModule});
            this.tsddbUndock.Image = global::Analogy.Properties.Resources.FullscreenBlue16;
            this.tsddbUndock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbUndock.Name = "tsddbUndock";
            this.tsddbUndock.Size = new System.Drawing.Size(129, 24);
            this.tsddbUndock.Text = "Undock View";
            // 
            // tsmiUndockView
            // 
            this.tsmiUndockView.Name = "tsmiUndockView";
            this.tsmiUndockView.Size = new System.Drawing.Size(312, 26);
            this.tsmiUndockView.Text = "Undock View (No filtering)";
            // 
            // tsmiUndockPerModule
            // 
            this.tsmiUndockPerModule.Name = "tsmiUndockPerModule";
            this.tsmiUndockPerModule.Size = new System.Drawing.Size(312, 26);
            this.tsmiUndockPerModule.Text = "Undock View Per Process/Module";
            // 
            // tsbScreenshot
            // 
            this.tsbScreenshot.Image = global::Analogy.Properties.Resources.Icon_6;
            this.tsbScreenshot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScreenshot.Name = "tsbScreenshot";
            this.tsbScreenshot.Size = new System.Drawing.Size(138, 24);
            this.tsbScreenshot.Text = "Take Screenshot";
            // 
            // tsddbExport
            // 
            this.tsddbExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportExcel});
            this.tsddbExport.Image = global::Analogy.Properties.Resources.Export_16x16;
            this.tsddbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbExport.Name = "tsddbExport";
            this.tsddbExport.Size = new System.Drawing.Size(86, 24);
            this.tsddbExport.Text = "Export";
            // 
            // tsmiExportExcel
            // 
            this.tsmiExportExcel.Image = global::Analogy.Properties.Resources.ExportToXLS_16x16;
            this.tsmiExportExcel.Name = "tsmiExportExcel";
            this.tsmiExportExcel.Size = new System.Drawing.Size(224, 26);
            this.tsmiExportExcel.Text = "Export To Excel";
            // 
            // tsBDataVisualizer
            // 
            this.tsBDataVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBDataVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("tsBDataVisualizer.Image")));
            this.tsBDataVisualizer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBDataVisualizer.Name = "tsBDataVisualizer";
            this.tsBDataVisualizer.Size = new System.Drawing.Size(29, 24);
            this.tsBDataVisualizer.Text = "Data Visualizer";
            this.tsBDataVisualizer.Visible = false;
            // 
            // UCLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCLogs";
            this.Size = new System.Drawing.Size(1277, 618);
            this.Load += new System.EventHandler(this.UCLogs_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCLogs_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCLogs_DragEnter);
            this.cmsMessageOperation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlights)).EndInit();
            this.pnlButtonsHighlight.ResumeLayout(false);
            this.pnlTopFiltering.ResumeLayout(false);
            this.spltFilteringBoth.Panel1.ResumeLayout(false);
            this.spltFilteringBoth.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltFilteringBoth)).EndInit();
            this.spltFilteringBoth.ResumeLayout(false);
            this.pnlFilteringLeft.ResumeLayout(false);
            this.spltcDateFiltering.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcDateFiltering)).EndInit();
            this.spltcDateFiltering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.spltcProcessesModule.Panel1.ResumeLayout(false);
            this.spltcProcessesModule.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcProcessesModule)).EndInit();
            this.spltcProcessesModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbModule)).EndInit();
            this.spltcSources.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcSources)).EndInit();
            this.spltcSources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfoExclude)).EndInit();
            this.spltTextExclude.Panel1.ResumeLayout(false);
            this.spltTextExclude.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltTextExclude)).EndInit();
            this.spltTextExclude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbExclude)).EndInit();
            this.spltText.Panel1.ResumeLayout(false);
            this.spltText.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltText)).EndInit();
            this.spltText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbInclude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbVerbose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDebug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbErrorCritical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessageInfo)).EndInit();
            this.tsMessageInfo.ResumeLayout(false);
            this.tsMessageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBookmarks)).EndInit();
            this.tsBookmark.ResumeLayout(false);
            this.tsBookmark.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcBottom)).EndInit();
            this.tcBottom.ResumeLayout(false);
            this.tabPageMessageInfo.ResumeLayout(false);
            this.tabPageMessageInfo.PerformLayout();
            this.tabPageBookmarks.ResumeLayout(false);
            this.tabPageBookmarks.PerformLayout();
            this.cmsBookmarked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageLogs.ResumeLayout(false);
            this.tabPageLogs.PerformLayout();
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel pnlTopFiltering;
        private System.Windows.Forms.CheckBox chkbIncludeText;
        private System.Windows.Forms.CheckBox chkExclude;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip cmsMessageOperation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExclude;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiOTAFull;
        private System.Windows.Forms.Timer tmrNewData;
        private System.Windows.Forms.PictureBox pboxInfo;
        private System.Windows.Forms.PictureBox pboxInfoExclude;
        private System.Windows.Forms.ImageList imageListBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCommentToMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkbHighlight;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeSource;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeModule;
        private System.Windows.Forms.Panel pnlButtonsHighlight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimeDiff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SplitContainer spltFilteringBoth;
        private System.Windows.Forms.Panel pnlFilteringLeft;
        private Syncfusion.WinForms.Controls.SfButton sBtnMostCommon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLayout;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkPersist;
        private System.Windows.Forms.ContextMenuStrip cmsBookmarked;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalcDiffBookmark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyBookmark;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeSourceBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeModuleBookmark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmailBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiOTAFullBookmark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLayoutBookmark;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyMessages;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyMessagesBookmark;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerMain;
        private Syncfusion.WinForms.Controls.SfButton btnPageFirst;
        private Syncfusion.WinForms.Controls.SfButton btnPageNext;
        private Syncfusion.WinForms.Controls.SfButton btnLastPage;
        private Syncfusion.WinForms.Controls.SfButton btnPagePrevious;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncreaseFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiDecreaseFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncreaseFontBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiDecreaseFontBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiREmoveAllPreviousMessages;
        private System.Windows.Forms.SplitContainer spltText;
        private Syncfusion.WinForms.Controls.SfButton btnTextInclude;
        private System.Windows.Forms.SplitContainer spltTextExclude;
        private Syncfusion.WinForms.Controls.SfButton btnTextExclude;
        private System.Windows.Forms.SplitContainer spltcSources;
        private Syncfusion.WinForms.Controls.SfButton btnSources;
        private System.Windows.Forms.CheckBox chkbSources;
        private System.Windows.Forms.SplitContainer spltcProcessesModule;
        private System.Windows.Forms.CheckBox chkbModules;
        private Syncfusion.WinForms.Controls.SfButton btnModules;
        private Syncfusion.WinForms.Controls.SfButton sbtnUndockPerProcess;
        private System.Windows.Forms.SplitContainer spltcDateFiltering;
        private System.Windows.Forms.CheckBox chkDateNewerThan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkDateOlderThan;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateFilterNewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateFilterOlder;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkDateFilterNewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkDateFilterOlder;
        private Syncfusion.WinForms.Controls.SfButton sbtnMoreHighlight;
        private Syncfusion.WinForms.Controls.SfButton sbtnPreDefinedFilters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFilters;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridMain;
        private Syncfusion.WinForms.ListView.SfComboBox cbInclude;
        private System.Windows.Forms.Panel pnlMessages;
        private Syncfusion.WinForms.ListView.SfComboBox cbExclude;
        private Syncfusion.WinForms.ListView.SfComboBox cbModule;
        private Syncfusion.WinForms.ListView.SfComboBox cbSource;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbAllLevel;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbVerbose;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbDebug;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbWarning;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbErrorCritical;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbTrace;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblPageNumber;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblTotalMessagesAlert;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblTotalMessages;
        private Syncfusion.WinForms.ListView.SfComboBox cbHighlights;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx tsMessageInfo;
        private System.Windows.Forms.ToolStripButton tsBtnMessageInfoCopy;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx tsBookmark;
        private System.Windows.Forms.ToolStripButton tsBtnBookmarkCopySingle;
        private System.Windows.Forms.ToolStripButton tsBtnBookmarkCopyAll;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridBookmarks;
        private System.Windows.Forms.ToolStripButton tsBtnBookmarkClear;
        private System.Windows.Forms.ToolStripButton tsBtnBookmarkGoToOriginal;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbMessageInfo;
        private Syncfusion.WinForms.Input.SfDateTimeEdit deOlderThanFilter;
        private Syncfusion.WinForms.Input.SfDateTimeEdit deNewerThanFilter;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlMain;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageLogs;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx tsTop;
        private System.Windows.Forms.ToolStripButton tsTopClear;
        private System.Windows.Forms.ToolStripDropDownButton tsddbSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveFullLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveFullLogDataProvider;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveFullLogAnalogy;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveCurrentViewDataProvider;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveCurrentViewAnalogy;
        private System.Windows.Forms.ToolStripDropDownButton tsddbUndock;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndockView;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndockPerModule;
        private System.Windows.Forms.ToolStripButton tsbScreenshot;
        private System.Windows.Forms.ToolStripDropDownButton tsddbExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportExcel;
        private System.Windows.Forms.ToolStripButton tsBDataVisualizer;
        public Syncfusion.Windows.Forms.Tools.ToolStripCheckBox tsTopPauseRefresh;
        public Syncfusion.Windows.Forms.Tools.ToolStripCheckBox tsTopAutoScrollToLast;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tcBottom;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageMessageInfo;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageBookmarks;
    }
}

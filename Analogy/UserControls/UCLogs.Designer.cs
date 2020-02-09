using System.ComponentModel;
using System.Windows.Forms;

namespace Analogy
{
    partial class UCLogs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;


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
            this.cbHighlights = new System.Windows.Forms.ComboBox();
            this.sbtnMoreHighlight = new System.Windows.Forms.Button();
            this.pnlButtonsHighlight = new System.Windows.Forms.Panel();
            this.btnPageFirst = new System.Windows.Forms.Button();
            this.btnPagePrevious = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.chkbHighlight = new System.Windows.Forms.CheckBox();
            this.pnlTopFiltering = new System.Windows.Forms.Panel();
            this.spltFilteringBoth = new System.Windows.Forms.SplitContainer();
            this.pnlFilteringLeft = new System.Windows.Forms.Panel();
            this.spltcDateFiltering = new System.Windows.Forms.SplitContainer();
            this.deOlderThanFilter = new System.Windows.Forms.DateTimePicker();
            this.chkDateOlderThan = new System.Windows.Forms.CheckBox();
            this.deNewerThanFilter = new System.Windows.Forms.DateTimePicker();
            this.chkDateNewerThan = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spltcProcessesModule = new System.Windows.Forms.SplitContainer();
            this.cbModule = new System.Windows.Forms.ComboBox();
            this.btnModules = new System.Windows.Forms.Button();
            this.sbtnUndockPerProcess = new System.Windows.Forms.Button();
            this.chkbModules = new System.Windows.Forms.CheckBox();
            this.spltcSources = new System.Windows.Forms.SplitContainer();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.btnSources = new System.Windows.Forms.Button();
            this.chkbSources = new System.Windows.Forms.CheckBox();
            this.pboxInfoExclude = new System.Windows.Forms.PictureBox();
            this.spltTextExclude = new System.Windows.Forms.SplitContainer();
            this.cbExclude = new System.Windows.Forms.ComboBox();
            this.btnTextExclude = new System.Windows.Forms.Button();
            this.sBtnMostCommon = new System.Windows.Forms.Button();
            this.chkExclude = new System.Windows.Forms.CheckBox();
            this.spltText = new System.Windows.Forms.SplitContainer();
            this.cbInclude = new System.Windows.Forms.ComboBox();
            this.btnTextInclude = new System.Windows.Forms.Button();
            this.chkbIncludeText = new System.Windows.Forms.CheckBox();
            this.pboxInfo = new System.Windows.Forms.PictureBox();
            this.sbtnPreDefinedFilters = new System.Windows.Forms.Button();
            this.rbVerbose = new System.Windows.Forms.RadioButton();
            this.rbDebug = new System.Windows.Forms.RadioButton();
            this.rbWarning = new System.Windows.Forms.RadioButton();
            this.rbErrorCritical = new System.Windows.Forms.RadioButton();
            this.rbTrace = new System.Windows.Forms.RadioButton();
            this.rbAllLevel = new System.Windows.Forms.RadioButton();
            this.tbMessageInfo = new System.Windows.Forms.RichTextBox();
            this.tsMessageInfo = new System.Windows.Forms.ToolStrip();
            this.tsBtnMessageInfoCopy = new System.Windows.Forms.ToolStripButton();
            this.sfDataGridBookmarks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsBookmark = new System.Windows.Forms.ToolStrip();
            this.tsBtnBookmarkCopySingle = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkCopyAll = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkClear = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkGoToOriginal = new System.Windows.Forms.ToolStripButton();
            this.imageListBottom = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrNewData = new System.Windows.Forms.Timer(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTotalMessagesAlert = new System.Windows.Forms.Label();
            this.lblTotalMessages = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.sfDataGridMain = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcBottom = new System.Windows.Forms.TabControl();
            this.tabPageMessageInfo = new System.Windows.Forms.TabPage();
            this.tabPageBookmarks = new System.Windows.Forms.TabPage();
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsTopClear = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.spltcSources)).BeginInit();
            this.spltcSources.Panel1.SuspendLayout();
            this.spltcSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfoExclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltTextExclude)).BeginInit();
            this.spltTextExclude.Panel1.SuspendLayout();
            this.spltTextExclude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltText)).BeginInit();
            this.spltText.Panel1.SuspendLayout();
            this.spltText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).BeginInit();
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
            this.tcBottom.SuspendLayout();
            this.tabPageMessageInfo.SuspendLayout();
            this.tabPageBookmarks.SuspendLayout();
            this.cmsBookmarked.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 26);
            this.panel1.TabIndex = 4;
            // 
            // cbHighlights
            // 
            this.cbHighlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHighlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.Location = new System.Drawing.Point(207, 0);
            this.cbHighlights.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbHighlights.Name = "cbHighlights";
            this.cbHighlights.Size = new System.Drawing.Size(383, 28);
            this.cbHighlights.TabIndex = 44;
            // 
            // sbtnMoreHighlight
            // 
            this.sbtnMoreHighlight.AccessibleName = "Button";
            this.sbtnMoreHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnMoreHighlight.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnMoreHighlight.Location = new System.Drawing.Point(590, 0);
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
            this.pnlButtonsHighlight.Location = new System.Drawing.Point(685, 0);
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
            this.pnlTopFiltering.Size = new System.Drawing.Size(1269, 153);
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
            this.spltFilteringBoth.Size = new System.Drawing.Size(1269, 153);
            this.spltFilteringBoth.SplitterDistance = 1082;
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
            this.pnlFilteringLeft.Size = new System.Drawing.Size(1082, 153);
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
            this.spltcDateFiltering.Size = new System.Drawing.Size(1070, 25);
            this.spltcDateFiltering.SplitterDistance = 138;
            this.spltcDateFiltering.SplitterWidth = 3;
            this.spltcDateFiltering.TabIndex = 27;
            // 
            // deOlderThanFilter
            // 
            this.deOlderThanFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.deOlderThanFilter.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.deOlderThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.deOlderThanFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deOlderThanFilter.Location = new System.Drawing.Point(662, 0);
            this.deOlderThanFilter.Name = "deOlderThanFilter";
            this.deOlderThanFilter.Size = new System.Drawing.Size(269, 22);
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
            this.deNewerThanFilter.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.deNewerThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.deNewerThanFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deNewerThanFilter.Location = new System.Drawing.Point(265, 0);
            this.deNewerThanFilter.Name = "deNewerThanFilter";
            this.deNewerThanFilter.Size = new System.Drawing.Size(269, 22);
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
            this.spltcProcessesModule.Size = new System.Drawing.Size(1070, 25);
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
            this.cbModule.Size = new System.Drawing.Size(453, 28);
            this.cbModule.TabIndex = 27;
            // 
            // btnModules
            // 
            this.btnModules.AccessibleName = "Button";
            this.btnModules.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModules.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnModules.Image = ((System.Drawing.Image)(resources.GetObject("btnModules.Image")));
            this.btnModules.Location = new System.Drawing.Point(767, 0);
            this.btnModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(26, 25);
            this.btnModules.TabIndex = 24;
            // 
            // sbtnUndockPerProcess
            // 
            this.sbtnUndockPerProcess.AccessibleName = "Button";
            this.sbtnUndockPerProcess.AutoSize = true;
            this.sbtnUndockPerProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnUndockPerProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnUndockPerProcess.Location = new System.Drawing.Point(793, 0);
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
            this.spltcSources.Size = new System.Drawing.Size(1070, 25);
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
            this.cbSource.Size = new System.Drawing.Size(783, 28);
            this.cbSource.TabIndex = 27;
            // 
            // btnSources
            // 
            this.btnSources.AccessibleName = "Button";
            this.btnSources.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSources.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSources.Image = ((System.Drawing.Image)(resources.GetObject("btnSources.Image")));
            this.btnSources.Location = new System.Drawing.Point(1044, 0);
            this.btnSources.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSources.Name = "btnSources";
            this.btnSources.Size = new System.Drawing.Size(26, 25);
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
            this.spltTextExclude.Size = new System.Drawing.Size(1070, 25);
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
            this.cbExclude.Size = new System.Drawing.Size(781, 28);
            this.cbExclude.TabIndex = 27;
            // 
            // btnTextExclude
            // 
            this.btnTextExclude.AccessibleName = "Button";
            this.btnTextExclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTextExclude.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTextExclude.Image = ((System.Drawing.Image)(resources.GetObject("btnTextExclude.Image")));
            this.btnTextExclude.Location = new System.Drawing.Point(907, 0);
            this.btnTextExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextExclude.Name = "btnTextExclude";
            this.btnTextExclude.Size = new System.Drawing.Size(26, 25);
            this.btnTextExclude.TabIndex = 20;
            // 
            // sBtnMostCommon
            // 
            this.sBtnMostCommon.AccessibleName = "Button";
            this.sBtnMostCommon.Dock = System.Windows.Forms.DockStyle.Right;
            this.sBtnMostCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnMostCommon.Location = new System.Drawing.Point(933, 0);
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
            this.spltText.Size = new System.Drawing.Size(1070, 25);
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
            this.cbInclude.Size = new System.Drawing.Size(890, 28);
            this.cbInclude.TabIndex = 26;
            // 
            // btnTextInclude
            // 
            this.btnTextInclude.AccessibleName = "Button";
            this.btnTextInclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTextInclude.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTextInclude.Image = ((System.Drawing.Image)(resources.GetObject("btnTextInclude.Image")));
            this.btnTextInclude.Location = new System.Drawing.Point(1018, 0);
            this.btnTextInclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextInclude.Name = "btnTextInclude";
            this.btnTextInclude.Size = new System.Drawing.Size(26, 25);
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
            this.sbtnPreDefinedFilters.Image = global::Analogy.Properties.Resources.SingleMasterFilter_16x16;
            this.sbtnPreDefinedFilters.Location = new System.Drawing.Point(1044, 0);
            this.sbtnPreDefinedFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnPreDefinedFilters.Name = "sbtnPreDefinedFilters";
            this.sbtnPreDefinedFilters.Size = new System.Drawing.Size(26, 25);
            this.sbtnPreDefinedFilters.TabIndex = 21;
            this.sbtnPreDefinedFilters.Click += new System.EventHandler(this.sbtnPreDefinedFilters_Click);
            // 
            // rbVerbose
            // 
            this.rbVerbose.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbVerbose.Location = new System.Drawing.Point(0, 100);
            this.rbVerbose.Name = "rbVerbose";
            this.rbVerbose.Size = new System.Drawing.Size(184, 20);
            this.rbVerbose.TabIndex = 28;
            this.rbVerbose.Text = "Verbose";
            // 
            // rbDebug
            // 
            this.rbDebug.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbDebug.Location = new System.Drawing.Point(0, 80);
            this.rbDebug.Name = "rbDebug";
            this.rbDebug.Size = new System.Drawing.Size(184, 20);
            this.rbDebug.TabIndex = 27;
            this.rbDebug.Text = "Debug";
            // 
            // rbWarning
            // 
            this.rbWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbWarning.Location = new System.Drawing.Point(0, 60);
            this.rbWarning.Name = "rbWarning";
            this.rbWarning.Size = new System.Drawing.Size(184, 20);
            this.rbWarning.TabIndex = 26;
            this.rbWarning.Text = "Warning";
            // 
            // rbErrorCritical
            // 
            this.rbErrorCritical.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbErrorCritical.Location = new System.Drawing.Point(0, 40);
            this.rbErrorCritical.Name = "rbErrorCritical";
            this.rbErrorCritical.Size = new System.Drawing.Size(184, 20);
            this.rbErrorCritical.TabIndex = 25;
            this.rbErrorCritical.Text = "Errors + Critical";
            // 
            // rbTrace
            // 
            this.rbTrace.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbTrace.Location = new System.Drawing.Point(0, 20);
            this.rbTrace.Name = "rbTrace";
            this.rbTrace.Size = new System.Drawing.Size(184, 20);
            this.rbTrace.TabIndex = 24;
            this.rbTrace.Text = "Trace";
            // 
            // rbAllLevel
            // 
            this.rbAllLevel.Checked = true;
            this.rbAllLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAllLevel.Location = new System.Drawing.Point(0, 0);
            this.rbAllLevel.Name = "rbAllLevel";
            this.rbAllLevel.Size = new System.Drawing.Size(184, 20);
            this.rbAllLevel.TabIndex = 23;
            this.rbAllLevel.TabStop = true;
            this.rbAllLevel.Text = "All";
            // 
            // tbMessageInfo
            // 
            this.tbMessageInfo.BackColor = System.Drawing.Color.White;
            this.tbMessageInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMessageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbMessageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbMessageInfo.Location = new System.Drawing.Point(0, 27);
            this.tbMessageInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessageInfo.Name = "tbMessageInfo";
            this.tbMessageInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbMessageInfo.Size = new System.Drawing.Size(1261, 180);
            this.tbMessageInfo.TabIndex = 14;
            this.tbMessageInfo.Text = "";
            // 
            // tsMessageInfo
            // 
            this.tsMessageInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsMessageInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMessageInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnMessageInfoCopy});
            this.tsMessageInfo.Location = new System.Drawing.Point(0, 0);
            this.tsMessageInfo.Name = "tsMessageInfo";
            this.tsMessageInfo.Size = new System.Drawing.Size(1261, 27);
            this.tsMessageInfo.TabIndex = 4;
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
            this.sfDataGridBookmarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.sfDataGridBookmarks.ColumnHeadersHeight = 29;
            this.sfDataGridBookmarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.sfDataGridBookmarks.ContextMenuStrip = this.cmsMessageOperation;
            this.sfDataGridBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridBookmarks.Location = new System.Drawing.Point(0, 27);
            this.sfDataGridBookmarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfDataGridBookmarks.Name = "sfDataGridBookmarks";
            this.sfDataGridBookmarks.RowHeadersWidth = 51;
            this.sfDataGridBookmarks.Size = new System.Drawing.Size(1261, 180);
            this.sfDataGridBookmarks.TabIndex = 6;
            this.sfDataGridBookmarks.Text = "Bookmarks";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Data Source/File Name";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 183;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Date";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 67;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Time Differenace";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 145;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Text";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 64;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Source";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 82;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Level";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 71;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Class";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 71;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Category";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 94;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "User";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 67;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "Module";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 83;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Object";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 78;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "Process ID";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 105;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "Thread ID";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // tsBookmark
            // 
            this.tsBookmark.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsBookmark.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBookmark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBookmarkCopySingle,
            this.tsBtnBookmarkCopyAll,
            this.tsBtnBookmarkClear,
            this.tsBtnBookmarkGoToOriginal});
            this.tsBookmark.Location = new System.Drawing.Point(0, 0);
            this.tsBookmark.Name = "tsBookmark";
            this.tsBookmark.Size = new System.Drawing.Size(1261, 27);
            this.tsBookmark.TabIndex = 5;
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
            this.progressBar1.Size = new System.Drawing.Size(777, 23);
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
            this.pnlBottom.Location = new System.Drawing.Point(0, 566);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1269, 23);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblTotalMessagesAlert
            // 
            this.lblTotalMessagesAlert.AutoSize = true;
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
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1048, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnCancel.Size = new System.Drawing.Size(221, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel Processing";
            this.btnCancel.Visible = false;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 27);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlMessages);
            this.splitContainerMain.Panel1.Controls.Add(this.panel1);
            this.splitContainerMain.Panel1.Controls.Add(this.pnlTopFiltering);
            this.splitContainerMain.Panel1.Text = "Panel1";
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tcBottom);
            this.splitContainerMain.Panel2.Text = "Panel2";
            this.splitContainerMain.Size = new System.Drawing.Size(1269, 539);
            this.splitContainerMain.SplitterDistance = 290;
            this.splitContainerMain.SplitterWidth = 13;
            this.splitContainerMain.TabIndex = 21;
            this.splitContainerMain.Text = "splitContainerControl1";
            // 
            // pnlMessages
            // 
            this.pnlMessages.Controls.Add(this.sfDataGridMain);
            this.pnlMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessages.Location = new System.Drawing.Point(0, 153);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(1269, 111);
            this.pnlMessages.TabIndex = 7;
            // 
            // sfDataGridMain
            // 
            this.sfDataGridMain.AccessibleName = "Table";
            this.sfDataGridMain.AllowUserToAddRows = false;
            this.sfDataGridMain.AllowUserToDeleteRows = false;
            this.sfDataGridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.sfDataGridMain.ColumnHeadersHeight = 29;
            this.sfDataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.sfDataGridMain.ContextMenuStrip = this.cmsMessageOperation;
            this.sfDataGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridMain.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfDataGridMain.Name = "sfDataGridMain";
            this.sfDataGridMain.RowHeadersWidth = 51;
            this.sfDataGridMain.Size = new System.Drawing.Size(1269, 111);
            this.sfDataGridMain.TabIndex = 5;
            this.sfDataGridMain.Text = "sfDataGridMain";
            this.sfDataGridMain.StyleChanged += new System.EventHandler(this.sfDataGridMain_StyleChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Data Source/File Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 183;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 67;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Time Differenace";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 145;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Text";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 64;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Source";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 82;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Level";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 71;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Class";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 71;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Category";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 94;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "User";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 67;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Module";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 83;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Object";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 78;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Process ID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 105;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Thread ID";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // tcBottom
            // 
            this.tcBottom.Controls.Add(this.tabPageMessageInfo);
            this.tcBottom.Controls.Add(this.tabPageBookmarks);
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedIndex = 0;
            this.tcBottom.Size = new System.Drawing.Size(1269, 236);
            this.tcBottom.TabIndex = 7;
            // 
            // tabPageMessageInfo
            // 
            this.tabPageMessageInfo.Controls.Add(this.tbMessageInfo);
            this.tabPageMessageInfo.Controls.Add(this.tsMessageInfo);
            this.tabPageMessageInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageMessageInfo.Name = "tabPageMessageInfo";
            this.tabPageMessageInfo.Size = new System.Drawing.Size(1261, 207);
            this.tabPageMessageInfo.TabIndex = 1;
            this.tabPageMessageInfo.Text = "Message Info";
            // 
            // tabPageBookmarks
            // 
            this.tabPageBookmarks.Controls.Add(this.sfDataGridBookmarks);
            this.tabPageBookmarks.Controls.Add(this.tsBookmark);
            this.tabPageBookmarks.Location = new System.Drawing.Point(4, 25);
            this.tabPageBookmarks.Name = "tabPageBookmarks";
            this.tabPageBookmarks.Size = new System.Drawing.Size(1261, 207);
            this.tabPageBookmarks.TabIndex = 2;
            this.tabPageBookmarks.Text = "Bookmarks";
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
            this.tabControlMain.Controls.Add(this.tabPageLogs);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1277, 618);
            this.tabControlMain.TabIndex = 27;
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.splitContainerMain);
            this.tabPageLogs.Controls.Add(this.pnlBottom);
            this.tabPageLogs.Controls.Add(this.tsTop);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Size = new System.Drawing.Size(1269, 589);
            this.tabPageLogs.TabIndex = 1;
            this.tabPageLogs.Text = "Logs";
            // 
            // tsTop
            // 
            this.tsTop.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTopClear,
            this.tsddbSave,
            this.tsddbUndock,
            this.tsbScreenshot,
            this.tsddbExport,
            this.tsBDataVisualizer});
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(1269, 27);
            this.tsTop.TabIndex = 5;
            // 
            // tsTopClear
            // 
            this.tsTopClear.Image = global::Analogy.Properties.Resources.Delete_16x16;
            this.tsTopClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTopClear.Name = "tsTopClear";
            this.tsTopClear.Size = new System.Drawing.Size(96, 24);
            this.tsTopClear.Text = "Clear Log";
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
            this.tsmiExportExcel.Size = new System.Drawing.Size(193, 26);
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
            this.spltcSources.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcSources)).EndInit();
            this.spltcSources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfoExclude)).EndInit();
            this.spltTextExclude.Panel1.ResumeLayout(false);
            this.spltTextExclude.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltTextExclude)).EndInit();
            this.spltTextExclude.ResumeLayout(false);
            this.spltText.Panel1.ResumeLayout(false);
            this.spltText.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltText)).EndInit();
            this.spltText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).EndInit();
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
            this.tcBottom.ResumeLayout(false);
            this.tabPageMessageInfo.ResumeLayout(false);
            this.tabPageMessageInfo.PerformLayout();
            this.tabPageBookmarks.ResumeLayout(false);
            this.tabPageBookmarks.PerformLayout();
            this.cmsBookmarked.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageLogs.ResumeLayout(false);
            this.tabPageLogs.PerformLayout();
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList;
        private Panel pnlTopFiltering;
        private CheckBox chkbIncludeText;
        private CheckBox chkExclude;
        private ProgressBar progressBar1;
        private ContextMenuStrip cmsMessageOperation;
        private ToolStripMenuItem tsmiCopy;
        private ToolStripMenuItem tsmiEmail;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmiExclude;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsmiOTAFull;
        private Timer tmrNewData;
        private PictureBox pboxInfo;
        private PictureBox pboxInfoExclude;
        private ImageList imageListBottom;
        private ToolStripMenuItem tsmiBookmark;
        private ToolStripMenuItem tsmiAddCommentToMessage;
        private Panel panel1;
        private CheckBox chkbHighlight;
        private ToolStripMenuItem tsmiExcludeSource;
        private ToolStripMenuItem tsmiExcludeModule;
        private Panel pnlButtonsHighlight;
        private Panel pnlBottom;
        private ToolStripMenuItem tsmiTimeDiff;
        private ToolStripSeparator toolStripSeparator4;
        private SplitContainer spltFilteringBoth;
        private Panel pnlFilteringLeft;
        private Button sBtnMostCommon;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiSaveLayout;
        private ToolStripMenuItem tsmiBookmarkPersist;
        private ContextMenuStrip cmsBookmarked;
        private ToolStripMenuItem tsmiCalcDiffBookmark;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem tsmiRemoveBookmark;
        private ToolStripMenuItem tsmiCopyBookmark;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem tsmiExcludeBookmark;
        private ToolStripMenuItem tsmiExcludeSourceBookmark;
        private ToolStripMenuItem tsmiExcludeModuleBookmark;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem tsmiEmailBookmark;
        private ToolStripMenuItem tsmiOTAFullBookmark;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem tsmiSaveLayoutBookmark;
        private Button btnCancel;
        private ToolStripMenuItem tsmiCopyMessages;
        private ToolStripMenuItem tsmiCopyMessagesBookmark;
        private SplitContainer splitContainerMain;
        private Button btnPageFirst;
        private Button btnPageNext;
        private Button btnLastPage;
        private Button btnPagePrevious;
        private ToolStripMenuItem tsmiIncreaseFont;
        private ToolStripMenuItem tsmiDecreaseFont;
        private ToolStripMenuItem tsmiIncreaseFontBookmark;
        private ToolStripMenuItem tsmiDecreaseFontBookmark;
        private ToolStripMenuItem tsmiClearLog;
        private ToolStripMenuItem tsmiREmoveAllPreviousMessages;
        private SplitContainer spltText;
        private Button btnTextInclude;
        private SplitContainer spltTextExclude;
        private Button btnTextExclude;
        private SplitContainer spltcSources;
        private Button btnSources;
        private CheckBox chkbSources;
        private SplitContainer spltcProcessesModule;
        private CheckBox chkbModules;
        private Button btnModules;
        private Button sbtnUndockPerProcess;
        private SplitContainer spltcDateFiltering;
        private CheckBox chkDateNewerThan;
        private PictureBox pictureBox1;
        private CheckBox chkDateOlderThan;
        private ToolStripMenuItem tsmiDateFilterNewer;
        private ToolStripMenuItem tsmiDateFilterOlder;
        private ToolStripMenuItem tsmiBookmarkDateFilterNewer;
        private ToolStripMenuItem tsmiBookmarkDateFilterOlder;
        private Button sbtnMoreHighlight;
        private Button sbtnPreDefinedFilters;
        private ContextMenuStrip contextMenuStripFilters;
        private DataGridView sfDataGridMain;
        private ComboBox cbInclude;
        private Panel pnlMessages;
        private ComboBox cbExclude;
        private ComboBox cbModule;
        private ComboBox cbSource;
        private RadioButton rbAllLevel;
        private RadioButton rbVerbose;
        private RadioButton rbDebug;
        private RadioButton rbWarning;
        private RadioButton rbErrorCritical;
        private RadioButton rbTrace;
        private Label lblPageNumber;
        private Label lblTotalMessagesAlert;
        private Label lblTotalMessages;
        private ComboBox cbHighlights;
        private ToolStrip tsMessageInfo;
        private ToolStripButton tsBtnMessageInfoCopy;
        private ToolStrip tsBookmark;
        private ToolStripButton tsBtnBookmarkCopySingle;
        private ToolStripButton tsBtnBookmarkCopyAll;
        private DataGridView sfDataGridBookmarks;
        private ToolStripButton tsBtnBookmarkClear;
        private ToolStripButton tsBtnBookmarkGoToOriginal;
        private RichTextBox tbMessageInfo;
        private DateTimePicker deOlderThanFilter;
        private DateTimePicker deNewerThanFilter;
        private TabControl tabControlMain;
        private TabPage tabPageLogs;
        private ToolStrip tsTop;
        private ToolStripButton tsTopClear;
        private ToolStripDropDownButton tsddbSave;
        private ToolStripMenuItem tsmiSaveFullLog;
        private ToolStripMenuItem tsmiSaveFullLogDataProvider;
        private ToolStripMenuItem tsmiSaveFullLogAnalogy;
        private ToolStripMenuItem saveCurrentViewToolStripMenuItem;
        private ToolStripMenuItem tsmiSaveCurrentViewDataProvider;
        private ToolStripMenuItem tsmiSaveCurrentViewAnalogy;
        private ToolStripDropDownButton tsddbUndock;
        private ToolStripMenuItem tsmiUndockView;
        private ToolStripMenuItem tsmiUndockPerModule;
        private ToolStripButton tsbScreenshot;
        private ToolStripDropDownButton tsddbExport;
        private ToolStripMenuItem tsmiExportExcel;
        private ToolStripButton tsBDataVisualizer;
        private TabControl tcBottom;
        private TabPage tabPageMessageInfo;
        private TabPage tabPageBookmarks;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}

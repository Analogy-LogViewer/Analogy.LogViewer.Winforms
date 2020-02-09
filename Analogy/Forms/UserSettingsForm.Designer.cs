using System.ComponentModel;
using System.Windows.Forms;

namespace Analogy
{
    partial class UserSettingsForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsForm));
            this.nudPageLength = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteHighlight = new System.Windows.Forms.Button();
            this.sbtnAddHighlight = new System.Windows.Forms.Button();
            this.rbtnHighlightEquals = new System.Windows.Forms.RadioButton();
            this.rbtnHighlightContains = new System.Windows.Forms.RadioButton();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.lblExplaination = new System.Windows.Forms.Label();
            this.lblModules = new System.Windows.Forms.Label();
            this.lblSources = new System.Windows.Forms.Label();
            this.lblExcludeMessageText = new System.Windows.Forms.Label();
            this.lblIncludeText = new System.Windows.Forms.Label();
            this.btnDeleteAlerts = new System.Windows.Forms.Button();
            this.btnAddAlerts = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImportColors = new System.Windows.Forms.Button();
            this.btnExportColors = new System.Windows.Forms.Button();
            this.btnClearStatistics = new System.Windows.Forms.Button();
            this.clExtensionslItems = new System.Windows.Forms.CheckedListBox();
            this.nudRecent = new System.Windows.Forms.NumericUpDown();
            this.nudIdleTime = new System.Windows.Forms.NumericUpDown();
            this.chkLstDataProviderStatus = new System.Windows.Forms.CheckedListBox();
            this.chkLstItemRealTimeDataSources = new System.Windows.Forms.CheckedListBox();
            this.cbDataProviderAssociation = new System.Windows.Forms.ComboBox();
            this.btnSetFileAssociation = new System.Windows.Forms.Button();
            this.txtbDataProviderAssociation = new System.Windows.Forms.TextBox();
            this.btnDataProviderCustomSettings = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.gbFilteringSettings = new System.Windows.Forms.GroupBox();
            this.cbPaging = new System.Windows.Forms.CheckBox();
            this.tbFileCaching = new System.Windows.Forms.CheckBox();
            this.cbSearchAlsoInSourceAndModule = new System.Windows.Forms.CheckBox();
            this.tbHistory = new System.Windows.Forms.CheckBox();
            this.tbAutoComplete = new System.Windows.Forms.CheckBox();
            this.tbErrorLevelAsDefault = new System.Windows.Forms.CheckBox();
            this.tbDataTimeAscendDescend = new System.Windows.Forms.CheckBox();
            this.tbFilteringLastEntries = new System.Windows.Forms.CheckBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage10 = new System.Windows.Forms.TabPage();
            this.gbHighlight = new System.Windows.Forms.GroupBox();
            this.tbHighlighColor = new System.Windows.Forms.TextBox();
            this.sfBtnPreDefinedSelectColor = new System.Windows.Forms.Button();
            this.lblHighlightColorSelection = new System.Windows.Forms.Label();
            this.tbHighlightEquals = new System.Windows.Forms.TextBox();
            this.tbHighlightContains = new System.Windows.Forms.TextBox();
            this.lboxHighlightItems = new System.Windows.Forms.ListBox();
            this.TabPage11 = new System.Windows.Forms.TabPage();
            this.lboxFilters = new System.Windows.Forms.ListBox();
            this.tbModulesFilter = new System.Windows.Forms.TextBox();
            this.tbSourcesFilter = new System.Windows.Forms.TextBox();
            this.tbExcludeFilter = new System.Windows.Forms.TextBox();
            this.tbIncludeTextFilter = new System.Windows.Forms.TextBox();
            this.TabPage12 = new System.Windows.Forms.TabPage();
            this.tbModulesAlert = new System.Windows.Forms.TextBox();
            this.tbSourcesAlert = new System.Windows.Forms.TextBox();
            this.tbExcludeAlert = new System.Windows.Forms.TextBox();
            this.tbIncludeTextAlert = new System.Windows.Forms.TextBox();
            this.lboxAlerts = new System.Windows.Forms.ListBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.sfBtnHighlightColor = new System.Windows.Forms.Button();
            this.tbHighlightColor = new System.Windows.Forms.TextBox();
            this.lblHighlightColor = new System.Windows.Forms.Label();
            this.gpLogLevelColors = new System.Windows.Forms.GroupBox();
            this.sfBtnLogLevelAnalogyInformation = new System.Windows.Forms.Button();
            this.sfBtnLogLevelCritical = new System.Windows.Forms.Button();
            this.sfBtnLogLevelError = new System.Windows.Forms.Button();
            this.sfBtnLogLevelWarning = new System.Windows.Forms.Button();
            this.sfBtnLogLevelVerbose = new System.Windows.Forms.Button();
            this.sfBtnLogLevelEvent = new System.Windows.Forms.Button();
            this.sfBtnLogLevelTrace = new System.Windows.Forms.Button();
            this.sfBtnLogLevelDebug = new System.Windows.Forms.Button();
            this.sfBtnLogLevelDisabled = new System.Windows.Forms.Button();
            this.sfBtnLogLevelUnknown = new System.Windows.Forms.Button();
            this.tbLogLevelAnalogyInformation = new System.Windows.Forms.TextBox();
            this.tbLogLevelCritical = new System.Windows.Forms.TextBox();
            this.lblLogLevelAnalogyInformation = new System.Windows.Forms.Label();
            this.lblLogLevelCritical = new System.Windows.Forms.Label();
            this.tbLogLevelError = new System.Windows.Forms.TextBox();
            this.tbLogLevelWarning = new System.Windows.Forms.TextBox();
            this.lblLogLevelError = new System.Windows.Forms.Label();
            this.lblLogLevelWarning = new System.Windows.Forms.Label();
            this.tbLogLevelEvent = new System.Windows.Forms.TextBox();
            this.tbLogLevelDebug = new System.Windows.Forms.TextBox();
            this.lblLogLevelEvent = new System.Windows.Forms.Label();
            this.lblLogLevelDebug = new System.Windows.Forms.Label();
            this.tbLogLevelVerbose = new System.Windows.Forms.TextBox();
            this.tbLogLevelTrace = new System.Windows.Forms.TextBox();
            this.lblLogLevelVerbose = new System.Windows.Forms.Label();
            this.lblLogLevelTrace = new System.Windows.Forms.Label();
            this.tbLogLevelDisabled = new System.Windows.Forms.TextBox();
            this.tbLogLevelUnknown = new System.Windows.Forms.TextBox();
            this.lblLogLevelDisabled = new System.Windows.Forms.Label();
            this.lblLogLevelUnknown = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.tbUserStatistics = new System.Windows.Forms.CheckBox();
            this.lblOpenedFiles = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblLaunchCount = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.tbExtensionsStartup = new System.Windows.Forms.CheckBox();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.TabPage8 = new System.Windows.Forms.TabPage();
            this.tbIdleMode = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TabPage9 = new System.Windows.Forms.TabPage();
            this.TabControl3 = new System.Windows.Forms.TabControl();
            this.TabPage13 = new System.Windows.Forms.TabPage();
            this.tbRememberLastOpenedDataProvider = new System.Windows.Forms.CheckBox();
            this.TabPage14 = new System.Windows.Forms.TabPage();
            this.TabPage15 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.TabPage16 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdleTime)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.gbFilteringSettings.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage10.SuspendLayout();
            this.gbHighlight.SuspendLayout();
            this.TabPage11.SuspendLayout();
            this.TabPage12.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.gpLogLevelColors.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.TabPage8.SuspendLayout();
            this.TabPage9.SuspendLayout();
            this.TabControl3.SuspendLayout();
            this.TabPage13.SuspendLayout();
            this.TabPage14.SuspendLayout();
            this.TabPage15.SuspendLayout();
            this.TabPage16.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudPageLength
            // 
            this.nudPageLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPageLength.Location = new System.Drawing.Point(845, 165);
            this.nudPageLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPageLength.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nudPageLength.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPageLength.Name = "nudPageLength";
            this.nudPageLength.Size = new System.Drawing.Size(178, 22);
            this.nudPageLength.TabIndex = 4;
            this.nudPageLength.Value = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            // 
            // btnDeleteHighlight
            // 
            this.btnDeleteHighlight.AccessibleName = "Button";
            this.btnDeleteHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteHighlight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteHighlight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHighlight.Location = new System.Drawing.Point(840, 437);
            this.btnDeleteHighlight.Name = "btnDeleteHighlight";
            this.btnDeleteHighlight.Size = new System.Drawing.Size(126, 27);
            this.btnDeleteHighlight.TabIndex = 7;
            this.btnDeleteHighlight.Text = "Delete";
            // 
            // sbtnAddHighlight
            // 
            this.sbtnAddHighlight.AccessibleName = "Button";
            this.sbtnAddHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnAddHighlight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sbtnAddHighlight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnAddHighlight.Location = new System.Drawing.Point(831, 141);
            this.sbtnAddHighlight.Name = "sbtnAddHighlight";
            this.sbtnAddHighlight.Size = new System.Drawing.Size(126, 27);
            this.sbtnAddHighlight.TabIndex = 6;
            this.sbtnAddHighlight.Text = "Add";
            this.sbtnAddHighlight.Click += new System.EventHandler(this.sbtnAddHighlight_Click);
            // 
            // rbtnHighlightEquals
            // 
            this.rbtnHighlightEquals.AutoSize = true;
            this.rbtnHighlightEquals.Location = new System.Drawing.Point(6, 71);
            this.rbtnHighlightEquals.Name = "rbtnHighlightEquals";
            this.rbtnHighlightEquals.Size = new System.Drawing.Size(168, 21);
            this.rbtnHighlightEquals.TabIndex = 1;
            this.rbtnHighlightEquals.Text = "Message Text Equals:";
            this.rbtnHighlightEquals.UseVisualStyleBackColor = true;
            this.rbtnHighlightEquals.CheckedChanged += new System.EventHandler(this.rbtnHighlightEquals_CheckedChanged);
            // 
            // rbtnHighlightContains
            // 
            this.rbtnHighlightContains.AutoSize = true;
            this.rbtnHighlightContains.Checked = true;
            this.rbtnHighlightContains.Location = new System.Drawing.Point(6, 38);
            this.rbtnHighlightContains.Name = "rbtnHighlightContains";
            this.rbtnHighlightContains.Size = new System.Drawing.Size(180, 21);
            this.rbtnHighlightContains.TabIndex = 0;
            this.rbtnHighlightContains.TabStop = true;
            this.rbtnHighlightContains.Text = "Message Text Contains:";
            this.rbtnHighlightContains.UseVisualStyleBackColor = true;
            this.rbtnHighlightContains.CheckedChanged += new System.EventHandler(this.rbtnHighlightContains_CheckedChanged);
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.AccessibleName = "Button";
            this.btnDeleteFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFilter.Location = new System.Drawing.Point(636, 455);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(126, 27);
            this.btnDeleteFilter.TabIndex = 38;
            this.btnDeleteFilter.Text = "Delete";
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.AccessibleName = "Button";
            this.btnAddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilter.Location = new System.Drawing.Point(666, 127);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(96, 27);
            this.btnAddFilter.TabIndex = 36;
            this.btnAddFilter.Text = "Add";
            // 
            // lblExplaination
            // 
            this.lblExplaination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExplaination.AutoEllipsis = true;
            this.lblExplaination.Location = new System.Drawing.Point(3, 162);
            this.lblExplaination.Name = "lblExplaination";
            this.lblExplaination.Size = new System.Drawing.Size(759, 87);
            this.lblExplaination.TabIndex = 35;
            this.lblExplaination.Text = resources.GetString("lblExplaination.Text");
            // 
            // lblModules
            // 
            this.lblModules.AutoEllipsis = true;
            this.lblModules.Location = new System.Drawing.Point(3, 97);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(217, 22);
            this.lblModules.TabIndex = 34;
            this.lblModules.Text = "Processes/Modules:";
            // 
            // lblSources
            // 
            this.lblSources.AutoEllipsis = true;
            this.lblSources.Location = new System.Drawing.Point(3, 68);
            this.lblSources.Name = "lblSources";
            this.lblSources.Size = new System.Drawing.Size(217, 22);
            this.lblSources.TabIndex = 33;
            this.lblSources.Text = "Sources";
            // 
            // lblExcludeMessageText
            // 
            this.lblExcludeMessageText.AutoEllipsis = true;
            this.lblExcludeMessageText.Location = new System.Drawing.Point(3, 38);
            this.lblExcludeMessageText.Name = "lblExcludeMessageText";
            this.lblExcludeMessageText.Size = new System.Drawing.Size(217, 22);
            this.lblExcludeMessageText.TabIndex = 32;
            this.lblExcludeMessageText.Text = "Exclude Message\'s text";
            // 
            // lblIncludeText
            // 
            this.lblIncludeText.AutoEllipsis = true;
            this.lblIncludeText.Location = new System.Drawing.Point(3, 9);
            this.lblIncludeText.Name = "lblIncludeText";
            this.lblIncludeText.Size = new System.Drawing.Size(217, 22);
            this.lblIncludeText.TabIndex = 31;
            this.lblIncludeText.Text = "Message\'s text";
            // 
            // btnDeleteAlerts
            // 
            this.btnDeleteAlerts.AccessibleName = "Button";
            this.btnDeleteAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAlerts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteAlerts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAlerts.Location = new System.Drawing.Point(636, 455);
            this.btnDeleteAlerts.Name = "btnDeleteAlerts";
            this.btnDeleteAlerts.Size = new System.Drawing.Size(126, 27);
            this.btnDeleteAlerts.TabIndex = 46;
            this.btnDeleteAlerts.Text = "Delete";
            // 
            // btnAddAlerts
            // 
            this.btnAddAlerts.AccessibleName = "Button";
            this.btnAddAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAlerts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddAlerts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlerts.Location = new System.Drawing.Point(666, 127);
            this.btnAddAlerts.Name = "btnAddAlerts";
            this.btnAddAlerts.Size = new System.Drawing.Size(96, 27);
            this.btnAddAlerts.TabIndex = 44;
            this.btnAddAlerts.Text = "Add";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.Location = new System.Drawing.Point(3, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(759, 87);
            this.label5.TabIndex = 43;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Processes/Modules:";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Sources";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Exclude Message\'s text";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Message\'s text";
            // 
            // btnImportColors
            // 
            this.btnImportColors.AccessibleName = "Button";
            this.btnImportColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportColors.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImportColors.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportColors.Location = new System.Drawing.Point(163, 462);
            this.btnImportColors.Name = "btnImportColors";
            this.btnImportColors.Size = new System.Drawing.Size(153, 32);
            this.btnImportColors.TabIndex = 23;
            this.btnImportColors.Text = "Import Colors";
            this.btnImportColors.Click += new System.EventHandler(this.sBtnImportColors_Click);
            // 
            // btnExportColors
            // 
            this.btnExportColors.AccessibleName = "Button";
            this.btnExportColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportColors.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportColors.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportColors.Location = new System.Drawing.Point(3, 462);
            this.btnExportColors.Name = "btnExportColors";
            this.btnExportColors.Size = new System.Drawing.Size(153, 32);
            this.btnExportColors.TabIndex = 22;
            this.btnExportColors.Text = "Export Colors";
            // 
            // btnClearStatistics
            // 
            this.btnClearStatistics.AccessibleName = "Button";
            this.btnClearStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearStatistics.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearStatistics.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStatistics.Location = new System.Drawing.Point(697, 72);
            this.btnClearStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearStatistics.Name = "btnClearStatistics";
            this.btnClearStatistics.Size = new System.Drawing.Size(110, 33);
            this.btnClearStatistics.TabIndex = 0;
            this.btnClearStatistics.Text = "Clear";
            // 
            // clExtensionslItems
            // 
            this.clExtensionslItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clExtensionslItems.CheckOnClick = true;
            this.clExtensionslItems.FormattingEnabled = true;
            this.clExtensionslItems.Location = new System.Drawing.Point(3, 44);
            this.clExtensionslItems.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.clExtensionslItems.Name = "clExtensionslItems";
            this.clExtensionslItems.Size = new System.Drawing.Size(809, 429);
            this.clExtensionslItems.TabIndex = 6;
            // 
            // nudRecent
            // 
            this.nudRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRecent.Location = new System.Drawing.Point(301, 18);
            this.nudRecent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRecent.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudRecent.Name = "nudRecent";
            this.nudRecent.Size = new System.Drawing.Size(83, 22);
            this.nudRecent.TabIndex = 2;
            this.nudRecent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudIdleTime
            // 
            this.nudIdleTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIdleTime.Location = new System.Drawing.Point(364, 49);
            this.nudIdleTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudIdleTime.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudIdleTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIdleTime.Name = "nudIdleTime";
            this.nudIdleTime.Size = new System.Drawing.Size(310, 22);
            this.nudIdleTime.TabIndex = 7;
            this.nudIdleTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // chkLstDataProviderStatus
            // 
            this.chkLstDataProviderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstDataProviderStatus.FormattingEnabled = true;
            this.chkLstDataProviderStatus.Location = new System.Drawing.Point(0, 22);
            this.chkLstDataProviderStatus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.chkLstDataProviderStatus.Name = "chkLstDataProviderStatus";
            this.chkLstDataProviderStatus.Size = new System.Drawing.Size(969, 424);
            this.chkLstDataProviderStatus.TabIndex = 10;
            // 
            // chkLstItemRealTimeDataSources
            // 
            this.chkLstItemRealTimeDataSources.CheckOnClick = true;
            this.chkLstItemRealTimeDataSources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstItemRealTimeDataSources.FormattingEnabled = true;
            this.chkLstItemRealTimeDataSources.Location = new System.Drawing.Point(0, 0);
            this.chkLstItemRealTimeDataSources.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.chkLstItemRealTimeDataSources.Name = "chkLstItemRealTimeDataSources";
            this.chkLstItemRealTimeDataSources.Size = new System.Drawing.Size(773, 489);
            this.chkLstItemRealTimeDataSources.TabIndex = 8;
            this.chkLstItemRealTimeDataSources.SelectedIndexChanged += new System.EventHandler(this.ChkLstItemRealTimeDataSources_SelectedIndexChanged);
            // 
            // cbDataProviderAssociation
            // 
            this.cbDataProviderAssociation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataProviderAssociation.FormattingEnabled = true;
            this.cbDataProviderAssociation.Location = new System.Drawing.Point(3, 3);
            this.cbDataProviderAssociation.Name = "cbDataProviderAssociation";
            this.cbDataProviderAssociation.Size = new System.Drawing.Size(758, 24);
            this.cbDataProviderAssociation.TabIndex = 4;
            this.cbDataProviderAssociation.SelectedIndexChanged += new System.EventHandler(this.cbDataProviderAssociation_SelectedIndexChanged);
            // 
            // btnSetFileAssociation
            // 
            this.btnSetFileAssociation.AccessibleName = "Button";
            this.btnSetFileAssociation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetFileAssociation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetFileAssociation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFileAssociation.Location = new System.Drawing.Point(690, 47);
            this.btnSetFileAssociation.Name = "btnSetFileAssociation";
            this.btnSetFileAssociation.Size = new System.Drawing.Size(61, 33);
            this.btnSetFileAssociation.TabIndex = 3;
            this.btnSetFileAssociation.Text = "set";
            this.btnSetFileAssociation.Click += new System.EventHandler(this.btnSetFileAssociation_Click);
            // 
            // txtbDataProviderAssociation
            // 
            this.txtbDataProviderAssociation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDataProviderAssociation.Location = new System.Drawing.Point(327, 53);
            this.txtbDataProviderAssociation.Name = "txtbDataProviderAssociation";
            this.txtbDataProviderAssociation.Size = new System.Drawing.Size(357, 22);
            this.txtbDataProviderAssociation.TabIndex = 1;
            // 
            // btnDataProviderCustomSettings
            // 
            this.btnDataProviderCustomSettings.AccessibleName = "Button";
            this.btnDataProviderCustomSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDataProviderCustomSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDataProviderCustomSettings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataProviderCustomSettings.Location = new System.Drawing.Point(193, 12);
            this.btnDataProviderCustomSettings.Name = "btnDataProviderCustomSettings";
            this.btnDataProviderCustomSettings.Size = new System.Drawing.Size(347, 29);
            this.btnDataProviderCustomSettings.TabIndex = 0;
            this.btnDataProviderCustomSettings.Text = "Open Data Providers custom settings";
            this.btnDataProviderCustomSettings.Click += new System.EventHandler(this.btnDataProviderCustomSettings_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.TabPage1);
            this.tabControlMain.Controls.Add(this.TabPage2);
            this.tabControlMain.Controls.Add(this.TabPage3);
            this.tabControlMain.Controls.Add(this.TabPage4);
            this.tabControlMain.Controls.Add(this.TabPage5);
            this.tabControlMain.Controls.Add(this.TabPage6);
            this.tabControlMain.Controls.Add(this.TabPage7);
            this.tabControlMain.Controls.Add(this.TabPage8);
            this.tabControlMain.Controls.Add(this.TabPage9);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1037, 525);
            this.tabControlMain.TabIndex = 1;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.gbFilteringSettings);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(1029, 496);
            this.TabPage1.TabIndex = 1;
            this.TabPage1.Text = "Filtering and Interactions";
            // 
            // gbFilteringSettings
            // 
            this.gbFilteringSettings.Controls.Add(this.cbPaging);
            this.gbFilteringSettings.Controls.Add(this.tbFileCaching);
            this.gbFilteringSettings.Controls.Add(this.cbSearchAlsoInSourceAndModule);
            this.gbFilteringSettings.Controls.Add(this.tbHistory);
            this.gbFilteringSettings.Controls.Add(this.tbAutoComplete);
            this.gbFilteringSettings.Controls.Add(this.tbErrorLevelAsDefault);
            this.gbFilteringSettings.Controls.Add(this.tbDataTimeAscendDescend);
            this.gbFilteringSettings.Controls.Add(this.tbFilteringLastEntries);
            this.gbFilteringSettings.Controls.Add(this.nudPageLength);
            this.gbFilteringSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilteringSettings.Location = new System.Drawing.Point(0, 0);
            this.gbFilteringSettings.Name = "gbFilteringSettings";
            this.gbFilteringSettings.Size = new System.Drawing.Size(1029, 496);
            this.gbFilteringSettings.TabIndex = 5;
            this.gbFilteringSettings.TabStop = false;
            this.gbFilteringSettings.Text = "Filtering, search and interaction of messages area";
            // 
            // cbPaging
            // 
            this.cbPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaging.Location = new System.Drawing.Point(6, 165);
            this.cbPaging.Name = "cbPaging";
            this.cbPaging.Size = new System.Drawing.Size(818, 22);
            this.cbPaging.TabIndex = 19;
            this.cbPaging.Text = "Enable Paging (number of rows per page):";
            this.cbPaging.UseVisualStyleBackColor = true;
            // 
            // tbFileCaching
            // 
            this.tbFileCaching.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileCaching.Location = new System.Drawing.Point(6, 221);
            this.tbFileCaching.Name = "tbFileCaching";
            this.tbFileCaching.Size = new System.Drawing.Size(1010, 22);
            this.tbFileCaching.TabIndex = 19;
            this.tbFileCaching.Text = "Use Caching of loaded Files";
            this.tbFileCaching.UseVisualStyleBackColor = true;
            // 
            // cbSearchAlsoInSourceAndModule
            // 
            this.cbSearchAlsoInSourceAndModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchAlsoInSourceAndModule.Location = new System.Drawing.Point(6, 193);
            this.cbSearchAlsoInSourceAndModule.Name = "cbSearchAlsoInSourceAndModule";
            this.cbSearchAlsoInSourceAndModule.Size = new System.Drawing.Size(1010, 22);
            this.cbSearchAlsoInSourceAndModule.TabIndex = 19;
            this.cbSearchAlsoInSourceAndModule.Text = "Search text also in Source and Module/Process columns";
            this.cbSearchAlsoInSourceAndModule.UseVisualStyleBackColor = true;
            // 
            // tbHistory
            // 
            this.tbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHistory.Location = new System.Drawing.Point(6, 137);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(1010, 22);
            this.tbHistory.TabIndex = 19;
            this.tbHistory.Text = "Show history of cleared Messages";
            this.tbHistory.UseVisualStyleBackColor = true;
            // 
            // tbAutoComplete
            // 
            this.tbAutoComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAutoComplete.Location = new System.Drawing.Point(6, 109);
            this.tbAutoComplete.Name = "tbAutoComplete";
            this.tbAutoComplete.Size = new System.Drawing.Size(1010, 22);
            this.tbAutoComplete.TabIndex = 19;
            this.tbAutoComplete.Text = "Save excluded filtering text for next startup";
            this.tbAutoComplete.UseVisualStyleBackColor = true;
            // 
            // tbErrorLevelAsDefault
            // 
            this.tbErrorLevelAsDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbErrorLevelAsDefault.Location = new System.Drawing.Point(6, 81);
            this.tbErrorLevelAsDefault.Name = "tbErrorLevelAsDefault";
            this.tbErrorLevelAsDefault.Size = new System.Drawing.Size(1010, 22);
            this.tbErrorLevelAsDefault.TabIndex = 19;
            this.tbErrorLevelAsDefault.Text = "Start logs with Error and Critical  level as default filtering";
            this.tbErrorLevelAsDefault.UseVisualStyleBackColor = true;
            // 
            // tbDataTimeAscendDescend
            // 
            this.tbDataTimeAscendDescend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDataTimeAscendDescend.Location = new System.Drawing.Point(6, 55);
            this.tbDataTimeAscendDescend.Name = "tbDataTimeAscendDescend";
            this.tbDataTimeAscendDescend.Size = new System.Drawing.Size(1010, 22);
            this.tbDataTimeAscendDescend.TabIndex = 19;
            this.tbDataTimeAscendDescend.Text = "Default sort is by descending date (new messages are at the top)";
            this.tbDataTimeAscendDescend.UseVisualStyleBackColor = true;
            // 
            // tbFilteringLastEntries
            // 
            this.tbFilteringLastEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilteringLastEntries.Location = new System.Drawing.Point(6, 27);
            this.tbFilteringLastEntries.Name = "tbFilteringLastEntries";
            this.tbFilteringLastEntries.Size = new System.Drawing.Size(1010, 22);
            this.tbFilteringLastEntries.TabIndex = 19;
            this.tbFilteringLastEntries.Text = "Remember last filters Input";
            this.tbFilteringLastEntries.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.TabControl2);
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(977, 496);
            this.TabPage2.TabIndex = 2;
            this.TabPage2.Text = "Pre-Defined Queries";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage10);
            this.TabControl2.Controls.Add(this.TabPage11);
            this.TabControl2.Controls.Add(this.TabPage12);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(977, 496);
            this.TabControl2.TabIndex = 0;
            // 
            // TabPage10
            // 
            this.TabPage10.Controls.Add(this.gbHighlight);
            this.TabPage10.Controls.Add(this.lboxHighlightItems);
            this.TabPage10.Controls.Add(this.btnDeleteHighlight);
            this.TabPage10.Location = new System.Drawing.Point(4, 25);
            this.TabPage10.Name = "TabPage10";
            this.TabPage10.Size = new System.Drawing.Size(969, 467);
            this.TabPage10.TabIndex = 1;
            this.TabPage10.Text = "Color Highlighting";
            // 
            // gbHighlight
            // 
            this.gbHighlight.Controls.Add(this.tbHighlighColor);
            this.gbHighlight.Controls.Add(this.sfBtnPreDefinedSelectColor);
            this.gbHighlight.Controls.Add(this.lblHighlightColorSelection);
            this.gbHighlight.Controls.Add(this.rbtnHighlightContains);
            this.gbHighlight.Controls.Add(this.tbHighlightEquals);
            this.gbHighlight.Controls.Add(this.rbtnHighlightEquals);
            this.gbHighlight.Controls.Add(this.tbHighlightContains);
            this.gbHighlight.Controls.Add(this.sbtnAddHighlight);
            this.gbHighlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHighlight.Location = new System.Drawing.Point(0, 0);
            this.gbHighlight.Name = "gbHighlight";
            this.gbHighlight.Size = new System.Drawing.Size(969, 200);
            this.gbHighlight.TabIndex = 10;
            this.gbHighlight.TabStop = false;
            this.gbHighlight.Text = "Highlight definitions";
            // 
            // tbHighlighColor
            // 
            this.tbHighlighColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHighlighColor.Location = new System.Drawing.Point(202, 102);
            this.tbHighlighColor.Name = "tbHighlighColor";
            this.tbHighlighColor.Size = new System.Drawing.Size(623, 22);
            this.tbHighlighColor.TabIndex = 11;
            // 
            // sfBtnPreDefinedSelectColor
            // 
            this.sfBtnPreDefinedSelectColor.AccessibleName = "Button";
            this.sfBtnPreDefinedSelectColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnPreDefinedSelectColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnPreDefinedSelectColor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnPreDefinedSelectColor.Location = new System.Drawing.Point(831, 99);
            this.sfBtnPreDefinedSelectColor.Name = "sfBtnPreDefinedSelectColor";
            this.sfBtnPreDefinedSelectColor.Size = new System.Drawing.Size(126, 27);
            this.sfBtnPreDefinedSelectColor.TabIndex = 10;
            this.sfBtnPreDefinedSelectColor.Text = "Select";
            // 
            // lblHighlightColorSelection
            // 
            this.lblHighlightColorSelection.AutoSize = true;
            this.lblHighlightColorSelection.Location = new System.Drawing.Point(6, 109);
            this.lblHighlightColorSelection.Name = "lblHighlightColorSelection";
            this.lblHighlightColorSelection.Size = new System.Drawing.Size(45, 17);
            this.lblHighlightColorSelection.TabIndex = 9;
            this.lblHighlightColorSelection.Text = "Color:";
            // 
            // tbHighlightEquals
            // 
            this.tbHighlightEquals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHighlightEquals.Location = new System.Drawing.Point(202, 71);
            this.tbHighlightEquals.Name = "tbHighlightEquals";
            this.tbHighlightEquals.Size = new System.Drawing.Size(755, 22);
            this.tbHighlightEquals.TabIndex = 8;
            // 
            // tbHighlightContains
            // 
            this.tbHighlightContains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHighlightContains.Location = new System.Drawing.Point(202, 38);
            this.tbHighlightContains.Name = "tbHighlightContains";
            this.tbHighlightContains.Size = new System.Drawing.Size(755, 22);
            this.tbHighlightContains.TabIndex = 7;
            // 
            // lboxHighlightItems
            // 
            this.lboxHighlightItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxHighlightItems.FormattingEnabled = true;
            this.lboxHighlightItems.ItemHeight = 16;
            this.lboxHighlightItems.Location = new System.Drawing.Point(6, 206);
            this.lboxHighlightItems.Name = "lboxHighlightItems";
            this.lboxHighlightItems.Size = new System.Drawing.Size(960, 196);
            this.lboxHighlightItems.TabIndex = 7;
            // 
            // TabPage11
            // 
            this.TabPage11.Controls.Add(this.lboxFilters);
            this.TabPage11.Controls.Add(this.tbModulesFilter);
            this.TabPage11.Controls.Add(this.tbSourcesFilter);
            this.TabPage11.Controls.Add(this.tbExcludeFilter);
            this.TabPage11.Controls.Add(this.tbIncludeTextFilter);
            this.TabPage11.Controls.Add(this.btnDeleteFilter);
            this.TabPage11.Controls.Add(this.lblIncludeText);
            this.TabPage11.Controls.Add(this.btnAddFilter);
            this.TabPage11.Controls.Add(this.lblExplaination);
            this.TabPage11.Controls.Add(this.lblModules);
            this.TabPage11.Controls.Add(this.lblSources);
            this.TabPage11.Controls.Add(this.lblExcludeMessageText);
            this.TabPage11.Location = new System.Drawing.Point(4, 25);
            this.TabPage11.Name = "TabPage11";
            this.TabPage11.Size = new System.Drawing.Size(773, 489);
            this.TabPage11.TabIndex = 2;
            this.TabPage11.Text = "Filters";
            // 
            // lboxFilters
            // 
            this.lboxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxFilters.FormattingEnabled = true;
            this.lboxFilters.ItemHeight = 16;
            this.lboxFilters.Location = new System.Drawing.Point(5, 252);
            this.lboxFilters.Name = "lboxFilters";
            this.lboxFilters.Size = new System.Drawing.Size(764, 164);
            this.lboxFilters.TabIndex = 40;
            // 
            // tbModulesFilter
            // 
            this.tbModulesFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModulesFilter.Location = new System.Drawing.Point(226, 93);
            this.tbModulesFilter.Name = "tbModulesFilter";
            this.tbModulesFilter.Size = new System.Drawing.Size(535, 22);
            this.tbModulesFilter.TabIndex = 39;
            // 
            // tbSourcesFilter
            // 
            this.tbSourcesFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSourcesFilter.Location = new System.Drawing.Point(227, 65);
            this.tbSourcesFilter.Name = "tbSourcesFilter";
            this.tbSourcesFilter.Size = new System.Drawing.Size(535, 22);
            this.tbSourcesFilter.TabIndex = 39;
            // 
            // tbExcludeFilter
            // 
            this.tbExcludeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExcludeFilter.Location = new System.Drawing.Point(227, 37);
            this.tbExcludeFilter.Name = "tbExcludeFilter";
            this.tbExcludeFilter.Size = new System.Drawing.Size(535, 22);
            this.tbExcludeFilter.TabIndex = 39;
            // 
            // tbIncludeTextFilter
            // 
            this.tbIncludeTextFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIncludeTextFilter.Location = new System.Drawing.Point(227, 9);
            this.tbIncludeTextFilter.Name = "tbIncludeTextFilter";
            this.tbIncludeTextFilter.Size = new System.Drawing.Size(535, 22);
            this.tbIncludeTextFilter.TabIndex = 39;
            // 
            // TabPage12
            // 
            this.TabPage12.Controls.Add(this.tbModulesAlert);
            this.TabPage12.Controls.Add(this.tbSourcesAlert);
            this.TabPage12.Controls.Add(this.tbExcludeAlert);
            this.TabPage12.Controls.Add(this.tbIncludeTextAlert);
            this.TabPage12.Controls.Add(this.lboxAlerts);
            this.TabPage12.Controls.Add(this.btnDeleteAlerts);
            this.TabPage12.Controls.Add(this.label4);
            this.TabPage12.Controls.Add(this.btnAddAlerts);
            this.TabPage12.Controls.Add(this.label5);
            this.TabPage12.Controls.Add(this.label3);
            this.TabPage12.Location = new System.Drawing.Point(4, 25);
            this.TabPage12.Name = "TabPage12";
            this.TabPage12.Size = new System.Drawing.Size(773, 489);
            this.TabPage12.TabIndex = 3;
            this.TabPage12.Text = "Alert and Notifications";
            // 
            // tbModulesAlert
            // 
            this.tbModulesAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModulesAlert.Location = new System.Drawing.Point(227, 98);
            this.tbModulesAlert.Name = "tbModulesAlert";
            this.tbModulesAlert.Size = new System.Drawing.Size(535, 22);
            this.tbModulesAlert.TabIndex = 48;
            // 
            // tbSourcesAlert
            // 
            this.tbSourcesAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSourcesAlert.Location = new System.Drawing.Point(227, 68);
            this.tbSourcesAlert.Name = "tbSourcesAlert";
            this.tbSourcesAlert.Size = new System.Drawing.Size(535, 22);
            this.tbSourcesAlert.TabIndex = 48;
            // 
            // tbExcludeAlert
            // 
            this.tbExcludeAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExcludeAlert.Location = new System.Drawing.Point(227, 38);
            this.tbExcludeAlert.Name = "tbExcludeAlert";
            this.tbExcludeAlert.Size = new System.Drawing.Size(535, 22);
            this.tbExcludeAlert.TabIndex = 48;
            // 
            // tbIncludeTextAlert
            // 
            this.tbIncludeTextAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIncludeTextAlert.Location = new System.Drawing.Point(227, 10);
            this.tbIncludeTextAlert.Name = "tbIncludeTextAlert";
            this.tbIncludeTextAlert.Size = new System.Drawing.Size(535, 22);
            this.tbIncludeTextAlert.TabIndex = 48;
            // 
            // lboxAlerts
            // 
            this.lboxAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxAlerts.FormattingEnabled = true;
            this.lboxAlerts.ItemHeight = 16;
            this.lboxAlerts.Location = new System.Drawing.Point(5, 252);
            this.lboxAlerts.Name = "lboxAlerts";
            this.lboxAlerts.Size = new System.Drawing.Size(757, 164);
            this.lboxAlerts.TabIndex = 47;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.sfBtnHighlightColor);
            this.TabPage3.Controls.Add(this.tbHighlightColor);
            this.TabPage3.Controls.Add(this.lblHighlightColor);
            this.TabPage3.Controls.Add(this.gpLogLevelColors);
            this.TabPage3.Controls.Add(this.btnImportColors);
            this.TabPage3.Controls.Add(this.btnExportColors);
            this.TabPage3.Location = new System.Drawing.Point(4, 25);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(977, 496);
            this.TabPage3.TabIndex = 3;
            this.TabPage3.Text = "Look And Feel";
            // 
            // sfBtnHighlightColor
            // 
            this.sfBtnHighlightColor.AccessibleName = "Button";
            this.sfBtnHighlightColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnHighlightColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnHighlightColor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnHighlightColor.Location = new System.Drawing.Point(471, 322);
            this.sfBtnHighlightColor.Name = "sfBtnHighlightColor";
            this.sfBtnHighlightColor.Size = new System.Drawing.Size(80, 22);
            this.sfBtnHighlightColor.TabIndex = 29;
            this.sfBtnHighlightColor.Text = "Select";
            // 
            // tbHighlightColor
            // 
            this.tbHighlightColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHighlightColor.Location = new System.Drawing.Point(215, 322);
            this.tbHighlightColor.Name = "tbHighlightColor";
            this.tbHighlightColor.Size = new System.Drawing.Size(250, 22);
            this.tbHighlightColor.TabIndex = 28;
            // 
            // lblHighlightColor
            // 
            this.lblHighlightColor.Location = new System.Drawing.Point(12, 322);
            this.lblHighlightColor.Name = "lblHighlightColor";
            this.lblHighlightColor.Size = new System.Drawing.Size(176, 22);
            this.lblHighlightColor.TabIndex = 27;
            this.lblHighlightColor.Text = "Highlight Color:";
            // 
            // gpLogLevelColors
            // 
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelAnalogyInformation);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelCritical);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelError);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelWarning);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelVerbose);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelEvent);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelTrace);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelDebug);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelDisabled);
            this.gpLogLevelColors.Controls.Add(this.sfBtnLogLevelUnknown);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelAnalogyInformation);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelCritical);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelAnalogyInformation);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelCritical);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelError);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelWarning);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelError);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelWarning);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelEvent);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelDebug);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelEvent);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelDebug);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelVerbose);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelTrace);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelVerbose);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelTrace);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelDisabled);
            this.gpLogLevelColors.Controls.Add(this.tbLogLevelUnknown);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelDisabled);
            this.gpLogLevelColors.Controls.Add(this.lblLogLevelUnknown);
            this.gpLogLevelColors.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpLogLevelColors.Location = new System.Drawing.Point(0, 0);
            this.gpLogLevelColors.Name = "gpLogLevelColors";
            this.gpLogLevelColors.Size = new System.Drawing.Size(977, 308);
            this.gpLogLevelColors.TabIndex = 24;
            this.gpLogLevelColors.TabStop = false;
            this.gpLogLevelColors.Text = "Log Level Colors Settings";
            // 
            // sfBtnLogLevelAnalogyInformation
            // 
            this.sfBtnLogLevelAnalogyInformation.AccessibleName = "Button";
            this.sfBtnLogLevelAnalogyInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelAnalogyInformation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelAnalogyInformation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelAnalogyInformation.Location = new System.Drawing.Point(897, 274);
            this.sfBtnLogLevelAnalogyInformation.Name = "sfBtnLogLevelAnalogyInformation";
            this.sfBtnLogLevelAnalogyInformation.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelAnalogyInformation.TabIndex = 29;
            this.sfBtnLogLevelAnalogyInformation.Text = "Select";
            // 
            // sfBtnLogLevelCritical
            // 
            this.sfBtnLogLevelCritical.AccessibleName = "Button";
            this.sfBtnLogLevelCritical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelCritical.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelCritical.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelCritical.Location = new System.Drawing.Point(897, 246);
            this.sfBtnLogLevelCritical.Name = "sfBtnLogLevelCritical";
            this.sfBtnLogLevelCritical.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelCritical.TabIndex = 29;
            this.sfBtnLogLevelCritical.Text = "Select";
            // 
            // sfBtnLogLevelError
            // 
            this.sfBtnLogLevelError.AccessibleName = "Button";
            this.sfBtnLogLevelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelError.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelError.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelError.Location = new System.Drawing.Point(897, 218);
            this.sfBtnLogLevelError.Name = "sfBtnLogLevelError";
            this.sfBtnLogLevelError.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelError.TabIndex = 29;
            this.sfBtnLogLevelError.Text = "Select";
            // 
            // sfBtnLogLevelWarning
            // 
            this.sfBtnLogLevelWarning.AccessibleName = "Button";
            this.sfBtnLogLevelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelWarning.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelWarning.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelWarning.Location = new System.Drawing.Point(897, 190);
            this.sfBtnLogLevelWarning.Name = "sfBtnLogLevelWarning";
            this.sfBtnLogLevelWarning.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelWarning.TabIndex = 29;
            this.sfBtnLogLevelWarning.Text = "Select";
            // 
            // sfBtnLogLevelVerbose
            // 
            this.sfBtnLogLevelVerbose.AccessibleName = "Button";
            this.sfBtnLogLevelVerbose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelVerbose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelVerbose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelVerbose.Location = new System.Drawing.Point(897, 106);
            this.sfBtnLogLevelVerbose.Name = "sfBtnLogLevelVerbose";
            this.sfBtnLogLevelVerbose.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelVerbose.TabIndex = 29;
            this.sfBtnLogLevelVerbose.Text = "Select";
            // 
            // sfBtnLogLevelEvent
            // 
            this.sfBtnLogLevelEvent.AccessibleName = "Button";
            this.sfBtnLogLevelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelEvent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelEvent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelEvent.Location = new System.Drawing.Point(897, 162);
            this.sfBtnLogLevelEvent.Name = "sfBtnLogLevelEvent";
            this.sfBtnLogLevelEvent.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelEvent.TabIndex = 29;
            this.sfBtnLogLevelEvent.Text = "Select";
            // 
            // sfBtnLogLevelTrace
            // 
            this.sfBtnLogLevelTrace.AccessibleName = "Button";
            this.sfBtnLogLevelTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelTrace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelTrace.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelTrace.Location = new System.Drawing.Point(897, 78);
            this.sfBtnLogLevelTrace.Name = "sfBtnLogLevelTrace";
            this.sfBtnLogLevelTrace.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelTrace.TabIndex = 29;
            this.sfBtnLogLevelTrace.Text = "Select";
            // 
            // sfBtnLogLevelDebug
            // 
            this.sfBtnLogLevelDebug.AccessibleName = "Button";
            this.sfBtnLogLevelDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelDebug.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelDebug.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelDebug.Location = new System.Drawing.Point(897, 134);
            this.sfBtnLogLevelDebug.Name = "sfBtnLogLevelDebug";
            this.sfBtnLogLevelDebug.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelDebug.TabIndex = 29;
            this.sfBtnLogLevelDebug.Text = "Select";
            // 
            // sfBtnLogLevelDisabled
            // 
            this.sfBtnLogLevelDisabled.AccessibleName = "Button";
            this.sfBtnLogLevelDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelDisabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelDisabled.Location = new System.Drawing.Point(897, 50);
            this.sfBtnLogLevelDisabled.Name = "sfBtnLogLevelDisabled";
            this.sfBtnLogLevelDisabled.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelDisabled.TabIndex = 29;
            this.sfBtnLogLevelDisabled.Text = "Select";
            // 
            // sfBtnLogLevelUnknown
            // 
            this.sfBtnLogLevelUnknown.AccessibleName = "Button";
            this.sfBtnLogLevelUnknown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfBtnLogLevelUnknown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sfBtnLogLevelUnknown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnLogLevelUnknown.Location = new System.Drawing.Point(897, 22);
            this.sfBtnLogLevelUnknown.Name = "sfBtnLogLevelUnknown";
            this.sfBtnLogLevelUnknown.Size = new System.Drawing.Size(80, 22);
            this.sfBtnLogLevelUnknown.TabIndex = 29;
            this.sfBtnLogLevelUnknown.Text = "Select";
            // 
            // tbLogLevelAnalogyInformation
            // 
            this.tbLogLevelAnalogyInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelAnalogyInformation.Location = new System.Drawing.Point(215, 274);
            this.tbLogLevelAnalogyInformation.Name = "tbLogLevelAnalogyInformation";
            this.tbLogLevelAnalogyInformation.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelAnalogyInformation.TabIndex = 27;
            // 
            // tbLogLevelCritical
            // 
            this.tbLogLevelCritical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelCritical.Location = new System.Drawing.Point(215, 246);
            this.tbLogLevelCritical.Name = "tbLogLevelCritical";
            this.tbLogLevelCritical.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelCritical.TabIndex = 28;
            // 
            // lblLogLevelAnalogyInformation
            // 
            this.lblLogLevelAnalogyInformation.Location = new System.Drawing.Point(11, 274);
            this.lblLogLevelAnalogyInformation.Name = "lblLogLevelAnalogyInformation";
            this.lblLogLevelAnalogyInformation.Size = new System.Drawing.Size(176, 22);
            this.lblLogLevelAnalogyInformation.TabIndex = 26;
            this.lblLogLevelAnalogyInformation.Text = "AnalogyInformation:";
            // 
            // lblLogLevelCritical
            // 
            this.lblLogLevelCritical.Location = new System.Drawing.Point(11, 246);
            this.lblLogLevelCritical.Name = "lblLogLevelCritical";
            this.lblLogLevelCritical.Size = new System.Drawing.Size(176, 22);
            this.lblLogLevelCritical.TabIndex = 25;
            this.lblLogLevelCritical.Text = "Critical:";
            // 
            // tbLogLevelError
            // 
            this.tbLogLevelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelError.Location = new System.Drawing.Point(215, 218);
            this.tbLogLevelError.Name = "tbLogLevelError";
            this.tbLogLevelError.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelError.TabIndex = 23;
            // 
            // tbLogLevelWarning
            // 
            this.tbLogLevelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelWarning.Location = new System.Drawing.Point(215, 190);
            this.tbLogLevelWarning.Name = "tbLogLevelWarning";
            this.tbLogLevelWarning.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelWarning.TabIndex = 24;
            // 
            // lblLogLevelError
            // 
            this.lblLogLevelError.Location = new System.Drawing.Point(11, 218);
            this.lblLogLevelError.Name = "lblLogLevelError";
            this.lblLogLevelError.Size = new System.Drawing.Size(176, 22);
            this.lblLogLevelError.TabIndex = 22;
            this.lblLogLevelError.Text = "Error:";
            // 
            // lblLogLevelWarning
            // 
            this.lblLogLevelWarning.Location = new System.Drawing.Point(11, 190);
            this.lblLogLevelWarning.Name = "lblLogLevelWarning";
            this.lblLogLevelWarning.Size = new System.Drawing.Size(176, 22);
            this.lblLogLevelWarning.TabIndex = 21;
            this.lblLogLevelWarning.Text = "Warning:";
            // 
            // tbLogLevelEvent
            // 
            this.tbLogLevelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelEvent.Location = new System.Drawing.Point(215, 162);
            this.tbLogLevelEvent.Name = "tbLogLevelEvent";
            this.tbLogLevelEvent.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelEvent.TabIndex = 19;
            // 
            // tbLogLevelDebug
            // 
            this.tbLogLevelDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelDebug.Location = new System.Drawing.Point(215, 134);
            this.tbLogLevelDebug.Name = "tbLogLevelDebug";
            this.tbLogLevelDebug.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelDebug.TabIndex = 20;
            // 
            // lblLogLevelEvent
            // 
            this.lblLogLevelEvent.Location = new System.Drawing.Point(11, 162);
            this.lblLogLevelEvent.Name = "lblLogLevelEvent";
            this.lblLogLevelEvent.Size = new System.Drawing.Size(176, 22);
            this.lblLogLevelEvent.TabIndex = 18;
            this.lblLogLevelEvent.Text = "Event:";
            // 
            // lblLogLevelDebug
            // 
            this.lblLogLevelDebug.Location = new System.Drawing.Point(11, 134);
            this.lblLogLevelDebug.Name = "lblLogLevelDebug";
            this.lblLogLevelDebug.Size = new System.Drawing.Size(177, 22);
            this.lblLogLevelDebug.TabIndex = 17;
            this.lblLogLevelDebug.Text = "Debug:";
            // 
            // tbLogLevelVerbose
            // 
            this.tbLogLevelVerbose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelVerbose.Location = new System.Drawing.Point(215, 106);
            this.tbLogLevelVerbose.Name = "tbLogLevelVerbose";
            this.tbLogLevelVerbose.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelVerbose.TabIndex = 15;
            // 
            // tbLogLevelTrace
            // 
            this.tbLogLevelTrace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelTrace.Location = new System.Drawing.Point(215, 78);
            this.tbLogLevelTrace.Name = "tbLogLevelTrace";
            this.tbLogLevelTrace.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelTrace.TabIndex = 16;
            // 
            // lblLogLevelVerbose
            // 
            this.lblLogLevelVerbose.Location = new System.Drawing.Point(11, 106);
            this.lblLogLevelVerbose.Name = "lblLogLevelVerbose";
            this.lblLogLevelVerbose.Size = new System.Drawing.Size(176, 22);
            this.lblLogLevelVerbose.TabIndex = 14;
            this.lblLogLevelVerbose.Text = "Verbose:";
            // 
            // lblLogLevelTrace
            // 
            this.lblLogLevelTrace.Location = new System.Drawing.Point(11, 78);
            this.lblLogLevelTrace.Name = "lblLogLevelTrace";
            this.lblLogLevelTrace.Size = new System.Drawing.Size(176, 22);
            this.lblLogLevelTrace.TabIndex = 13;
            this.lblLogLevelTrace.Text = "Trace:";
            // 
            // tbLogLevelDisabled
            // 
            this.tbLogLevelDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelDisabled.Location = new System.Drawing.Point(215, 50);
            this.tbLogLevelDisabled.Name = "tbLogLevelDisabled";
            this.tbLogLevelDisabled.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelDisabled.TabIndex = 12;
            // 
            // tbLogLevelUnknown
            // 
            this.tbLogLevelUnknown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogLevelUnknown.Location = new System.Drawing.Point(215, 22);
            this.tbLogLevelUnknown.Name = "tbLogLevelUnknown";
            this.tbLogLevelUnknown.Size = new System.Drawing.Size(676, 22);
            this.tbLogLevelUnknown.TabIndex = 12;
            // 
            // lblLogLevelDisabled
            // 
            this.lblLogLevelDisabled.Location = new System.Drawing.Point(11, 50);
            this.lblLogLevelDisabled.Name = "lblLogLevelDisabled";
            this.lblLogLevelDisabled.Size = new System.Drawing.Size(176, 22);
            this.lblLogLevelDisabled.TabIndex = 1;
            this.lblLogLevelDisabled.Text = "Disabled:";
            // 
            // lblLogLevelUnknown
            // 
            this.lblLogLevelUnknown.Location = new System.Drawing.Point(11, 22);
            this.lblLogLevelUnknown.Name = "lblLogLevelUnknown";
            this.lblLogLevelUnknown.Size = new System.Drawing.Size(177, 22);
            this.lblLogLevelUnknown.TabIndex = 0;
            this.lblLogLevelUnknown.Text = "Unknown:";
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.tbUserStatistics);
            this.TabPage4.Controls.Add(this.btnClearStatistics);
            this.TabPage4.Controls.Add(this.lblOpenedFiles);
            this.TabPage4.Controls.Add(this.lblTotalTime);
            this.TabPage4.Controls.Add(this.lblLaunchCount);
            this.TabPage4.Location = new System.Drawing.Point(4, 25);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(977, 496);
            this.TabPage4.TabIndex = 4;
            this.TabPage4.Text = "User Statistics";
            // 
            // tbUserStatistics
            // 
            this.tbUserStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserStatistics.Location = new System.Drawing.Point(3, 9);
            this.tbUserStatistics.Name = "tbUserStatistics";
            this.tbUserStatistics.Size = new System.Drawing.Size(804, 22);
            this.tbUserStatistics.TabIndex = 20;
            this.tbUserStatistics.Text = "Enable User Statistics";
            this.tbUserStatistics.UseVisualStyleBackColor = true;
            // 
            // lblOpenedFiles
            // 
            this.lblOpenedFiles.AutoSize = true;
            this.lblOpenedFiles.Location = new System.Drawing.Point(12, 124);
            this.lblOpenedFiles.Name = "lblOpenedFiles";
            this.lblOpenedFiles.Size = new System.Drawing.Size(181, 17);
            this.lblOpenedFiles.TabIndex = 15;
            this.lblOpenedFiles.Text = "Number Of Opened Files: 0";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(12, 88);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(86, 17);
            this.lblTotalTime.TabIndex = 15;
            this.lblTotalTime.Text = "Total time: 0";
            // 
            // lblLaunchCount
            // 
            this.lblLaunchCount.AutoSize = true;
            this.lblLaunchCount.Location = new System.Drawing.Point(12, 57);
            this.lblLaunchCount.Name = "lblLaunchCount";
            this.lblLaunchCount.Size = new System.Drawing.Size(211, 17);
            this.lblLaunchCount.TabIndex = 15;
            this.lblLaunchCount.Text = "Number of Analogy Launches: 0";
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.tbExtensionsStartup);
            this.TabPage5.Controls.Add(this.clExtensionslItems);
            this.TabPage5.Location = new System.Drawing.Point(4, 25);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(977, 496);
            this.TabPage5.TabIndex = 5;
            this.TabPage5.Text = "Extensions";
            // 
            // tbExtensionsStartup
            // 
            this.tbExtensionsStartup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExtensionsStartup.Location = new System.Drawing.Point(12, 9);
            this.tbExtensionsStartup.Name = "tbExtensionsStartup";
            this.tbExtensionsStartup.Size = new System.Drawing.Size(804, 22);
            this.tbExtensionsStartup.TabIndex = 21;
            this.tbExtensionsStartup.Text = "Enable Startup Extensions:";
            this.tbExtensionsStartup.UseVisualStyleBackColor = true;
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.label11);
            this.TabPage6.Controls.Add(this.label10);
            this.TabPage6.Controls.Add(this.label9);
            this.TabPage6.Controls.Add(this.label8);
            this.TabPage6.Location = new System.Drawing.Point(4, 25);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new System.Drawing.Size(977, 496);
            this.TabPage6.TabIndex = 6;
            this.TabPage6.Text = "Shortcuts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Toggle on warning log level filtering: ALT + W";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Toggle on Error + Critical log level filtering: ALT + E";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Go to exclude filter textbox: SHIFT + F";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Go to include filter textbox: Ctrl + F";
            // 
            // TabPage7
            // 
            this.TabPage7.Controls.Add(this.label7);
            this.TabPage7.Controls.Add(this.nudRecent);
            this.TabPage7.Location = new System.Drawing.Point(4, 25);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Size = new System.Drawing.Size(977, 496);
            this.TabPage7.TabIndex = 7;
            this.TabPage7.Text = "Most Recently Used";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Number of recent files to keep:";
            // 
            // TabPage8
            // 
            this.TabPage8.Controls.Add(this.tbIdleMode);
            this.TabPage8.Controls.Add(this.label12);
            this.TabPage8.Controls.Add(this.nudIdleTime);
            this.TabPage8.Location = new System.Drawing.Point(4, 25);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Size = new System.Drawing.Size(977, 496);
            this.TabPage8.TabIndex = 8;
            this.TabPage8.Text = "Resources Usage";
            // 
            // tbIdleMode
            // 
            this.tbIdleMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdleMode.Location = new System.Drawing.Point(6, 9);
            this.tbIdleMode.Name = "tbIdleMode";
            this.tbIdleMode.Size = new System.Drawing.Size(804, 22);
            this.tbIdleMode.TabIndex = 22;
            this.tbIdleMode.Text = "Enable Idle Mode";
            this.tbIdleMode.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Idle time (in minutes) of no activity :";
            // 
            // TabPage9
            // 
            this.TabPage9.Controls.Add(this.TabControl3);
            this.TabPage9.Location = new System.Drawing.Point(4, 46);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Size = new System.Drawing.Size(977, 475);
            this.TabPage9.TabIndex = 9;
            this.TabPage9.Text = "Data Providers";
            // 
            // TabControl3
            // 
            this.TabControl3.Controls.Add(this.TabPage13);
            this.TabControl3.Controls.Add(this.TabPage14);
            this.TabControl3.Controls.Add(this.TabPage15);
            this.TabControl3.Controls.Add(this.TabPage16);
            this.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl3.Location = new System.Drawing.Point(0, 0);
            this.TabControl3.Name = "TabControl3";
            this.TabControl3.SelectedIndex = 0;
            this.TabControl3.Size = new System.Drawing.Size(977, 475);
            this.TabControl3.TabIndex = 0;
            // 
            // TabPage13
            // 
            this.TabPage13.Controls.Add(this.chkLstDataProviderStatus);
            this.TabPage13.Controls.Add(this.tbRememberLastOpenedDataProvider);
            this.TabPage13.Controls.Add(this.label1);
            this.TabPage13.Location = new System.Drawing.Point(4, 25);
            this.TabPage13.Name = "TabPage13";
            this.TabPage13.Size = new System.Drawing.Size(969, 446);
            this.TabPage13.TabIndex = 1;
            this.TabPage13.Text = "Data Providers Enable/Disable";
            // 
            // tbRememberLastOpenedDataProvider
            // 
            this.tbRememberLastOpenedDataProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbRememberLastOpenedDataProvider.Location = new System.Drawing.Point(0, 0);
            this.tbRememberLastOpenedDataProvider.Name = "tbRememberLastOpenedDataProvider";
            this.tbRememberLastOpenedDataProvider.Size = new System.Drawing.Size(969, 22);
            this.tbRememberLastOpenedDataProvider.TabIndex = 23;
            this.tbRememberLastOpenedDataProvider.Text = "Remember last opened Data provider on startup and switch to it after restart";
            this.tbRememberLastOpenedDataProvider.UseVisualStyleBackColor = true;
            // 
            // TabPage14
            // 
            this.TabPage14.Controls.Add(this.chkLstItemRealTimeDataSources);
            this.TabPage14.Controls.Add(this.label2);
            this.TabPage14.Location = new System.Drawing.Point(4, 25);
            this.TabPage14.Name = "TabPage14";
            this.TabPage14.Size = new System.Drawing.Size(773, 489);
            this.TabPage14.TabIndex = 2;
            this.TabPage14.Text = "Real time Auto-Startup";
            // 
            // TabPage15
            // 
            this.TabPage15.Controls.Add(this.label6);
            this.TabPage15.Controls.Add(this.btnSetFileAssociation);
            this.TabPage15.Controls.Add(this.cbDataProviderAssociation);
            this.TabPage15.Controls.Add(this.txtbDataProviderAssociation);
            this.TabPage15.Location = new System.Drawing.Point(4, 25);
            this.TabPage15.Name = "TabPage15";
            this.TabPage15.Size = new System.Drawing.Size(773, 489);
            this.TabPage15.TabIndex = 3;
            this.TabPage15.Text = "Default File Associations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "File Types (use , as seperator. eg: *.log,*.nlog)):";
            // 
            // TabPage16
            // 
            this.TabPage16.Controls.Add(this.btnDataProviderCustomSettings);
            this.TabPage16.Location = new System.Drawing.Point(4, 25);
            this.TabPage16.Name = "TabPage16";
            this.TabPage16.Size = new System.Drawing.Size(773, 489);
            this.TabPage16.TabIndex = 4;
            this.TabPage16.Text = "Custom Settings";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 525);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserSettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPageLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdleTime)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.gbFilteringSettings.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.TabPage10.ResumeLayout(false);
            this.gbHighlight.ResumeLayout(false);
            this.gbHighlight.PerformLayout();
            this.TabPage11.ResumeLayout(false);
            this.TabPage11.PerformLayout();
            this.TabPage12.ResumeLayout(false);
            this.TabPage12.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.gpLogLevelColors.ResumeLayout(false);
            this.gpLogLevelColors.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.TabPage8.ResumeLayout(false);
            this.TabPage8.PerformLayout();
            this.TabPage9.ResumeLayout(false);
            this.TabControl3.ResumeLayout(false);
            this.TabPage13.ResumeLayout(false);
            this.TabPage14.ResumeLayout(false);
            this.TabPage15.ResumeLayout(false);
            this.TabPage15.PerformLayout();
            this.TabPage16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private NumericUpDown nudRecent;
        private Button btnClearStatistics;
        private CheckedListBox clExtensionslItems;
        private NumericUpDown nudPageLength;
        private NumericUpDown nudIdleTime;
        private CheckedListBox chkLstItemRealTimeDataSources;
        private Button btnImportColors;
        private Button btnExportColors;
        private CheckedListBox chkLstDataProviderStatus;
        private Button btnDataProviderCustomSettings;
        private Button btnSetFileAssociation;
        private TextBox txtbDataProviderAssociation;
        private ComboBox cbDataProviderAssociation;
        private RadioButton rbtnHighlightEquals;
        private RadioButton rbtnHighlightContains;
        private Button btnDeleteHighlight;
        private Button sbtnAddHighlight;
        private Button btnDeleteFilter;
        private Button btnAddFilter;
        private Label lblExplaination;
        private Label lblModules;
        private Label lblSources;
        private Label lblExcludeMessageText;
        private Label lblIncludeText;
        private Button btnDeleteAlerts;
        private Button btnAddAlerts;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TabControl tabControlMain;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private TabPage TabPage3;
        private TabPage TabPage4;
        private TabPage TabPage5;
        private TabPage TabPage6;
        private TabPage TabPage7;
        private TabPage TabPage8;
        private TabPage TabPage9;
        private TabControl TabControl2;
        private TabPage TabPage10;
        private TabPage TabPage11;
        private TabPage TabPage12;
        private TabControl TabControl3;
        private TabPage TabPage13;
        private Label Label1;
        private TabPage TabPage14;
        private Label Label2;
        private TabPage TabPage15;
        private Label label6;
        private TabPage TabPage16;
        private GroupBox gbFilteringSettings;
        private Label label7;
        private ListBox lboxHighlightItems;
        private TextBox tbHighlightEquals;
        private TextBox tbHighlightContains;
        private GroupBox gbHighlight;
        private Label lblHighlightColorSelection;
        private TextBox tbHighlighColor;
        private Button sfBtnPreDefinedSelectColor;
        private ColorDialog colorDialog1;
        private TextBox tbModulesFilter;
        private TextBox tbSourcesFilter;
        private TextBox tbExcludeFilter;
        private TextBox tbIncludeTextFilter;
        private ListBox lboxFilters;
        private ListBox lboxAlerts;
        private TextBox tbModulesAlert;
        private TextBox tbSourcesAlert;
        private TextBox tbExcludeAlert;
        private TextBox tbIncludeTextAlert;
        private GroupBox gpLogLevelColors;
        private TextBox tbLogLevelAnalogyInformation;
        private TextBox tbLogLevelCritical;
        private Label lblLogLevelAnalogyInformation;
        private Label lblLogLevelCritical;
        private TextBox tbLogLevelError;
        private TextBox tbLogLevelWarning;
        private Label lblLogLevelError;
        private Label lblLogLevelWarning;
        private TextBox tbLogLevelEvent;
        private TextBox tbLogLevelDebug;
        private Label lblLogLevelEvent;
        private Label lblLogLevelDebug;
        private TextBox tbLogLevelVerbose;
        private TextBox tbLogLevelTrace;
        private Label lblLogLevelVerbose;
        private Label lblLogLevelTrace;
        private TextBox tbLogLevelDisabled;
        private TextBox tbLogLevelUnknown;
        private Label lblLogLevelDisabled;
        private Label lblLogLevelUnknown;
        private TextBox tbHighlightColor;
        private Label lblHighlightColor;
        private Button sfBtnLogLevelVerbose;
        private Button sfBtnLogLevelTrace;
        private Button sfBtnLogLevelDisabled;
        private Button sfBtnLogLevelUnknown;
        private Button sfBtnHighlightColor;
        private Button sfBtnLogLevelAnalogyInformation;
        private Button sfBtnLogLevelCritical;
        private Button sfBtnLogLevelError;
        private Button sfBtnLogLevelWarning;
        private Button sfBtnLogLevelEvent;
        private Button sfBtnLogLevelDebug;
        private Label lblOpenedFiles;
        private Label lblTotalTime;
        private Label lblLaunchCount;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
        private CheckBox tbHistory;
        private CheckBox tbAutoComplete;
        private CheckBox tbErrorLevelAsDefault;
        private CheckBox tbDataTimeAscendDescend;
        private CheckBox tbFilteringLastEntries;
        private CheckBox cbPaging;
        private CheckBox cbSearchAlsoInSourceAndModule;
        private CheckBox tbFileCaching;
        private CheckBox tbUserStatistics;
        private CheckBox tbExtensionsStartup;
        private CheckBox tbIdleMode;
        private CheckBox tbRememberLastOpenedDataProvider;
    }
}
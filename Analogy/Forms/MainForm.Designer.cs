using System.ComponentModel;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;

namespace Analogy
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControlMain = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.RibbonTabAnalogy = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.tsbtnAnalogyOpenFolder = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.tsbtnAnalogyOpenFiles = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple15 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.contextMenuStripRecentFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kryptonRibbonGroupButton8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.modeStackGroup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.modeStackHeaderGroup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.modeBarGroupOutside = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.modeBarGroupInside = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.modeTabGroup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.modeBarRibbonTabGroup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.modeHeaderBarGroup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.modeHeaderBarHeaderGroup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.modeHeaderGroupTab = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.colorsRandom = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.colorsReset = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.buttonSpecsAdd = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.buttonSpecsClear = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krtTheme = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.krtSettings = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.tsbSettingsFiltering = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.tsbSettingsPreDefined = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.tsbSettingsLookAndFeel = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple12 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.tsbSettingsUserStatistics = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.tsbSettingsExtension = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.tsbSettingsShortcuts = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple13 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.tsbSettingsMRU = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.tsbSettingsResources = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.tsbSettingsDataProviders = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple14 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.tsbSettingsCustomDataProviders = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableWorkspace = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonDockingManager = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonRibbonGroupGallery1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupGallery();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFileCaching = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrAutoConnect = new System.Windows.Forms.Timer(this.components);
            this.tmrStatusUpdates = new System.Windows.Forms.Timer(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tsslMemoryUsage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIdleMessage = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.InDesignHelperMode = true;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.RibbonTabAnalogy,
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2,
            this.krtTheme,
            this.krtSettings});
            this.ribbonControlMain.SelectedTab = this.RibbonTabAnalogy;
            this.ribbonControlMain.Size = new System.Drawing.Size(1083, 165);
            this.ribbonControlMain.TabIndex = 0;
            // 
            // RibbonTabAnalogy
            // 
            this.RibbonTabAnalogy.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup8,
            this.kryptonRibbonGroup9,
            this.kryptonRibbonGroup10});
            this.RibbonTabAnalogy.Text = "Analogy";
            // 
            // kryptonRibbonGroup8
            // 
            this.kryptonRibbonGroup8.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple8,
            this.kryptonRibbonGroupTriple15});
            // 
            // kryptonRibbonGroupTriple8
            // 
            this.kryptonRibbonGroupTriple8.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.tsbtnAnalogyOpenFolder,
            this.tsbtnAnalogyOpenFiles,
            this.kryptonRibbonGroupButton1});
            // 
            // tsbtnAnalogyOpenFolder
            // 
            this.tsbtnAnalogyOpenFolder.ImageLarge = global::Analogy.Properties.Resources.Open2_32x32;
            this.tsbtnAnalogyOpenFolder.ImageSmall = global::Analogy.Properties.Resources.Open2_32x32;
            this.tsbtnAnalogyOpenFolder.TextLine1 = "Open Folder";
            // 
            // tsbtnAnalogyOpenFiles
            // 
            this.tsbtnAnalogyOpenFiles.ImageLarge = global::Analogy.Properties.Resources.Article_32x32;
            this.tsbtnAnalogyOpenFiles.ImageSmall = global::Analogy.Properties.Resources.Article_16x16;
            this.tsbtnAnalogyOpenFiles.TextLine1 = "Open Files";
            // 
            // kryptonRibbonGroupButton1
            // 
            this.kryptonRibbonGroupButton1.Visible = false;
            // 
            // kryptonRibbonGroupTriple15
            // 
            this.kryptonRibbonGroupTriple15.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton7,
            this.kryptonRibbonGroupButton8});
            // 
            // kryptonRibbonGroupButton7
            // 
            this.kryptonRibbonGroupButton7.ContextMenuStrip = this.contextMenuStripRecentFiles;
            this.kryptonRibbonGroupButton7.ImageLarge = global::Analogy.Properties.Resources.RecentlyUse_32x32;
            this.kryptonRibbonGroupButton7.ImageSmall = global::Analogy.Properties.Resources.RecentlyUse_16x16;
            this.kryptonRibbonGroupButton7.TextLine1 = "Recently Used";
            this.kryptonRibbonGroupButton7.TextLine2 = "Files";
            // 
            // contextMenuStripRecentFiles
            // 
            this.contextMenuStripRecentFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStripRecentFiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRecentFiles.Name = "contextMenuStripRecentFiles";
            this.contextMenuStripRecentFiles.Size = new System.Drawing.Size(61, 4);
            // 
            // kryptonRibbonGroupButton8
            // 
            this.kryptonRibbonGroupButton8.ImageLarge = global::Analogy.Properties.Resources.RichEditBookmark_32x32;
            this.kryptonRibbonGroupButton8.ImageSmall = global::Analogy.Properties.Resources.RichEditBookmark_16x16;
            this.kryptonRibbonGroupButton8.TextLine1 = "Bookmarks";
            // 
            // kryptonRibbonGroup9
            // 
            this.kryptonRibbonGroup9.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple9});
            this.kryptonRibbonGroup9.TextLine1 = "Analogy\'s Built-in tools for logs";
            // 
            // kryptonRibbonGroupTriple9
            // 
            this.kryptonRibbonGroupTriple9.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton2,
            this.kryptonRibbonGroupButton3,
            this.kryptonRibbonGroupButton4});
            // 
            // kryptonRibbonGroupButton2
            // 
            this.kryptonRibbonGroupButton2.ImageLarge = global::Analogy.Properties.Resources.Lookup_Reference_32x32;
            this.kryptonRibbonGroupButton2.ImageSmall = global::Analogy.Properties.Resources.Lookup_Reference_16x16;
            this.kryptonRibbonGroupButton2.TextLine1 = "Search";
            this.kryptonRibbonGroupButton2.TextLine2 = "In Files";
            // 
            // kryptonRibbonGroupButton3
            // 
            this.kryptonRibbonGroupButton3.ImageLarge = global::Analogy.Properties.Resources.Sutotal_32x32;
            this.kryptonRibbonGroupButton3.TextLine1 = "Combine";
            this.kryptonRibbonGroupButton3.TextLine2 = "Files";
            // 
            // kryptonRibbonGroupButton4
            // 
            this.kryptonRibbonGroupButton4.ImageLarge = global::Analogy.Properties.Resources.TwoColumns;
            this.kryptonRibbonGroupButton4.TextLine1 = "Compare";
            this.kryptonRibbonGroupButton4.TextLine2 = "Files";
            // 
            // kryptonRibbonGroup10
            // 
            this.kryptonRibbonGroup10.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple10});
            this.kryptonRibbonGroup10.TextLine1 = "Tools";
            // 
            // kryptonRibbonGroupTriple10
            // 
            this.kryptonRibbonGroupTriple10.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton5});
            // 
            // kryptonRibbonGroupButton5
            // 
            this.kryptonRibbonGroupButton5.ImageLarge = global::Analogy.Properties.Resources.PageSetup_32x32;
            this.kryptonRibbonGroupButton5.ImageSmall = global::Analogy.Properties.Resources.PageSetup_16x16;
            this.kryptonRibbonGroupButton5.TextLine1 = "Process";
            this.kryptonRibbonGroupButton5.TextLine2 = "Identifier";
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup2,
            this.kryptonRibbonGroup3,
            this.kryptonRibbonGroup5,
            this.kryptonRibbonGroup4,
            this.kryptonRibbonGroup7});
            this.kryptonRibbonTab1.KeyTip = "C";
            this.kryptonRibbonTab1.Text = "Cell Modes";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.DialogBoxLauncher = false;
            this.kryptonRibbonGroup2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple5});
            this.kryptonRibbonGroup2.KeyTipGroup = "S";
            this.kryptonRibbonGroup2.TextLine1 = "Stack Modes";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.modeStackGroup,
            this.modeStackHeaderGroup});
            this.kryptonRibbonGroupTriple5.MaximumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple5.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // modeStackGroup
            // 
            this.modeStackGroup.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.modeStackGroup.ImageLarge = global::Analogy.Properties.Resources.modeStackGroup_ImageLarge;
            this.modeStackGroup.ImageSmall = global::Analogy.Properties.Resources.modeStackGroup_ImageSmall;
            this.modeStackGroup.KeyTip = "SG";
            this.modeStackGroup.Tag = "StackCheckButtonGroup";
            this.modeStackGroup.TextLine1 = "Stack - Group";
            this.modeStackGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // modeStackHeaderGroup
            // 
            this.modeStackHeaderGroup.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.modeStackHeaderGroup.ImageLarge = global::Analogy.Properties.Resources.modeStackGroup_ImageLarge;
            this.modeStackHeaderGroup.ImageSmall = global::Analogy.Properties.Resources.modeStackGroup_ImageSmall;
            this.modeStackHeaderGroup.KeyTip = "SH";
            this.modeStackHeaderGroup.Tag = "StackCheckButtonHeaderGroup";
            this.modeStackHeaderGroup.TextLine1 = "Stack - HeaderGroup";
            this.modeStackHeaderGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.DialogBoxLauncher = false;
            this.kryptonRibbonGroup3.Image = global::Analogy.Properties.Resources.kryptonRibbonGroup3_Image;
            this.kryptonRibbonGroup3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple3});
            this.kryptonRibbonGroup3.KeyTipGroup = "B";
            this.kryptonRibbonGroup3.TextLine1 = "Bar Modes";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.modeBarGroupOutside,
            this.modeBarGroupInside,
            this.modeTabGroup});
            this.kryptonRibbonGroupTriple3.MaximumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple3.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // modeBarGroupOutside
            // 
            this.modeBarGroupOutside.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.modeBarGroupOutside.ImageLarge = global::Analogy.Properties.Resources.modeStackGroup_ImageLarge;
            this.modeBarGroupOutside.ImageSmall = global::Analogy.Properties.Resources.modeStackGroup_ImageSmall;
            this.modeBarGroupOutside.KeyTip = "BO";
            this.modeBarGroupOutside.Tag = "BarCheckButtonGroupOutside";
            this.modeBarGroupOutside.TextLine1 = "Bar - GroupOutside";
            this.modeBarGroupOutside.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // modeBarGroupInside
            // 
            this.modeBarGroupInside.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.modeBarGroupInside.ImageLarge = global::Analogy.Properties.Resources.modeStackGroup_ImageLarge;
            this.modeBarGroupInside.ImageSmall = global::Analogy.Properties.Resources.modeStackGroup_ImageSmall;
            this.modeBarGroupInside.KeyTip = "BI";
            this.modeBarGroupInside.Tag = "BarCheckButtonGroupInside";
            this.modeBarGroupInside.TextLine1 = "Bar - GroupInside";
            this.modeBarGroupInside.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // modeTabGroup
            // 
            this.modeTabGroup.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.modeTabGroup.ImageLarge = global::Analogy.Properties.Resources.modeStackGroup_ImageLarge;
            this.modeTabGroup.ImageSmall = global::Analogy.Properties.Resources.modeStackGroup_ImageSmall;
            this.modeTabGroup.KeyTip = "BT";
            this.modeTabGroup.Tag = "BarTabGroup";
            this.modeTabGroup.TextLine1 = "Bar - TabGroup";
            this.modeTabGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonGroup5
            // 
            this.kryptonRibbonGroup5.DialogBoxLauncher = false;
            this.kryptonRibbonGroup5.Image = global::Analogy.Properties.Resources.kryptonRibbonGroup5_Image;
            this.kryptonRibbonGroup5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4});
            this.kryptonRibbonGroup5.KeyTipGroup = "R";
            this.kryptonRibbonGroup5.TextLine1 = "BarRibbon Modes";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.modeBarRibbonTabGroup});
            this.kryptonRibbonGroupTriple4.MaximumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple4.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // modeBarRibbonTabGroup
            // 
            this.modeBarRibbonTabGroup.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.modeBarRibbonTabGroup.ImageLarge = global::Analogy.Properties.Resources.modeStackGroup_ImageLarge;
            this.modeBarRibbonTabGroup.ImageSmall = global::Analogy.Properties.Resources.modeStackGroup_ImageSmall;
            this.modeBarRibbonTabGroup.KeyTip = "BR";
            this.modeBarRibbonTabGroup.Tag = "BarRibbonTabGroup";
            this.modeBarRibbonTabGroup.TextLine1 = "BarRibbon - TabGroup";
            this.modeBarRibbonTabGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.DialogBoxLauncher = false;
            this.kryptonRibbonGroup4.Image = global::Analogy.Properties.Resources.kryptonRibbonGroup4_Image;
            this.kryptonRibbonGroup4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            this.kryptonRibbonGroup4.KeyTipGroup = "H";
            this.kryptonRibbonGroup4.TextLine1 = "HeaderBar Modes";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.modeHeaderBarGroup,
            this.modeHeaderBarHeaderGroup});
            this.kryptonRibbonGroupTriple2.MaximumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            this.kryptonRibbonGroupTriple2.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // modeHeaderBarGroup
            // 
            this.modeHeaderBarGroup.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.modeHeaderBarGroup.ImageLarge = global::Analogy.Properties.Resources.modeStackGroup_ImageLarge;
            this.modeHeaderBarGroup.ImageSmall = global::Analogy.Properties.Resources.modeStackGroup_ImageSmall;
            this.modeHeaderBarGroup.KeyTip = "HG";
            this.modeHeaderBarGroup.Tag = "HeaderBarCheckButtonGroup";
            this.modeHeaderBarGroup.TextLine1 = "HeaderBar - Group";
            this.modeHeaderBarGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // modeHeaderBarHeaderGroup
            // 
            this.modeHeaderBarHeaderGroup.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.modeHeaderBarHeaderGroup.ImageLarge = global::Analogy.Properties.Resources.modeStackGroup_ImageLarge;
            this.modeHeaderBarHeaderGroup.ImageSmall = global::Analogy.Properties.Resources.modeStackGroup_ImageSmall;
            this.modeHeaderBarHeaderGroup.KeyTip = "HH";
            this.modeHeaderBarHeaderGroup.Tag = "HeaderBarCheckButtonHeaderGroup";
            this.modeHeaderBarHeaderGroup.TextLine1 = "HeaderBar - HeaderGroup";
            this.modeHeaderBarHeaderGroup.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonGroup7
            // 
            this.kryptonRibbonGroup7.DialogBoxLauncher = false;
            this.kryptonRibbonGroup7.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple7});
            this.kryptonRibbonGroup7.TextLine1 = "HeaderGroup Modes";
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.modeHeaderGroupTab});
            this.kryptonRibbonGroupTriple7.MaximumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium;
            // 
            // modeHeaderGroupTab
            // 
            this.modeHeaderGroupTab.ImageSmall = global::Analogy.Properties.Resources.modeBarRibbonTabGroup_ImageSmall;
            this.modeHeaderGroupTab.KeyTip = "GT";
            this.modeHeaderGroupTab.Tag = "HeaderGroupTab";
            this.modeHeaderGroupTab.TextLine1 = "HeaderGroup - Tab";
            this.modeHeaderGroupTab.Click += new System.EventHandler(this.kryptonRibbonModeButton_Click);
            // 
            // kryptonRibbonTab2
            // 
            this.kryptonRibbonTab2.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup6});
            this.kryptonRibbonTab2.KeyTip = "A";
            this.kryptonRibbonTab2.Text = "Actions";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.AllowCollapsed = false;
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.KeyTipGroup = "C";
            this.kryptonRibbonGroup1.TextLine1 = "Colors";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.colorsRandom,
            this.colorsReset});
            this.kryptonRibbonGroupTriple1.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Large;
            // 
            // colorsRandom
            // 
            this.colorsRandom.ImageLarge = global::Analogy.Properties.Resources.colorsRandom_ImageLarge;
            this.colorsRandom.KeyTip = "R";
            this.colorsRandom.TextLine1 = "Random";
            this.colorsRandom.TextLine2 = "Page Colors";
            this.colorsRandom.Click += new System.EventHandler(this.colorsRandom_Click);
            // 
            // colorsReset
            // 
            this.colorsReset.ImageLarge = global::Analogy.Properties.Resources.colorsReset_ImageLarge;
            this.colorsReset.KeyTip = "S";
            this.colorsReset.TextLine1 = "Reset";
            this.colorsReset.TextLine2 = "Page Colors";
            this.colorsReset.Click += new System.EventHandler(this.colorsReset_Click);
            // 
            // kryptonRibbonGroup6
            // 
            this.kryptonRibbonGroup6.AllowCollapsed = false;
            this.kryptonRibbonGroup6.DialogBoxLauncher = false;
            this.kryptonRibbonGroup6.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple6});
            this.kryptonRibbonGroup6.TextLine1 = "ButtonSpecs";
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.buttonSpecsAdd,
            this.buttonSpecsClear});
            this.kryptonRibbonGroupTriple6.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Large;
            // 
            // buttonSpecsAdd
            // 
            this.buttonSpecsAdd.ImageLarge = global::Analogy.Properties.Resources.buttonSpecsAdd_ImageLarge;
            this.buttonSpecsAdd.TextLine1 = "Add Page";
            this.buttonSpecsAdd.TextLine2 = "ButtonSpecs";
            this.buttonSpecsAdd.Click += new System.EventHandler(this.buttonSpecsAdd_Click);
            // 
            // buttonSpecsClear
            // 
            this.buttonSpecsClear.ImageLarge = global::Analogy.Properties.Resources.buttonSpecsClear_ImageLarge;
            this.buttonSpecsClear.KeyTip = "C";
            this.buttonSpecsClear.TextLine1 = "Clear Page";
            this.buttonSpecsClear.TextLine2 = "ButtonSpecs";
            this.buttonSpecsClear.Click += new System.EventHandler(this.buttonSpecsClear_Click);
            // 
            // krtTheme
            // 
            this.krtTheme.Text = "Theme";
            // 
            // krtSettings
            // 
            this.krtSettings.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup11});
            this.krtSettings.Text = "Settings";
            // 
            // kryptonRibbonGroup11
            // 
            this.kryptonRibbonGroup11.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple11,
            this.kryptonRibbonGroupTriple12,
            this.kryptonRibbonGroupTriple13,
            this.kryptonRibbonGroupTriple14});
            this.kryptonRibbonGroup11.TextLine1 = "Settings";
            // 
            // kryptonRibbonGroupTriple11
            // 
            this.kryptonRibbonGroupTriple11.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.tsbSettingsFiltering,
            this.tsbSettingsPreDefined,
            this.tsbSettingsLookAndFeel});
            // 
            // tsbSettingsFiltering
            // 
            this.tsbSettingsFiltering.ImageLarge = global::Analogy.Properties.Resources.ReapplyFilter_32x32;
            this.tsbSettingsFiltering.ImageSmall = global::Analogy.Properties.Resources.ReapplyFilter_16x16;
            this.tsbSettingsFiltering.TextLine1 = "Filtering";
            // 
            // tsbSettingsPreDefined
            // 
            this.tsbSettingsPreDefined.ImageLarge = global::Analogy.Properties.Resources.FilterByArgument_Chart_32x32;
            this.tsbSettingsPreDefined.ImageSmall = global::Analogy.Properties.Resources.FilterByArgument_Chart_16x16;
            this.tsbSettingsPreDefined.TextLine1 = "Pre-Defined";
            this.tsbSettingsPreDefined.TextLine2 = "Queries";
            // 
            // tsbSettingsLookAndFeel
            // 
            this.tsbSettingsLookAndFeel.ImageLarge = global::Analogy.Properties.Resources.Palette_32x32;
            this.tsbSettingsLookAndFeel.ImageSmall = global::Analogy.Properties.Resources.Palette_16x16;
            this.tsbSettingsLookAndFeel.TextLine1 = "Look and Feel";
            // 
            // kryptonRibbonGroupTriple12
            // 
            this.kryptonRibbonGroupTriple12.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.tsbSettingsUserStatistics,
            this.tsbSettingsExtension,
            this.tsbSettingsShortcuts});
            // 
            // tsbSettingsUserStatistics
            // 
            this.tsbSettingsUserStatistics.ImageLarge = global::Analogy.Properties.Resources.Statistical_32x32;
            this.tsbSettingsUserStatistics.ImageSmall = global::Analogy.Properties.Resources.Statistical_16x16;
            this.tsbSettingsUserStatistics.TextLine1 = "User Statistics";
            // 
            // tsbSettingsExtension
            // 
            this.tsbSettingsExtension.ImageLarge = global::Analogy.Properties.Resources.Wizard_32x32;
            this.tsbSettingsExtension.ImageSmall = global::Analogy.Properties.Resources.Wizard_32x32;
            this.tsbSettingsExtension.TextLine1 = "Extensions";
            // 
            // tsbSettingsShortcuts
            // 
            this.tsbSettingsShortcuts.ImageLarge = global::Analogy.Properties.Resources.ArrangeGroups_32x32;
            this.tsbSettingsShortcuts.TextLine1 = "Shortcuts";
            // 
            // kryptonRibbonGroupTriple13
            // 
            this.kryptonRibbonGroupTriple13.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.tsbSettingsMRU,
            this.tsbSettingsResources,
            this.tsbSettingsDataProviders});
            // 
            // tsbSettingsMRU
            // 
            this.tsbSettingsMRU.ImageLarge = global::Analogy.Properties.Resources.RecentlyUse_32x32;
            this.tsbSettingsMRU.ImageSmall = global::Analogy.Properties.Resources.RecentlyUse_16x16;
            this.tsbSettingsMRU.TextLine1 = "MRU";
            // 
            // tsbSettingsResources
            // 
            this.tsbSettingsResources.ImageLarge = global::Analogy.Properties.Resources.StackedLine_32x32;
            this.tsbSettingsResources.ImageSmall = global::Analogy.Properties.Resources.StackedLine_16x16;
            this.tsbSettingsResources.TextLine1 = "Resources";
            this.tsbSettingsResources.TextLine2 = "Usage";
            // 
            // tsbSettingsDataProviders
            // 
            this.tsbSettingsDataProviders.ImageLarge = global::Analogy.Properties.Resources.Database_on;
            this.tsbSettingsDataProviders.TextLine1 = "Data Providers";
            this.tsbSettingsDataProviders.TextLine2 = "Settings";
            // 
            // kryptonRibbonGroupTriple14
            // 
            this.kryptonRibbonGroupTriple14.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.tsbSettingsCustomDataProviders});
            // 
            // tsbSettingsCustomDataProviders
            // 
            this.tsbSettingsCustomDataProviders.ImageLarge = global::Analogy.Properties.Resources.Database_on;
            this.tsbSettingsCustomDataProviders.TextLine1 = "Custom Data";
            this.tsbSettingsCustomDataProviders.TextLine2 = "Providers Setings";
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonDockableWorkspace);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 165);
            this.kryptonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Padding = new System.Windows.Forms.Padding(4);
            this.kryptonPanel.Size = new System.Drawing.Size(1083, 565);
            this.kryptonPanel.TabIndex = 1;
            // 
            // kryptonDockableWorkspace
            // 
            this.kryptonDockableWorkspace.AutoHiddenHost = false;
            this.kryptonDockableWorkspace.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace.Location = new System.Drawing.Point(4, 4);
            this.kryptonDockableWorkspace.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace";
            // 
            // 
            // 
            this.kryptonDockableWorkspace.Root.UniqueName = "5594893E2F2E42885594893E2F2E4288";
            this.kryptonDockableWorkspace.Root.WorkspaceControl = this.kryptonDockableWorkspace;
            this.kryptonDockableWorkspace.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace.Size = new System.Drawing.Size(1075, 557);
            this.kryptonDockableWorkspace.TabIndex = 0;
            this.kryptonDockableWorkspace.TabStop = true;
            // 
            // kryptonDockingManager
            // 
            this.kryptonDockingManager.ShowPageContextMenu += new System.EventHandler<ComponentFactory.Krypton.Docking.ContextPageEventArgs>(this.kryptonDockingManager_ShowPageContextMenu);
            this.kryptonDockingManager.ShowWorkspacePageContextMenu += new System.EventHandler<ComponentFactory.Krypton.Docking.ContextPageEventArgs>(this.kryptonDockingManager_ShowWorkspacePageContextMenu);
            this.kryptonDockingManager.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager_DockspaceAdding);
            this.kryptonDockingManager.DockspaceCellAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceCellEventArgs>(this.kryptonDockingManager_DockspaceCellAdding);
            this.kryptonDockingManager.FloatspaceCellAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.FloatspaceCellEventArgs>(this.kryptonDockingManager_FloatspaceCellAdding);
            this.kryptonDockingManager.FloatingWindowAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.FloatingWindowEventArgs>(this.kryptonDockingManager_FloatingWindowAdding);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // kryptonRibbonGroupGallery1
            // 
            this.kryptonRibbonGroupGallery1.ImageList = null;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblError,
            this.tsslFileCaching,
            this.tsslMemoryUsage,
            this.tsslIdleMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 730);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1083, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblError
            // 
            this.tsslblError.Name = "tsslblError";
            this.tsslblError.Size = new System.Drawing.Size(36, 20);
            this.tsslblError.Text = "N/A";
            // 
            // tsslFileCaching
            // 
            this.tsslFileCaching.Name = "tsslFileCaching";
            this.tsslFileCaching.Size = new System.Drawing.Size(85, 20);
            this.tsslFileCaching.Text = "file caching";
            // 
            // TmrAutoConnect
            // 
            this.TmrAutoConnect.Interval = 1000;
            this.TmrAutoConnect.Tick += new System.EventHandler(this.TmrAutoConnect_Tick);
            // 
            // tmrStatusUpdates
            // 
            this.tmrStatusUpdates.Enabled = true;
            this.tmrStatusUpdates.Interval = 1000;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Search.png");
            this.imageList3.Images.SetKeyName(1, "1.png");
            this.imageList3.Images.SetKeyName(2, "2.png");
            this.imageList3.Images.SetKeyName(3, "3.png");
            this.imageList3.Images.SetKeyName(4, "4.png");
            this.imageList3.Images.SetKeyName(5, "5.png");
            this.imageList3.Images.SetKeyName(6, "6.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icon-3.png");
            this.imageList1.Images.SetKeyName(1, "Icon-4.png");
            this.imageList1.Images.SetKeyName(2, "Icon-5.png");
            this.imageList1.Images.SetKeyName(3, "Icon-6.png");
            this.imageList1.Images.SetKeyName(4, "Icon-7.png");
            this.imageList1.Images.SetKeyName(5, "Icon-8.png");
            this.imageList1.Images.SetKeyName(6, "Icon-9.png");
            this.imageList1.Images.SetKeyName(7, "Icon-10.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "__DVD RW drive.png");
            this.imageList2.Images.SetKeyName(1, "__Local Disk(c).png");
            this.imageList2.Images.SetKeyName(2, "__Local Disk(d).png");
            this.imageList2.Images.SetKeyName(3, "__Desktop.png");
            this.imageList2.Images.SetKeyName(4, "__Document.png");
            this.imageList2.Images.SetKeyName(5, "__Download.png");
            this.imageList2.Images.SetKeyName(6, "__Music.png");
            this.imageList2.Images.SetKeyName(7, "__Pictures.png");
            this.imageList2.Images.SetKeyName(8, "__Video.png");
            // 
            // tsslMemoryUsage
            // 
            this.tsslMemoryUsage.Name = "tsslMemoryUsage";
            this.tsslMemoryUsage.Size = new System.Drawing.Size(30, 20);
            this.tsslMemoryUsage.Text = "NA";
            // 
            // tsslIdleMessage
            // 
            this.tsslIdleMessage.Name = "tsslIdleMessage";
            this.tsslIdleMessage.Size = new System.Drawing.Size(65, 20);
            this.tsslIdleMessage.Text = "Idle user";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 756);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Analogy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonPanel kryptonPanel;
        private KryptonDockableWorkspace kryptonDockableWorkspace;
        private KryptonDockingManager kryptonDockingManager;
        private ImageList imageListSmall;
        private KryptonManager kryptonManager;
        private KryptonRibbon ribbonControlMain;
        private KryptonRibbonTab kryptonRibbonTab1;
        private KryptonRibbonGroup kryptonRibbonGroup2;
        private KryptonRibbonGroup kryptonRibbonGroup3;
        private KryptonRibbonGroup kryptonRibbonGroup4;
        private KryptonRibbonGroup kryptonRibbonGroup5;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private KryptonRibbonGroupButton modeHeaderBarHeaderGroup;
        private KryptonRibbonGroupButton modeHeaderBarGroup;
        private KryptonRibbonGroupButton modeTabGroup;
        private KryptonRibbonGroupButton modeBarGroupInside;
        private KryptonRibbonGroupButton modeBarGroupOutside;
        private KryptonRibbonGroupButton modeBarRibbonTabGroup;
        private KryptonRibbonGroupButton modeStackGroup;
        private KryptonRibbonGroupButton modeStackHeaderGroup;
        private KryptonRibbonTab kryptonRibbonTab2;
        private KryptonRibbonGroup kryptonRibbonGroup1;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private KryptonRibbonGroupButton colorsRandom;
        private KryptonRibbonGroupButton colorsReset;
        private KryptonRibbonGroup kryptonRibbonGroup6;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private KryptonRibbonGroupButton buttonSpecsAdd;
        private KryptonRibbonGroupButton buttonSpecsClear;
        private KryptonRibbonGroup kryptonRibbonGroup7;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private KryptonRibbonGroupButton modeHeaderGroupTab;
        private KryptonRibbonTab RibbonTabAnalogy;
        private KryptonRibbonGroup kryptonRibbonGroup8;
        private KryptonRibbonGroup kryptonRibbonGroup9;
        private KryptonRibbonGroupGallery kryptonRibbonGroupGallery1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslblError;
        private ToolStripStatusLabel tsslFileCaching;
        private Timer TmrAutoConnect;
        private Timer tmrStatusUpdates;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple8;
        private KryptonRibbonGroupButton tsbtnAnalogyOpenFolder;
        private KryptonRibbonGroupButton tsbtnAnalogyOpenFiles;
        private KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple9;
        private KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private KryptonRibbonGroupButton kryptonRibbonGroupButton4;
        private ImageList imageList3;
        private ImageList imageList1;
        private ImageList imageList2;
        private KryptonRibbonGroup kryptonRibbonGroup10;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple10;
        private KryptonRibbonGroupButton kryptonRibbonGroupButton5;
        private KryptonRibbonTab krtTheme;
        private KryptonRibbonTab krtSettings;
        private KryptonRibbonGroup kryptonRibbonGroup11;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple11;
        private KryptonRibbonGroupButton tsbSettingsFiltering;
        private KryptonRibbonGroupButton tsbSettingsPreDefined;
        private KryptonRibbonGroupButton tsbSettingsLookAndFeel;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple12;
        private KryptonRibbonGroupButton tsbSettingsUserStatistics;
        private KryptonRibbonGroupButton tsbSettingsExtension;
        private KryptonRibbonGroupButton tsbSettingsShortcuts;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple13;
        private KryptonRibbonGroupButton tsbSettingsMRU;
        private KryptonRibbonGroupButton tsbSettingsResources;
        private KryptonRibbonGroupButton tsbSettingsDataProviders;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple14;
        private KryptonRibbonGroupButton tsbSettingsCustomDataProviders;
        private KryptonRibbonGroupTriple kryptonRibbonGroupTriple15;
        private KryptonRibbonGroupButton kryptonRibbonGroupButton7;
        private KryptonRibbonGroupButton kryptonRibbonGroupButton8;
        private ContextMenuStrip contextMenuStripRecentFiles;
        private ToolStripStatusLabel tsslMemoryUsage;
        private ToolStripStatusLabel tsslIdleMessage;
    }
}


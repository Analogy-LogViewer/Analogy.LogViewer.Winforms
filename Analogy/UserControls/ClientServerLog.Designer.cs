namespace Analogy
{
    partial class ClientServerUCLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientServerUCLog));
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.splcLeft = new System.Windows.Forms.SplitContainer();
            this.lBoxSources = new System.Windows.Forms.ListBox();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRemove = new System.Windows.Forms.ToolStripButton();
            this.lBoxFiles = new System.Windows.Forms.ListBox();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsBtnOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.checkBoxSelectionMode = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxRecursiveLoad = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.ucLogs1 = new Analogy.UCLogs();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imageListBottom = new System.Windows.Forms.ImageList(this.components);
            this.tsPrimary = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).BeginInit();
            this.splcLeft.Panel1.SuspendLayout();
            this.splcLeft.Panel2.SuspendLayout();
            this.splcLeft.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSelectionMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRecursiveLoad)).BeginInit();
            this.tsPrimary.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltMain
            // 
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.Location = new System.Drawing.Point(0, 0);
            this.spltMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltMain.Name = "spltMain";
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.Controls.Add(this.splcLeft);
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.ucLogs1);
            this.spltMain.Size = new System.Drawing.Size(1387, 700);
            this.spltMain.SplitterDistance = 376;
            this.spltMain.TabIndex = 5;
            // 
            // splcLeft
            // 
            this.splcLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcLeft.Location = new System.Drawing.Point(0, 0);
            this.splcLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splcLeft.Name = "splcLeft";
            this.splcLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcLeft.Panel1
            // 
            this.splcLeft.Panel1.Controls.Add(this.lBoxSources);
            this.splcLeft.Panel1.Controls.Add(this.toolStripEx1);
            // 
            // splcLeft.Panel2
            // 
            this.splcLeft.Panel2.Controls.Add(this.lBoxFiles);
            this.splcLeft.Panel2.Controls.Add(this.toolStripEx2);
            this.splcLeft.Panel2.Controls.Add(this.checkBoxSelectionMode);
            this.splcLeft.Panel2.Controls.Add(this.checkBoxRecursiveLoad);
            this.splcLeft.Size = new System.Drawing.Size(376, 700);
            this.splcLeft.SplitterDistance = 244;
            this.splcLeft.TabIndex = 4;
            // 
            // lBoxSources
            // 
            this.lBoxSources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxSources.FormattingEnabled = true;
            this.lBoxSources.ItemHeight = 16;
            this.lBoxSources.Location = new System.Drawing.Point(0, 27);
            this.lBoxSources.Name = "lBoxSources";
            this.lBoxSources.Size = new System.Drawing.Size(376, 217);
            this.lBoxSources.TabIndex = 3;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.tsBtnRemove});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripEx1.Size = new System.Drawing.Size(376, 27);
            this.toolStripEx1.TabIndex = 4;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.Image = global::Analogy.Properties.Resources.AddNewDataSource_32x32;
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(61, 24);
            this.tsBtnAdd.Text = "Add";
            // 
            // tsBtnRemove
            // 
            this.tsBtnRemove.Image = global::Analogy.Properties.Resources.Database_off;
            this.tsBtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRemove.Name = "tsBtnRemove";
            this.tsBtnRemove.Size = new System.Drawing.Size(87, 24);
            this.tsBtnRemove.Text = "Remove";
            // 
            // lBoxFiles
            // 
            this.lBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxFiles.FormattingEnabled = true;
            this.lBoxFiles.ItemHeight = 16;
            this.lBoxFiles.Location = new System.Drawing.Point(0, 65);
            this.lBoxFiles.Name = "lBoxFiles";
            this.lBoxFiles.Size = new System.Drawing.Size(376, 387);
            this.lBoxFiles.TabIndex = 10;
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnOpenFolder,
            this.tsBtnRefresh,
            this.tsBtnDelete});
            this.toolStripEx2.Location = new System.Drawing.Point(0, 38);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripEx2.Size = new System.Drawing.Size(376, 27);
            this.toolStripEx2.TabIndex = 9;
            this.toolStripEx2.Text = "toolStripEx2";
            // 
            // tsBtnOpenFolder
            // 
            this.tsBtnOpenFolder.Image = global::Analogy.Properties.Resources.Action_OpenFile_16x16;
            this.tsBtnOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpenFolder.Name = "tsBtnOpenFolder";
            this.tsBtnOpenFolder.Size = new System.Drawing.Size(115, 24);
            this.tsBtnOpenFolder.Text = "Open Folder";
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.Image = global::Analogy.Properties.Resources.RefreshAllPivotTable_32x32;
            this.tsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(82, 24);
            this.tsBtnRefresh.Text = "Refresh";
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnDelete.Image = global::Analogy.Properties.Resources.DeleteList_32x32;
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(77, 24);
            this.tsBtnDelete.Text = "Delete";
            // 
            // checkBoxSelectionMode
            // 
            this.checkBoxSelectionMode.BeforeTouchSize = new System.Drawing.Size(376, 19);
            this.checkBoxSelectionMode.Checked = true;
            this.checkBoxSelectionMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSelectionMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxSelectionMode.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxSelectionMode.Location = new System.Drawing.Point(0, 19);
            this.checkBoxSelectionMode.Name = "checkBoxSelectionMode";
            this.checkBoxSelectionMode.Size = new System.Drawing.Size(376, 19);
            this.checkBoxSelectionMode.TabIndex = 12;
            this.checkBoxSelectionMode.Text = "Clear log between selection";
            // 
            // checkBoxRecursiveLoad
            // 
            this.checkBoxRecursiveLoad.BeforeTouchSize = new System.Drawing.Size(376, 19);
            this.checkBoxRecursiveLoad.Checked = true;
            this.checkBoxRecursiveLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRecursiveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxRecursiveLoad.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxRecursiveLoad.Location = new System.Drawing.Point(0, 0);
            this.checkBoxRecursiveLoad.Name = "checkBoxRecursiveLoad";
            this.checkBoxRecursiveLoad.Size = new System.Drawing.Size(376, 19);
            this.checkBoxRecursiveLoad.TabIndex = 11;
            this.checkBoxRecursiveLoad.Text = "Load Recursive Files";
            // 
            // ucLogs1
            // 
            this.ucLogs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLogs1.DoNotAddToRecentHistory = false;
            this.ucLogs1.ForceNoFileCaching = false;
            this.ucLogs1.Location = new System.Drawing.Point(0, 0);
            this.ucLogs1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucLogs1.Name = "ucLogs1";
            this.ucLogs1.OnlineMode = false;
            this.ucLogs1.Size = new System.Drawing.Size(1007, 700);
            this.ucLogs1.TabIndex = 0;
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
            // 
            // imageListBottom
            // 
            this.imageListBottom.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBottom.ImageStream")));
            this.imageListBottom.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBottom.Images.SetKeyName(0, "Info_16x16.png");
            this.imageListBottom.Images.SetKeyName(1, "RichEditBookmark_16x16.png");
            this.imageListBottom.Images.SetKeyName(2, "RichEditBookmark_32x32.png");
            // 
            // tsPrimary
            // 
            this.tsPrimary.AutoSize = false;
            this.tsPrimary.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPrimary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.tsPrimary.Location = new System.Drawing.Point(0, 0);
            this.tsPrimary.Name = "tsPrimary";
            this.tsPrimary.Size = new System.Drawing.Size(1387, 46);
            this.tsPrimary.TabIndex = 6;
            this.tsPrimary.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // ClientServerUCLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spltMain);
            this.Controls.Add(this.tsPrimary);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientServerUCLog";
            this.Size = new System.Drawing.Size(1387, 700);
            this.Load += new System.EventHandler(this.ClientServerUCLog_Load);
            this.spltMain.Panel1.ResumeLayout(false);
            this.spltMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            this.splcLeft.Panel1.ResumeLayout(false);
            this.splcLeft.Panel1.PerformLayout();
            this.splcLeft.Panel2.ResumeLayout(false);
            this.splcLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).EndInit();
            this.splcLeft.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSelectionMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRecursiveLoad)).EndInit();
            this.tsPrimary.ResumeLayout(false);
            this.tsPrimary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip tsPrimary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splcLeft;
        private System.Windows.Forms.ImageList imageListBottom;
        private UCLogs ucLogs1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton tsBtnAdd;
        private System.Windows.Forms.ToolStripButton tsBtnRemove;
        private System.Windows.Forms.ListBox lBoxSources;
        private System.Windows.Forms.ListBox lBoxFiles;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.ToolStripButton tsBtnOpenFolder;
        private System.Windows.Forms.ToolStripButton tsBtnRefresh;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxSelectionMode;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxRecursiveLoad;
    }
}

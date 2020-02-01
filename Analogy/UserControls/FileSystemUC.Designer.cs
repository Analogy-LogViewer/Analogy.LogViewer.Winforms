namespace Analogy
{
    partial class FileSystemUC
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.splcLeft = new System.Windows.Forms.SplitContainer();
            this.tvFolderUC = new Analogy.FolderTreeViewUC();
            this.lBoxFiles = new System.Windows.Forms.ListBox();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.checkBoxRecursiveLoad = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).BeginInit();
            this.splcLeft.Panel1.SuspendLayout();
            this.splcLeft.Panel2.SuspendLayout();
            this.splcLeft.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRecursiveLoad)).BeginInit();
            this.SuspendLayout();
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
            this.splcLeft.Panel1.Controls.Add(this.tvFolderUC);
            // 
            // splcLeft.Panel2
            // 
            this.splcLeft.Panel2.Controls.Add(this.lBoxFiles);
            this.splcLeft.Panel2.Controls.Add(this.toolStripEx1);
            this.splcLeft.Panel2.Controls.Add(this.checkBoxRecursiveLoad);
            this.splcLeft.Size = new System.Drawing.Size(523, 426);
            this.splcLeft.SplitterDistance = 201;
            this.splcLeft.TabIndex = 5;
            // 
            // tvFolderUC
            // 
            this.tvFolderUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFolderUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tvFolderUC.Location = new System.Drawing.Point(0, 0);
            this.tvFolderUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvFolderUC.Name = "tvFolderUC";
            this.tvFolderUC.Size = new System.Drawing.Size(523, 201);
            this.tvFolderUC.TabIndex = 0;
            // 
            // lBoxFiles
            // 
            this.lBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxFiles.FormattingEnabled = true;
            this.lBoxFiles.ItemHeight = 16;
            this.lBoxFiles.Location = new System.Drawing.Point(0, 46);
            this.lBoxFiles.Name = "lBoxFiles";
            this.lBoxFiles.Size = new System.Drawing.Size(523, 175);
            this.lBoxFiles.TabIndex = 9;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 19);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripEx1.Size = new System.Drawing.Size(523, 27);
            this.toolStripEx1.TabIndex = 10;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::Analogy.Properties.Resources.Open2_32x32;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(69, 24);
            this.btnOpen.Text = "Open";
            // 
            // checkBoxRecursiveLoad
            // 
            this.checkBoxRecursiveLoad.BeforeTouchSize = new System.Drawing.Size(523, 19);
            this.checkBoxRecursiveLoad.Checked = true;
            this.checkBoxRecursiveLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRecursiveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxRecursiveLoad.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxRecursiveLoad.Location = new System.Drawing.Point(0, 0);
            this.checkBoxRecursiveLoad.Name = "checkBoxRecursiveLoad";
            this.checkBoxRecursiveLoad.Size = new System.Drawing.Size(523, 19);
            this.checkBoxRecursiveLoad.TabIndex = 12;
            this.checkBoxRecursiveLoad.Text = "Load Recursive Files";
            // 
            // FileSystemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splcLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileSystemUC";
            this.Size = new System.Drawing.Size(523, 450);
            this.splcLeft.Panel1.ResumeLayout(false);
            this.splcLeft.Panel2.ResumeLayout(false);
            this.splcLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).EndInit();
            this.splcLeft.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRecursiveLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splcLeft;
        private FolderTreeViewUC tvFolderUC;
        private System.Windows.Forms.ListBox lBoxFiles;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxRecursiveLoad;
    }
}

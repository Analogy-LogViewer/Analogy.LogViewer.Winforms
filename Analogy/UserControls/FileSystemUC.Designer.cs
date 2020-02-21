using System.ComponentModel;
using System.Windows.Forms;

namespace Analogy
{
    partial class FileSystemUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splcLeft = new System.Windows.Forms.SplitContainer();
            this.tvFolderUC = new Analogy.FolderTreeViewUC();
            this.fileListing1 = new Analogy.FileListing();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).BeginInit();
            this.splcLeft.Panel1.SuspendLayout();
            this.splcLeft.Panel2.SuspendLayout();
            this.splcLeft.SuspendLayout();
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
            this.splcLeft.Panel2.Controls.Add(this.fileListing1);
            this.splcLeft.Size = new System.Drawing.Size(523, 450);
            this.splcLeft.SplitterDistance = 212;
            this.splcLeft.TabIndex = 5;
            // 
            // tvFolderUC
            // 
            this.tvFolderUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFolderUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tvFolderUC.Location = new System.Drawing.Point(0, 0);
            this.tvFolderUC.Margin = new System.Windows.Forms.Padding(4);
            this.tvFolderUC.Name = "tvFolderUC";
            this.tvFolderUC.Size = new System.Drawing.Size(523, 212);
            this.tvFolderUC.TabIndex = 0;
            // 
            // fileListing1
            // 
            this.fileListing1.DataProvider = null;
            this.fileListing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListing1.Location = new System.Drawing.Point(0, 0);
            this.fileListing1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileListing1.Name = "fileListing1";
            this.fileListing1.Size = new System.Drawing.Size(523, 234);
            this.fileListing1.TabIndex = 0;
            this.fileListing1.ZipFilesOnly = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).EndInit();
            this.splcLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splcLeft;
        private FolderTreeViewUC tvFolderUC;
        private FileListing fileListing1;
    }
}

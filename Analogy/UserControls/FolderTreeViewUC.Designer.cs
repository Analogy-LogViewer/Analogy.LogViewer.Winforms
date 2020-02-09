
using System.ComponentModel;
using System.Windows.Forms;

namespace Analogy
{
    partial class FolderTreeViewUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderTreeViewUC));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbFolder = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.tsBtnRootDrive = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbFolder);
            this.panel2.Controls.Add(this.btnOpenFolder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 23);
            this.panel2.TabIndex = 5;
            // 
            // txtbFolder
            // 
            this.txtbFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbFolder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFolder.Location = new System.Drawing.Point(0, 0);
            this.txtbFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbFolder.Name = "txtbFolder";
            this.txtbFolder.Size = new System.Drawing.Size(418, 27);
            this.txtbFolder.TabIndex = 12;
            this.txtbFolder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbFolder_KeyUp);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.AccessibleName = "Button";
            this.btnOpenFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenFolder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.Location = new System.Drawing.Point(418, 0);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(26, 23);
            this.btnOpenFolder.TabIndex = 13;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
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
            // toolStripTop
            // 
            this.toolStripTop.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnRootDrive});
            this.toolStripTop.Location = new System.Drawing.Point(0, 23);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripTop.Size = new System.Drawing.Size(444, 27);
            this.toolStripTop.TabIndex = 7;
            this.toolStripTop.Text = "toolStripEx1";
            // 
            // tsBtnRootDrive
            // 
            this.tsBtnRootDrive.Image = global::Analogy.Properties.Resources.ServerMode_32x32;
            this.tsBtnRootDrive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRootDrive.Name = "tsBtnRootDrive";
            this.tsBtnRootDrive.Size = new System.Drawing.Size(104, 24);
            this.tsBtnRootDrive.Text = "Root Drive";
            // 
            // FolderTreeViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripTop);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "FolderTreeViewUC";
            this.Size = new System.Drawing.Size(444, 311);
            this.Load += new System.EventHandler(this.FolderTreeViewUC_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private TextBox txtbFolder;
        private ImageList imageList;
        private Button btnOpenFolder;
        private ToolStrip toolStripTop;
        private ToolStripButton tsBtnRootDrive;
    }
}

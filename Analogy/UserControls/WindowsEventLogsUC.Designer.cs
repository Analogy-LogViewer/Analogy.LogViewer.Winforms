using System.ComponentModel;
using System.Windows.Forms;

namespace Analogy
{
    partial class WindowsEventLogsUC
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
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLaunchCount = new System.Windows.Forms.Label();
            this.splitContainerAdv1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSelected
            // 
            this.lstSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelected.ItemHeight = 16;
            this.lstSelected.Location = new System.Drawing.Point(0, 30);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(364, 427);
            this.lstSelected.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleName = "Button";
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnRemove.Location = new System.Drawing.Point(0, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(364, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "remove from selected logs ->";
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lstAvailable
            // 
            this.lstAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAvailable.ItemHeight = 16;
            this.lstAvailable.Location = new System.Drawing.Point(0, 30);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.Size = new System.Drawing.Size(477, 427);
            this.lstAvailable.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "Button";
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(477, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "<-- Add to selected logs";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblLaunchCount
            // 

            this.lblLaunchCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLaunchCount.Location = new System.Drawing.Point(0, 0);
            this.lblLaunchCount.Name = "lblLaunchCount";
            this.lblLaunchCount.Size = new System.Drawing.Size(848, 29);
            this.lblLaunchCount.TabIndex = 2;
            this.lblLaunchCount.Text = "Select logs from the right list or remove selected log from the left list:";
            this.lblLaunchCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.lstSelected);
            this.splitContainerAdv1.Panel1.Controls.Add(this.btnRemove);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.lstAvailable);
            this.splitContainerAdv1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainerAdv1.Size = new System.Drawing.Size(848, 457);
            this.splitContainerAdv1.SplitterDistance = 364;
            this.splitContainerAdv1.TabIndex = 5;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // WindowsEventLogsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.lblLaunchCount);
            this.Name = "WindowsEventLogsUC";
            this.Size = new System.Drawing.Size(848, 486);
            this.Load += new System.EventHandler(this.XtraUCWindowsEventLogs_Load);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox lstSelected;
        private Button btnRemove;
        private ListBox lstAvailable;
        private Button btnAdd;
        private Label lblLaunchCount;
        private SplitContainer splitContainerAdv1;
     
    }
}

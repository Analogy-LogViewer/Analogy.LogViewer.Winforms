﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Analogy
{
    partial class ChangeLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLog));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtxtbChangeLog = new System.Windows.Forms.RichTextBox();
            this.sBtnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtxtbChangeLog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sBtnOk);
            this.splitContainer1.Size = new System.Drawing.Size(974, 452);
            this.splitContainer1.SplitterDistance = 406;
            this.splitContainer1.TabIndex = 0;
            // 
            // rtxtbChangeLog
            // 
            this.rtxtbChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbChangeLog.Location = new System.Drawing.Point(0, 0);
            this.rtxtbChangeLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtbChangeLog.Name = "rtxtbChangeLog";
            this.rtxtbChangeLog.Size = new System.Drawing.Size(974, 406);
            this.rtxtbChangeLog.TabIndex = 0;
            this.rtxtbChangeLog.Text = resources.GetString("rtxtbChangeLog.Text");
            // 
            // sBtnOk
            // 
            this.sBtnOk.AccessibleName = "Button";
            this.sBtnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.sBtnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sBtnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnOk.Location = new System.Drawing.Point(899, 0);
            this.sBtnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtnOk.Name = "sBtnOk";
            this.sBtnOk.Size = new System.Drawing.Size(75, 42);
            this.sBtnOk.TabIndex = 1;
            this.sBtnOk.Text = "OK";
            this.sBtnOk.Click += new System.EventHandler(this.sBtnOk_Click);
            // 
            // ChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 452);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Log (Before releasing as open source)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox rtxtbChangeLog;
        private Button sBtnOk;
    }
}
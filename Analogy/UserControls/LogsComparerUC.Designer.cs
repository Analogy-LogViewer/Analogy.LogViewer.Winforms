namespace Analogy.Tools
{
    partial class LogsComparerUC
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
            this.rtboxRight = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtboxLeft = new System.Windows.Forms.RichTextBox();
            this.lblFileLeft = new System.Windows.Forms.Label();
            this.sBtnLeft = new Syncfusion.WinForms.Controls.SfButton();
            this.lblFileRight = new System.Windows.Forms.Label();
            this.simpleButtonRight = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtboxRight
            // 
            this.rtboxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtboxRight.Location = new System.Drawing.Point(0, 32);
            this.rtboxRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rtboxRight.Name = "rtboxRight";
            this.rtboxRight.Size = new System.Drawing.Size(255, 355);
            this.rtboxRight.TabIndex = 3;
            this.rtboxRight.Text = "";
            this.rtboxRight.WordWrap = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtboxLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtboxRight);
            this.splitContainer1.Size = new System.Drawing.Size(504, 387);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // rtboxLeft
            // 
            this.rtboxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtboxLeft.Location = new System.Drawing.Point(0, 32);
            this.rtboxLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtboxLeft.Name = "rtboxLeft";
            this.rtboxLeft.Size = new System.Drawing.Size(243, 355);
            this.rtboxLeft.TabIndex = 0;
            this.rtboxLeft.Text = "";
            this.rtboxLeft.WordWrap = false;
            // 
            // lblFileLeft
            // 
            this.lblFileLeft.AutoEllipsis = true;
            this.lblFileLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileLeft.Location = new System.Drawing.Point(2, 2);
            this.lblFileLeft.Name = "lblFileLeft";
            this.lblFileLeft.Size = new System.Drawing.Size(164, 28);
            this.lblFileLeft.TabIndex = 1;
            // 
            // sBtnLeft
            // 
            this.sBtnLeft.AccessibleName = "Button";
            this.sBtnLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.sBtnLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sBtnLeft.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBtnLeft.Location = new System.Drawing.Point(166, 2);
            this.sBtnLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sBtnLeft.Name = "sBtnLeft";
            this.sBtnLeft.Size = new System.Drawing.Size(75, 28);
            this.sBtnLeft.TabIndex = 2;
            this.sBtnLeft.Text = "..";
            this.sBtnLeft.Click += new System.EventHandler(this.sBtnLeft_Click);
            // 
            // lblFileRight
            // 
            this.lblFileRight.AutoEllipsis = true;
            this.lblFileRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileRight.Location = new System.Drawing.Point(2, 2);
            this.lblFileRight.Name = "lblFileRight";
            this.lblFileRight.Size = new System.Drawing.Size(176, 28);
            this.lblFileRight.TabIndex = 2;
            // 
            // simpleButtonRight
            // 
            this.simpleButtonRight.AccessibleName = "Button";
            this.simpleButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.simpleButtonRight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonRight.Location = new System.Drawing.Point(178, 2);
            this.simpleButtonRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButtonRight.Name = "simpleButtonRight";
            this.simpleButtonRight.Size = new System.Drawing.Size(75, 28);
            this.simpleButtonRight.TabIndex = 3;
            this.simpleButtonRight.Text = "..";
            this.simpleButtonRight.Click += new System.EventHandler(this.simpleButtonRight_Click);
            // 
            // LogsComparerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogsComparerUC";
            this.Size = new System.Drawing.Size(504, 387);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtboxRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtboxLeft;
        private System.Windows.Forms.Label lblFileLeft;
        private System.Windows.Forms.Label lblFileRight;
        private Syncfusion.WinForms.Controls.SfButton sBtnLeft;
        private Syncfusion.WinForms.Controls.SfButton simpleButtonRight;
    }
}

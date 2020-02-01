namespace Analogy
{
    partial class ClientServerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientServerForm));
            this.sBtnAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.txtbPath = new System.Windows.Forms.TextBox();
            this.sBtnTest = new Syncfusion.WinForms.Controls.SfButton();
            this.rBtnNetwork = new System.Windows.Forms.RadioButton();
            this.rBtnLocal = new System.Windows.Forms.RadioButton();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblPath = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.SuspendLayout();
            // 
            // sBtnAdd
            // 
            this.sBtnAdd.AccessibleName = "Button";
            this.sBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sBtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnAdd.Location = new System.Drawing.Point(535, 94);
            this.sBtnAdd.Name = "sBtnAdd";
            this.sBtnAdd.Size = new System.Drawing.Size(186, 58);
            this.sBtnAdd.TabIndex = 0;
            this.sBtnAdd.Text = "Add";
            this.sBtnAdd.Click += new System.EventHandler(this.sBtnAdd_Click);
            // 
            // txtbPath
            // 
            this.txtbPath.Location = new System.Drawing.Point(127, 56);
            this.txtbPath.Name = "txtbPath";
            this.txtbPath.Size = new System.Drawing.Size(379, 22);
            this.txtbPath.TabIndex = 5;
            // 
            // sBtnTest
            // 
            this.sBtnTest.AccessibleName = "Button";
            this.sBtnTest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sBtnTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnTest.Location = new System.Drawing.Point(535, 20);
            this.sBtnTest.Name = "sBtnTest";
            this.sBtnTest.Size = new System.Drawing.Size(186, 58);
            this.sBtnTest.TabIndex = 6;
            this.sBtnTest.Text = "Test";
            this.sBtnTest.Click += new System.EventHandler(this.sBtnTest_Click);
            // 
            // rBtnNetwork
            // 
            this.rBtnNetwork.AutoSize = true;
            this.rBtnNetwork.Location = new System.Drawing.Point(14, 12);
            this.rBtnNetwork.Name = "rBtnNetwork";
            this.rBtnNetwork.Size = new System.Drawing.Size(113, 21);
            this.rBtnNetwork.TabIndex = 9;
            this.rBtnNetwork.Text = "Network Path";
            this.rBtnNetwork.UseVisualStyleBackColor = true;
            this.rBtnNetwork.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rBtnLocal
            // 
            this.rBtnLocal.AutoSize = true;
            this.rBtnLocal.Location = new System.Drawing.Point(163, 12);
            this.rBtnLocal.Name = "rBtnLocal";
            this.rBtnLocal.Size = new System.Drawing.Size(107, 21);
            this.rBtnLocal.TabIndex = 10;
            this.rBtnLocal.Text = "Local Folder";
            this.rBtnLocal.UseVisualStyleBackColor = true;
            this.rBtnLocal.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(127, 87);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(379, 22);
            this.txtDisplayName.TabIndex = 12;
            // 
            // lblPath
            // 
            this.lblPath.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblPath.BeforeTouchSize = new System.Drawing.Size(120, 22);
            this.lblPath.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblPath.Location = new System.Drawing.Point(1, 56);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(120, 22);
            this.lblPath.TabIndex = 13;
            this.lblPath.Text = "IP/Hostname:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(120, 22);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Location = new System.Drawing.Point(1, 87);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(120, 22);
            this.gradientLabel1.TabIndex = 13;
            this.gradientLabel1.Text = "Display Name:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 190);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.rBtnLocal);
            this.Controls.Add(this.rBtnNetwork);
            this.Controls.Add(this.sBtnTest);
            this.Controls.Add(this.txtbPath);
            this.Controls.Add(this.sBtnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Other File Locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton sBtnAdd;
        private System.Windows.Forms.TextBox txtbPath;
        private Syncfusion.WinForms.Controls.SfButton sBtnTest;
        private System.Windows.Forms.RadioButton rBtnNetwork;
        private System.Windows.Forms.RadioButton rBtnLocal;
        private System.Windows.Forms.TextBox txtDisplayName;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblPath;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
    }
}
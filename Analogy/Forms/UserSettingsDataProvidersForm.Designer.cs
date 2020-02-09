using System.ComponentModel;
using System.Windows.Forms;

namespace Analogy
{
    partial class UserSettingsDataProvidersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsDataProvidersForm));
            this._windowsEventLogsUcWindowsEventLogs1 = new Analogy.WindowsEventLogsUC();
            this.tabControlAdv1 = new System.Windows.Forms.TabControl();
            this.tabPageWindowsEventLogs = new System.Windows.Forms.TabPage();
            this.gradientLabel1 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new System.Windows.Forms.TabPage();
            this.gradientLabel2 = new System.Windows.Forms.Label();
            this.tabPageAdv3 = new System.Windows.Forms.TabPage();
            this.gradientLabel3 = new System.Windows.Forms.Label();
            this.tabPageAdv4 = new System.Windows.Forms.TabPage();
            this.gradientLabel4 = new System.Windows.Forms.Label();
            this.tabPageAdv5 = new System.Windows.Forms.TabPage();
            this.gradientLabel5 = new System.Windows.Forms.Label();
            this.tabPageAdv6 = new System.Windows.Forms.TabPage();
            this.gradientLabel6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageWindowsEventLogs.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            this.tabPageAdv5.SuspendLayout();
            this.tabPageAdv6.SuspendLayout();
            this.SuspendLayout();
            // 
            // _windowsEventLogsUcWindowsEventLogs1
            // 
            this._windowsEventLogsUcWindowsEventLogs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._windowsEventLogsUcWindowsEventLogs1.Location = new System.Drawing.Point(0, 27);
            this._windowsEventLogsUcWindowsEventLogs1.Name = "_windowsEventLogsUcWindowsEventLogs1";
            this._windowsEventLogsUcWindowsEventLogs1.Size = new System.Drawing.Size(851, 594);
            this._windowsEventLogsUcWindowsEventLogs1.TabIndex = 0;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv1.Controls.Add(this.tabPageWindowsEventLogs);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv6);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(1033, 628);
            this.tabControlAdv1.TabIndex = 1;
            // 
            // tabPageWindowsEventLogs
            // 
            this.tabPageWindowsEventLogs.Controls.Add(this._windowsEventLogsUcWindowsEventLogs1);
            this.tabPageWindowsEventLogs.Controls.Add(this.gradientLabel1);
            this.tabPageWindowsEventLogs.Location = new System.Drawing.Point(179, 3);
            this.tabPageWindowsEventLogs.Name = "tabPageWindowsEventLogs";
            this.tabPageWindowsEventLogs.Size = new System.Drawing.Size(851, 621);
            this.tabPageWindowsEventLogs.TabIndex = 1;
            this.tabPageWindowsEventLogs.Text = "Windows Event Logs";
           
            // 
            // gradientLabel1
            // 
           
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(851, 27);
            this.gradientLabel1.TabIndex = 0;
            this.gradientLabel1.Text = "Windows Event Logs: Real time settings:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.gradientLabel2);
            this.tabPageAdv2.Location = new System.Drawing.Point(179, 3);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(851, 621);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "IIs Logs";
            // 
            // gradientLabel2
            // 
            
            this.gradientLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel2.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(851, 27);
            this.gradientLabel2.TabIndex = 1;
            this.gradientLabel2.Text = "No Special Settings Exists";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.gradientLabel3);
            this.tabPageAdv3.Location = new System.Drawing.Point(179, 3);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.Size = new System.Drawing.Size(851, 621);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "Serilog Parser";
            // 
            // gradientLabel3
            // 
            
            this.gradientLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel3.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(851, 27);
            this.gradientLabel3.TabIndex = 2;
            this.gradientLabel3.Text = "Coming Soon";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Controls.Add(this.gradientLabel4);
            this.tabPageAdv4.Location = new System.Drawing.Point(179, 3);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.Size = new System.Drawing.Size(851, 621);
            this.tabPageAdv4.TabIndex = 4;
            this.tabPageAdv4.Text = "Log4Net Parser";
            // 
            // gradientLabel4
            // 

            this.gradientLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel4.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(851, 27);
            this.gradientLabel4.TabIndex = 3;
            this.gradientLabel4.Text = "Coming Soon";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.gradientLabel5);
            this.tabPageAdv5.Location = new System.Drawing.Point(179, 3);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.Size = new System.Drawing.Size(851, 621);
            this.tabPageAdv5.TabIndex = 5;
            this.tabPageAdv5.Text = "Json Parser";
            // 
            // gradientLabel5
            // 
            this.gradientLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel5.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel5.Name = "gradientLabel5";
            this.gradientLabel5.Size = new System.Drawing.Size(851, 27);
            this.gradientLabel5.TabIndex = 3;
            this.gradientLabel5.Text = "Coming Soon";
            this.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.Controls.Add(this.gradientLabel6);
            this.tabPageAdv6.Location = new System.Drawing.Point(179, 3);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.Size = new System.Drawing.Size(851, 621);
            this.tabPageAdv6.TabIndex = 6;
            this.tabPageAdv6.Text = "XML Parser";
            // 
            // gradientLabel6
            // 

            this.gradientLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel6.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel6.Name = "gradientLabel6";
            this.gradientLabel6.Size = new System.Drawing.Size(851, 27);
            this.gradientLabel6.TabIndex = 3;
            this.gradientLabel6.Text = "Coming Soon";
            this.gradientLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserSettingsDataProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 628);
            this.Controls.Add(this.tabControlAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserSettingsDataProvidersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Built-In Data Providers Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettingsDataProvidersForm_FormClosing);
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageWindowsEventLogs.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsEventLogsUC _windowsEventLogsUcWindowsEventLogs1;
        private TabControl tabControlAdv1;
        private TabPage tabPageWindowsEventLogs;
        private Label gradientLabel1;
        private TabPage tabPageAdv2;
        private Label gradientLabel2;
        private TabPage tabPageAdv3;
        private Label gradientLabel3;
        private TabPage tabPageAdv4;
        private Label gradientLabel4;
        private TabPage tabPageAdv5;
        private Label gradientLabel5;
        private TabPage tabPageAdv6;
        private Label gradientLabel6;
    }
}
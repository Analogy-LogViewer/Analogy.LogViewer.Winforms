namespace Analogy
{
    partial class WindowsEventLogsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsEventLogsForm));
            this._windowsEventLogsUcWindowsEventLogs1 = new Analogy.WindowsEventLogsUC();
            this.SuspendLayout();
            // 
            // _windowsEventLogsUcWindowsEventLogs1
            // 
            this._windowsEventLogsUcWindowsEventLogs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._windowsEventLogsUcWindowsEventLogs1.Location = new System.Drawing.Point(0, 0);
            this._windowsEventLogsUcWindowsEventLogs1.Name = "_windowsEventLogsUcWindowsEventLogs1";
            this._windowsEventLogsUcWindowsEventLogs1.Size = new System.Drawing.Size(845, 466);
            this._windowsEventLogsUcWindowsEventLogs1.TabIndex = 0;
            // 
            // WindowsEventLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 466);
            this.Controls.Add(this._windowsEventLogsUcWindowsEventLogs1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowsEventLogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Windows event logs";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsEventLogsUC _windowsEventLogsUcWindowsEventLogs1;
    }
}
using System.Windows.Forms;

namespace Analogy.UserControls
{
    partial class AnalogyColumnsMatcherUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalogyColumnsMatcherUC));
            this.lstBAnalogyColumns = new System.Windows.Forms.ListBox();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.sBtnMoveUp = new Syncfusion.WinForms.Controls.SfButton();
            this.sBtnMoveDown = new Syncfusion.WinForms.Controls.SfButton();
            this.lstBoxItems = new System.Windows.Forms.ListBox();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.scMain = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBAnalogyColumns
            // 
            this.lstBAnalogyColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBAnalogyColumns.FormattingEnabled = true;
            this.lstBAnalogyColumns.ItemHeight = 16;
            this.lstBAnalogyColumns.Items.AddRange(new object[] {
            "Date",
            "Text",
            "Source",
            "Module",
            "MethodName",
            "FileName",
            "User",
            "LineNumber",
            "ProcessID",
            "Thread",
            "Level",
            "Class",
            "Category",
            "ID",
            "__ignore__",
            "__ignore__",
            "__ignore__",
            "__ignore__",
            "__ignore__",
            "__ignore__",
            "__ignore__"});
            this.lstBAnalogyColumns.Location = new System.Drawing.Point(77, 39);
            this.lstBAnalogyColumns.Name = "lstBAnalogyColumns";
            this.lstBAnalogyColumns.Size = new System.Drawing.Size(263, 444);
            this.lstBAnalogyColumns.TabIndex = 12;
            this.lstBAnalogyColumns.SelectedIndexChanged += new System.EventHandler(this.lstBAnalogyColumns_SelectedIndexChanged);
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(263, 39);
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel2.Location = new System.Drawing.Point(77, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(263, 39);
            this.gradientLabel2.TabIndex = 11;
            this.gradientLabel2.Text = "Log message Columns";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sBtnMoveUp
            // 
            this.sBtnMoveUp.AccessibleName = "Button";
            this.sBtnMoveUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sBtnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sBtnMoveUp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBtnMoveUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sBtnMoveUp.ImageSize = new System.Drawing.Size(30, 30);
            this.sBtnMoveUp.Location = new System.Drawing.Point(0, 0);
            this.sBtnMoveUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtnMoveUp.Name = "sBtnMoveUp";
            this.sBtnMoveUp.Size = new System.Drawing.Size(77, 237);
            this.sBtnMoveUp.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sBtnMoveUp.TabIndex = 2;
            this.sBtnMoveUp.Text = "Up";
            this.sBtnMoveUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sBtnMoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sBtnMoveUp.Click += new System.EventHandler(this.SBtnMoveUp_Click);
            // 
            // sBtnMoveDown
            // 
            this.sBtnMoveDown.AccessibleName = "Button";
            this.sBtnMoveDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sBtnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sBtnMoveDown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBtnMoveDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sBtnMoveDown.ImageSize = new System.Drawing.Size(30, 30);
            this.sBtnMoveDown.Location = new System.Drawing.Point(0, 0);
            this.sBtnMoveDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtnMoveDown.Name = "sBtnMoveDown";
            this.sBtnMoveDown.Size = new System.Drawing.Size(77, 239);
            this.sBtnMoveDown.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.sBtnMoveDown.TabIndex = 3;
            this.sBtnMoveDown.Text = "Down";
            this.sBtnMoveDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sBtnMoveDown.Click += new System.EventHandler(this.SBtnMoveDown_Click);
            // 
            // lstBoxItems
            // 
            this.lstBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxItems.FormattingEnabled = true;
            this.lstBoxItems.ItemHeight = 16;
            this.lstBoxItems.Location = new System.Drawing.Point(0, 39);
            this.lstBoxItems.Name = "lstBoxItems";
            this.lstBoxItems.Size = new System.Drawing.Size(341, 444);
            this.lstBoxItems.TabIndex = 9;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(341, 39);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(341, 39);
            this.gradientLabel1.TabIndex = 10;
            this.gradientLabel1.Text = "Parsed columns.";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scMain
            // 
            this.scMain.BeforeTouchSize = 7;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.lstBAnalogyColumns);
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientLabel2);
            this.splitContainerAdv1.Panel1.Controls.Add(this.splitContainerAdv1);
            // 
            // scMain.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.lstBoxItems);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientLabel1);
            this.scMain.Size = new System.Drawing.Size(688, 483);
            this.scMain.SplitterDistance = 340;
            this.scMain.TabIndex = 11;
            this.scMain.Text = "splitContainerAdv1";
            this.scMain.ThemeName = "None";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.sBtnMoveUp);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.sBtnMoveDown);
            this.splitContainerAdv1.Size = new System.Drawing.Size(77, 483);
            this.splitContainerAdv1.SplitterDistance = 237;
            this.splitContainerAdv1.TabIndex = 13;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // AnalogyColumnsMatcherUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "AnalogyColumnsMatcherUC";
            this.Size = new System.Drawing.Size(688, 483);
            this.Load += new System.EventHandler(this.AnalogyColumnsMatcherUC_Load);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton sBtnMoveUp;
        private Syncfusion.WinForms.Controls.SfButton sBtnMoveDown;
        private ListBox lstBAnalogyColumns;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private ListBox lstBoxItems;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv scMain;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
    }
}

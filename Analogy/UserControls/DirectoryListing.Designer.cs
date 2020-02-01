using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.WinForms.Controls;

namespace Analogy
{
    partial class DirectoryListing
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
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo treeNodeAdvSubItemStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo treeColumnAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo();
            this.multiColumnTreeView1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // multiColumnTreeView1
            // 
            this.multiColumnTreeView1.AddSeparatorAtEnd = true;
            this.multiColumnTreeView1.AutoAdjustMultiLineHeight = true;
            this.multiColumnTreeView1.AutoGenerateColumns = true;
            this.multiColumnTreeView1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo1.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.DisabledOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            treeNodeAdvStyleInfo1.HoverCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            treeNodeAdvStyleInfo1.HoverOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.IntermediateDisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.IntermediateHoverCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            treeNodeAdvSubItemStyleInfo1.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvSubItemStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            treeColumnAdvStyleInfo1.AreaBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeColumnAdvStyleInfo1.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225))))));
            treeColumnAdvStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.multiColumnTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard", treeNodeAdvStyleInfo1),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - SubItem", treeNodeAdvSubItemStyleInfo1),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - Column", treeColumnAdvStyleInfo1)});
            this.multiColumnTreeView1.BeforeTouchSize = new System.Drawing.Size(521, 312);
            this.multiColumnTreeView1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.multiColumnTreeView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.multiColumnTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.ColumnsHeaderBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.multiColumnTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiColumnTreeView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiColumnTreeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.multiColumnTreeView1.HelpTextControl.BaseThemeName = null;
            this.multiColumnTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.HelpTextControl.Name = "m_helpText";
            this.multiColumnTreeView1.HelpTextControl.Size = new System.Drawing.Size(63, 19);
            this.multiColumnTreeView1.HelpTextControl.TabIndex = 0;
            this.multiColumnTreeView1.HelpTextControl.Text = "help text";
            this.multiColumnTreeView1.KeepDottedSelection = false;
            this.multiColumnTreeView1.LabelEdit = true;
            this.multiColumnTreeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.multiColumnTreeView1.LoadOnDemand = true;
            this.multiColumnTreeView1.Location = new System.Drawing.Point(10, 10);
            this.multiColumnTreeView1.Margin = new System.Windows.Forms.Padding(4);
            this.multiColumnTreeView1.MetroScrollBars = true;
            this.multiColumnTreeView1.Name = "multiColumnTreeView1";
            this.multiColumnTreeView1.OwnerDrawNodes = true;
            this.multiColumnTreeView1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197))))));
            this.multiColumnTreeView1.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.multiColumnTreeView1.Size = new System.Drawing.Size(521, 312);
            this.multiColumnTreeView1.Style = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnVisualStyle.Office2016Colorful;
            this.multiColumnTreeView1.TabIndex = 4;
            this.multiColumnTreeView1.Text = "MultiColumnTreeViewDemo.csmultiColumnTreeView1";
            this.multiColumnTreeView1.ThemeName = "Office2016Colorful";
            this.multiColumnTreeView1.ThemeStyle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.multiColumnTreeView1.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 0;
            this.multiColumnTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.multiColumnTreeView1.ToolTipControl.BaseThemeName = null;
            this.multiColumnTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiColumnTreeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.multiColumnTreeView1.ToolTipControl.Name = "m_toolTip";
            this.multiColumnTreeView1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.multiColumnTreeView1.ToolTipControl.TabIndex = 1;
            this.multiColumnTreeView1.ToolTipControl.Text = "toolTip";
            this.multiColumnTreeView1.TransparentControls = true;
            this.multiColumnTreeView1.VScrollPos = -13;


            treeColumnAdv1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            treeColumnAdv2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            treeColumnAdv3 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();

            treeColumnAdv1.HelpText = "Name";
            treeColumnAdv1.Highlighted = false;
            treeColumnAdv1.Text = "Name";
            treeColumnAdv1.Background = new BrushInfo(SystemColors.Highlight);
            treeColumnAdv1.AreaBackground = new BrushInfo(GradientStyle.ForwardDiagonal, Color.White, Color.Snow);
            treeColumnAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            treeColumnAdv2.HelpText = "Full Path";
            treeColumnAdv2.Highlighted = false;
            treeColumnAdv2.Text = "Full Path";
            treeColumnAdv2.Background = new BrushInfo(GradientStyle.Vertical, SystemColors.Highlight, SystemColors.Highlight);
            treeColumnAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            treeColumnAdv3.HelpText = "Date Modified";
            treeColumnAdv3.Highlighted = false;
            treeColumnAdv3.Text = "Date Modified";
            treeColumnAdv3.Background = new BrushInfo(GradientStyle.Vertical, SystemColors.Highlight, SystemColors.Highlight);
            treeColumnAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.Fill;

            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;
            // 
            // DirectoryListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multiColumnTreeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DirectoryListing";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(541, 332);
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView multiColumnTreeView1;
       private Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv1;
       private Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv2;
       private Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv3;
    }
}
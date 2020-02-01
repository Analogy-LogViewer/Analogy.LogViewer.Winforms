using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.IO;
using System.Linq;
using Analogy.Interfaces;
using Analogy.Types;
using Syncfusion.Data.Extensions;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;


namespace Analogy
{
    public partial class DirectoryListing : UserControl
    {
        public event EventHandler<FolderSelectionEventArgs> FolderChanged;
        private string FolderRoot { get; set; }
        private IAnalogyOfflineDataProvider DataProvider { get; set; }
        public DirectoryListing()
        {
            InitializeComponent();
            SetupEventsHandlers();
            multiColumnTreeView1.Columns.AddRange(new[] { treeColumnAdv1, treeColumnAdv2, treeColumnAdv3 });
            treeColumnAdv1.BaseStyle = (multiColumnTreeView1.BaseStylePairs[2] as StyleNamePair).Name;
            multiColumnTreeView1.FullRowSelect = true;
        }


        private void SetupEventsHandlers()
        {
            multiColumnTreeView1.BeforeExpand += multiColumnTreeView1_BeforeExpand;
            multiColumnTreeView1.AfterSelect += (s, e) =>
            {
                var items = multiColumnTreeView1.SelectedNodes.Cast<TreeNodeAdv>().ToList();
                if (items.Any())
                {
                   var folder = items.First();
                        FolderChanged?.Invoke(this, new FolderSelectionEventArgs(folder.SubItems[folder.SubItems.Count - 2].Text));
                    }

            };
        }


        void multiColumnTreeView1_BeforeExpand(object sender, TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {
                //Checking whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                DirectoryInfo dir;
                DirectoryInfo[] subDir;
                if (multiColumnTreeView1.Nodes[0].Nodes.Count == 0) //Root directory
                {

                    dir = new DirectoryInfo(FolderRoot);
                    subDir = dir.GetDirectories();
                }

                else
                {
                    //Get the Path of the node and AddSeparatorAtEnd Property set to true
                    string path = e.Node[1].Text;

                    dir = new DirectoryInfo(path);
                    subDir = dir.GetDirectories();
                }

                foreach (DirectoryInfo dirinfo in subDir)
                {
                    TreeNodeAdvSubItem subitem1 = new TreeNodeAdvSubItem();
                    TreeNodeAdvSubItem subitem2 = new TreeNodeAdvSubItem();
                    subitem1.Text = dirinfo.FullName;
                    subitem1.HelpText = subitem1.Text;

                    subitem2.Text = dirinfo.LastWriteTime.ToString();
                    subitem2.HelpText = subitem2.Text;

                    TreeNodeAdv node = new TreeNodeAdv(dirinfo.Name);
                    node.SubItems.AddRange(new[] { subitem1, subitem2 });
                    e.Node.Nodes.Add(node);
                }
            }
            catch { }
        }
        public List<string> GetSelection()
        {
            //todo
            return new List<string>();
        }

        public void SelectAll()
        {
            //todo
        }

        public void SortLastChanged(SortOrder sortOrder)
        {
            //todo
        }

        public void Clear()
        {
            //todo
        }

        public void HighlightFile(string file)
        {
            //todo
        }

        public void Add(string fileName, DateTime fileLastWriteTime, long fileLength, string fileFullName)
        {
            //todo
        }

        public void SetPath(string folderPath, IAnalogyOfflineDataProvider dataProvider)
        {
            FolderRoot = folderPath;
            DataProvider = dataProvider;

            var dir = new DirectoryInfo(folderPath);
            TreeNodeAdvSubItem subitem1 = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem subitem2 = new TreeNodeAdvSubItem();
            subitem1.Text = dir.FullName;
            subitem1.HelpText = subitem1.Text;
            subitem2.Text = dir.LastWriteTime.ToString();
            subitem2.HelpText = subitem2.Text;
            TreeNodeAdv node = new TreeNodeAdv(dir.Name);
            node.SubItems.AddRange(new[] { subitem1, subitem2 });
            multiColumnTreeView1.Nodes.Clear();
            multiColumnTreeView1.Nodes.Add(node);
            multiColumnTreeView1.Nodes[0].Expanded = true;
            multiColumnTreeView1.SelectedNode = multiColumnTreeView1.Nodes[0];
            multiColumnTreeView1.Focus();
        }
    }
}

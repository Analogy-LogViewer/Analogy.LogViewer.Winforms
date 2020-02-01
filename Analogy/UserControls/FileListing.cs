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
    public partial class FileListing : UserControl
    {
        public event EventHandler<SelectionEventArgs> FilesSelectionChanged;
        private string FolderRoot { get; set; }
        private IAnalogyOfflineDataProvider DataProvider { get; set; }
        public FileListing()
        {
            InitializeComponent();
            SetupEventsHandlers();
            multiColumnTreeView1.Columns.AddRange(new[] { treeColumnAdv1, treeColumnAdv2, treeColumnAdv3 });
            treeColumnAdv1.BaseStyle = (multiColumnTreeView1.BaseStylePairs[2] as StyleNamePair).Name;
            multiColumnTreeView1.FullRowSelect = true;
        }


        private void SetupEventsHandlers()
        {
            multiColumnTreeView1.AfterSelect += (s, e) =>
            {
                var items = multiColumnTreeView1.SelectedNodes.Cast<TreeNodeAdv>().ToList();
                if (items.Any())
                {
                    var files = items.Select(i => i.SubItems[i.SubItems.Count - 2].Text).ToList<string>();
                    FilesSelectionChanged?.Invoke(this, new SelectionEventArgs(files));
                }

            };
        }


        void LoadFiles()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(FolderRoot);
                var files = DataProvider.GetSupportedFiles(di, false);
                if (files.Any())
                {
                    List<TreeNodeAdv> nodes = new List<TreeNodeAdv>();
                    foreach (FileInfo fi in files)
                    {
                        TreeNodeAdvSubItem subitem1 = new TreeNodeAdvSubItem();
                        TreeNodeAdvSubItem subitem2 = new TreeNodeAdvSubItem();
                        subitem1.Text = fi.FullName;
                        subitem1.HelpText = subitem1.Text;

                        subitem2.Text = fi.LastWriteTime.ToString();
                        subitem2.HelpText = subitem2.Text;

                        TreeNodeAdv node = new TreeNodeAdv(fi.Name);
                        node.SubItems.AddRange(new[] { subitem1, subitem2 });
                        nodes.Add(node);
                    }

                    multiColumnTreeView1.Nodes.Clear();
                    multiColumnTreeView1.Nodes.AddRange(nodes);
                    multiColumnTreeView1.Nodes[0].Expanded = true;
                    multiColumnTreeView1.SelectedNode = multiColumnTreeView1.Nodes[0];
                    multiColumnTreeView1.Focus();
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
            LoadFiles();
        }
    }
}

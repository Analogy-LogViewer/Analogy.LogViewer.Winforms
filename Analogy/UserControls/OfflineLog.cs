using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Types;

namespace Analogy
{

    public partial class OfflineUCLogs : UserControl
    {
        private UserSettingsManager Settings => UserSettingsManager.UserSettings;
        private List<string> extrenalFiles = new List<string>();
        public string SelectedPath { get; set; }
        private IAnalogyOfflineDataProvider DataProvider { get; }
        //private List<string> TreeListFileNodes { get; set; }
        public OfflineUCLogs(string initSelectedPath)
        {
            //TreeListFileNodes = new List<string>();
            SelectedPath = initSelectedPath;
            InitializeComponent();
            SetupEventsHandlers();
        }

        private void SetupEventsHandlers()
        {
            folderTreeViewUC1.FolderChanged += (s, e) =>
                { fileListing.SetPath(e.SelectedFolderPath, DataProvider); };
            fileListing.FilesSelectionChanged += TreeList1_SelectionChanged;
            tsBtnDelete.Click += (s, e) =>
            {
                if (fileListing.GetSelection().Any())
                {
                    //todo:fix
                    var filename = fileListing.GetSelection().First();
                    if (filename == null || !File.Exists(filename)) return;
                    var result = MessageBox.Show($"Are you sure you want to delete {filename}?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (File.Exists(filename))
                            try
                            {
                                File.Delete(filename);
                                PopulateFiles(SelectedPath);
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message, @"Error deleting file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                }
            };
            tsBtnOpenFolder.Click += (s, e) =>
            {
                if (fileListing.GetSelection().Any())
                {
                    //todo:fix
                    var filename = fileListing.GetSelection().First();
                    if (filename == null || !File.Exists(filename)) return;
                    Process.Start("explorer.exe", "/select, \"" + filename + "\"");
                }
            };
            tsBtnRefresh.Click += (s, e) => { PopulateFiles(SelectedPath); };
            tsBtnSelecAll.Click += (s, e) => { fileListing.SelectAll(); };
        }

        private void FolderTreeViewUC1_FolderChanged1(object sender, Types.FolderSelectionEventArgs e)
        {
            throw new NotImplementedException();
        }

        public OfflineUCLogs(IAnalogyOfflineDataProvider dataProvider, string[] fileNames = null, string initialSelectedPath = null) : this(initialSelectedPath)
        {

            DataProvider = dataProvider;
            if (fileNames != null)
                extrenalFiles.AddRange(fileNames);
            ucLogs1.OnlineMode = false;
            ucLogs1.SetFileDataSource(dataProvider);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ucLogs1.ProcessCmdKeyFromParent(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private async void OfflineUCLogs_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            fileListing.SortLastChanged(SortOrder.Descending);
            folderTreeViewUC1.FolderChanged += FolderTreeViewUC1_FolderChanged;
            spltMain.Panel1Collapsed = false;
            ucLogs1.tsTopPauseRefresh.Visible = false;
            ucLogs1.tsTopAutoScrollToLast.Visible = false;
            if (extrenalFiles.Any())
            {
                if (File.Exists(extrenalFiles.First()))
                    SelectedPath = Path.GetDirectoryName(extrenalFiles.First());
            }

            folderTreeViewUC1.SetFolder(SelectedPath, DataProvider);
            PopulateFiles(SelectedPath);

            if (extrenalFiles.Any())
            {
                await LoadFilesAsync(extrenalFiles, false);
            }
            ucLogs1.OnFocusedRowChanged += UcLogs1_OnFocusedRowChanged;
        }

        private void UcLogs1_OnFocusedRowChanged(object sender, (string file, AnalogyLogMessage e) data)
        {
            fileListing.HighlightFile(data.file);
        }

        private async void FolderTreeViewUC1_FolderChanged(object sender, Types.FolderSelectionEventArgs e)
        {
            if (Directory.Exists(e.SelectedFolderPath))
            {
                PopulateFiles(e.SelectedFolderPath);
            }
        }

        private void AnalogyUCLogs_DragEnter(object sender, DragEventArgs e) =>
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        private async void AnalogyUCLogs_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            await LoadFilesAsync(files.ToList(), checkBoxSelectionMode.Checked);
        }

        private void PopulateFiles(string folder)
        {
            fileListing.SetPath(folder,DataProvider);
            //if (string.IsNullOrEmpty(folder) || !Directory.Exists(folder)) return;
            //SelectedPath = folder;
            //fileListing.FilesSelectionChanged -= TreeList1_SelectionChanged;
            //bool recursiveLoad = checkBoxRecursiveLoad.Checked;
            //DirectoryInfo dirInfo = new DirectoryInfo(folder);
            //List<FileInfo> fileInfos = DataProvider.GetSupportedFiles(dirInfo, recursiveLoad).ToList();
            //fileListing.Clear();
            //// TreeListFileNodes.Clear();
            //foreach (FileInfo fi in fileInfos)
            //{
            //    fileListing.Add(fi.Name, fi.LastWriteTime, fi.Length, fi.FullName);
            //}
            //fileListing.FilesSelectionChanged += TreeList1_SelectionChanged;
        }

        private async Task LoadFilesAsync(List<string> fileNames, bool clearLog)
        {
            ucLogs1.OnFocusedRowChanged -= UcLogs1_OnFocusedRowChanged;
            await ucLogs1.LoadFilesAsync(fileNames, clearLog);
            ucLogs1.OnFocusedRowChanged += UcLogs1_OnFocusedRowChanged;

        }

        private async void TreeList1_SelectionChanged(object sender, SelectionEventArgs e)
        {
            await LoadFilesAsync(e.SelectedFileNames, checkBoxSelectionMode.Checked);
        }
    }

}



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

    public partial class ClientServerUCLog : UserControl
    {
        public string SelectedPath { get; set; }
        private IAnalogyOfflineDataProvider DataProvider { get; }
        public ClientServerUCLog()
        {
            InitializeComponent();
            SetupEventsHandlers();
        }

        public ClientServerUCLog(IAnalogyOfflineDataProvider dataProvider) : this()
        {
            DataProvider = dataProvider;
            ucLogs1.SetFileDataSource(DataProvider);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ucLogs1.ProcessCmdKeyFromParent(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void SetupEventsHandlers()
        {
            tsBtnAdd.Click += (s, e) =>
            {
                ClientServerForm f = new ClientServerForm();
                f.ShowDialog(this);
                lBoxSources.DataSource = ClientServerDataSourceManager.Instance.DataSources;
            };

            tsBtnAdd.Click += (s, e) =>
            {
                if (lBoxSources.SelectedItem is DataSource data &&
                    MessageBox.Show($"Are you sure you want to delete {data}?", "Confirmation Required", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClientServerDataSourceManager.Instance.Remove(data);
                    lBoxSources.Items.Remove(data);

                }

            };

            tsBtnDelete.Click += (s, e) =>
            {
                if (lBoxFiles.SelectedItem != null)
                {
                    var filename = (lBoxFiles.SelectedItem as FileInfo)?.FullName;
                    if (filename == null) return;
                    var result = MessageBox.Show($"Are you sure you want to delete {filename}?", "Delete confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                                MessageBox.Show(exception.Message, @"Error deleting file", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                    }
                }
            };

            tsBtnRefresh.Click += (s, e) =>
            {
                if (string.IsNullOrEmpty(SelectedPath) || !Directory.Exists(SelectedPath)) return;
                PopulateFiles(SelectedPath);
            };

            tsBtnOpenFolder.Click += (s, e) =>
            {
                if (lBoxFiles.SelectedItem != null)
                {
                    var filename = (lBoxFiles.SelectedItem as FileInfo)?.FullName;
                    if (filename == null || !File.Exists(filename)) return;
                    try
                    {
                        Process.Start("explorer.exe", "/select, \"" + filename + "\"");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"Error Opening file location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            };
        }
        private void ClientServerUCLog_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            lBoxSources.DataSource = ClientServerDataSourceManager.Instance.DataSources;
            ucLogs1.tsTopPauseRefresh.Visible = false;
            ucLogs1.tsTopAutoScrollToLast.Visible = false;
            lBoxSources.SelectedIndex = -1;
            lBoxSources.SelectedValueChanged += lBoxSources_SelectedValueChanged;
        }

        private async void lBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadFilesAsync(lBoxFiles.SelectedItems.Cast<FileInfo>().Select(f => f.FullName).ToList(), checkBoxSelectionMode.Checked);

        }
        private void PopulateFiles(string folder)
        {
            if (!Directory.Exists(folder)) return;
            lBoxFiles.SelectedIndexChanged -= lBoxFiles_SelectedIndexChanged;
            bool recursiveLoad = checkBoxRecursiveLoad.Checked;
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            var fileInfos = DataProvider.GetSupportedFiles(dirInfo, recursiveLoad).OrderByDescending(f => f.LastWriteTime);
            lBoxFiles.DisplayMember = recursiveLoad ? "FullName" : "Name";
            lBoxFiles.DataSource = fileInfos;
            lBoxFiles.SelectedIndexChanged += lBoxFiles_SelectedIndexChanged;
        }


        public async Task LoadFilesAsync(List<string> fileNames, bool clearLog)
        {
            await ucLogs1.LoadFilesAsync(fileNames, clearLog);

        }

        private void lBoxSources_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lBoxSources.SelectedItem is DataSource data)
            {
                SelectedPath = data.Path;
                PopulateFiles(data.Path);
            }
        }
    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Managers;
using Analogy.Types;

namespace Analogy
{

    public partial class FilePoolingUCLogs : UserControl
    {
        private bool showHistory = UserSettingsManager.UserSettings.ShowHistoryOfClearedMessages;
        private static int clearHistoryCounter;
        private string FileName { get; set; }
        public bool Enable { get; set; } = true;
        private FilePoolingManager PoolingManager { get; }
        public FilePoolingUCLogs(IAnalogyOfflineDataProvider offlineDataProvider, string fileName, string initialFolder)
        {
            InitializeComponent();
            SetupEventsHandlers();
            FileName = fileName;
            ucLogs1.OnlineMode = false;
            PoolingManager = new FilePoolingManager(FileName, offlineDataProvider);
            ucLogs1.SetFileDataSource(offlineDataProvider);
            PoolingManager.OnNewMessages += (s, data) =>
            {
                AppendMessages(data.messages, data.dataSource);
                OnNewMessages(data.messages);
            };
        }
        private async void OnlineUCLogs_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            ucLogs1.OnHistoryCleared += UcLogs1_OnHistoryCleared;
            spltMain.Panel1Collapsed = true;
            await PoolingManager.Init();
        }
        private void SetupEventsHandlers()
        {
            Disposed += (s, e) => PoolingManager.StopMonitoring();
            btnClear.Click += (s, e) => listBoxClearHistory.Items.Clear();
            btnHide.Click += (s, e) =>
            {
                if (IsDisposed) return;
                showHistory = false;
                spltMain.Panel1Collapsed = true;
            };
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ucLogs1.ProcessCmdKeyFromParent(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }
 
        private void UcLogs1_OnHistoryCleared(object sender, AnalogyClearedHistoryEventArgs e)
        {
            Interlocked.Increment(ref clearHistoryCounter);
            listBoxClearHistory.SelectedIndexChanged -= ListBoxClearHistoryIndexChanged;
            spltMain.Panel1Collapsed = !showHistory;
            string entry = $"cleared #{clearHistoryCounter} ({e.ClearedMessages.Count} messages)";
            FileProcessingManager.Instance.DoneProcessingFile(e.ClearedMessages, entry);
            listBoxClearHistory.Items.Add(entry);
            listBoxClearHistory.SelectedItem = null;
            listBoxClearHistory.SelectedIndex = -1;
            listBoxClearHistory.SelectedIndexChanged += ListBoxClearHistoryIndexChanged;
        }
        private void OnNewMessages(List<AnalogyLogMessage> messages)
        {
            if (IsDisposed || !IsHandleCreated) return;
            BeginInvoke(new MethodInvoker(() =>
            {
                Interlocked.Increment(ref clearHistoryCounter);
                listBoxClearHistory.SelectedIndexChanged -= ListBoxClearHistoryIndexChanged;
                spltMain.Panel1Collapsed = !showHistory;
                string entry = $"New #{clearHistoryCounter} ({messages.Count} messages)";
                FileProcessingManager.Instance.DoneProcessingFile(messages, entry);
                listBoxClearHistory.Items.Add(entry);
                listBoxClearHistory.SelectedItem = null;
                listBoxClearHistory.SelectedIndex = -1;
                listBoxClearHistory.SelectedIndexChanged += ListBoxClearHistoryIndexChanged;
            }));

        }
        private void AnalogyUCLogs_DragEnter(object sender, DragEventArgs e) =>
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        private async void AnalogyUCLogs_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            await LoadFilesAsync(files.ToList(), true);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendMessages(List<AnalogyLogMessage> messages, string dataSource)
        {
            if (Enable && !IsDisposed)
            {

                string interned = string.Intern(dataSource);
                ucLogs1.AppendMessages(messages, interned);

            }
        }

        public async Task LoadFilesAsync(List<string> fileNames, bool clearLogBeforeLoading)
        {
            await ucLogs1.LoadFilesAsync(fileNames, clearLogBeforeLoading);
        }

        private void ListBoxClearHistoryIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClearHistory.SelectedItem == null) return;
            var messages = FileProcessingManager.Instance.GetMessages((string)listBoxClearHistory.SelectedItem);
            LogGridForm grid = new LogGridForm(messages, Environment.MachineName);
            grid.Show(this);
        }
    }

}



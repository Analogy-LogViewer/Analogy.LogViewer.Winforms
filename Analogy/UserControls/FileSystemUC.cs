using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Types;

namespace Analogy
{
    public partial class FileSystemUC : UserControl
    {
        private IAnalogyOfflineDataProvider _dataProvider;
        public event EventHandler<SelectionEventArgs> SelectionChanged;
        public bool ZipFilesOnly { get; set; }

        public IAnalogyOfflineDataProvider DataProvider
        {
            get => _dataProvider;
            set
            {
                _dataProvider = value;
                if (value != null)
                {
                    tvFolderUC.SetFolder(value.InitialFolderFullPath, _dataProvider);
                }
            }
        }

        public FileSystemUC()
        {
            InitializeComponent();
            tvFolderUC.FolderChanged += TvFolderUC_FolderChanged;
            
        }

        private void TvFolderUC_FolderChanged(object sender, FolderSelectionEventArgs e)
        {
            fileListing1.FolderChanged(e.SelectedFolderPath);
           

        }

        public List<string> GetSelectedFileNames() => fileListing1.GetSelectedFileNames();


    }

}

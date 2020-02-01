using System.Windows.Forms;
using Analogy.Interfaces;

namespace Analogy.Tools
{
    public partial class FileComparerForm : Form
    {
        private IAnalogyOfflineDataProvider offlineAnalogy;

        private FileComparerForm()
        {
            InitializeComponent();
        }

        public FileComparerForm(IAnalogyOfflineDataProvider offlineAnalogy) : this()
        {
            this.offlineAnalogy = offlineAnalogy;
            logsComparerUC1.SetDataSource(offlineAnalogy);
        }
    }
}
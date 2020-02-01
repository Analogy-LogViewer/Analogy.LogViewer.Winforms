using System.Windows.Forms;
using Analogy.Interfaces;

namespace Analogy
{
    public partial class FormCombineFiles : Form
    {
        private IAnalogyOfflineDataProvider offlineAnalogy;

        private FormCombineFiles()
        {
            InitializeComponent();
        }

        public FormCombineFiles(IAnalogyOfflineDataProvider offlineAnalogy) : this()
        {
            this.offlineAnalogy = offlineAnalogy;
            combineFilesUC1.SetDataSource(offlineAnalogy);
        }
    }
}

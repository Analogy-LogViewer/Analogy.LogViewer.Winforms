using System.Windows.Forms;
using Analogy.Interfaces;

namespace Analogy
{
    public partial class SearchForm : Form
    {
        private IAnalogyOfflineDataProvider offlineAnalogy;

        private SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(IAnalogyOfflineDataProvider offlineAnalogy) : this()
        {
            this.offlineAnalogy = offlineAnalogy;
            searchInFilesUC1.SetDataSource(offlineAnalogy);
        }
    }
}

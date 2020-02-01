using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Analogy.DataProviders.Extensions;
using Analogy.Managers;
using Syncfusion.Data.Extensions;
using Syncfusion.Windows.Forms.Tools;

namespace Analogy
{

    public partial class UserSettingsDataProvidersForm : Form
    {
        private struct RealTimeCheckItem
        {
            public string Name;
            public Guid ID;

            public RealTimeCheckItem(string name, Guid id)
            {
                Name = name;
                ID = id;
            }

            public override string ToString() => $"{Name} ({ID})";
        }

        private UserSettingsManager Settings => UserSettingsManager.UserSettings;
        private readonly int _initialSelection = -1;

        public UserSettingsDataProvidersForm()
        {
            InitializeComponent();

        }

        public UserSettingsDataProvidersForm(int tabIndex) : this()
        {
            _initialSelection = tabIndex;
        }

        public UserSettingsDataProvidersForm(string tabName) : this()
        {
       var tab = tabControlAdv1.TabPages.ToList<TabPageAdv>().FirstOrDefault(t=>t.Name==tabName);
            if (tab != null)
                _initialSelection = tab.TabIndex;
        }

        private void LoadSettings()
        {
            AddExternalUserControlSettings();
        }

        private void AddExternalUserControlSettings()
        {
            foreach (IAnalogyDataProviderSettings settings in FactoriesManager.Instance.GetProvidersSettings())
            {
                TabPageAdv tab = new TabPageAdv();
                tab.Text = settings.Title;
                UserControl uc = settings.DataProviderSettings;
                tab.Controls.Add(uc);
                tab.Image = settings.Icon;
                tab.ImageSize=new Size(32,32);
                uc.Dock = DockStyle.Fill;
                tabControlAdv1.TabPages.Add(tab);
            }
        }

        private async void UserSettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();

            if (_initialSelection >= 0)
                tabControlAdv1.SelectedIndex =  _initialSelection;


        }

        private void UserSettingsDataProvidersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        public async void SaveSetting()
        {
            foreach (IAnalogyDataProviderSettings settings in FactoriesManager.Instance.GetProvidersSettings())
            {
                try
                {
                    await settings.SaveSettingsAsync();
                }
                catch (Exception e)
                {
                    AnalogyLogManager.Instance.LogError("Error during call for SaveSetting for data provider: " + e);
                }

            }
        }
    }
}

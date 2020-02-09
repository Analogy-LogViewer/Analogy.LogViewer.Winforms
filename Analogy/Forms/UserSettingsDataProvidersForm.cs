using System;
using System.Linq;
using System.Windows.Forms;
using Analogy.DataProviders.Extensions;
using Analogy.Managers;

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
       var tab = tabControlAdv1.TabPages.Cast<TabPage>().FirstOrDefault(t=>t.Name==tabName);
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
                TabPage tab = new TabPage();
                tab.Text = settings.Title;
                UserControl uc = settings.DataProviderSettings;
                tab.Controls.Add(uc);

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

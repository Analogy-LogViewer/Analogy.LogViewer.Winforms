using System;
using System.Windows.Forms;

namespace Analogy
{
    public partial class ExtensionsForm : Form
    {
        public ExtensionsForm()
        {
            InitializeComponent();
        }

        private void ExtensionsForm_Load(object sender, EventArgs e)
        {
            extensionsUC1.OnClick += (s, args) => { Close(); };

        }
    }
}

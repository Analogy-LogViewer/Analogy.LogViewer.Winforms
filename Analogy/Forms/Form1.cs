using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Analogy.Interfaces;

namespace Analogy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCLogs uc = new UCLogs();
            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}

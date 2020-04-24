using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anthem_Sigma
{
    public partial class CreditsPage : Form
    {
        public CreditsPage()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = MainPage.main;
            main.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ButtonGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dpesall");
        }
    }
}

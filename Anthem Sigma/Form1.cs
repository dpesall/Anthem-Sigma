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
    public partial class MainPage : Form
    {
        public static MainPage main;
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            main = this;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDecipherText_Click(object sender, EventArgs e)
        {
            DecipherPage decipher = new DecipherPage();
            decipher.Show();
            main.Hide();
        }

        private void ButtonEncipherText_Click(object sender, EventArgs e)
        {
            EncipherPage encipher = new EncipherPage();
            encipher.Show();
            main.Hide();
        }

        private void ButtonUtilities_Click(object sender, EventArgs e)
        {
            UtilitiesPage utilities = new UtilitiesPage();
            utilities.Show();
            main.Hide();
        }

        private void ButtonDecipherManual_Click(object sender, EventArgs e)
        {
            ManualPage manual = new ManualPage();
            manual.Show();
            main.Hide();
        }

        private void ButtonCredits_Click(object sender, EventArgs e)
        {

        }
    }
}

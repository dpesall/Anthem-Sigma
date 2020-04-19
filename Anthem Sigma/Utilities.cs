using System;
using System.IO;
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
    public partial class UtilitiesPage : Form
    {
        public UtilitiesPage()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = MainPage.main;
            main.Show();
        }

        private void UtilitiesPage_Load(object sender, EventArgs e)
        {

        }

        private void updateLetterFrequency(object sender, EventArgs e)
        {
            string text = textBoxCiphertext.Text.ToUpper();
            string printout = "";
            Dictionary<char, int> Frequency = new Dictionary<char, int>();

            for(int i = 0; i < 26; i++)
            {
                Frequency[(char) ('A' + i)] = 0;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] >= 'A' && text[i] <= 'Z')
                {
                    char temp = text[i];
                    Frequency[temp] += 1;
                }
            }
            for (int i = 0; i < Frequency.Count; i++)
            {
                int freq = Frequency[(char)('A' + i)];
                string temp = freq.ToString("####").PadLeft(5, ' ');
                printout += ((char)('A' + i)).ToString() + " : " + temp + "\n";
                
            }
            textBoxLetterFrequency.Text = printout;
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {

            #pragma warning disable IDE0017
            OpenFileDialog dialog = new OpenFileDialog();
            #pragma warning restore IDE0017
            dialog.Filter = "Text files | *.txt";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    string inputText = reader.ReadToEnd();
                    textBoxCiphertext.Text = inputText.ToUpper();
                    updateLetterFrequency(sender, e);
                }
            }
        }
    }
}

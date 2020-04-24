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
            textBoxLetterFrequency.Font = new Font(FontFamily.GenericMonospace, textBoxLetterFrequency.Font.Size);
            textBoxNGram.Font = new Font(FontFamily.GenericMonospace, textBoxNGram.Font.Size);
            comboNGram.SelectedIndex = 0;
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
            var sortedDict = from entry in Frequency orderby entry.Value ascending select entry;
            for (int i = 0; i < Frequency.Count; i++)
            {
                int freq = Frequency[(char)('A' + i)];
                string temp = sortedDict.ElementAt(25 - i).ToString();
                string[] arr = temp.Split(' ');
                var charsToRemove = new string[] { "[", "]", ","};
                foreach (var c in charsToRemove)
                {
                    arr[0] = arr[0].Replace(c, string.Empty);
                    arr[1] = arr[1].Replace(c, string.Empty);
                }

                printout += arr[0] + " : " + arr[1] + "\n";
            }
            
            textBoxLetterFrequency.Text = printout;
        }

        private void updateNGramCount (object sender, EventArgs e)
        {
            int gram = comboNGram.SelectedIndex + 2;
            string text = textBoxCiphertext.Text;
            string justLetters = "";
            string printout = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z') {
                    justLetters += text[i];
                }
            }

            Dictionary<string, int> Frequency = new Dictionary<string, int>();
            for (int i = 0; i < justLetters.Length - gram + 1; i++)
            {
                string temp = "";
                for (int k = 0; k < gram; k++)
                {
                    temp += justLetters[i + k];
                }
                try
                {
                    Frequency[temp] += 1;
                } catch(Exception)
                {
                    Frequency[temp] = 1;
                }
            }
            var sortedDict = from entry in Frequency orderby entry.Value ascending select entry;

            for (int i = 0; i < sortedDict.Count(); i++)
            {
                string temp = sortedDict.ElementAt((sortedDict.Count() - 1) - i).ToString();
                string[] arr = temp.Split(' ');
                var charsToRemove = new string[] { "[", "]", "," };
                foreach (var c in charsToRemove)
                {
                    arr[0] = arr[0].Replace(c, string.Empty);
                    arr[1] = arr[1].Replace(c, string.Empty);
                }

                printout += arr[0] + " : " + arr[1] + "\n";
            }

            textBoxNGram.Text = printout;
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
                    updateNGramCount(sender, e);
                }
            }
        }

        private void ComboNGram_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateNGramCount(sender, e);
        }
    }
}

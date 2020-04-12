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
    public partial class EncipherPage : Form
    {
#pragma warning disable IDE0052 // Remove unread private members
        private static string inputText;
#pragma warning restore IDE0052 // Remove unread private members
#pragma warning disable IDE0052 // Remove unread private members
        private static string outputText;
#pragma warning restore IDE0052 // Remove unread private members
        public EncipherPage()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = MainPage.main;
            main.Show();
        }

        private void EncipherPage_Load(object sender, EventArgs e)
        {

        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            #pragma warning disable IDE0017 // Simplify object initialization
            OpenFileDialog dialog = new OpenFileDialog();
            #pragma warning restore IDE0017 // Simplify object initialization
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    inputText = reader.ReadToEnd();
                    textBoxInput.Text = inputText.ToUpper();
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int method = comboEncipherMethod.SelectedIndex;

            labelKey.Visible = false; comboKeyLetter.Visible = false; labelKeyword.Visible = false;
            textKeyword.Visible = false; labelMultiplicative.Visible = false; labelAdditive.Visible = false;
            numericMultiplicative.Visible = false; numericAdditive.Visible = false; labelKeyword.Visible = false;
            textKeyword.Visible = false; labelMatrix.Visible = false; textMatrix1.Visible = false;
            textMatrix2.Visible = false; textMatrix3.Visible = false; textMatrix4.Visible = false;

            buttonEncipher.Visible = false;
            textBoxOutput.Text = "";

            switch (method)
            {
                case 0:
                    labelKey.Visible = true;
                    comboKeyLetter.Visible = true;
                    if (comboKeyLetter.SelectedIndex != -1)
                    {
                        buttonEncipher.Visible = true;
                    }
                    break;
                case 1:
                    labelKeyword.Visible = true;
                    textKeyword.Visible = true;

                    if (textKeyword.Text.Equals(""))
                    {
                        buttonEncipher.Visible = false;
                    }
                    else
                    {
                        buttonEncipher.Visible = true;
                    }

                    break;
                case 2:
                    buttonEncipher.Visible = true;

                    labelMultiplicative.Visible = true;
                    labelAdditive.Visible = true;
                    numericMultiplicative.Visible = true;
                    numericAdditive.Visible = true;
                    break;
                case 3:
                    labelKeyword.Visible = true;
                    textKeyword.Visible = true;

                    if (textKeyword.Text.Equals(""))
                    {
                        buttonEncipher.Visible = false;
                    }
                    else
                    {
                        buttonEncipher.Visible = true;
                    }

                    break;
                case 4:
                    labelMatrix.Visible = true;
                    textMatrix1.Visible = true;
                    textMatrix2.Visible = true;
                    textMatrix3.Visible = true;
                    textMatrix4.Visible = true;
                    break;
            }
        }

        private void ButtonEncipher_Click(object sender, EventArgs e)
        {
            string text = textBoxInput.Text;
            int method = comboEncipherMethod.SelectedIndex;
            switch (method)
            {
                case 0:
                    int key = (comboKeyLetter.SelectedIndex + 1) % 26;
                    text = encipherCaesar(text, key);
                    break;
                case 1:
                    encipherAffine(text);
                    break;
                case 2:
                    encipherKeyword(text);
                    break;
                case 3:
                    encipherVigenere(text);
                    break;
                case 4:
                    encipherHill(text);
                    break;
            }

            textBoxOutput.Text = text;
        }

        private string encipherCaesar(string text, int key)
        {
            char[] textArray = text.ToCharArray();

            for (int i = 0; i < textArray.Length; i++)
            {
                if (char.IsUpper(textArray[i]))
                {
                    textArray[i] = (char)(((int)text[i] + key - 65) % 26 + 65);
                }
            }

            text = new string(textArray);

            return text;
        }

        private string encipherAffine(string text)
        {
            return text;
        }

        private string encipherKeyword(string text)
        {
            return text;
        }

        private string encipherVigenere(string text)
        {
            return text;
        }

        private string encipherHill(string text)
        {
            return text;
        }

        private void ComboKeyLetter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKeyLetter.SelectedIndex != -1)
            {
                buttonEncipher.Visible = true;
            }
        }

        private void TextKeyword_TextChanged(object sender, EventArgs e)
        {
            if (textKeyword.Text.Equals(""))
            {
                buttonEncipher.Visible = false;
            }
            else
            {
                buttonEncipher.Visible = true;
            }
        }

        private void textKeyword_Pressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void matrixKey_Pressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

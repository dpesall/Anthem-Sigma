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
            int key;
            string keyword;
            string text = textBoxInput.Text;
            int method = comboEncipherMethod.SelectedIndex;
            switch (method)
            {
                case 0:
                    key = (comboKeyLetter.SelectedIndex + 1) % 26;
                    text = encipherCaesar(text, key);
                    break;
                case 1:
                    keyword = textKeyword.Text.ToLower();
                    text = encipherKeyword(text, keyword);
                    break;
                case 2:
                    int mult = (int) numericMultiplicative.Value;
                    int add = (int) numericAdditive.Value;
                    text = encipherAffine(text, mult, add);
                    break;
                case 3:
                    keyword = textKeyword.Text.ToLower();
                    text = encipherVigenere(text, keyword);
                    break;
                case 4:
                    int[] matrix = {
                        Int32.Parse(textMatrix1.Text),
                        Int32.Parse(textMatrix2.Text),
                        Int32.Parse(textMatrix3.Text),
                        Int32.Parse(textMatrix4.Text)
                    };
                    text = encipherHill(text, matrix);
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

        private string encipherAffine(string text, int mult, int add)
        {
            string segment = "";
            char[] arr = text.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    segment = segment + (char)((((mult * (arr[i] - 'A')) + add) % 26) + 'A');
                }
                else
                {
                    segment += arr[i];
                }
            }
            return segment;
        }

        private string encipherKeyword(string text, string keyword)
        {

            string encoded = encoder(keyword.ToCharArray());
            text = keywordEnciphering(text, encoded);

            return text;
        }

        private string encipherVigenere(string text, string keyword)
        {
            string fullKey = keyword.ToUpper();
            int x = text.Length;

            for (int i = 0; ; i++)
            {
                if (x == i)
                    i = 0;
                if (fullKey.Length == text.Length)
                    break;
                fullKey += (fullKey[i]);
            }

            String segment = "";

            int k = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    int y = (text[i] + fullKey[k]) % 26;
                    y += 'A';
                    segment += (char)(y);
                    k++;
                }
                else
                {
                    segment += text[i];
                }
            }
            return segment;
        }

        private string encipherHill(string text, int[] matrix)
        {
            string enciphered = getPairMatrix(text, matrix);
            return enciphered;
        }

        static string getPairMatrix(String text, int[] matrix)
        {
            if (text.Length % 2 != 0)
            {
                text = text.Remove(text.Length - 1, 1);
            }

            text = string.Join("", text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            string onlyLetters = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    onlyLetters += text[i];
                }
            }
            text = onlyLetters;

            int pairCount = text.Length / 2;

            int[,] pairsValue = new int[2, pairCount];

            int j = 0;
            for (int i = 0; i < pairCount; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    pairsValue[k, i] = Int32.Parse((text[j] - 'A').ToString());
                    j++;
                }
            }

            string pairedText = "";
            for (int i = 0; i < pairCount; i++)
            {
                for (int k = 0; k < 1; k++)
                {
                    int x = pairsValue[0, i];
                    int y = pairsValue[1, i];

                    int newX = matrix[0] * x + matrix[1] * y;
                    newX %= 26;
                    int newY = matrix[2] * x + matrix[3] * y;
                    newY %= 26;

                    char top =    (char) (newX + 'A');
                    char bottom = (char) (newY + 'A');

                    pairedText += top.ToString();
                    pairedText += bottom.ToString();
                }
                pairedText += " ";
            }

            return pairedText;
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

        // Courtesy of GeeksForGeeks below
        static String encoder(char[] key)
        {
            String encoded = "";

            Boolean[] arr = new Boolean[26];

            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] >= 'A' && key[i] <= 'Z')
                {
                    if (arr[key[i] - 65] == false)
                    {
                        encoded += (char)key[i];
                        arr[key[i] - 65] = true;
                    }
                }
                else if (key[i] >= 'a' && key[i] <= 'z')
                {
                    if (arr[key[i] - 97] == false)
                    {
                        encoded += (char)(key[i] - 32);
                        arr[key[i] - 97] = true;
                    }
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (arr[i] == false)
                {
                    arr[i] = true;
                    encoded += (char)(i + 65);
                }
            }
            return encoded;
        }

        static String keywordEnciphering(String msg, String encoded)
        {
            String cipher = "";

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] >= 'a' && msg[i] <= 'z')
                {
                    int pos = msg[i] - 97;
                    cipher += encoded[pos];
                }
                else if (msg[i] >= 'A' && msg[i] <= 'Z')
                {
                    int pos = msg[i] - 65;
                    cipher += encoded[pos];
                }
                else
                {
                    cipher += msg[i];
                }
            }
            return cipher;
        }

        private void matrixText_Changed(object sender, EventArgs e)
        {
            if (textMatrix1.Text.Equals("") || textMatrix2.Text.Equals("") || textMatrix3.Text.Equals("") || textMatrix4.Text.Equals(""))
            {
                buttonEncipher.Visible = false;
            }
            else
            {
                buttonEncipher.Visible = true;
            }
        }
    }
}

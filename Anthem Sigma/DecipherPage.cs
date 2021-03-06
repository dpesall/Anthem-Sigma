﻿using System;
using System.IO;
using System.Numerics;
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
    public partial class DecipherPage : Form
    {
        private static string inputText;
        public DecipherPage()
        {
            InitializeComponent();
        }

        private void DecipherPage_Load(object sender, EventArgs e)
        {
            comboOffset.SelectedIndex = 0;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = MainPage.main;
            main.Show();
        }

        private void ComboEncipherMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int method = comboDecipherMethod.SelectedIndex;

            labelKey.Visible = false; comboKeyLetter.Visible = false; labelKeyword.Visible = false;
            textKeyword.Visible = false; labelMultiplicative.Visible = false; labelAdditive.Visible = false;
            numericMultiplicative.Visible = false; numericAdditive.Visible = false; labelKeyword.Visible = false;
            textKeyword.Visible = false; labelMatrix.Visible = false; textMatrix1.Visible = false;
            textMatrix2.Visible = false; textMatrix3.Visible = false; textMatrix4.Visible = false;
            comboOffset.Visible = false; labelOffset.Visible = false;

            buttonDecipher.Visible = false;
            textBoxOutput.Text = "";

            switch (method)
            {
                case 0:
                    labelKey.Visible = true;
                    comboKeyLetter.Visible = true;
                    if (comboKeyLetter.SelectedIndex != -1)
                    {
                        buttonDecipher.Visible = true;
                    }
                    break;
                case 1:
                    labelKeyword.Visible = true;
                    textKeyword.Visible = true;
                    comboOffset.Visible = true;
                    labelOffset.Visible = true;

                    if (textKeyword.Text.Equals(""))
                    {
                        buttonDecipher.Visible = false;
                    }
                    else
                    {
                        buttonDecipher.Visible = true;
                    }

                    break;
                case 2:
                    buttonDecipher.Visible = true;

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
                        buttonDecipher.Visible = false;
                    }
                    else
                    {
                        buttonDecipher.Visible = true;
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

        private void ComboKeyLetter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboKeyLetter.SelectedIndex != -1)
            {
                buttonDecipher.Visible = true;
            }
        }

        private void TextKeyword_TextChanged(object sender, EventArgs e)
        {
            if (textKeyword.Text.Equals(""))
            {
                buttonDecipher.Visible = false;
            }
            else
            {
                buttonDecipher.Visible = true;
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

        private void TextMatrix2_TextChanged(object sender, EventArgs e)
        {
            if (textMatrix1.Text.Equals("") || textMatrix2.Text.Equals("") || textMatrix3.Text.Equals("") || textMatrix4.Text.Equals(""))
            {
                buttonDecipher.Visible = false;
            }
            else
            {
                buttonDecipher.Visible = true;
            }
        }

        private void TextMatrix3_TextChanged(object sender, EventArgs e)
        {
            if (textMatrix1.Text.Equals("") || textMatrix2.Text.Equals("") || textMatrix3.Text.Equals("") || textMatrix4.Text.Equals(""))
            {
                buttonDecipher.Visible = false;
            }
            else
            {
                buttonDecipher.Visible = true;
            }
        }

        private void TextMatrix4_TextChanged(object sender, EventArgs e)
        {
            if (textMatrix1.Text.Equals("") || textMatrix2.Text.Equals("") || textMatrix3.Text.Equals("") || textMatrix4.Text.Equals(""))
            {
                buttonDecipher.Visible = false;
            }
            else
            {
                buttonDecipher.Visible = true;
            }
        }

        private void TextMatrix1_TextChanged(object sender, EventArgs e)
        {
            if (textMatrix1.Text.Equals("") || textMatrix2.Text.Equals("") || textMatrix3.Text.Equals("") || textMatrix4.Text.Equals(""))
            {
                buttonDecipher.Visible = false;
            }
            else
            {
                buttonDecipher.Visible = true;
            }
        }

        private void ButtonDecipher_Click(object sender, EventArgs e)
        {
            int key;
            string keyword;
            string text = textBoxInput.Text;
            int method = comboDecipherMethod.SelectedIndex;

            switch(method)
            {
                case 0:
                    key = comboKeyLetter.SelectedIndex;
                    text = decipherCaesar(text, key);
                    textBoxOutput.Text = text;

                    break;
                case 1:
                    keyword = textKeyword.Text;
                    int offset = comboOffset.SelectedIndex;
                    text = decipherKeyword(text, keyword, offset);
                    textBoxOutput.Text = text;

                    break;
                case 2:
                    int mult = (int)numericMultiplicative.Value;
                    int add = (int)numericAdditive.Value;
                    text = decipherAffine(text, mult, add);
                    textBoxOutput.Text = text;

                    break;
                case 3:
                    keyword = textKeyword.Text;
                    text = decipherVigenere(text, keyword);
                    textBoxOutput.Text = text;

                    break;
                case 4:
                    int[] matrix = {
                        Int32.Parse(textMatrix1.Text),
                        Int32.Parse(textMatrix2.Text),
                        Int32.Parse(textMatrix3.Text),
                        Int32.Parse(textMatrix4.Text)
                    };
                    matrix = invertMatrix(matrix);
                    text = decipherHills(text, matrix);

                    textBoxOutput.Text = text;
                    break;
            }
        }

        private string decipherCaesar(string text, int key)
        {
            char[] arr = text.ToCharArray();
            for(int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                {
                    int temp = (int)text[i] - 'A' - key;
                    if (temp < 0) {
                        temp += 26;
                    }
                    temp += 'A';
                    arr[i] = (char)(temp);
                }
                
            }
            text = new string(arr);
            return text;
        }

        private string decipherKeyword(string text, string keyword, int offset)
        {
            string encoded = encoder(keyword.ToCharArray());

            string encodedOffset = "";

            for (int i = 0; i < 26; i++)
            {
                int temp = (i - offset + 26) % 26;
                encodedOffset += encoded[temp];
            }

            text = keywordDeciphering(text, encodedOffset);

            return text;
        }

        private static string keywordDeciphering(String msg, String encoded)
        {
            Dictionary<char, int> enc = new Dictionary<char, int>();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < encoded.Length; i++)
            {
                enc[encoded[i]] = i;
            }

            String cipher = "";

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] >= 'A' && msg[i] <= 'Z')
                {
                    int pos = enc[msg[i]];
                    cipher += alphabet[pos];
                }
                else
                {
                    cipher += msg[i];
                }
            }
            return cipher;
        }

        private static string decipherAffine(string text, int mult, int add)
        {
            mult = modInverse(mult, 26);
            add = 26 - add;
            string segment = "";
            char[] arr = text.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    segment = segment + (char)(((mult * ((arr[i] - 'A') + add)) % 26) + 'A');
                }
                else
                {
                    segment += arr[i];
                }
            }
            return segment;
        }

        private static string decipherVigenere(string text, string keyword)
        {
            String deciphered = "";
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

            int k = 0;
            for (int i = 0; i < text.Length && i < fullKey.Length; i++)
            {

                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    int y = (text[i] - fullKey[k] + 26) % 26;

                    y += 'A';
                    deciphered += (char)(y);
                    k++;
                } else
                {
                    deciphered += text[i];
                }

                
            }

            return deciphered;
        }
        // a[0]  b[1]
        // c[2]  d]3]
        private static int[] invertMatrix(int[] matrix)
        {
            int[] inverted = { matrix[3], -matrix[1], -matrix[2], matrix[0] };

            for (int i = 0; i < 4; i++)
            {
                while(inverted[i] < 0 || inverted[i] > 26)
                {
                    if (inverted[i] > 26)
                    {
                        inverted[i] -= 26;
                    }
                    if (inverted[i] < 0)
                    {
                        inverted[i] += 26;
                    }
                }
            }

            int a = matrix[0] * matrix[3];
            int b = matrix[1] * matrix[2];
            int det = a - b;
            while (det < 0 || det > 26)
            {
                if (det > 26)
                {
                    det -= 26;
                }
                if (det < 0)
                {
                    det += 26;
                }
            }
            det = modInverse(det, 26);

            for (int i = 0; i < 4; i++)
            {
                inverted[i] *= det;
                while (inverted[i] < 0 || inverted[i] > 26)
                {
                    if (inverted[i] > 26)
                    {
                        inverted[i] -= 26;
                    }
                    if (inverted[i] < 0)
                    {
                        inverted[i] += 26;
                    }
                }
            }

            return inverted;
        }

        private static string decipherHills(string text, int[] matrix)
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

                    char top = (char)(newX + 'A');
                    char bottom = (char)(newY + 'A');

                    pairedText += top.ToString();
                    pairedText += bottom.ToString();
                }
                pairedText += " ";
            }

            return pairedText;
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
        static int modInverse(int a, int n)
        {
            a = a % n;
            for (int x = 1; x < n; x++)
                if ((a * x) % n == 1)
                    return x;
            return 1;
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
                    inputText = reader.ReadToEnd();
                    textBoxInput.Text = inputText.ToUpper();
                }
            }
        }
    }
}

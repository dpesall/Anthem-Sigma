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
    public partial class ManualPage : Form
    {
        public ManualPage()
        {
            InitializeComponent();
        }
        private static char previous = '-';
        private static Dictionary<char, char> Alphabet = new Dictionary<char, char>();
        private void ManualPage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 26; i++)
            {
                Alphabet[(char) ('a' + i)] = '-';
            }
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = MainPage.main;
            main.Show();
        }

        private void showPlaintextButtons(object sender, EventArgs e)
        {
            buttonPlaina.Visible = true; buttonPlaing.Visible = true; buttonPlainl.Visible = true; buttonPlainq.Visible = true; buttonPlainv.Visible = true;
            buttonPlainb.Visible = true; buttonPlainh.Visible = true; buttonPlainm.Visible = true; buttonPlainr.Visible = true; buttonPlainw.Visible = true;
            buttonPlainc.Visible = true; buttonPlaini.Visible = true; buttonPlainn.Visible = true; buttonPlains.Visible = true; buttonPlainx.Visible = true;
            buttonPlaind.Visible = true; buttonPlainj.Visible = true; buttonPlaino.Visible = true; buttonPlaint.Visible = true; buttonPlainy.Visible = true;
            buttonPlaine.Visible = true; buttonPlaink.Visible = true; buttonPlainp.Visible = true; buttonPlainu.Visible = true; buttonPlainz.Visible = true;
            buttonPlainf.Visible = true; buttonPlainEmpty.Visible = true;
        }

        private void hidePlaintextButtons(object sender, EventArgs e)
        {
            buttonPlaina.Visible = false; buttonPlaing.Visible = false; buttonPlainl.Visible = false; buttonPlainq.Visible = false; buttonPlainv.Visible = false;
            buttonPlainb.Visible = false; buttonPlainh.Visible = false; buttonPlainm.Visible = false; buttonPlainr.Visible = false; buttonPlainw.Visible = false;
            buttonPlainc.Visible = false; buttonPlaini.Visible = false; buttonPlainn.Visible = false; buttonPlains.Visible = false; buttonPlainx.Visible = false;
            buttonPlaind.Visible = false; buttonPlainj.Visible = false; buttonPlaino.Visible = false; buttonPlaint.Visible = false; buttonPlainy.Visible = false;
            buttonPlaine.Visible = false; buttonPlaink.Visible = false; buttonPlainp.Visible = false; buttonPlainu.Visible = false; buttonPlainz.Visible = false;
            buttonPlainf.Visible = false; buttonPlainEmpty.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'a';
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'b';
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'c';
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'd';
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'e';
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'f';
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'g';
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'h';
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'i';
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'j';
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'k';
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'l';
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'm';
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'n';
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'o';
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'p';
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'q';
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'r';
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 's';
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 't';
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'u';
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'v';
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'w';
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'x';
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'y';
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            showPlaintextButtons(sender, e);
            previous = 'z';
        }

        private void onLetterClick(object sender, EventArgs e)
        {
            hidePlaintextButtons(sender, e);
            string content = (sender as Button).Text;
            
            switch (previous)
            {
                case 'a':
                    Alphabet['a'] = content[0];
                    buttonSeta.Text = content;
                    break;
                case 'b':
                    Alphabet['b'] = content[0];
                    buttonSetb.Text = content;
                    break;
                case 'c':
                    Alphabet['c'] = content[0];
                    buttonSetc.Text = content;
                    break;
                case 'd':
                    Alphabet['d'] = content[0];
                    buttonSetd.Text = content;
                    break;
                case 'e':
                    Alphabet['e'] = content[0];
                    buttonSete.Text = content;
                    break;
                case 'f':
                    Alphabet['f'] = content[0];
                    buttonSetf.Text = content;
                    break;
                case 'g':
                    Alphabet['g'] = content[0];
                    buttonSetg.Text = content;
                    break;
                case 'h':
                    Alphabet['h'] = content[0];

                    buttonSeth.Text = content;
                    break;
                case 'i':
                    Alphabet['i'] = content[0];
                    buttonSeti.Text = content;
                    break;
                case 'j':
                    Alphabet['j'] = content[0];
                    buttonSetj.Text = content;
                    break;
                case 'k':
                    Alphabet['k'] = content[0];
                    buttonSetk.Text = content;
                    break;
                case 'l':
                    Alphabet['l'] = content[0];
                    buttonSetl.Text = content;
                    break;
                case 'm':
                    Alphabet['m'] = content[0];
                    buttonSetm.Text = content;
                    break;
                case 'n':
                    Alphabet['n'] = content[0];
                    buttonSetn.Text = content;
                    break;
                case 'o':
                    Alphabet['o'] = content[0];
                    buttonSeto.Text = content;
                    break;
                case 'p':
                    Alphabet['p'] = content[0];
                    buttonSetp.Text = content;
                    break;
                case 'q':
                    Alphabet['q'] = content[0];
                    buttonSetq.Text = content;
                    break;
                case 'r':
                    Alphabet['r'] = content[0];
                    buttonSetr.Text = content;
                    break;
                case 's':
                    Alphabet['s'] = content[0];
                    buttonSets.Text = content;
                    break;
                case 't':
                    Alphabet['t'] = content[0];
                    buttonSett.Text = content;
                    break;
                case 'u':
                    Alphabet['u'] = content[0];
                    buttonSetu.Text = content;
                    break;
                case 'v':
                    Alphabet['v'] = content[0];
                    buttonSetv.Text = content;
                    break;
                case 'w':
                    Alphabet['w'] = content[0];
                    buttonSetw.Text = content;
                    break;
                case 'x':
                    Alphabet['x'] = content[0];
                    buttonSetx.Text = content;
                    break;
                case 'y':
                    Alphabet['y'] = content[0];
                    buttonSety.Text = content;
                    break;
                case 'z':
                    Alphabet['z'] = content[0];
                    buttonSetz.Text = content;
                    break;
            }
            string plaintext = crackCiphertext(textBoxCiphertext.Text.ToLower());
            textBoxPlaintext.Text = plaintext;
        }

        private void ButtonPlainEmpty_Click(object sender, EventArgs e)
        {
            onLetterClick(sender, e);
        }

        private string crackCiphertext(string text)
        {
            string plaintext = "";
            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                if (current >= 'a' && current <= 'z')
                {
                    plaintext += Alphabet[current];
                } else
                {
                    plaintext += current;
                }
            }

            return plaintext;
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
                    string plaintext = crackCiphertext(textBoxCiphertext.Text.ToLower());
                    textBoxPlaintext.Text = plaintext;
                }
            }
        }

        private void LabelUpload_Click(object sender, EventArgs e)
        {

        }
    }
}

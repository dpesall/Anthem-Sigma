﻿namespace Anthem_Sigma
{
    partial class EncipherPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncipherPage));
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.labelSelectEncodingType = new System.Windows.Forms.Label();
            this.comboEncipherMethod = new System.Windows.Forms.ComboBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.labelUpload = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.comboKeyLetter = new System.Windows.Forms.ComboBox();
            this.labelKeyword = new System.Windows.Forms.Label();
            this.textKeyword = new System.Windows.Forms.TextBox();
            this.labelMultiplicative = new System.Windows.Forms.Label();
            this.labelAdditive = new System.Windows.Forms.Label();
            this.numericMultiplicative = new System.Windows.Forms.NumericUpDown();
            this.numericAdditive = new System.Windows.Forms.NumericUpDown();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.textMatrix1 = new System.Windows.Forms.TextBox();
            this.textMatrix2 = new System.Windows.Forms.TextBox();
            this.textMatrix3 = new System.Windows.Forms.TextBox();
            this.textMatrix4 = new System.Windows.Forms.TextBox();
            this.buttonEncipher = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOffset = new System.Windows.Forms.Label();
            this.comboOffset = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericMultiplicative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdditive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Location = new System.Drawing.Point(1082, 627);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 42);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 285);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.Size = new System.Drawing.Size(509, 311);
            this.textBoxInput.TabIndex = 3;
            this.textBoxInput.Text = "";
            // 
            // labelSelectEncodingType
            // 
            this.labelSelectEncodingType.AutoSize = true;
            this.labelSelectEncodingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectEncodingType.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSelectEncodingType.Location = new System.Drawing.Point(12, 18);
            this.labelSelectEncodingType.Name = "labelSelectEncodingType";
            this.labelSelectEncodingType.Size = new System.Drawing.Size(345, 31);
            this.labelSelectEncodingType.TabIndex = 4;
            this.labelSelectEncodingType.Text = "Select Enciphering Method:";
            // 
            // comboEncipherMethod
            // 
            this.comboEncipherMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEncipherMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEncipherMethod.FormattingEnabled = true;
            this.comboEncipherMethod.Items.AddRange(new object[] {
            "Caesar Cipher",
            "Keyword Cipher",
            "Affine Cipher",
            "Vigenere Cipher",
            "Hill\'s Cipher"});
            this.comboEncipherMethod.Location = new System.Drawing.Point(18, 53);
            this.comboEncipherMethod.Name = "comboEncipherMethod";
            this.comboEncipherMethod.Size = new System.Drawing.Size(275, 33);
            this.comboEncipherMethod.TabIndex = 5;
            this.comboEncipherMethod.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInput.Location = new System.Drawing.Point(12, 251);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(83, 31);
            this.labelInput.TabIndex = 6;
            this.labelInput.Text = "Input:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.labelOutput.Location = new System.Drawing.Point(663, 251);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(104, 31);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "Output:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(663, 285);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(509, 311);
            this.textBoxOutput.TabIndex = 7;
            this.textBoxOutput.Text = "";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.Black;
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpload.Location = new System.Drawing.Point(12, 627);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(90, 42);
            this.buttonUpload.TabIndex = 9;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // labelUpload
            // 
            this.labelUpload.AutoSize = true;
            this.labelUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpload.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUpload.Location = new System.Drawing.Point(108, 649);
            this.labelUpload.Name = "labelUpload";
            this.labelUpload.Size = new System.Drawing.Size(122, 20);
            this.labelUpload.TabIndex = 10;
            this.labelUpload.Text = "Upload a .txt file";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey.ForeColor = System.Drawing.SystemColors.Control;
            this.labelKey.Location = new System.Drawing.Point(12, 102);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(69, 31);
            this.labelKey.TabIndex = 11;
            this.labelKey.Text = "Key:";
            this.labelKey.Visible = false;
            // 
            // comboKeyLetter
            // 
            this.comboKeyLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKeyLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKeyLetter.FormattingEnabled = true;
            this.comboKeyLetter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboKeyLetter.Location = new System.Drawing.Point(87, 105);
            this.comboKeyLetter.Name = "comboKeyLetter";
            this.comboKeyLetter.Size = new System.Drawing.Size(47, 33);
            this.comboKeyLetter.TabIndex = 12;
            this.comboKeyLetter.Visible = false;
            this.comboKeyLetter.SelectedIndexChanged += new System.EventHandler(this.ComboKeyLetter_SelectedIndexChanged);
            // 
            // labelKeyword
            // 
            this.labelKeyword.AutoSize = true;
            this.labelKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelKeyword.Location = new System.Drawing.Point(12, 151);
            this.labelKeyword.Name = "labelKeyword";
            this.labelKeyword.Size = new System.Drawing.Size(128, 31);
            this.labelKeyword.TabIndex = 13;
            this.labelKeyword.Text = "Keyword:";
            this.labelKeyword.Visible = false;
            // 
            // textKeyword
            // 
            this.textKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKeyword.Location = new System.Drawing.Point(146, 155);
            this.textKeyword.Name = "textKeyword";
            this.textKeyword.Size = new System.Drawing.Size(197, 29);
            this.textKeyword.TabIndex = 14;
            this.textKeyword.Visible = false;
            this.textKeyword.TextChanged += new System.EventHandler(this.TextKeyword_TextChanged);
            this.textKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKeyword_Pressed);
            // 
            // labelMultiplicative
            // 
            this.labelMultiplicative.AutoSize = true;
            this.labelMultiplicative.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultiplicative.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMultiplicative.Location = new System.Drawing.Point(443, 18);
            this.labelMultiplicative.Name = "labelMultiplicative";
            this.labelMultiplicative.Size = new System.Drawing.Size(232, 31);
            this.labelMultiplicative.TabIndex = 15;
            this.labelMultiplicative.Text = "Multiplicative Key:";
            this.labelMultiplicative.Visible = false;
            // 
            // labelAdditive
            // 
            this.labelAdditive.AutoSize = true;
            this.labelAdditive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditive.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAdditive.Location = new System.Drawing.Point(502, 66);
            this.labelAdditive.Name = "labelAdditive";
            this.labelAdditive.Size = new System.Drawing.Size(173, 31);
            this.labelAdditive.TabIndex = 16;
            this.labelAdditive.Text = "Additive Key:";
            this.labelAdditive.Visible = false;
            // 
            // numericMultiplicative
            // 
            this.numericMultiplicative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMultiplicative.Location = new System.Drawing.Point(681, 22);
            this.numericMultiplicative.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericMultiplicative.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMultiplicative.Name = "numericMultiplicative";
            this.numericMultiplicative.Size = new System.Drawing.Size(83, 31);
            this.numericMultiplicative.TabIndex = 17;
            this.numericMultiplicative.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMultiplicative.Visible = false;
            // 
            // numericAdditive
            // 
            this.numericAdditive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAdditive.Location = new System.Drawing.Point(681, 70);
            this.numericAdditive.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericAdditive.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericAdditive.Name = "numericAdditive";
            this.numericAdditive.Size = new System.Drawing.Size(83, 31);
            this.numericAdditive.TabIndex = 18;
            this.numericAdditive.Visible = false;
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatrix.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMatrix.Location = new System.Drawing.Point(917, 18);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(149, 31);
            this.labelMatrix.TabIndex = 19;
            this.labelMatrix.Text = "Key Matrix:";
            this.labelMatrix.Visible = false;
            // 
            // textMatrix1
            // 
            this.textMatrix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatrix1.Location = new System.Drawing.Point(935, 70);
            this.textMatrix1.Name = "textMatrix1";
            this.textMatrix1.Size = new System.Drawing.Size(45, 31);
            this.textMatrix1.TabIndex = 20;
            this.textMatrix1.Visible = false;
            this.textMatrix1.TextChanged += new System.EventHandler(this.matrixText_Changed);
            this.textMatrix1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixKey_Pressed);
            // 
            // textMatrix2
            // 
            this.textMatrix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatrix2.Location = new System.Drawing.Point(1010, 70);
            this.textMatrix2.Name = "textMatrix2";
            this.textMatrix2.Size = new System.Drawing.Size(45, 31);
            this.textMatrix2.TabIndex = 21;
            this.textMatrix2.Visible = false;
            this.textMatrix2.TextChanged += new System.EventHandler(this.matrixText_Changed);
            this.textMatrix2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixKey_Pressed);
            // 
            // textMatrix3
            // 
            this.textMatrix3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatrix3.Location = new System.Drawing.Point(935, 125);
            this.textMatrix3.Name = "textMatrix3";
            this.textMatrix3.Size = new System.Drawing.Size(45, 31);
            this.textMatrix3.TabIndex = 22;
            this.textMatrix3.Visible = false;
            this.textMatrix3.TextChanged += new System.EventHandler(this.matrixText_Changed);
            this.textMatrix3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixKey_Pressed);
            // 
            // textMatrix4
            // 
            this.textMatrix4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatrix4.Location = new System.Drawing.Point(1010, 125);
            this.textMatrix4.Name = "textMatrix4";
            this.textMatrix4.Size = new System.Drawing.Size(45, 31);
            this.textMatrix4.TabIndex = 23;
            this.textMatrix4.Visible = false;
            this.textMatrix4.TextChanged += new System.EventHandler(this.matrixText_Changed);
            this.textMatrix4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixKey_Pressed);
            // 
            // buttonEncipher
            // 
            this.buttonEncipher.BackColor = System.Drawing.Color.Black;
            this.buttonEncipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncipher.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEncipher.Location = new System.Drawing.Point(547, 407);
            this.buttonEncipher.Name = "buttonEncipher";
            this.buttonEncipher.Size = new System.Drawing.Size(90, 42);
            this.buttonEncipher.TabIndex = 24;
            this.buttonEncipher.Text = "Encipher";
            this.buttonEncipher.UseVisualStyleBackColor = false;
            this.buttonEncipher.Visible = false;
            this.buttonEncipher.Click += new System.EventHandler(this.ButtonEncipher_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Anthem_Sigma.Properties.Resources.Logo_Full;
            this.pictureBox1.Location = new System.Drawing.Point(531, 475);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 144;
            this.pictureBox1.TabStop = false;
            // 
            // labelOffset
            // 
            this.labelOffset.AutoSize = true;
            this.labelOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOffset.ForeColor = System.Drawing.SystemColors.Control;
            this.labelOffset.Location = new System.Drawing.Point(44, 196);
            this.labelOffset.Name = "labelOffset";
            this.labelOffset.Size = new System.Drawing.Size(96, 31);
            this.labelOffset.TabIndex = 147;
            this.labelOffset.Text = "Offset:";
            this.labelOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOffset.Visible = false;
            // 
            // comboOffset
            // 
            this.comboOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOffset.FormattingEnabled = true;
            this.comboOffset.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.comboOffset.Location = new System.Drawing.Point(146, 199);
            this.comboOffset.Name = "comboOffset";
            this.comboOffset.Size = new System.Drawing.Size(50, 28);
            this.comboOffset.TabIndex = 146;
            this.comboOffset.Visible = false;
            // 
            // EncipherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.labelOffset);
            this.Controls.Add(this.comboOffset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEncipher);
            this.Controls.Add(this.textMatrix4);
            this.Controls.Add(this.textMatrix3);
            this.Controls.Add(this.textMatrix2);
            this.Controls.Add(this.textMatrix1);
            this.Controls.Add(this.labelMatrix);
            this.Controls.Add(this.numericAdditive);
            this.Controls.Add(this.numericMultiplicative);
            this.Controls.Add(this.labelAdditive);
            this.Controls.Add(this.labelMultiplicative);
            this.Controls.Add(this.textKeyword);
            this.Controls.Add(this.labelKeyword);
            this.Controls.Add(this.comboKeyLetter);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelUpload);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.comboEncipherMethod);
            this.Controls.Add(this.labelSelectEncodingType);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EncipherPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anthem Sigma - Cryptanalysis Tool";
            this.Load += new System.EventHandler(this.EncipherPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMultiplicative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdditive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.Label labelSelectEncodingType;
        private System.Windows.Forms.ComboBox comboEncipherMethod;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label labelUpload;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.ComboBox comboKeyLetter;
        private System.Windows.Forms.Label labelKeyword;
        private System.Windows.Forms.TextBox textKeyword;
        private System.Windows.Forms.Label labelMultiplicative;
        private System.Windows.Forms.Label labelAdditive;
        private System.Windows.Forms.NumericUpDown numericMultiplicative;
        private System.Windows.Forms.NumericUpDown numericAdditive;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.TextBox textMatrix1;
        private System.Windows.Forms.TextBox textMatrix2;
        private System.Windows.Forms.TextBox textMatrix3;
        private System.Windows.Forms.TextBox textMatrix4;
        private System.Windows.Forms.Button buttonEncipher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelOffset;
        private System.Windows.Forms.ComboBox comboOffset;
    }
}
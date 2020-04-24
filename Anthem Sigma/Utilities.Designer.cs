namespace Anthem_Sigma
{
    partial class UtilitiesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilitiesPage));
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxCiphertext = new System.Windows.Forms.RichTextBox();
            this.labelUpload = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxNGram = new System.Windows.Forms.RichTextBox();
            this.labelNGram = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNGram = new System.Windows.Forms.ComboBox();
            this.textBoxLetterFrequency = new System.Windows.Forms.RichTextBox();
            this.labelLetterFrequency = new System.Windows.Forms.Label();
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
            // textBoxCiphertext
            // 
            this.textBoxCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiphertext.Location = new System.Drawing.Point(12, 12);
            this.textBoxCiphertext.Name = "textBoxCiphertext";
            this.textBoxCiphertext.ReadOnly = true;
            this.textBoxCiphertext.Size = new System.Drawing.Size(518, 354);
            this.textBoxCiphertext.TabIndex = 28;
            this.textBoxCiphertext.Text = "";
            // 
            // labelUpload
            // 
            this.labelUpload.AutoSize = true;
            this.labelUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpload.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUpload.Location = new System.Drawing.Point(108, 383);
            this.labelUpload.Name = "labelUpload";
            this.labelUpload.Size = new System.Drawing.Size(122, 20);
            this.labelUpload.TabIndex = 34;
            this.labelUpload.Text = "Upload a .txt file";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.Black;
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpload.Location = new System.Drawing.Point(12, 372);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(90, 42);
            this.buttonUpload.TabIndex = 33;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // textBoxNGram
            // 
            this.textBoxNGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNGram.Location = new System.Drawing.Point(654, 12);
            this.textBoxNGram.Name = "textBoxNGram";
            this.textBoxNGram.ReadOnly = true;
            this.textBoxNGram.Size = new System.Drawing.Size(518, 354);
            this.textBoxNGram.TabIndex = 35;
            this.textBoxNGram.Text = "";
            // 
            // labelNGram
            // 
            this.labelNGram.AutoSize = true;
            this.labelNGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNGram.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNGram.Location = new System.Drawing.Point(649, 376);
            this.labelNGram.Name = "labelNGram";
            this.labelNGram.Size = new System.Drawing.Size(281, 29);
            this.labelNGram.TabIndex = 36;
            this.labelNGram.Text = "N-Gram Frequency Chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(647, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "N-Gram:";
            // 
            // comboNGram
            // 
            this.comboNGram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNGram.FormattingEnabled = true;
            this.comboNGram.Items.AddRange(new object[] {
            "Digraph",
            "Trigraph",
            "Quadgraph",
            "Pentgraph",
            "Hexgraph",
            "Septgraph",
            "Octgraph"});
            this.comboNGram.Location = new System.Drawing.Point(794, 437);
            this.comboNGram.Name = "comboNGram";
            this.comboNGram.Size = new System.Drawing.Size(178, 39);
            this.comboNGram.TabIndex = 38;
            this.comboNGram.SelectedIndexChanged += new System.EventHandler(this.ComboNGram_SelectedIndexChanged);
            // 
            // textBoxLetterFrequency
            // 
            this.textBoxLetterFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLetterFrequency.Location = new System.Drawing.Point(12, 437);
            this.textBoxLetterFrequency.Name = "textBoxLetterFrequency";
            this.textBoxLetterFrequency.ReadOnly = true;
            this.textBoxLetterFrequency.Size = new System.Drawing.Size(518, 149);
            this.textBoxLetterFrequency.TabIndex = 39;
            this.textBoxLetterFrequency.Text = "";
            // 
            // labelLetterFrequency
            // 
            this.labelLetterFrequency.AutoSize = true;
            this.labelLetterFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetterFrequency.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLetterFrequency.Location = new System.Drawing.Point(12, 589);
            this.labelLetterFrequency.Name = "labelLetterFrequency";
            this.labelLetterFrequency.Size = new System.Drawing.Size(257, 29);
            this.labelLetterFrequency.TabIndex = 40;
            this.labelLetterFrequency.Text = "Letter Frequency Chart";
            // 
            // UtilitiesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.labelLetterFrequency);
            this.Controls.Add(this.textBoxLetterFrequency);
            this.Controls.Add(this.comboNGram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNGram);
            this.Controls.Add(this.textBoxNGram);
            this.Controls.Add(this.labelUpload);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.textBoxCiphertext);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UtilitiesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anthem Sigma - Cryptanalysis Tool";
            this.Load += new System.EventHandler(this.UtilitiesPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RichTextBox textBoxCiphertext;
        private System.Windows.Forms.Label labelUpload;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.RichTextBox textBoxNGram;
        private System.Windows.Forms.Label labelNGram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNGram;
        private System.Windows.Forms.RichTextBox textBoxLetterFrequency;
        private System.Windows.Forms.Label labelLetterFrequency;
    }
}
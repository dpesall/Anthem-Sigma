namespace Anthem_Sigma
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDecipherText = new System.Windows.Forms.Button();
            this.buttonEncipherText = new System.Windows.Forms.Button();
            this.buttonUtilities = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDecipherManual = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Black;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(1082, 627);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 42);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonDecipherText
            // 
            this.buttonDecipherText.BackColor = System.Drawing.Color.Black;
            this.buttonDecipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecipherText.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDecipherText.Location = new System.Drawing.Point(64, 76);
            this.buttonDecipherText.Name = "buttonDecipherText";
            this.buttonDecipherText.Size = new System.Drawing.Size(279, 81);
            this.buttonDecipherText.TabIndex = 1;
            this.buttonDecipherText.Text = "Decipher Text";
            this.buttonDecipherText.UseVisualStyleBackColor = false;
            this.buttonDecipherText.Click += new System.EventHandler(this.ButtonDecipherText_Click);
            // 
            // buttonEncipherText
            // 
            this.buttonEncipherText.BackColor = System.Drawing.Color.Black;
            this.buttonEncipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncipherText.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEncipherText.Location = new System.Drawing.Point(454, 76);
            this.buttonEncipherText.Name = "buttonEncipherText";
            this.buttonEncipherText.Size = new System.Drawing.Size(279, 81);
            this.buttonEncipherText.TabIndex = 2;
            this.buttonEncipherText.Text = "Encipher Text";
            this.buttonEncipherText.UseVisualStyleBackColor = false;
            this.buttonEncipherText.Click += new System.EventHandler(this.ButtonEncipherText_Click);
            // 
            // buttonUtilities
            // 
            this.buttonUtilities.BackColor = System.Drawing.Color.Black;
            this.buttonUtilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilities.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUtilities.Location = new System.Drawing.Point(844, 76);
            this.buttonUtilities.Name = "buttonUtilities";
            this.buttonUtilities.Size = new System.Drawing.Size(279, 81);
            this.buttonUtilities.TabIndex = 3;
            this.buttonUtilities.Text = "Utilities";
            this.buttonUtilities.UseVisualStyleBackColor = false;
            this.buttonUtilities.Click += new System.EventHandler(this.ButtonUtilities_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Anthem_Sigma.Properties.Resources.Logo_Full;
            this.pictureBox1.Location = new System.Drawing.Point(456, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDecipherManual
            // 
            this.buttonDecipherManual.BackColor = System.Drawing.Color.Black;
            this.buttonDecipherManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecipherManual.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDecipherManual.Location = new System.Drawing.Point(64, 241);
            this.buttonDecipherManual.Name = "buttonDecipherManual";
            this.buttonDecipherManual.Size = new System.Drawing.Size(279, 81);
            this.buttonDecipherManual.TabIndex = 5;
            this.buttonDecipherManual.Text = "Decipher Manual";
            this.buttonDecipherManual.UseVisualStyleBackColor = false;
            this.buttonDecipherManual.Click += new System.EventHandler(this.ButtonDecipherManual_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.BackColor = System.Drawing.Color.Black;
            this.buttonCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCredits.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCredits.Location = new System.Drawing.Point(853, 241);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(279, 81);
            this.buttonCredits.TabIndex = 6;
            this.buttonCredits.Text = "Credits";
            this.buttonCredits.UseVisualStyleBackColor = false;
            this.buttonCredits.Click += new System.EventHandler(this.ButtonCredits_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.buttonDecipherManual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUtilities);
            this.Controls.Add(this.buttonEncipherText);
            this.Controls.Add(this.buttonDecipherText);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anthem Sigma - Crpytanalysis Tool";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDecipherText;
        private System.Windows.Forms.Button buttonEncipherText;
        private System.Windows.Forms.Button buttonUtilities;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDecipherManual;
        private System.Windows.Forms.Button buttonCredits;
    }
}


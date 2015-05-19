namespace Program
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Korisnici = new System.Windows.Forms.ListBox();
            this.Domaćice = new System.Windows.Forms.ListBox();
            this.btKorisnik = new System.Windows.Forms.Button();
            this.btDomacica = new System.Windows.Forms.Button();
            this.btObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Korisnici
            // 
            this.Korisnici.FormattingEnabled = true;
            this.Korisnici.Location = new System.Drawing.Point(36, 145);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(218, 355);
            this.Korisnici.TabIndex = 2;
            // 
            // Domaćice
            // 
            this.Domaćice.FormattingEnabled = true;
            this.Domaćice.Location = new System.Drawing.Point(320, 145);
            this.Domaćice.Name = "Domaćice";
            this.Domaćice.Size = new System.Drawing.Size(218, 355);
            this.Domaćice.TabIndex = 3;
            // 
            // btKorisnik
            // 
            this.btKorisnik.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKorisnik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.btKorisnik.Location = new System.Drawing.Point(394, 23);
            this.btKorisnik.Name = "btKorisnik";
            this.btKorisnik.Size = new System.Drawing.Size(144, 28);
            this.btKorisnik.TabIndex = 4;
            this.btKorisnik.Text = "Novi Korisnik";
            this.btKorisnik.UseVisualStyleBackColor = true;
            // 
            // btDomacica
            // 
            this.btDomacica.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDomacica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.btDomacica.Location = new System.Drawing.Point(394, 75);
            this.btDomacica.Name = "btDomacica";
            this.btDomacica.Size = new System.Drawing.Size(144, 28);
            this.btDomacica.TabIndex = 5;
            this.btDomacica.Text = "Nova Domaćica";
            this.btDomacica.UseVisualStyleBackColor = true;
            // 
            // btObrisi
            // 
            this.btObrisi.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.btObrisi.Location = new System.Drawing.Point(394, 519);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(144, 28);
            this.btObrisi.TabIndex = 6;
            this.btObrisi.Text = "Obriši";
            this.btObrisi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(181)))), ((int)(((byte)(195)))));
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(36, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Korisnici";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(181)))), ((int)(((byte)(195)))));
            this.label3.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(320, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Domaćice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(181)))), ((int)(((byte)(195)))));
            this.pictureBox1.Location = new System.Drawing.Point(24, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 376);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(151)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(579, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.btDomacica);
            this.Controls.Add(this.btKorisnik);
            this.Controls.Add(this.Domaćice);
            this.Controls.Add(this.Korisnici);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Korisnici;
        private System.Windows.Forms.ListBox Domaćice;
        private System.Windows.Forms.Button btKorisnik;
        private System.Windows.Forms.Button btDomacica;
        private System.Windows.Forms.Button btObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


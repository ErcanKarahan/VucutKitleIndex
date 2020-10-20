namespace VucutKitleIndex
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
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblVki = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.lblVkiSonuc = new System.Windows.Forms.Label();
            this.lblDurumSonuc = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(31, 82);
            this.lblBoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(131, 25);
            this.lblBoy.TabIndex = 0;
            this.lblBoy.Text = "Boy (Ör:1,82)";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Location = new System.Drawing.Point(48, 132);
            this.lblKilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(114, 25);
            this.lblKilo.TabIndex = 1;
            this.lblKilo.Text = "Kilo (Ör:74)";
            // 
            // lblVki
            // 
            this.lblVki.AutoSize = true;
            this.lblVki.Location = new System.Drawing.Point(106, 226);
            this.lblVki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVki.Name = "lblVki";
            this.lblVki.Size = new System.Drawing.Size(56, 25);
            this.lblVki.TabIndex = 2;
            this.lblVki.Text = "VKI :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(81, 279);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(81, 25);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "Durum :";
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(192, 77);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(93, 30);
            this.txtBoy.TabIndex = 1;
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(192, 127);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(93, 30);
            this.txtKilo.TabIndex = 2;
            // 
            // lblVkiSonuc
            // 
            this.lblVkiSonuc.AutoSize = true;
            this.lblVkiSonuc.Location = new System.Drawing.Point(187, 226);
            this.lblVkiSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVkiSonuc.Name = "lblVkiSonuc";
            this.lblVkiSonuc.Size = new System.Drawing.Size(69, 25);
            this.lblVkiSonuc.TabIndex = 2;
            this.lblVkiSonuc.Text = "Sonuc";
            // 
            // lblDurumSonuc
            // 
            this.lblDurumSonuc.AutoSize = true;
            this.lblDurumSonuc.Location = new System.Drawing.Point(187, 279);
            this.lblDurumSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurumSonuc.Name = "lblDurumSonuc";
            this.lblDurumSonuc.Size = new System.Drawing.Size(69, 25);
            this.lblDurumSonuc.TabIndex = 2;
            this.lblDurumSonuc.Text = "Sonuc";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Black;
            this.lblBaslik.Location = new System.Drawing.Point(30, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(379, 32);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Vucut Kitle Index Hesaplama";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(192, 178);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(93, 33);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(456, 348);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblDurumSonuc);
            this.Controls.Add(this.lblVkiSonuc);
            this.Controls.Add(this.lblVki);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblBoy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblVki;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Label lblVkiSonuc;
        private System.Windows.Forms.Label lblDurumSonuc;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnHesapla;
    }
}


﻿namespace Otobüs_Bilet_Otomasyonu
{
    partial class Giriş_Ekranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSıfre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Giriş Yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSıfre
            // 
            this.txtSıfre.Location = new System.Drawing.Point(107, 86);
            this.txtSıfre.Name = "txtSıfre";
            this.txtSıfre.Size = new System.Drawing.Size(100, 20);
            this.txtSıfre.TabIndex = 3;
            // 
            // txtKullanıcıAd
            // 
            this.txtKullanıcıAd.Location = new System.Drawing.Point(107, 44);
            this.txtKullanıcıAd.Name = "txtKullanıcıAd";
            this.txtKullanıcıAd.Size = new System.Drawing.Size(100, 20);
            this.txtKullanıcıAd.TabIndex = 2;
            // 
            // Giriş_Ekranı
            // 
            this.ClientSize = new System.Drawing.Size(252, 200);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSıfre);
            this.Controls.Add(this.txtKullanıcıAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Giriş_Ekranı";
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtSıfre;
        public System.Windows.Forms.TextBox txtKullanıcıAd;
    }
}


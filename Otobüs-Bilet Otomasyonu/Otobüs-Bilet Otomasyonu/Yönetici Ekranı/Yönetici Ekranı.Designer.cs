namespace Otobüs_Bilet_Otomasyonu
{
    partial class Yönetici_Ekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yönetici_Ekranı));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSeferEkle = new System.Windows.Forms.Button();
            this.btnİstatistikler = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnOturumBilgileri = new System.Windows.Forms.Button();
            this.btnKullanıcıEkle = new System.Windows.Forms.Button();
            this.btnPersonelBilgileri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.pnlYönetici = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel2);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSeferEkle);
            this.panel3.Controls.Add(this.btnİstatistikler);
            this.panel3.Controls.Add(this.btnAnasayfa);
            this.panel3.Controls.Add(this.btnOturumBilgileri);
            this.panel3.Controls.Add(this.btnKullanıcıEkle);
            this.panel3.Controls.Add(this.btnPersonelBilgileri);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnSeferEkle
            // 
            resources.ApplyResources(this.btnSeferEkle, "btnSeferEkle");
            this.btnSeferEkle.Name = "btnSeferEkle";
            this.btnSeferEkle.TabStop = false;
            this.btnSeferEkle.UseVisualStyleBackColor = true;
            this.btnSeferEkle.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnİstatistikler
            // 
            resources.ApplyResources(this.btnİstatistikler, "btnİstatistikler");
            this.btnİstatistikler.Name = "btnİstatistikler";
            this.btnİstatistikler.TabStop = false;
            this.btnİstatistikler.UseVisualStyleBackColor = true;
            this.btnİstatistikler.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAnasayfa
            // 
            resources.ApplyResources(this.btnAnasayfa, "btnAnasayfa");
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            // 
            // btnOturumBilgileri
            // 
            resources.ApplyResources(this.btnOturumBilgileri, "btnOturumBilgileri");
            this.btnOturumBilgileri.Name = "btnOturumBilgileri";
            this.btnOturumBilgileri.TabStop = false;
            this.btnOturumBilgileri.UseVisualStyleBackColor = true;
            this.btnOturumBilgileri.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnKullanıcıEkle
            // 
            resources.ApplyResources(this.btnKullanıcıEkle, "btnKullanıcıEkle");
            this.btnKullanıcıEkle.Name = "btnKullanıcıEkle";
            this.btnKullanıcıEkle.TabStop = false;
            this.btnKullanıcıEkle.UseVisualStyleBackColor = true;
            this.btnKullanıcıEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPersonelBilgileri
            // 
            resources.ApplyResources(this.btnPersonelBilgileri, "btnPersonelBilgileri");
            this.btnPersonelBilgileri.Name = "btnPersonelBilgileri";
            this.btnPersonelBilgileri.TabStop = false;
            this.btnPersonelBilgileri.UseVisualStyleBackColor = true;
            this.btnPersonelBilgileri.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblKullanıcı);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblKullanıcı
            // 
            resources.ApplyResources(this.lblKullanıcı, "lblKullanıcı");
            this.lblKullanıcı.Name = "lblKullanıcı";
            // 
            // pnlYönetici
            // 
            resources.ApplyResources(this.pnlYönetici, "pnlYönetici");
            this.pnlYönetici.Name = "pnlYönetici";
            // 
            // Yönetici_Ekranı
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlYönetici);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.label1);
            this.Name = "Yönetici_Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Yönetici_Ekranı_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnPersonelBilgileri;
        private System.Windows.Forms.Button btnKullanıcıEkle;
        private System.Windows.Forms.Button btnİstatistikler;
        private System.Windows.Forms.Button btnSeferEkle;
        private System.Windows.Forms.Button btnOturumBilgileri;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel pnlYönetici;
        public System.Windows.Forms.Panel panel2;
    }
}
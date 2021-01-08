namespace Otobüs_Bilet_Otomasyonu
{
    partial class Personel_Ekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Ekranı));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPersonel = new System.Windows.Forms.Panel();
            this.btnBiletSatıs = new System.Windows.Forms.Button();
            this.btnOtobusSeferlerı = new System.Windows.Forms.Button();
            this.btnMusterıBılgılerı = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // pnlPersonel
            // 
            resources.ApplyResources(this.pnlPersonel, "pnlPersonel");
            this.pnlPersonel.Name = "pnlPersonel";
            // 
            // btnBiletSatıs
            // 
            resources.ApplyResources(this.btnBiletSatıs, "btnBiletSatıs");
            this.btnBiletSatıs.ForeColor = System.Drawing.Color.Black;
            this.btnBiletSatıs.Name = "btnBiletSatıs";
            this.btnBiletSatıs.TabStop = false;
            this.btnBiletSatıs.UseVisualStyleBackColor = true;
            this.btnBiletSatıs.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOtobusSeferlerı
            // 
            resources.ApplyResources(this.btnOtobusSeferlerı, "btnOtobusSeferlerı");
            this.btnOtobusSeferlerı.ForeColor = System.Drawing.Color.Black;
            this.btnOtobusSeferlerı.Name = "btnOtobusSeferlerı";
            this.btnOtobusSeferlerı.TabStop = false;
            this.btnOtobusSeferlerı.UseVisualStyleBackColor = true;
            this.btnOtobusSeferlerı.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMusterıBılgılerı
            // 
            resources.ApplyResources(this.btnMusterıBılgılerı, "btnMusterıBılgılerı");
            this.btnMusterıBılgılerı.ForeColor = System.Drawing.Color.Black;
            this.btnMusterıBılgılerı.Name = "btnMusterıBılgılerı";
            this.btnMusterıBılgılerı.TabStop = false;
            this.btnMusterıBılgılerı.UseVisualStyleBackColor = true;
            this.btnMusterıBılgılerı.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlMenu
            // 
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Name = "pnlMenu";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.btnAnasayfa);
            this.panel3.Controls.Add(this.btnMusterıBılgılerı);
            this.panel3.Controls.Add(this.btnBiletSatıs);
            this.panel3.Controls.Add(this.btnOtobusSeferlerı);
            this.panel3.Name = "panel3";
            // 
            // btnAnasayfa
            // 
            resources.ApplyResources(this.btnAnasayfa, "btnAnasayfa");
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.lblKullanıcı);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Name = "panel2";
            // 
            // lblKullanıcı
            // 
            resources.ApplyResources(this.lblKullanıcı, "lblKullanıcı");
            this.lblKullanıcı.Name = "lblKullanıcı";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Personel_Ekranı
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlPersonel);
            this.Controls.Add(this.label1);
            this.Name = "Personel_Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personel_Ekranı_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBiletSatıs;
        private System.Windows.Forms.Button btnOtobusSeferlerı;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAnasayfa;
        public System.Windows.Forms.Panel pnlPersonel;
        public System.Windows.Forms.Label lblKullanıcı;
        public System.Windows.Forms.Panel pnlMenu;
        public System.Windows.Forms.Button btnMusterıBılgılerı;
    }
}
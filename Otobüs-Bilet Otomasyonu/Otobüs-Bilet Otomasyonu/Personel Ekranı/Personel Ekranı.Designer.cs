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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(378, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personelin göreceği ekran";
            // 
            // pnlPersonel
            // 
            this.pnlPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPersonel.Location = new System.Drawing.Point(288, 140);
            this.pnlPersonel.Name = "pnlPersonel";
            this.pnlPersonel.Size = new System.Drawing.Size(826, 451);
            this.pnlPersonel.TabIndex = 1;
            // 
            // btnBiletSatıs
            // 
            this.btnBiletSatıs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiletSatıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiletSatıs.ForeColor = System.Drawing.Color.Black;
            this.btnBiletSatıs.Location = new System.Drawing.Point(0, 67);
            this.btnBiletSatıs.Name = "btnBiletSatıs";
            this.btnBiletSatıs.Size = new System.Drawing.Size(265, 60);
            this.btnBiletSatıs.TabIndex = 2;
            this.btnBiletSatıs.TabStop = false;
            this.btnBiletSatıs.Text = "Bilet Satışı";
            this.btnBiletSatıs.UseVisualStyleBackColor = true;
            this.btnBiletSatıs.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOtobusSeferlerı
            // 
            this.btnOtobusSeferlerı.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOtobusSeferlerı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtobusSeferlerı.ForeColor = System.Drawing.Color.Black;
            this.btnOtobusSeferlerı.Location = new System.Drawing.Point(0, 0);
            this.btnOtobusSeferlerı.Name = "btnOtobusSeferlerı";
            this.btnOtobusSeferlerı.Size = new System.Drawing.Size(265, 67);
            this.btnOtobusSeferlerı.TabIndex = 2;
            this.btnOtobusSeferlerı.TabStop = false;
            this.btnOtobusSeferlerı.Text = "Otobüs Seferleri";
            this.btnOtobusSeferlerı.UseVisualStyleBackColor = true;
            this.btnOtobusSeferlerı.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMusterıBılgılerı
            // 
            this.btnMusterıBılgılerı.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusterıBılgılerı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusterıBılgılerı.ForeColor = System.Drawing.Color.Black;
            this.btnMusterıBılgılerı.Location = new System.Drawing.Point(0, 127);
            this.btnMusterıBılgılerı.Name = "btnMusterıBılgılerı";
            this.btnMusterıBılgılerı.Size = new System.Drawing.Size(265, 65);
            this.btnMusterıBılgılerı.TabIndex = 2;
            this.btnMusterıBılgılerı.TabStop = false;
            this.btnMusterıBılgılerı.Text = "Müşteri Bilgileri";
            this.btnMusterıBılgılerı.UseVisualStyleBackColor = true;
            this.btnMusterıBılgılerı.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(265, 603);
            this.pnlMenu.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAnasayfa);
            this.panel3.Controls.Add(this.btnMusterıBılgılerı);
            this.panel3.Controls.Add(this.btnBiletSatıs);
            this.panel3.Controls.Add(this.btnOtobusSeferlerı);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 362);
            this.panel3.TabIndex = 1;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 192);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(265, 67);
            this.btnAnasayfa.TabIndex = 3;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblKullanıcı);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 140);
            this.panel2.TabIndex = 0;
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcı.Location = new System.Drawing.Point(66, 93);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(130, 25);
            this.lblKullanıcı.TabIndex = 1;
            this.lblKullanıcı.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            
            // 
            // Personel_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 603);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlPersonel);
            this.Controls.Add(this.label1);
            this.Name = "Personel_Ekranı";
            this.Text = "Personel_Ekranı";
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
        private System.Windows.Forms.Button btnMusterıBılgılerı;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAnasayfa;
        public System.Windows.Forms.Panel pnlPersonel;
        public System.Windows.Forms.Label lblKullanıcı;
        public System.Windows.Forms.Panel pnlMenu;
    }
}
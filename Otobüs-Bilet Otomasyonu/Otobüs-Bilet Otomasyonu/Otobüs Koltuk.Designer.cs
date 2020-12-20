
namespace Otobüs_Bilet_Otomasyonu
{
    partial class Otobüs_Koltuk
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
            this.pnlOtobusKoltuk = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlOtobusKoltuk
            // 
            this.pnlOtobusKoltuk.Location = new System.Drawing.Point(12, -90);
            this.pnlOtobusKoltuk.Name = "pnlOtobusKoltuk";
            this.pnlOtobusKoltuk.Size = new System.Drawing.Size(893, 509);
            this.pnlOtobusKoltuk.TabIndex = 0;
            // 
            // Otobüs_Koltuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 533);
            this.Controls.Add(this.pnlOtobusKoltuk);
            this.Name = "Otobüs_Koltuk";
            this.Text = "Otobüs_Koltuk";
            this.Load += new System.EventHandler(this.Otobüs_Koltuk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOtobusKoltuk;
    }
}
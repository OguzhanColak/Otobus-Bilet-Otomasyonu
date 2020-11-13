using System;

namespace Otobüs_Bilet_Otomasyonu
{
    partial class Sefer_ve_Koltuk_Seçimi
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Balıkesir",
            "Bilecik",
            "Bursa",
            "Çanakkale",
            "Edirne",
            "İstanbul",
            "Kocaeli",
            "Kırklareli",
            "Sakarya",
            "Tekirdağ",
            "Yalova"});
            this.comboBox1.Location = new System.Drawing.Point(206, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Balıkesir",
            "Bilecik",
            "Bursa",
            "Çanakkale",
            "Edirne",
            "İstanbul",
            "Kocaeli",
            "Kırklareli",
            "Sakarya",
            "Tekirdağ",
            "Yalova"});
            this.comboBox2.Location = new System.Drawing.Point(481, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 32);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kalkış Noktası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(352, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varış Noktası:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Uygun Sefer Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 173);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(751, 61);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(64, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(751, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tarih       K. Noktası - V. Noktası       Kalkış Saati        Kalan Koltuk Sayısı" +
    "       Koltuk Düzeni";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(631, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Koltuk Seçme Ekranı";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(680, 340);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(135, 77);
            this.button12.TabIndex = 8;
            this.button12.Text = "Koltuk Al";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(69, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(69, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(69, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(123, 481);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 50);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btn_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(177, 481);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Location = new System.Drawing.Point(231, 481);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 50);
            this.button8.TabIndex = 9;
            this.button8.Text = "12";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btn_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button9.Location = new System.Drawing.Point(123, 340);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 50);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btn_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Location = new System.Drawing.Point(123, 397);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 50);
            this.button10.TabIndex = 9;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btn_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button11.Location = new System.Drawing.Point(177, 340);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(48, 50);
            this.button11.TabIndex = 9;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btn_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button14.Location = new System.Drawing.Point(177, 397);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(48, 50);
            this.button14.TabIndex = 9;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btn_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button15.Location = new System.Drawing.Point(231, 340);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(48, 50);
            this.button15.TabIndex = 9;
            this.button15.Text = "10";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btn_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button16.Location = new System.Drawing.Point(231, 397);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(48, 50);
            this.button16.TabIndex = 9;
            this.button16.Text = "11";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btn_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(680, 454);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(135, 77);
            this.button13.TabIndex = 8;
            this.button13.Text = "Rezerve Ettir";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // Sefer_ve_Koltuk_Seçimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 554);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Sefer_ve_Koltuk_Seçimi";
            this.Text = "Sefer_ve_Koltuk_Seçimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
    }
}
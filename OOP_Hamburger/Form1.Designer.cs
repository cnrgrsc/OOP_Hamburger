namespace OOP_Hamburger
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
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.rndBuyuk = new System.Windows.Forms.RadioButton();
            this.rndOrta = new System.Windows.Forms.RadioButton();
            this.rndKucuk = new System.Windows.Forms.RadioButton();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.grbMalzemeler = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.grbMalzemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(19, 42);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(161, 21);
            this.cmbMenuler.TabIndex = 1;
            this.cmbMenuler.SelectedIndexChanged += new System.EventHandler(this.cmbMenuler_SelectedIndexChanged);
            // 
            // rndBuyuk
            // 
            this.rndBuyuk.AutoSize = true;
            this.rndBuyuk.Location = new System.Drawing.Point(17, 122);
            this.rndBuyuk.Name = "rndBuyuk";
            this.rndBuyuk.Size = new System.Drawing.Size(76, 17);
            this.rndBuyuk.TabIndex = 2;
            this.rndBuyuk.TabStop = true;
            this.rndBuyuk.Text = "Buyuk Boy";
            this.rndBuyuk.UseVisualStyleBackColor = true;
            // 
            // rndOrta
            // 
            this.rndOrta.AutoSize = true;
            this.rndOrta.Location = new System.Drawing.Point(17, 164);
            this.rndOrta.Name = "rndOrta";
            this.rndOrta.Size = new System.Drawing.Size(66, 17);
            this.rndOrta.TabIndex = 2;
            this.rndOrta.TabStop = true;
            this.rndOrta.Text = "Orta Boy";
            this.rndOrta.UseVisualStyleBackColor = true;
            // 
            // rndKucuk
            // 
            this.rndKucuk.AutoSize = true;
            this.rndKucuk.Location = new System.Drawing.Point(17, 202);
            this.rndKucuk.Name = "rndKucuk";
            this.rndKucuk.Size = new System.Drawing.Size(77, 17);
            this.rndKucuk.TabIndex = 2;
            this.rndKucuk.TabStop = true;
            this.rndKucuk.Text = "Kucuk Boy";
            this.rndKucuk.UseVisualStyleBackColor = true;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(447, 42);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(601, 602);
            this.lstSiparisler.TabIndex = 3;
            // 
            // grbMalzemeler
            // 
            this.grbMalzemeler.Controls.Add(this.checkBox8);
            this.grbMalzemeler.Controls.Add(this.checkBox4);
            this.grbMalzemeler.Controls.Add(this.checkBox7);
            this.grbMalzemeler.Controls.Add(this.checkBox3);
            this.grbMalzemeler.Controls.Add(this.checkBox6);
            this.grbMalzemeler.Controls.Add(this.checkBox2);
            this.grbMalzemeler.Controls.Add(this.checkBox5);
            this.grbMalzemeler.Controls.Add(this.checkBox1);
            this.grbMalzemeler.Location = new System.Drawing.Point(16, 278);
            this.grbMalzemeler.Name = "grbMalzemeler";
            this.grbMalzemeler.Size = new System.Drawing.Size(365, 217);
            this.grbMalzemeler.TabIndex = 4;
            this.grbMalzemeler.TabStop = false;
            this.grbMalzemeler.Text = "Soslar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "0,90";
            this.checkBox1.Text = "Ketcap";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 98);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Tag = "0,75";
            this.checkBox2.Text = "Mayonez";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 152);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "1";
            this.checkBox3.Text = "Hardal";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(262, 120);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(52, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Tag = "0,95";
            this.checkBox4.Text = "Ranc";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(148, 45);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(59, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Tag = "0,85";
            this.checkBox5.Text = "Buffalo";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(148, 98);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(59, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Tag = "0,80";
            this.checkBox6.Text = "AciSos";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(262, 70);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(66, 17);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Tag = "0,70";
            this.checkBox7.Text = "Barbuku";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(148, 152);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(116, 17);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Tag = "1,25";
            this.checkBox8.Text = "SarmisakliMayonez";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDurum.Location = new System.Drawing.Point(16, 531);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(365, 113);
            this.lblDurum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adet";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(305, 42);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(71, 20);
            this.nmrAdet.TabIndex = 6;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(447, 678);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 44);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(915, 678);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(133, 44);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 748);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.grbMalzemeler);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.rndKucuk);
            this.Controls.Add(this.rndOrta);
            this.Controls.Add(this.rndBuyuk);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMalzemeler.ResumeLayout(false);
            this.grbMalzemeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.RadioButton rndBuyuk;
        private System.Windows.Forms.RadioButton rndOrta;
        private System.Windows.Forms.RadioButton rndKucuk;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.GroupBox grbMalzemeler;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
    }
}


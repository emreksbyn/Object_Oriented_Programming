﻿namespace OOP_Giris_Son
{
    partial class frmCalisanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanlar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniCalisan = new System.Windows.Forms.Button();
            this.lstboxCalisanlar = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDepartmani = new System.Windows.Forms.ComboBox();
            this.cmbAnaDili = new System.Windows.Forms.ComboBox();
            this.numMaasi = new System.Windows.Forms.NumericUpDown();
            this.radioKadin = new System.Windows.Forms.RadioButton();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.datetimeDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonu = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaasi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniCalisan);
            this.groupBox1.Controls.Add(this.lstboxCalisanlar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışanlar :";
            // 
            // btnYeniCalisan
            // 
            this.btnYeniCalisan.Location = new System.Drawing.Point(15, 241);
            this.btnYeniCalisan.Name = "btnYeniCalisan";
            this.btnYeniCalisan.Size = new System.Drawing.Size(148, 36);
            this.btnYeniCalisan.TabIndex = 21;
            this.btnYeniCalisan.Text = "Yeni Çalışan Ekle";
            this.btnYeniCalisan.UseVisualStyleBackColor = true;
            this.btnYeniCalisan.Click += new System.EventHandler(this.btnYeniCalisan_Click);
            // 
            // lstboxCalisanlar
            // 
            this.lstboxCalisanlar.FormattingEnabled = true;
            this.lstboxCalisanlar.Location = new System.Drawing.Point(15, 23);
            this.lstboxCalisanlar.Name = "lstboxCalisanlar";
            this.lstboxCalisanlar.Size = new System.Drawing.Size(148, 212);
            this.lstboxCalisanlar.TabIndex = 0;
            this.lstboxCalisanlar.SelectedIndexChanged += new System.EventHandler(this.lstboxCalisanlar_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDepartmani);
            this.groupBox2.Controls.Add(this.cmbAnaDili);
            this.groupBox2.Controls.Add(this.numMaasi);
            this.groupBox2.Controls.Add(this.radioKadin);
            this.groupBox2.Controls.Add(this.radioErkek);
            this.groupBox2.Controls.Add(this.datetimeDogumTarihi);
            this.groupBox2.Controls.Add(this.txtTelefonu);
            this.groupBox2.Controls.Add(this.txtSoyadi);
            this.groupBox2.Controls.Add(this.txtAdi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(202, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalışan Detaylar :";
            // 
            // cmbDepartmani
            // 
            this.cmbDepartmani.FormattingEnabled = true;
            this.cmbDepartmani.Location = new System.Drawing.Point(102, 250);
            this.cmbDepartmani.Name = "cmbDepartmani";
            this.cmbDepartmani.Size = new System.Drawing.Size(148, 21);
            this.cmbDepartmani.TabIndex = 20;
            // 
            // cmbAnaDili
            // 
            this.cmbAnaDili.FormattingEnabled = true;
            this.cmbAnaDili.Location = new System.Drawing.Point(102, 122);
            this.cmbAnaDili.Name = "cmbAnaDili";
            this.cmbAnaDili.Size = new System.Drawing.Size(148, 21);
            this.cmbAnaDili.TabIndex = 20;
            // 
            // numMaasi
            // 
            this.numMaasi.Location = new System.Drawing.Point(102, 219);
            this.numMaasi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaasi.Name = "numMaasi";
            this.numMaasi.Size = new System.Drawing.Size(149, 21);
            this.numMaasi.TabIndex = 19;
            // 
            // radioKadin
            // 
            this.radioKadin.AutoSize = true;
            this.radioKadin.Location = new System.Drawing.Point(166, 155);
            this.radioKadin.Name = "radioKadin";
            this.radioKadin.Size = new System.Drawing.Size(57, 17);
            this.radioKadin.TabIndex = 18;
            this.radioKadin.TabStop = true;
            this.radioKadin.Text = "Kadın";
            this.radioKadin.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Location = new System.Drawing.Point(102, 155);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(58, 17);
            this.radioErkek.TabIndex = 18;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // datetimeDogumTarihi
            // 
            this.datetimeDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeDogumTarihi.Location = new System.Drawing.Point(102, 89);
            this.datetimeDogumTarihi.Name = "datetimeDogumTarihi";
            this.datetimeDogumTarihi.Size = new System.Drawing.Size(149, 21);
            this.datetimeDogumTarihi.TabIndex = 17;
            // 
            // txtTelefonu
            // 
            this.txtTelefonu.Location = new System.Drawing.Point(102, 186);
            this.txtTelefonu.Name = "txtTelefonu";
            this.txtTelefonu.Size = new System.Drawing.Size(149, 21);
            this.txtTelefonu.TabIndex = 16;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(102, 58);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(149, 21);
            this.txtSoyadi.TabIndex = 16;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(102, 26);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(149, 21);
            this.txtAdi.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Departmanı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maaşı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefonu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cinsiyeti :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ana Dili :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "D. Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adı :";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(496, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(249, 287);
            this.propertyGrid1.TabIndex = 2;
            // 
            // frmCalisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 312);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(763, 346);
            this.Name = "frmCalisanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışanlar";
            this.Load += new System.EventHandler(this.frmCalisanlar_Load);
            this.SizeChanged += new System.EventHandler(this.frmCalisanlar_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDepartmani;
        private System.Windows.Forms.ComboBox cmbAnaDili;
        private System.Windows.Forms.NumericUpDown numMaasi;
        private System.Windows.Forms.RadioButton radioKadin;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.DateTimePicker datetimeDogumTarihi;
        private System.Windows.Forms.TextBox txtTelefonu;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeniCalisan;
        public System.Windows.Forms.ListBox lstboxCalisanlar;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}
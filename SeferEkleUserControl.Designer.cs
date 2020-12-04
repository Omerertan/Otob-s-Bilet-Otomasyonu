namespace OtobüsFirma
{
    partial class SeferEkleUserControl
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOtobus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGuzergah = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBiletFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKaptan = new System.Windows.Forms.TextBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSaat = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label12.Location = new System.Drawing.Point(15, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 32);
            this.label12.TabIndex = 46;
            this.label12.Text = "Sefer Ekle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(56, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tarih";
            // 
            // comboBoxOtobus
            // 
            this.comboBoxOtobus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOtobus.FormattingEnabled = true;
            this.comboBoxOtobus.Items.AddRange(new object[] {
            "Mercedes - Benz Travego",
            "Setra S",
            "Temsa Safir"});
            this.comboBoxOtobus.Location = new System.Drawing.Point(130, 114);
            this.comboBoxOtobus.Name = "comboBoxOtobus";
            this.comboBoxOtobus.Size = new System.Drawing.Size(196, 28);
            this.comboBoxOtobus.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Otobüs";
            // 
            // comboBoxGuzergah
            // 
            this.comboBoxGuzergah.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxGuzergah.FormattingEnabled = true;
            this.comboBoxGuzergah.Items.AddRange(new object[] {
            "İstanbul - Kocaeli",
            "İstanbul - İzmir",
            "Kocaeli - İstanbul",
            "Kocaeli - İzmir",
            "İzmir - İstanbul",
            "İzmir - Kocaeli"});
            this.comboBoxGuzergah.Location = new System.Drawing.Point(130, 52);
            this.comboBoxGuzergah.Name = "comboBoxGuzergah";
            this.comboBoxGuzergah.Size = new System.Drawing.Size(196, 28);
            this.comboBoxGuzergah.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(352, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bilet Fiyatı";
            // 
            // textBoxBiletFiyat
            // 
            this.textBoxBiletFiyat.Location = new System.Drawing.Point(463, 174);
            this.textBoxBiletFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBiletFiyat.Name = "textBoxBiletFiyat";
            this.textBoxBiletFiyat.Size = new System.Drawing.Size(132, 23);
            this.textBoxBiletFiyat.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Güzergah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(387, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Plaka";
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Location = new System.Drawing.Point(463, 113);
            this.textBoxPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(132, 23);
            this.textBoxPlaka.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(370, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kaptan";
            // 
            // textBoxKaptan
            // 
            this.textBoxKaptan.Location = new System.Drawing.Point(463, 51);
            this.textBoxKaptan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKaptan.Name = "textBoxKaptan";
            this.textBoxKaptan.Size = new System.Drawing.Size(132, 23);
            this.textBoxKaptan.TabIndex = 25;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.CustomFormat = "";
            this.dateTimePickerTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTarih.Location = new System.Drawing.Point(126, 174);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTarih.TabIndex = 47;
            // 
            // dateTimePickerSaat
            // 
            this.dateTimePickerSaat.CustomFormat = "";
            this.dateTimePickerSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerSaat.Location = new System.Drawing.Point(126, 240);
            this.dateTimePickerSaat.Name = "dateTimePickerSaat";
            this.dateTimePickerSaat.ShowUpDown = true;
            this.dateTimePickerSaat.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerSaat.TabIndex = 48;
            // 
            // SeferEkleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerSaat);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxOtobus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGuzergah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBiletFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKaptan);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeferEkleUserControl";
            this.Size = new System.Drawing.Size(641, 353);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBoxOtobus;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxGuzergah;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxBiletFiyat;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxPlaka;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxKaptan;
        public System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        public System.Windows.Forms.DateTimePicker dateTimePickerSaat;
    }
}

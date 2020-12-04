namespace OtobüsFirma
{
    partial class BiletİslemleriUserControl
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
            this.listViewSeferListesi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewKoltukListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxKoltukDurum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYolcuSoyadı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYolcuAdı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewSeferListesi
            // 
            this.listViewSeferListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listViewSeferListesi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewSeferListesi.FullRowSelect = true;
            this.listViewSeferListesi.GridLines = true;
            this.listViewSeferListesi.HideSelection = false;
            this.listViewSeferListesi.Location = new System.Drawing.Point(13, 49);
            this.listViewSeferListesi.Name = "listViewSeferListesi";
            this.listViewSeferListesi.Size = new System.Drawing.Size(721, 129);
            this.listViewSeferListesi.TabIndex = 14;
            this.listViewSeferListesi.UseCompatibleStateImageBehavior = false;
            this.listViewSeferListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sefer No";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Güzergah";
            this.columnHeader5.Width = 145;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kaptan";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Otobüs";
            this.columnHeader12.Width = 176;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Plaka";
            this.columnHeader13.Width = 89;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Sefer Tarihi";
            this.columnHeader14.Width = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sefer Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(7, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Koltuk Listesi";
            // 
            // listViewKoltukListesi
            // 
            this.listViewKoltukListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewKoltukListesi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewKoltukListesi.FullRowSelect = true;
            this.listViewKoltukListesi.GridLines = true;
            this.listViewKoltukListesi.HideSelection = false;
            this.listViewKoltukListesi.Location = new System.Drawing.Point(13, 234);
            this.listViewKoltukListesi.Name = "listViewKoltukListesi";
            this.listViewKoltukListesi.Size = new System.Drawing.Size(721, 129);
            this.listViewKoltukListesi.TabIndex = 16;
            this.listViewKoltukListesi.UseCompatibleStateImageBehavior = false;
            this.listViewKoltukListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Koltuk No";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cinsiyeti";
            this.columnHeader7.Width = 107;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Koltuk Durumu";
            this.columnHeader8.Width = 136;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Bilet Fiyatı";
            this.columnHeader9.Width = 82;
            // 
            // comboBoxKoltukDurum
            // 
            this.comboBoxKoltukDurum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKoltukDurum.FormattingEnabled = true;
            this.comboBoxKoltukDurum.Items.AddRange(new object[] {
            "Satın Al",
            "Rezervasyon"});
            this.comboBoxKoltukDurum.Location = new System.Drawing.Point(753, 135);
            this.comboBoxKoltukDurum.Name = "comboBoxKoltukDurum";
            this.comboBoxKoltukDurum.Size = new System.Drawing.Size(132, 28);
            this.comboBoxKoltukDurum.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(749, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Koltuk Durumu";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(753, 52);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(132, 28);
            this.comboBoxCinsiyet.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(749, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Cinsiyeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(749, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Yolcu Soyadı";
            // 
            // textBoxYolcuSoyadı
            // 
            this.textBoxYolcuSoyadı.Location = new System.Drawing.Point(753, 299);
            this.textBoxYolcuSoyadı.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYolcuSoyadı.Name = "textBoxYolcuSoyadı";
            this.textBoxYolcuSoyadı.Size = new System.Drawing.Size(132, 27);
            this.textBoxYolcuSoyadı.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(749, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Yolcu Adı";
            // 
            // textBoxYolcuAdı
            // 
            this.textBoxYolcuAdı.Location = new System.Drawing.Point(753, 216);
            this.textBoxYolcuAdı.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYolcuAdı.Name = "textBoxYolcuAdı";
            this.textBoxYolcuAdı.Size = new System.Drawing.Size(132, 27);
            this.textBoxYolcuAdı.TabIndex = 47;
            // 
            // BiletİslemleriUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxKoltukDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYolcuSoyadı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxYolcuAdı);
            this.Controls.Add(this.listViewKoltukListesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewSeferListesi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BiletİslemleriUserControl";
            this.Size = new System.Drawing.Size(1014, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listViewSeferListesi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView listViewKoltukListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        public System.Windows.Forms.ComboBox comboBoxKoltukDurum;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxCinsiyet;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxYolcuSoyadı;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxYolcuAdı;
    }
}

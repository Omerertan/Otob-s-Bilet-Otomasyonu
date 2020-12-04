namespace OtobüsFirma
{
    partial class GecmisSeferUserControl
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
            this.listViewGecmisKoltuk = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listViewGecmisSefer = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerGecmisTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listViewGecmisKoltuk
            // 
            this.listViewGecmisKoltuk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewGecmisKoltuk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewGecmisKoltuk.FullRowSelect = true;
            this.listViewGecmisKoltuk.GridLines = true;
            this.listViewGecmisKoltuk.HideSelection = false;
            this.listViewGecmisKoltuk.Location = new System.Drawing.Point(21, 229);
            this.listViewGecmisKoltuk.Name = "listViewGecmisKoltuk";
            this.listViewGecmisKoltuk.Size = new System.Drawing.Size(721, 149);
            this.listViewGecmisKoltuk.TabIndex = 20;
            this.listViewGecmisKoltuk.UseCompatibleStateImageBehavior = false;
            this.listViewGecmisKoltuk.View = System.Windows.Forms.View.Details;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Koltuk Listesi";
            // 
            // listViewGecmisSefer
            // 
            this.listViewGecmisSefer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listViewGecmisSefer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewGecmisSefer.FullRowSelect = true;
            this.listViewGecmisSefer.GridLines = true;
            this.listViewGecmisSefer.HideSelection = false;
            this.listViewGecmisSefer.Location = new System.Drawing.Point(21, 44);
            this.listViewGecmisSefer.Name = "listViewGecmisSefer";
            this.listViewGecmisSefer.Size = new System.Drawing.Size(721, 129);
            this.listViewGecmisSefer.TabIndex = 18;
            this.listViewGecmisSefer.UseCompatibleStateImageBehavior = false;
            this.listViewGecmisSefer.View = System.Windows.Forms.View.Details;
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
            this.label1.Location = new System.Drawing.Point(15, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sefer Listesi";
            // 
            // dateTimePickerGecmisTarih
            // 
            this.dateTimePickerGecmisTarih.CustomFormat = "";
            this.dateTimePickerGecmisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGecmisTarih.Location = new System.Drawing.Point(542, 3);
            this.dateTimePickerGecmisTarih.Name = "dateTimePickerGecmisTarih";
            this.dateTimePickerGecmisTarih.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerGecmisTarih.TabIndex = 48;
            // 
            // GecmisSeferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerGecmisTarih);
            this.Controls.Add(this.listViewGecmisKoltuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewGecmisSefer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GecmisSeferUserControl";
            this.Size = new System.Drawing.Size(769, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listViewGecmisKoltuk;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView listViewGecmisSefer;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePickerGecmisTarih;
    }
}

namespace OtobüsFirma
{
    partial class SeferGelirUserControl
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
            this.listViewSeferGelir = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.labelSeferGelir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewSeferGelir
            // 
            this.listViewSeferGelir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listViewSeferGelir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewSeferGelir.FullRowSelect = true;
            this.listViewSeferGelir.GridLines = true;
            this.listViewSeferGelir.HideSelection = false;
            this.listViewSeferGelir.Location = new System.Drawing.Point(31, 67);
            this.listViewSeferGelir.Name = "listViewSeferGelir";
            this.listViewSeferGelir.Size = new System.Drawing.Size(721, 300);
            this.listViewSeferGelir.TabIndex = 13;
            this.listViewSeferGelir.UseCompatibleStateImageBehavior = false;
            this.listViewSeferGelir.View = System.Windows.Forms.View.Details;
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
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sefer Listesi";
            // 
            // labelSeferGelir
            // 
            this.labelSeferGelir.AutoSize = true;
            this.labelSeferGelir.Location = new System.Drawing.Point(349, 24);
            this.labelSeferGelir.Name = "labelSeferGelir";
            this.labelSeferGelir.Size = new System.Drawing.Size(57, 21);
            this.labelSeferGelir.TabIndex = 14;
            this.labelSeferGelir.Text = "label2";
            // 
            // SeferGelirUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSeferGelir);
            this.Controls.Add(this.listViewSeferGelir);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SeferGelirUserControl";
            this.Size = new System.Drawing.Size(816, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listViewSeferGelir;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelSeferGelir;
    }
}

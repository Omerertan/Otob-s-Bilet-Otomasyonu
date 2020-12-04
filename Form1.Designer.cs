namespace OtobüsFirma
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSeferMenuPanel = new System.Windows.Forms.Panel();
            this.buttonSeferGelir = new System.Windows.Forms.Button();
            this.buttonGecmisSefer = new System.Windows.Forms.Button();
            this.buttonSeferEkle = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonSeferIslemleri = new System.Windows.Forms.Button();
            this.buttonBiletİslemleri = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonListeSil = new System.Windows.Forms.Button();
            this.labelDeneme = new System.Windows.Forms.Label();
            this.buttonKaptanDegistir = new System.Windows.Forms.Button();
            this.buttonKoltukListele = new System.Windows.Forms.Button();
            this.buttonAl = new System.Windows.Forms.Button();
            this.buttonGecmisKoltukListele = new System.Windows.Forms.Button();
            this.buttonSatısİptal = new System.Windows.Forms.Button();
            this.buttonGelirHesapla = new System.Windows.Forms.Button();
            this.seferGelirUserControl1 = new OtobüsFirma.SeferGelirUserControl();
            this.gecmisSeferUserControl1 = new OtobüsFirma.GecmisSeferUserControl();
            this.biletİslemleriUserControl1 = new OtobüsFirma.BiletİslemleriUserControl();
            this.seferEkleUserControl1 = new OtobüsFirma.SeferEkleUserControl();
            this.seferİslemleriUserControl1 = new OtobüsFirma.SeferİslemleriUserControl();
            this.panelMenu.SuspendLayout();
            this.panelSeferMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.panelSeferMenuPanel);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.buttonSeferIslemleri);
            this.panelMenu.Controls.Add(this.buttonBiletİslemleri);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 507);
            this.panelMenu.TabIndex = 4;
            // 
            // panelSeferMenuPanel
            // 
            this.panelSeferMenuPanel.Controls.Add(this.buttonSeferGelir);
            this.panelSeferMenuPanel.Controls.Add(this.buttonGecmisSefer);
            this.panelSeferMenuPanel.Controls.Add(this.buttonSeferEkle);
            this.panelSeferMenuPanel.Location = new System.Drawing.Point(2, 280);
            this.panelSeferMenuPanel.Name = "panelSeferMenuPanel";
            this.panelSeferMenuPanel.Size = new System.Drawing.Size(208, 175);
            this.panelSeferMenuPanel.TabIndex = 4;
            // 
            // buttonSeferGelir
            // 
            this.buttonSeferGelir.FlatAppearance.BorderSize = 0;
            this.buttonSeferGelir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeferGelir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeferGelir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSeferGelir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeferGelir.Image")));
            this.buttonSeferGelir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeferGelir.Location = new System.Drawing.Point(2, 60);
            this.buttonSeferGelir.Name = "buttonSeferGelir";
            this.buttonSeferGelir.Size = new System.Drawing.Size(205, 50);
            this.buttonSeferGelir.TabIndex = 7;
            this.buttonSeferGelir.Text = "Gelir Hesaplama";
            this.buttonSeferGelir.UseVisualStyleBackColor = true;
            this.buttonSeferGelir.Click += new System.EventHandler(this.buttonSeferGelir_Click);
            // 
            // buttonGecmisSefer
            // 
            this.buttonGecmisSefer.FlatAppearance.BorderSize = 0;
            this.buttonGecmisSefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGecmisSefer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGecmisSefer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGecmisSefer.Image = ((System.Drawing.Image)(resources.GetObject("buttonGecmisSefer.Image")));
            this.buttonGecmisSefer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGecmisSefer.Location = new System.Drawing.Point(2, 117);
            this.buttonGecmisSefer.Name = "buttonGecmisSefer";
            this.buttonGecmisSefer.Size = new System.Drawing.Size(205, 50);
            this.buttonGecmisSefer.TabIndex = 6;
            this.buttonGecmisSefer.Text = "Geçmiş Seferler";
            this.buttonGecmisSefer.UseVisualStyleBackColor = true;
            this.buttonGecmisSefer.Click += new System.EventHandler(this.buttonGecmisSefer_Click);
            // 
            // buttonSeferEkle
            // 
            this.buttonSeferEkle.FlatAppearance.BorderSize = 0;
            this.buttonSeferEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeferEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeferEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSeferEkle.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeferEkle.Image")));
            this.buttonSeferEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeferEkle.Location = new System.Drawing.Point(1, 5);
            this.buttonSeferEkle.Name = "buttonSeferEkle";
            this.buttonSeferEkle.Size = new System.Drawing.Size(205, 50);
            this.buttonSeferEkle.TabIndex = 5;
            this.buttonSeferEkle.Text = "Sefer Ekle";
            this.buttonSeferEkle.UseVisualStyleBackColor = true;
            this.buttonSeferEkle.Click += new System.EventHandler(this.buttonSeferEkle_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(30, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(146, 149);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonSeferIslemleri
            // 
            this.buttonSeferIslemleri.FlatAppearance.BorderSize = 0;
            this.buttonSeferIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeferIslemleri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeferIslemleri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSeferIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeferIslemleri.Image")));
            this.buttonSeferIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeferIslemleri.Location = new System.Drawing.Point(4, 222);
            this.buttonSeferIslemleri.Name = "buttonSeferIslemleri";
            this.buttonSeferIslemleri.Size = new System.Drawing.Size(207, 50);
            this.buttonSeferIslemleri.TabIndex = 3;
            this.buttonSeferIslemleri.Text = "Sefer İşlemleri";
            this.buttonSeferIslemleri.UseVisualStyleBackColor = true;
            this.buttonSeferIslemleri.Click += new System.EventHandler(this.buttonSeferIslemleri_Click);
            // 
            // buttonBiletİslemleri
            // 
            this.buttonBiletİslemleri.FlatAppearance.BorderSize = 0;
            this.buttonBiletİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBiletİslemleri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBiletİslemleri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBiletİslemleri.Image = ((System.Drawing.Image)(resources.GetObject("buttonBiletİslemleri.Image")));
            this.buttonBiletİslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBiletİslemleri.Location = new System.Drawing.Point(5, 165);
            this.buttonBiletİslemleri.Name = "buttonBiletİslemleri";
            this.buttonBiletİslemleri.Size = new System.Drawing.Size(205, 50);
            this.buttonBiletİslemleri.TabIndex = 2;
            this.buttonBiletİslemleri.Text = "Bilet İşlemleri";
            this.buttonBiletİslemleri.UseVisualStyleBackColor = true;
            this.buttonBiletİslemleri.Click += new System.EventHandler(this.buttonBiletİslemleri_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1116, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 38);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Green;
            this.buttonEkle.FlatAppearance.BorderSize = 0;
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.Location = new System.Drawing.Point(722, 351);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(107, 33);
            this.buttonEkle.TabIndex = 37;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonListeSil
            // 
            this.buttonListeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonListeSil.FlatAppearance.BorderSize = 0;
            this.buttonListeSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListeSil.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonListeSil.ForeColor = System.Drawing.Color.White;
            this.buttonListeSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonListeSil.Location = new System.Drawing.Point(977, 439);
            this.buttonListeSil.Name = "buttonListeSil";
            this.buttonListeSil.Size = new System.Drawing.Size(114, 34);
            this.buttonListeSil.TabIndex = 38;
            this.buttonListeSil.Text = "Sil";
            this.buttonListeSil.UseVisualStyleBackColor = false;
            this.buttonListeSil.Click += new System.EventHandler(this.buttonListeSil_Click);
            // 
            // labelDeneme
            // 
            this.labelDeneme.AutoSize = true;
            this.labelDeneme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDeneme.Location = new System.Drawing.Point(495, 26);
            this.labelDeneme.Name = "labelDeneme";
            this.labelDeneme.Size = new System.Drawing.Size(77, 21);
            this.labelDeneme.TabIndex = 45;
            this.labelDeneme.Text = "Deneme";
            // 
            // buttonKaptanDegistir
            // 
            this.buttonKaptanDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(7)))));
            this.buttonKaptanDegistir.FlatAppearance.BorderSize = 0;
            this.buttonKaptanDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaptanDegistir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaptanDegistir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonKaptanDegistir.Location = new System.Drawing.Point(220, 225);
            this.buttonKaptanDegistir.Name = "buttonKaptanDegistir";
            this.buttonKaptanDegistir.Size = new System.Drawing.Size(138, 33);
            this.buttonKaptanDegistir.TabIndex = 46;
            this.buttonKaptanDegistir.Text = "Kaptan Değiştir";
            this.buttonKaptanDegistir.UseVisualStyleBackColor = false;
            this.buttonKaptanDegistir.Click += new System.EventHandler(this.buttonKaptanDegistir_Click);
            // 
            // buttonKoltukListele
            // 
            this.buttonKoltukListele.BackColor = System.Drawing.Color.Green;
            this.buttonKoltukListele.FlatAppearance.BorderSize = 0;
            this.buttonKoltukListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKoltukListele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKoltukListele.ForeColor = System.Drawing.Color.White;
            this.buttonKoltukListele.Location = new System.Drawing.Point(835, 269);
            this.buttonKoltukListele.Name = "buttonKoltukListele";
            this.buttonKoltukListele.Size = new System.Drawing.Size(120, 33);
            this.buttonKoltukListele.TabIndex = 48;
            this.buttonKoltukListele.Text = "Koltuk Listele";
            this.buttonKoltukListele.UseVisualStyleBackColor = false;
            this.buttonKoltukListele.Click += new System.EventHandler(this.buttonKoltukListele_Click);
            // 
            // buttonAl
            // 
            this.buttonAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(7)))));
            this.buttonAl.FlatAppearance.BorderSize = 0;
            this.buttonAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonAl.Location = new System.Drawing.Point(977, 439);
            this.buttonAl.Name = "buttonAl";
            this.buttonAl.Size = new System.Drawing.Size(130, 33);
            this.buttonAl.TabIndex = 50;
            this.buttonAl.Text = "Bilet Al";
            this.buttonAl.UseVisualStyleBackColor = false;
            this.buttonAl.Click += new System.EventHandler(this.buttonAl_Click);
            // 
            // buttonGecmisKoltukListele
            // 
            this.buttonGecmisKoltukListele.BackColor = System.Drawing.Color.Green;
            this.buttonGecmisKoltukListele.FlatAppearance.BorderSize = 0;
            this.buttonGecmisKoltukListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGecmisKoltukListele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGecmisKoltukListele.ForeColor = System.Drawing.Color.White;
            this.buttonGecmisKoltukListele.Location = new System.Drawing.Point(835, 255);
            this.buttonGecmisKoltukListele.Name = "buttonGecmisKoltukListele";
            this.buttonGecmisKoltukListele.Size = new System.Drawing.Size(130, 33);
            this.buttonGecmisKoltukListele.TabIndex = 52;
            this.buttonGecmisKoltukListele.Text = "Koltuk Listele";
            this.buttonGecmisKoltukListele.UseVisualStyleBackColor = false;
            this.buttonGecmisKoltukListele.Click += new System.EventHandler(this.buttonGecmisKoltukListele_Click);
            // 
            // buttonSatısİptal
            // 
            this.buttonSatısİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonSatısİptal.FlatAppearance.BorderSize = 0;
            this.buttonSatısİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSatısİptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSatısİptal.ForeColor = System.Drawing.Color.White;
            this.buttonSatısİptal.Location = new System.Drawing.Point(825, 455);
            this.buttonSatısİptal.Name = "buttonSatısİptal";
            this.buttonSatısİptal.Size = new System.Drawing.Size(130, 33);
            this.buttonSatısİptal.TabIndex = 53;
            this.buttonSatısİptal.Text = "Bileti İptal Et";
            this.buttonSatısİptal.UseVisualStyleBackColor = false;
            this.buttonSatısİptal.Click += new System.EventHandler(this.buttonSatısİptal_Click);
            // 
            // buttonGelirHesapla
            // 
            this.buttonGelirHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(7)))));
            this.buttonGelirHesapla.FlatAppearance.BorderSize = 0;
            this.buttonGelirHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGelirHesapla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGelirHesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonGelirHesapla.Location = new System.Drawing.Point(841, 439);
            this.buttonGelirHesapla.Name = "buttonGelirHesapla";
            this.buttonGelirHesapla.Size = new System.Drawing.Size(130, 33);
            this.buttonGelirHesapla.TabIndex = 55;
            this.buttonGelirHesapla.Text = "Gelir Hesapla";
            this.buttonGelirHesapla.UseVisualStyleBackColor = false;
            this.buttonGelirHesapla.Click += new System.EventHandler(this.buttonGelirHesapla_Click);
            // 
            // seferGelirUserControl1
            // 
            this.seferGelirUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.seferGelirUserControl1.Location = new System.Drawing.Point(222, 61);
            this.seferGelirUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.seferGelirUserControl1.Name = "seferGelirUserControl1";
            this.seferGelirUserControl1.Size = new System.Drawing.Size(816, 419);
            this.seferGelirUserControl1.TabIndex = 54;
            // 
            // gecmisSeferUserControl1
            // 
            this.gecmisSeferUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gecmisSeferUserControl1.Location = new System.Drawing.Point(222, 73);
            this.gecmisSeferUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gecmisSeferUserControl1.Name = "gecmisSeferUserControl1";
            this.gecmisSeferUserControl1.Size = new System.Drawing.Size(769, 400);
            this.gecmisSeferUserControl1.TabIndex = 51;
            // 
            // biletİslemleriUserControl1
            // 
            this.biletİslemleriUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.biletİslemleriUserControl1.Location = new System.Drawing.Point(222, 80);
            this.biletİslemleriUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.biletİslemleriUserControl1.Name = "biletİslemleriUserControl1";
            this.biletİslemleriUserControl1.Size = new System.Drawing.Size(930, 400);
            this.biletİslemleriUserControl1.TabIndex = 47;
            // 
            // seferEkleUserControl1
            // 
            this.seferEkleUserControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.seferEkleUserControl1.Location = new System.Drawing.Point(237, 73);
            this.seferEkleUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.seferEkleUserControl1.Name = "seferEkleUserControl1";
            this.seferEkleUserControl1.Size = new System.Drawing.Size(783, 400);
            this.seferEkleUserControl1.TabIndex = 7;
            // 
            // seferİslemleriUserControl1
            // 
            this.seferİslemleriUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.seferİslemleriUserControl1.Location = new System.Drawing.Point(237, 80);
            this.seferİslemleriUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.seferİslemleriUserControl1.Name = "seferİslemleriUserControl1";
            this.seferİslemleriUserControl1.Size = new System.Drawing.Size(885, 367);
            this.seferİslemleriUserControl1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 507);
            this.Controls.Add(this.buttonGelirHesapla);
            this.Controls.Add(this.seferGelirUserControl1);
            this.Controls.Add(this.buttonSatısİptal);
            this.Controls.Add(this.buttonGecmisKoltukListele);
            this.Controls.Add(this.gecmisSeferUserControl1);
            this.Controls.Add(this.buttonAl);
            this.Controls.Add(this.buttonKoltukListele);
            this.Controls.Add(this.biletİslemleriUserControl1);
            this.Controls.Add(this.buttonKaptanDegistir);
            this.Controls.Add(this.labelDeneme);
            this.Controls.Add(this.buttonListeSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.seferEkleUserControl1);
            this.Controls.Add(this.seferİslemleriUserControl1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelSeferMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSeferMenuPanel;
        private System.Windows.Forms.Button buttonGecmisSefer;
        private System.Windows.Forms.Button buttonSeferEkle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonSeferIslemleri;
        private System.Windows.Forms.Button buttonBiletİslemleri;
        private System.Windows.Forms.Button button2;
        private SeferİslemleriUserControl seferİslemleriUserControl1;
        private SeferEkleUserControl seferEkleUserControl1;
        public System.Windows.Forms.Button buttonEkle;
        public System.Windows.Forms.Button buttonListeSil;
        public System.Windows.Forms.Label labelDeneme;
        public System.Windows.Forms.Button buttonKaptanDegistir;
        private BiletİslemleriUserControl biletİslemleriUserControl1;
        public System.Windows.Forms.Button buttonKoltukListele;
        public System.Windows.Forms.Button buttonAl;
        private GecmisSeferUserControl gecmisSeferUserControl1;
        public System.Windows.Forms.Button buttonGecmisKoltukListele;
        public System.Windows.Forms.Button buttonSatısİptal;
        private System.Windows.Forms.Button buttonSeferGelir;
        private SeferGelirUserControl seferGelirUserControl1;
        public System.Windows.Forms.Button buttonGelirHesapla;
    }
}


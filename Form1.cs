using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobüsFirma
{
    public partial class Form1 : Form
    {
        /*
         Nested Linked list -> https://www.techiedelight.com/flatten-linked-list/
         Timer kullanımı -> https://www.codeproject.com/Questions/169892/display-a-form-for-a-period-of-time
         Streamwriter kullanımı -> https://www.hikmetokumus.com/makale/59/csharp-ile-streamwriter-dosya-yazma-islemleri
         Streamwriter autoflush kullanımı -> https://stackoverflow.com/questions/20448608/c-sharp-getting-empty-txt-while-using-streamwriter
         C# userControl tasarımı -> https://www.youtube.com/watch?v=nLfzH4xOVqo
         Diziyi split() işlemi -> https://www.yazilimbilisim.net/c-sharp/c-split-kullanimi/
         ListView kullanımı -> http://alkanfatih.com/listview-kullanimi-ve-ozellikleri/
         ListView seçili satır var mı kontrolü -> http://forum.csharpnedir.com/forum_posts.asp?TID=33235&title=c-listview-seili-satr-silme-nasl   
         Datetime birleştirme -> https://stackoverflow.com/questions/93472/datetimepicker-pick-both-date-and-time
        */

        // Tüm seferler seferlerim de  tutulur
        SeferList<Sefer> seferlerim = new SeferList<Sefer>();

        SeferList<Sefer> gecmisSeferlerim = new SeferList<Sefer>();

        public Form1()
        {

            InitializeComponent();

            customizeDesign();

            seferEkleUserControl1.Visible = false;
            seferİslemleriUserControl1.Visible = false;
            gecmisSeferUserControl1.Visible = false;
            seferGelirUserControl1.Visible = false;

            biletİslemleriUserControl1.Visible = false;

            // Alınan bileti iptal etme işini gerçekleştiren buton
            buttonSatısİptal.Visible = false;

            // Bilet İşlemleri sayfasında ki bilet alma butonu
            buttonAl.Visible = false;

            // Bilet işlemleri sayfasındaki koltuk listeleme butonu
            buttonKoltukListele.Visible = false;

            // Sefer Ekleme butonu, textbox da ki verileri listeye ekler
            buttonEkle.Visible = false;

            // Seferde ki seçilen seferi silme işini yapan button
            buttonListeSil.Visible = false;

            // Seferde ki seçilen seferin kaptan adını değiştiren button
            buttonKaptanDegistir.Visible = false;

            // Geçmiş seferlerde ki koltukları listeleyen button
            buttonGecmisKoltukListele.Visible = false;

            // Seferlerin gelirlerini hesaplayan button
            buttonGelirHesapla.Visible = false;
            

            //Program çalıştığında seferlerim listesindeki elemanlasrı ListView yazar.
            Listeleme();

            //Bilet işlemlerin de ki listeyi çalıştırı.
            SeferListeleme();

            // Gün bitmediyse seferlerim listesi dosyadan yüklenir            
            GunBitmedenSefer();
            
        }
        

        public StreamWriter Seferdosya /*= new StreamWriter(@"C:\Users\Omer\source\repos\OtobüsFirma\GecmisSeferler\" + $"{DateTime.Now.ToShortDateString() }" + ".txt")*/;

        public List<string> log = new List<string>();
        //public StringBuilder log = new StringBuilder(@"C:\Users\Omer\source\repos\OtobüsFirma\GecmisSeferler\log.txt", FileMode.Open);

        private void customizeDesign()
        {
            panelSeferMenuPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Log listesine yazdıklarımızı log dosyasına yazıyoruz
            File.AppendAllLines($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\log.txt", log, Encoding.GetEncoding("iso-8859-9"));

            // Dosya oluşturulmuşsa tekrar oluşturmaz
            if (!File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt"))
            {
                Seferdosya = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt");
            }

            //File.WriteAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt", String.Empty);

            bool dosya = File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt");

            // Eğer dosya yoksa dosya boşaltmayı yapmaz
            //if (!dosya)
            //{

            //}

            // Dosyayı ilk boşaltıyoruz
            File.WriteAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt", String.Empty);


            // Güncel Listeyi yazdırıyoruz
            DosyaSeferYaz();


            //Seferdosya.Close();
            this.Close();
        }

        private void buttonSeferIslemleri_Click(object sender, EventArgs e)
        {

            biletİslemleriUserControl1.Visible = false;
            buttonKoltukListele.Visible = false;
            buttonAl.Visible = false;
            buttonSatısİptal.Visible = false;

            buttonGecmisKoltukListele.Visible = false;
            gecmisSeferUserControl1.Visible = false;
            seferGelirUserControl1.Visible = false;
            buttonGelirHesapla.Visible = false;
            
            buttonEkle.Visible = false;

            buttonListeSil.Visible = true;
            buttonKaptanDegistir.Visible = true;

            // Listeyi açmadan önce en güncel halini yazıyoruz
            seferİslemleriUserControl1.listView2.Items.Clear();
            Listeleme();

            if (panelSeferMenuPanel.Visible == true)
            {
                panelSeferMenuPanel.Visible = false;
                seferİslemleriUserControl1.Visible = false;
                seferEkleUserControl1.Visible = false;

                buttonListeSil.Visible = false;
                buttonKaptanDegistir.Visible = false;
            }
            else
            {

                panelSeferMenuPanel.Visible = true;
                seferİslemleriUserControl1.Visible = true;
                seferEkleUserControl1.Visible = false;

                buttonListeSil.Visible = true;
                buttonKaptanDegistir.Visible = true;

                // yapılan işlemi log dosyasına yazdık.
                LogYaz("Seferler Listelendi");
                //Listeleme();
            }
        }

        private void buttonSeferEkle_Click(object sender, EventArgs e)
        {
            biletİslemleriUserControl1.Visible = false;
            buttonKoltukListele.Visible = false;
            buttonAl.Visible = false;
            buttonSatısİptal.Visible = false;

            seferİslemleriUserControl1.Visible = false;
            gecmisSeferUserControl1.Visible = false;
            seferGelirUserControl1.Visible = false;

            buttonGelirHesapla.Visible = false;
            buttonGecmisKoltukListele.Visible = false;
            buttonListeSil.Visible = false;
            buttonKaptanDegistir.Visible = false;

            buttonEkle.Visible = true;


            //Sefer Ekle butonuna tıklayınca ekleuser true ise false false ise true yapar 
            if (seferEkleUserControl1.Visible == true)
            {
                biletİslemleriUserControl1.Visible = false;
                buttonKoltukListele.Visible = false;
                buttonAl.Visible = false;

                seferEkleUserControl1.Visible = false;
                buttonEkle.Visible = false;
                // SeferEkle butonu tıklayınca ekleuser kapatılınca seferuser açılır
                seferİslemleriUserControl1.Visible = true;
                buttonListeSil.Visible = true;
                buttonKaptanDegistir.Visible = true;
            }
            else
            {
                biletİslemleriUserControl1.Visible = false;
                buttonKoltukListele.Visible = false;
                buttonAl.Visible = false;

                seferEkleUserControl1.Visible = true;
                buttonEkle.Visible = true;
            }
        }

        private void Listeleme()
        {
            //DateTime sefertarih;
            //sefertarih = new DateTime(2020, 3, 24, 12, 30, 0);

            //string guzergah = "Örnek";
            //string otobus_adi = "Örnek";
            //string kaptan = "Örnek";
            //string plaka = "Örnek";

            //seferlerim.SeferEkle(10, guzergah, otobus_adi, plaka, kaptan, sefertarih, 50);

            SeferList<Sefer>.SeferNode current = seferlerim.Shead;

            if (current == null)
            {
                // Shead boş ise çalışacak kısım
            }
            else
            {
                while (current != null)
                {
                    /* ---- ListView  yazdırma işi ---- */

                    ListViewItem lvi = new ListViewItem(current.sefer_n.ToString());
                    lvi.SubItems.Add(current.guzergah);
                    lvi.SubItems.Add(current.kaptan);
                    lvi.SubItems.Add(current.otobus_adi);
                    lvi.SubItems.Add(current.plaka);
                    lvi.SubItems.Add(current.seferTarih.ToString());

                    seferİslemleriUserControl1.listView2.Items.Add(lvi);

                    //Console.WriteLine("\n- Sefer " + current.sefer_n + " Güzergah: " + current.guzergah + " " + current.otobus_adi + " Plaka: " + current.plaka + " Kaptan : " + current.kaptan + " Sefer Saati: " + current.seferTarih + " " + current.seferTarih.DayOfWeek + "\n");
                    //k.KoltukYazdır(current.Khead);

                    current = current.next;
                }


            }

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            /* https://mustafabukulmez.com/2018/11/28/c-string-sayisal-deger-kontrolu/ */
            try
            {
                /* ---- Sefer listesine yeni sefer ekleme işini yapar ----- */

                DateTime sefertarih;
                int koltukSayi = 10;



                string guzergah = seferEkleUserControl1.comboBoxGuzergah.Text;
                string otobus = seferEkleUserControl1.comboBoxOtobus.Text;
                string kaptan = seferEkleUserControl1.textBoxKaptan.Text;
                string plaka = seferEkleUserControl1.textBoxPlaka.Text;
                string b = seferEkleUserControl1.textBoxBiletFiyat.Text;


                int biletFiyatı = Convert.ToInt32(b);


                //labelDeneme.Text = seferEkleUserControl1.dateTimePickerTarih.Value.Date.ToString();

                // İki ayrı DateTimePicker verilerini birleştirip sefertarih atıyoruz
                sefertarih = seferEkleUserControl1.dateTimePickerTarih.Value.Date + seferEkleUserControl1.dateTimePickerSaat.Value.TimeOfDay;

                switch (otobus)
                {
                    case "Mercedes - Benz Travego": koltukSayi = 10; break;
                    case "Setra S": koltukSayi = 16; break;
                    case "Temsa Safir": koltukSayi = 14; break;
                    default:
                        break;
                }

                // TextBox verilerini Listemize ekledik
                seferlerim.SeferEkle(koltukSayi, guzergah, otobus, plaka, kaptan, sefertarih, biletFiyatı);



                // Seferlerim listesine ekleme yaptıktan sonra ik defa listeyi yazdırmamak için listeyi temizliyoruz
                seferİslemleriUserControl1.listView2.Items.Clear();
                Listeleme();

                // yapılan işlemi log dosyasına yazdık.
                LogYaz("yeni sefer eklendi");

                biletİslemleriUserControl1.Visible = false;
                buttonKoltukListele.Visible = false;
                buttonAl.Visible = false;

                seferEkleUserControl1.Visible = false;
                buttonEkle.Visible = false;

                seferİslemleriUserControl1.Visible = true;
                buttonListeSil.Visible = true;
                buttonKaptanDegistir.Visible = true;


            }
            catch (Exception)
            {
                MessageBox.Show("Boş veya yanlış değer girdiniz");
            }
            

            
        }

        private int ElemanSayısı()
        {
            SeferList<Sefer>.SeferNode current = seferlerim.Shead;
            int i = 0;

            if (current == null)
            {
                // Listede eleman yok
            }
            else if(current != null)
            {
                while (current.next != null)
                {
                    current = current.next;
                    i++;
                }
            }

            return i;
        }

        private void buttonListeSil_Click(object sender, EventArgs e)
        {
            /* ----- Sefer listesinden sefer silme işini yapar ------ */

            // Listviewden satır seçilmediyse işlem yapmaz
            if (seferİslemleriUserControl1.listView2.SelectedIndices.Count > 0)
            {

                int seferSayisi = seferİslemleriUserControl1.listView2.Items.Count; // Listede kaç tane satır olduğunu alıyoruz

                string secilen = seferİslemleriUserControl1.listView2.SelectedItems[0].SubItems[0].Text; // Seçilen satırın sefer no değeri
                int s = int.Parse(secilen);

                SeferList<Sefer>.SeferNode seferNode = seferlerim.SeferBul(s);

                // Satılan Koltuk sayısını döndürür.
                int satılanKoltuk = KoltukDurum(seferNode.Khead);

                // Satılan koltuk olup olmamaasına göre işlem yapar
                if (satılanKoltuk != 0)
                {
                    MessageBox.Show("Satılan koltuk var sefer Silinemez");
                }
                else
                {

                    /* ----- Listeden SON sefer silince çalışan kısım ------ */
                    if (s == ElemanSayısı()) //Secili satır varmı yokmu kontrol ediliyor.
                    {
                        //Seçili satırın index i ni yakalayarak satırı sildik.
                        //seferİslemleriUserControl1.listView2.Items.RemoveAt(seferİslemleriUserControl1.listView2.SelectedItems[0].Index); 

                        //Sefer listesinde seçilen eleman son eleman ise sefer listesinden silinir
                        seferlerim.Sil(s);

                        seferİslemleriUserControl1.listView2.Items.Clear();
                        Listeleme();

                    }
                    /* ----- Listeden Herhangi bir sefer silince çalışan kısım ------ */
                    else
                    {
                        if (seferİslemleriUserControl1.listView2.SelectedIndices.Count > 0) //Secili satır varmı yokmu kontrol ediliyor.
                        {
                            //secilen = seferİslemleriUserControl1.listView2.SelectedItems[0].SubItems[0].Text;//Seçili satırın index i ni yakalayarak satırı sildik.

                            //s = int.Parse(secilen); 

                            seferlerim.Sil(s);

                            seferİslemleriUserControl1.listView2.Items.Clear();
                            Listeleme();
                        }
                    }

                    seferİslemleriUserControl1.listView2.Items.Clear();
                    Listeleme();

                    // Sefer silindiğinde koltuk listesini boşaltır
                    biletİslemleriUserControl1.listViewKoltukListesi.Items.Clear();

                    labelDeneme.Text = $"Seçilen Sefer no:{s} ListViewdeki sefer sayısı {seferSayisi - 1}";

                }



            }

                        
        }

        private void buttonKaptanDegistir_Click(object sender, EventArgs e)
        {
            /* ---- TextBox veri girilmediği sürece kaptan değiştirme işlemi yapmaz ----- */
            /* http://forum.csharpnedir.com/forum_posts.asp?TID=33235&title=c-listview-seili-satr-silme-nasl */

            string yeniKaptan;
            yeniKaptan = seferİslemleriUserControl1.textBoxKaptanDeğiş.Text;

            // Textbox boş ve listview seçilmezse işlem yapmaz
            if (yeniKaptan != "" && seferİslemleriUserControl1.listView2.SelectedIndices.Count > 0)
            {
                string secilen = seferİslemleriUserControl1.listView2.SelectedItems[0].SubItems[0].Text; // Seçilen satırın sefer no değeri
                int s = int.Parse(secilen);


                seferlerim.KaptanDegistirme(s, yeniKaptan);

                seferİslemleriUserControl1.listView2.Items.Clear();
                Listeleme();

                // yapılan işlemi log dosyasına yazdık.
                LogYaz($"{s} nolu seferin kaptanı {yeniKaptan} ile değiştirildi");
            }

        }

        private void buttonBiletİslemleri_Click(object sender, EventArgs e)
        {

            buttonKoltukListele.Visible = true;
            buttonAl.Visible = true;
            buttonSatısİptal.Visible = true;

            // Butona her tıklandığında bilet işlemlerin de ki sefer Listesi güncellenir
            biletİslemleriUserControl1.listViewSeferListesi.Items.Clear();
            SeferListeleme();

            buttonListeSil.Visible = false;
            buttonKaptanDegistir.Visible = false;
            buttonEkle.Visible = false;
            buttonGecmisKoltukListele.Visible = false;
            buttonGelirHesapla.Visible = false;
            
            seferGelirUserControl1.Visible = false;
            gecmisSeferUserControl1.Visible = false;
            seferEkleUserControl1.Visible = false;
            seferİslemleriUserControl1.Visible = false;
            panelSeferMenuPanel.Visible = false;

            if (biletİslemleriUserControl1.Visible == true)
            {
                biletİslemleriUserControl1.Visible = false;
                buttonKoltukListele.Visible = false;
                buttonAl.Visible = false;
                buttonSatısİptal.Visible = false;

                // yapılan işlemi log dosyasına yazdık.

                LogYaz("Bilet işlemleri sayfası kapatıldı");

                //seferEkleUserControl1.Visible = false;

                //buttonListeSil.Visible = false;
                //buttonKaptanDegistir.Visible = false;
            }
            else
            {
                biletİslemleriUserControl1.Visible = true;
                buttonKoltukListele.Visible = true;
                buttonAl.Visible = true;
                buttonSatısİptal.Visible = true;
                //seferEkleUserControl1.Visible = false;

                // yapılan işlemi log dosyasına yazdık.
                LogYaz("Bilet işlemleri sayfası açıldı");

                //buttonListeSil.Visible = true;
                //buttonKaptanDegistir.Visible = true;
                //Listeleme();
            }
        }

        private void SeferListeleme()
        {
            SeferList<Sefer>.SeferNode current = seferlerim.Shead;


            if (current == null)
            {
                // Shead boş ise çalışacak kısım
            }
            else
            {
                while (current != null)
                {
                    /* ---- ListView  yazdırma işi ---- */

                    ListViewItem seferlist = new ListViewItem(current.sefer_n.ToString());
                    seferlist.SubItems.Add(current.guzergah);
                    seferlist.SubItems.Add(current.kaptan);
                    seferlist.SubItems.Add(current.otobus_adi);
                    seferlist.SubItems.Add(current.plaka);
                    seferlist.SubItems.Add(current.seferTarih.ToString());

                    biletİslemleriUserControl1.listViewSeferListesi.Items.Add(seferlist);


                    current = current.next;
                }


            }

        }

        private void KoltukYazdırma(KoltukList<Sefer>.KoltukNode head)
        {
            // seferlerim listesinde ilgili seferin ilk koltuk node Seferlisteleme sınıfından alındı
            KoltukList<Sefer>.KoltukNode current = head;

            var Khead = seferlerim.Shead.Khead;

            if (Khead == null)
            {
                //Console.WriteLine("Khead boş");
            }
            while (current != null)
            {
                ListViewItem koltuklist = new ListViewItem(current.koltuk_n.ToString());
                koltuklist.SubItems.Add(current.yolcu_adi);
                koltuklist.SubItems.Add(current.yolcu_soyadi);
                koltuklist.SubItems.Add(current.cinsiyet);
                koltuklist.SubItems.Add(current.koltuk_durum);
                koltuklist.SubItems.Add(current.koltuk_fiyat.ToString());

                biletİslemleriUserControl1.listViewKoltukListesi.Items.Add(koltuklist);

                //Console.WriteLine("\t\t Koltuk no: " + current.koltuk_n + " -> " + " Yolcu Adı :" + current.yolcu_adi + " Soyadı : " + current.yolcu_soyadi + " Cinsiyeti: " + current.cinsiyet + " Durum : " + current.koltuk_durum + " Fiyati : " + current.koltuk_fiyat);

                current = current.next;
            }
        }

        private void buttonKoltukListele_Click(object sender, EventArgs e)
        {
            // Listeden sefer seçildiyse
            if (biletİslemleriUserControl1.listViewSeferListesi.SelectedIndices.Count > 0)
            {


                string secilen = biletİslemleriUserControl1.listViewSeferListesi.SelectedItems[0].SubItems[0].Text; // Seçilen satırın sefer no değeri
                int s = int.Parse(secilen);

                // Listviewden seçilen seferin node  bulma
                SeferList<Sefer>.SeferNode seferNode = seferlerim.SeferBul(s);

                biletİslemleriUserControl1.listViewKoltukListesi.Items.Clear();
                // Seçilen sefer İlk koltuk Node koltukyazdırmaya gönderiyoruz
                KoltukYazdırma(seferNode.Khead);

                // yapılan işlemi log dosyasına yazdık.                
                LogYaz($"{s} nolu seferin koltukları listelendi" );

                //biletİslemleriUserControl1.listViewSeferListesi.Items.Clear();
                //SeferListeleme();
            }


        }

        private void buttonAl_Click(object sender, EventArgs e)
        {
            string yAdı = biletİslemleriUserControl1.textBoxYolcuAdı.Text;
            string ySoyadı = biletİslemleriUserControl1.textBoxYolcuSoyadı.Text;
            string cinsiyet = biletİslemleriUserControl1.comboBoxCinsiyet.Text;
            string koltukDurum = biletİslemleriUserControl1.comboBoxKoltukDurum.Text;

            string secilenSefer = biletİslemleriUserControl1.listViewSeferListesi.SelectedItems[0].SubItems[0].Text; // Seçilen satırın sefer no değeri
            int seferNo = int.Parse(secilenSefer);

            string secilenKoltuk = biletİslemleriUserControl1.listViewKoltukListesi.SelectedItems[0].SubItems[0].Text; // Seçilen satırın koltuk no değeri
            int koltukNo = int.Parse(secilenKoltuk);

            SeferList<Sefer>.SeferNode Node =  seferlerim.SeferBul(seferNo);

            if (SatılanKoltuk(Node.Khead, koltukNo))
            {
                MessageBox.Show("Bilet Satılmış");
            }
            else
            {

                // SeferListesi Ve Koltuk Listesi seçildiyse
                if (biletİslemleriUserControl1.listViewSeferListesi.SelectedIndices.Count > 0 && biletİslemleriUserControl1.listViewKoltukListesi.SelectedIndices.Count > 0)
                {
                    secilenSefer = biletİslemleriUserControl1.listViewSeferListesi.SelectedItems[0].SubItems[0].Text; // Seçilen satırın sefer no değeri
                    seferNo = int.Parse(secilenSefer);

                    secilenKoltuk = biletİslemleriUserControl1.listViewKoltukListesi.SelectedItems[0].SubItems[0].Text; // Seçilen satırın koltuk no değeri
                    koltukNo = int.Parse(secilenKoltuk);

                    // Listede ilgili sefer ve koltuğa verileri atar
                    seferlerim.SeferSatis(seferNo, koltukNo, yAdı, ySoyadı, cinsiyet, koltukDurum);

                    SeferList<Sefer>.SeferNode seferNode = seferlerim.SeferBul(seferNo);

                    biletİslemleriUserControl1.listViewKoltukListesi.Items.Clear();
                    KoltukYazdırma(seferNode.Khead);

                    // yapılan işlemi log dosyasına yazdık.
                    LogYaz($"{koltukDurum} işlemi yapıldı");

                }


            }


        }

        private void buttonSatısİptal_Click(object sender, EventArgs e)
        {
            if (biletİslemleriUserControl1.listViewSeferListesi.SelectedIndices.Count > 0 && biletİslemleriUserControl1.listViewKoltukListesi.SelectedIndices.Count > 0)
            {
                // Hem sefer hem kotuk seçildiğinde çalışır

                string secilenSefer = biletİslemleriUserControl1.listViewSeferListesi.SelectedItems[0].SubItems[0].Text; // Seçilen satırın sefer no değeri
                int seferNo = int.Parse(secilenSefer);

                string secilenKoltuk = biletİslemleriUserControl1.listViewKoltukListesi.SelectedItems[0].SubItems[0].Text; // Seçilen satırın koltuk no değeri
                int koltukNo = int.Parse(secilenKoltuk);

                seferlerim.SatisIptal(seferNo, koltukNo);

                SeferList<Sefer>.SeferNode seferNode = seferlerim.SeferBul(seferNo);

                biletİslemleriUserControl1.listViewKoltukListesi.Items.Clear();
                KoltukYazdırma(seferNode.Khead);

                LogYaz($"{seferNo} nolu seferin {koltukNo} nolu koltuğun satışı iptal edildi.");
            }
        }

        // Gecmis seferleri Dosyadan okur listeye atar
        private void GecmisSeferler(DateTime tarih)
        {
            // Dosyadaki verileri gecmisSeferlerime atmadan önce listeyi boşaltıyoruz
            gecmisSeferlerim.Shead = null;

            string t = Convert.ToString(tarih.ToShortDateString());
            // Girilen tarih tipinde dosya varsa Seferleri listeler
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{t}" + ".txt"))
            {
                // GEçmiş seferler listesi
                SeferList<Sefer>.SeferNode current = gecmisSeferlerim.Shead;

                KoltukList<Sefer>.KoltukNode Khead = null;

                // Dosya konumunu al
                String filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{t}" + ".txt";

                // Txt dosyasın da ki verileri satır olarak lines adında listeye aktarır.
                List<string> lines = File.ReadAllLines(filepath).ToList();

                // Seferlistesinden sefer seçildiyse
                foreach (var line in lines)
                {


                    //her satırı virgüllerle bölüp ilgili sütun bilgisini seferListe atadık
                    string[] enteries = line.Split(',');

                    // sefer listesini yazdırırken başına yıldız koyduk
                    if (enteries[0] == "*")
                    {
                        //if (current != null)
                        //{
                        //    current.Khead = Khead;
                        //    Khead = null;
                        //}


                        SeferList<Sefer>.SeferNode newNode = new SeferList<Sefer>.SeferNode();

                        newNode.sefer_n = Convert.ToInt32(enteries[1]);
                        newNode.guzergah = enteries[2];
                        newNode.otobus_adi = enteries[4];
                        newNode.plaka = enteries[5];
                        newNode.kaptan = enteries[3];
                        newNode.seferTarih = DateTime.Parse(enteries[6]);

                        newNode.Khead = GecmisKoltuklar(newNode.sefer_n, newNode, tarih);


                        // seferlerim de hiç sefer yoksa 
                        if (current == null)
                        {

                            //newNode.next = null;

                            //newNode.Khead = k.KoltukEkle(koltukSayi, Koltukfiyat);

                            gecmisSeferlerim.Shead = newNode;
                            current = gecmisSeferlerim.Shead;
                        }
                        else if (current != null)
                        {

                            while (current.next != null)
                            {
                                current = current.next;
                            }

                            //newNode.Khead = k.KoltukEkle(koltukSayi, Koltukfiyat);

                            current.next = newNode;

                        }

                        // Her seferi yazdırma işleminden sonra listeleme yapar
                        //Listeleme();

                        // Bilet sayfasındaki listeyi de güncelledik
                        //SeferListeleme();

                    }

                    // Satır koltuk bilgilerini içeriyorsa
                    //else if (enteries[0] != "*")
                    //{

                    //}



                }



            }

        }

        // Gecmis seferlerlerde ki koltukları dosyadan okuyarak ekler 
        private KoltukList<Sefer>.KoltukNode GecmisKoltuklar(int seferNo, SeferList<Sefer>.SeferNode newNode, DateTime tarih)
        {
            string t = Convert.ToString(tarih.ToShortDateString());

            KoltukList<Sefer>.KoltukNode Khead = null;

            // Hem sefer hem koltuk seçildiyse çalışır
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{t}" + ".txt"))
            {

                KoltukList<Sefer>.KoltukNode current = Khead;

                String filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{t}" + ".txt";

                // Txt dosyasın da ki verileri satır olarak lines adında listeye aktarır.
                List<string> lines = File.ReadAllLines(filepath).ToList();

                foreach (var line in lines)
                {


                    //her satırı virgüllerle bölüp ilgili sütun bilgisini seferListe atadık
                    string[] enteries = line.Split(',');

                    // Vİrgüle olan ilk kısım * ise sefer olduğundan o satırı almıyoruz

                    if (enteries[0] != "*" && enteries[0] == seferNo.ToString())
                    {
                        KoltukList<Sefer>.KoltukNode KnewNode = new KoltukList<Sefer>.KoltukNode();


                        KnewNode.koltuk_n = Convert.ToInt32(enteries[1]);
                        KnewNode.yolcu_adi = enteries[3].ToString();
                        KnewNode.yolcu_soyadi = enteries[4].ToString();
                        KnewNode.cinsiyet = enteries[5].ToString();
                        KnewNode.koltuk_durum = enteries[6].ToString();
                        KnewNode.koltuk_fiyat = Convert.ToInt32(enteries[2]);

                        // 1 numaralı koltuksa
                        if (Khead == null)
                        {
                            // Koltuk no 1 ise ilk node newNode olur
                            Khead = KnewNode;
                            current = Khead;
                        }
                        else if (current != null)
                        {

                            while (current.next != null)
                            {
                                current = current.next;
                            }

                            current.next = KnewNode;
                            current = current.next;
                        }

                    }



                }


            }


            return Khead;
        }

        private void buttonGecmisSefer_Click(object sender, EventArgs e)
        {
            biletİslemleriUserControl1.Visible = false;
            buttonKoltukListele.Visible = false;
            buttonAl.Visible = false;
            buttonSatısİptal.Visible = false;
            buttonKaptanDegistir.Visible = false;

            
            seferEkleUserControl1.Visible = false;
            seferİslemleriUserControl1.Visible = false;
            seferGelirUserControl1.Visible = false;
            buttonEkle.Visible = false;
            buttonListeSil.Visible = false;
            buttonGelirHesapla.Visible = false;

            if (gecmisSeferUserControl1.Visible == true)
            {
                gecmisSeferUserControl1.Visible = false;
                buttonGecmisKoltukListele.Visible = false;
                
            }
            else
            {
                buttonGecmisKoltukListele.Visible = true;
                gecmisSeferUserControl1.Visible = true;

                LogYaz("Geçmiş seferler listelendi");
            }

            gecmisSeferUserControl1.listViewGecmisSefer.Items.Clear();
            gecmisSeferUserControl1.listViewGecmisKoltuk.Items.Clear();

            //String filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\GecmisSeferler.txt";

            //// Txt dosyasın da ki verileri satır olarak lines adında listeye aktarır.
            //List<string> lines = File.ReadAllLines(filepath).ToList();

            //foreach (var line in lines)
            //{
            //    //her satırı virgüllerle bölüp ilgili sütun bilgisini seferListe atadık
            //    string[] enteries = line.Split(',');

            //    // sefer listesini yazdırırken başına yıldız koyduk
            //    if (enteries[0] == "*")
            //    {
            //        ListViewItem seferlist = new ListViewItem(enteries[1]);
            //        seferlist.SubItems.Add(enteries[2]);
            //        seferlist.SubItems.Add(enteries[5]);
            //        seferlist.SubItems.Add(enteries[4]);
            //        seferlist.SubItems.Add(enteries[3]);
            //        seferlist.SubItems.Add(enteries[6]);

            //        // Listeyi tabloya yazdırdık
            //        gecmisSeferUserControl1.listViewGecmisSefer.Items.Add(seferlist);
            //    }

            //}

        }

        private void buttonGecmisKoltukListele_Click(object sender, EventArgs e)
        {
            

            DateTime tarih = gecmisSeferUserControl1.dateTimePickerGecmisTarih.Value;
            GecmisSeferler(tarih);

            string t = Convert.ToString(tarih.ToShortDateString());

            labelDeneme.Text = Convert.ToString(tarih.ToShortDateString());

            SeferList<Sefer>.SeferNode current = gecmisSeferlerim.Shead;

            // İşlem yapılan günün verilerini önler
            if (t != Convert.ToString(DateTime.Now.ToShortDateString()))
            {
                
                // Tarih varsa seferleri listview yazdırır
                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{t}" + ".txt") && gecmisSeferUserControl1.listViewGecmisSefer.SelectedIndices.Count <= 0)
                {
                    // ListView tekrar tekrar yazdırmamak için listview temizliyoruz
                    gecmisSeferUserControl1.listViewGecmisSefer.Items.Clear();
                    gecmisSeferUserControl1.listViewGecmisKoltuk.Items.Clear();

                    if (current == null)
                    {
                        // Shead boş ise çalışacak kısım
                    }
                    else
                    {
                        while (current != null)
                        {
                            /* ---- ListView  yazdırma işi ---- */

                            ListViewItem seferlist = new ListViewItem(current.sefer_n.ToString());
                            seferlist.SubItems.Add(current.guzergah);
                            seferlist.SubItems.Add(current.kaptan);
                            seferlist.SubItems.Add(current.otobus_adi);
                            seferlist.SubItems.Add(current.plaka);
                            seferlist.SubItems.Add(current.seferTarih.ToString());

                            gecmisSeferUserControl1.listViewGecmisSefer.Items.Add(seferlist);


                            current = current.next;
                        }


                    }


                }
                // Tarih ve sefer no varsa listview yazdırır.
                else if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{t}" + ".txt") && gecmisSeferUserControl1.listViewGecmisSefer.SelectedIndices.Count > 0)
                {
                    gecmisSeferUserControl1.listViewGecmisKoltuk.Items.Clear();


                    string secilen = gecmisSeferUserControl1.listViewGecmisSefer.SelectedItems[0].SubItems[0].Text; // Seçilen satırın sefer no değeri
                    int s = int.Parse(secilen);

                    // Listviewden seçilen seferin node  bulma
                    SeferList<Sefer>.SeferNode seferNode = gecmisSeferlerim.SeferBul(s);

                    //gecmisSeferUserControl1.listViewGecmisKoltuk.Items.Clear();

                    // Seçilen sefer İlk koltuk Node
                    KoltukList<Sefer>.KoltukNode head = seferNode.Khead;

                    KoltukList<Sefer>.KoltukNode kcurrent = head;

                    var Khead = gecmisSeferlerim.Shead.Khead;

                    if (Khead == null)
                    {
                        //Console.WriteLine("Khead boş");
                    }
                    while (kcurrent != null)
                    {
                        ListViewItem koltuklist = new ListViewItem(kcurrent.koltuk_n.ToString());
                        koltuklist.SubItems.Add(kcurrent.yolcu_adi);
                        koltuklist.SubItems.Add(kcurrent.yolcu_soyadi);
                        koltuklist.SubItems.Add(kcurrent.cinsiyet);
                        koltuklist.SubItems.Add(kcurrent.koltuk_durum);
                        koltuklist.SubItems.Add(kcurrent.koltuk_fiyat.ToString());

                        gecmisSeferUserControl1.listViewGecmisKoltuk.Items.Add(koltuklist);

                        //Console.WriteLine("\t\t Koltuk no: " + current.koltuk_n + " -> " + " Yolcu Adı :" + current.yolcu_adi + " Soyadı : " + current.yolcu_soyadi + " Cinsiyeti: " + current.cinsiyet + " Durum : " + current.koltuk_durum + " Fiyati : " + current.koltuk_fiyat);

                        kcurrent = kcurrent.next;
                    }




                    // yapılan işlemi log dosyasına yazdık.                
                    LogYaz($"{s} nolu seferin koltukları listelendi");

                    //biletİslemleriUserControl1.listViewSeferListesi.Items.Clear();
                    //SeferListeleme();

                }
                else
                {
                    gecmisSeferUserControl1.listViewGecmisSefer.Items.Clear();
                    gecmisSeferUserControl1.listViewGecmisKoltuk.Items.Clear();
                }
                
            }

        }
        
        // Gün bitiminde seferleri txt dosyasına yazar. 
        private void DosyaSeferYaz()
        {
            SeferList<Sefer>.SeferNode current = seferlerim.Shead;
            
            if (current == null)
            {
                // Shead boş ise çalışacak kısım
            }
            else
            {
                while (current != null)
                {
                    string a = $"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString()}" + ".txt";
                    /* ----Seferleri Dosyaya  yazdırma işi ---- */

                    File.AppendAllText(a,"*"+",");
                    File.AppendAllText(a,$"{current.sefer_n}" + ",");
                    File.AppendAllText(a,$"{current.guzergah}" + ",");
                    File.AppendAllText(a,$"{current.kaptan}" + ",");
                    File.AppendAllText(a,$"{current.otobus_adi}" + ",");
                    File.AppendAllText(a,$"{current.plaka}" + ",");
                    File.AppendAllText(a,$"{current.seferTarih} \n");
                   
                    SeferList<Sefer>.SeferNode seferNode = seferlerim.SeferBul(current.sefer_n);

                    // Seferİn koltuk listesini gönderiyoruz
                    DosyaKoltukYaz(seferNode.Khead, current.sefer_n);

                    current = current.next;
                }


            }

        }

        // Koltuk listesi ve sefer no bilgisiyle birlikte dosyaya yazıldı
        private void DosyaKoltukYaz(KoltukList<Sefer>.KoltukNode head, int seferNo)
        {
            string a = $"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt";

            KoltukList<Sefer>.KoltukNode current = head;

            var Khead = seferlerim.Shead.Khead;

            if (Khead == null)
            {
                //Console.WriteLine("Khead boş");
            }
            while (current != null)
            {
                File.AppendAllText(a,$"{seferNo}" + ",");
                File.AppendAllText(a,$"{current.koltuk_n}" + ",");
                File.AppendAllText(a,$"{current.koltuk_fiyat}" + ",");
                File.AppendAllText(a,$"{current.yolcu_adi}" + ",");
                File.AppendAllText(a,$"{current.yolcu_soyadi}" + ",");
                File.AppendAllText(a,$"{current.cinsiyet}" + ",");
                File.AppendAllText(a,$"{current.koltuk_durum}" + "\n");

                current = current.next;
            }

            
        }

        private void LogYaz(string islem)
        {
            string tarih = DateTime.Now.ToString() + " - " + islem;
            log.Add(tarih);
            
        }
        
        private int KoltukDurum(KoltukList<Sefer>.KoltukNode head)
        {
            /* http://www.gorselprogramlama.com/string%E2%80%99deki-yazidaki-bosluklari-atma-c-net-ders-34/ */

            int satılan = 0;
            //int koltukFiyatı = 1;

            KoltukList<Sefer>.KoltukNode current = head;

            //var Khead = seferlerim.Shead.Khead;

            if (seferlerim == null)
            {
                // Koltuk Listesi boşsa
            }
            else
            {
                while (current != null)
                {
                    // koltuk durumunun başında ve sonunda boşluk varsa silme yapıp karşılaştırırız
                    if (current.koltuk_durum.Trim() == "Satın Al")
                    {
                        satılan++;
                    }

                    current = current.next;
                }
            }
            return satılan;
        }

        private bool SatılanKoltuk(KoltukList<Sefer>.KoltukNode head, int koltukNo)
        {
            /* http://www.gorselprogramlama.com/string%E2%80%99deki-yazidaki-bosluklari-atma-c-net-ders-34/ */

            //bool durum = false;
            //int koltukFiyatı = 1;

            KoltukList<Sefer>.KoltukNode current = head;

            //var Khead = seferlerim.Shead.Khead;

            if (seferlerim == null)
            {
                // Koltuk Listesi boşsa
            }
            else
            {
                while (current != null)
                {
                    // koltuk durumunun başında ve sonunda boşluk varsa silme yapıp karşılaştırırız
                    if (current.koltuk_durum.Trim() == "Satın Al" && current.koltuk_n == koltukNo)
                    {
                        //durum = true;
                        return true;
                    }

                    current = current.next;
                }
            }

            return false;
        }

        private void GelirListele()
        {

            // SeferGelir listview seferlerim de bulunan seferleri listeler.
            SeferList<Sefer>.SeferNode current = seferlerim.Shead;

            if (current == null)
            {
                // Shead boş ise çalışacak kısım
            }
            else
            {
                while (current != null)
                {
                    /* ---- ListView  yazdırma işi ---- */

                    ListViewItem lvi = new ListViewItem(current.sefer_n.ToString());
                    lvi.SubItems.Add(current.guzergah);
                    lvi.SubItems.Add(current.kaptan);
                    lvi.SubItems.Add(current.otobus_adi);
                    lvi.SubItems.Add(current.plaka);
                    lvi.SubItems.Add(current.seferTarih.ToString());

                    seferGelirUserControl1.listViewSeferGelir.Items.Add(lvi);

                    //Console.WriteLine("\n- Sefer " + current.sefer_n + " Güzergah: " + current.guzergah + " " + current.otobus_adi + " Plaka: " + current.plaka + " Kaptan : " + current.kaptan + " Sefer Saati: " + current.seferTarih + " " + current.seferTarih.DayOfWeek + "\n");
                    //k.KoltukYazdır(current.Khead);

                    current = current.next;
                }


            }
        }

        private void buttonSeferGelir_Click(object sender, EventArgs e)
        {

            biletİslemleriUserControl1.Visible = false;
            buttonKoltukListele.Visible = false;
            buttonAl.Visible = false;
            buttonSatısİptal.Visible = false;
            buttonKaptanDegistir.Visible = false;
            buttonGecmisKoltukListele.Visible = false;

            gecmisSeferUserControl1.Visible = false;
            seferEkleUserControl1.Visible = false;
            seferİslemleriUserControl1.Visible = false;
            buttonEkle.Visible = false;
            buttonListeSil.Visible = false;

            buttonGelirHesapla.Visible = true;

            if (seferGelirUserControl1.Visible == true)
            {
                seferGelirUserControl1.Visible = false;
                buttonGelirHesapla.Visible = false;

            }
            else
            {
                seferGelirUserControl1.Visible = true;
                buttonGelirHesapla.Visible = true;
            }

            seferGelirUserControl1.listViewSeferGelir.Items.Clear();
            GelirListele();
        }

        private void buttonGelirHesapla_Click(object sender, EventArgs e)
        {
                       
            // Sefer seçildiyse işlem gerçekleşir
            if (seferGelirUserControl1.listViewSeferGelir.SelectedIndices.Count > 0)
            {
                string secilenSefer = seferGelirUserControl1.listViewSeferGelir.SelectedItems[0].SubItems[0].Text; // Seçilen satırın sefer no değeri
                int seferNo = int.Parse(secilenSefer);

                //Listviewden seçilen seferin node  bulma
                SeferList<Sefer>.SeferNode seferNode = seferlerim.SeferBul(seferNo);

                // Satılan Koltuk sayısını döndürür.
                int satılanKoltuk = KoltukDurum(seferNode.Khead);

                int bilet = seferNode.Khead.koltuk_fiyat;
                

                seferGelirUserControl1.labelSeferGelir.Text = $"{seferNo}'nolu seferin geliri {bilet * satılanKoltuk} ";

                LogYaz($"{seferNo}nolu seferin geliri hesaplandı");
            }
        }

        // Dosyadan okuyup seferlerim listesine işler
        private void GunBitmedenSefer()
        {
            
            // O gün tarihli dosya varsa 
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt"))            
            {
                SeferList<Sefer>.SeferNode current = seferlerim.Shead;

                KoltukList<Sefer>.KoltukNode Khead = null ;

                String filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt";

                // Txt dosyasın da ki verileri satır olarak lines adında listeye aktarır.
                List<string> lines = File.ReadAllLines(filepath).ToList();

                foreach (var line in lines)
                {
                    

                    //her satırı virgüllerle bölüp ilgili sütun bilgisini seferListe atadık
                    string[] enteries = line.Split(',');

                    // sefer listesini yazdırırken başına yıldız koyduk
                    if (enteries[0] == "*")
                    {
                        //if (current != null)
                        //{
                        //    current.Khead = Khead;
                        //    Khead = null;
                        //}
                        

                        SeferList<Sefer>.SeferNode newNode = new SeferList<Sefer>.SeferNode();

                        newNode.sefer_n = Convert.ToInt32(enteries[1]);
                        newNode.guzergah = enteries[2];
                        newNode.otobus_adi = enteries[4];
                        newNode.plaka = enteries[5];
                        newNode.kaptan = enteries[3];
                        newNode.seferTarih = DateTime.Parse(enteries[6]);

                        newNode.Khead = GunBitmedenKoltuk(newNode.sefer_n, newNode);


                        // seferlerim de hiç sefer yoksa 
                        if (current == null)
                        {              
                            
                            //newNode.next = null;

                            //newNode.Khead = k.KoltukEkle(koltukSayi, Koltukfiyat);

                            seferlerim.Shead = newNode;
                            current = seferlerim.Shead;
                        }
                        else if (current != null)
                        {

                            while (current.next != null)
                            {
                                current = current.next;
                            }

                            //newNode.Khead = k.KoltukEkle(koltukSayi, Koltukfiyat);

                            current.next = newNode;

                        }

                        // Her seferi yazdırma işleminden sonra listeleme yapar
                        Listeleme();

                        // Bilet sayfasındaki listeyi de güncelledik
                        SeferListeleme();
                        
                    }

                    // Satır koltuk bilgilerini içeriyorsa
                    //else if (enteries[0] != "*")
                    //{
                        
                    //}
                    


                }


                
            }
        }

        private KoltukList<Sefer>.KoltukNode GunBitmedenKoltuk(int seferNo, SeferList<Sefer>.SeferNode newNode)
        {
            // Koltuk listesi ilk node 
            KoltukList<Sefer>.KoltukNode Khead = null;

            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt"))
            {
                
                KoltukList<Sefer>.KoltukNode current = Khead;

                String filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\GecmisSeferler\\" + $"{DateTime.Now.ToShortDateString() }" + ".txt";

                // Txt dosyasın da ki verileri satır olarak lines adında listeye aktarır.
                List<string> lines = File.ReadAllLines(filepath).ToList();

                foreach (var line in lines)
                {
                   

                    //her satırı virgüllerle bölüp ilgili sütun bilgisini seferListe atadık
                    string[] enteries = line.Split(',');

                    // Vİrgüle olan ilk kısım * ise sefer olduğundan o satırı almıyoruz

                    if (enteries[0] != "*" && enteries[0] == seferNo.ToString())
                    {
                        KoltukList<Sefer>.KoltukNode KnewNode = new KoltukList<Sefer>.KoltukNode();


                        KnewNode.koltuk_n = Convert.ToInt32(enteries[1]);
                        KnewNode.yolcu_adi = enteries[3].ToString();
                        KnewNode.yolcu_soyadi = enteries[4].ToString();
                        KnewNode.cinsiyet = enteries[5].ToString();
                        KnewNode.koltuk_durum = enteries[6].ToString();
                        KnewNode.koltuk_fiyat = Convert.ToInt32(enteries[2]);

                        // 1 numaralı koltuksa
                        if (Khead == null)
                        {
                            // Koltuk no 1 ise ilk node newNode olur
                            Khead = KnewNode;
                            current = Khead;
                        }
                        else if (current != null)
                        {

                            while (current.next != null)
                            {
                                current = current.next;
                            }

                            current.next = KnewNode;
                            current = current.next;
                        }

                    }



                }


            }

            
            return Khead;
        }

    }
}


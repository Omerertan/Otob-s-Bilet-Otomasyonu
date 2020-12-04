using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobüsFirma
{
    public class SeferList<T>
    {

        public class SeferNode
        {
            public int sefer_n;
            public string guzergah;
            public string plaka;
            public string otobus_adi;
            public string kaptan;
            public DateTime seferTarih;
            public SeferNode next;
            public KoltukList<T>.KoltukNode Khead;
        }

        public  SeferNode Shead = null;
        public int sonsefer;

        // Sefer listesinin sonuna sefer ekler.
        public void SeferEkle(int koltukSayi, string guzergah, string otobus_adi, string plaka, string kaptan, DateTime tarih, int Koltukfiyat)
        {
            KoltukList<T> k = new KoltukList<T>();
            SeferNode current = Shead;
            SeferNode newNode = new SeferNode();

            int sonsefer = 1;
            if (current == null)
            {
                newNode.sefer_n = 1;
                newNode.guzergah = guzergah;
                newNode.otobus_adi = otobus_adi;
                newNode.plaka = plaka;
                newNode.kaptan = kaptan;
                newNode.seferTarih = tarih;
                //newNode.next = null;

                Console.Write("\n- Sefer " + newNode.sefer_n + " Güzergah: " + newNode.guzergah + " " + newNode.otobus_adi + " Plaka: " + newNode.plaka + " Kaptan: " + newNode.kaptan + " Sefer Saati: " + newNode.seferTarih + " " + newNode.seferTarih.DayOfWeek + " \n");
                newNode.Khead = k.KoltukEkle(koltukSayi, Koltukfiyat);
                //newNode.Khead.KoltukEkle(koltukSayi);
                //for (int i = 1; i <= koltukSayi; i++)
                //{
                //    // Koltuk sayısı kadar koltuk ekliyoruz
                //    newNode.koltuklar.KoltukEkle(i);
                //}

                Shead = newNode;
            }
            else if (current != null)
            {
                sonsefer = 2;
                while (current.next != null)
                {
                    current = current.next;
                    sonsefer++;
                }

                newNode.sefer_n = sonsefer;
                newNode.guzergah = guzergah;
                newNode.otobus_adi = otobus_adi;
                newNode.plaka = plaka;
                newNode.kaptan = kaptan;
                newNode.seferTarih = tarih;
                Console.Write("\n- Sefer " + newNode.sefer_n + " Güzergah: " + newNode.guzergah + " " + newNode.otobus_adi + " Plaka: " + newNode.plaka + " Kaptan: " + newNode.kaptan + " Sefer Saati: " + newNode.seferTarih + " " + newNode.seferTarih.DayOfWeek + "\n");


                newNode.Khead = k.KoltukEkle(koltukSayi, Koltukfiyat);

                //for (int i = 1; i <= koltukSayi; i++)
                //{
                //    // Koltuk sayısı kadar koltuk ekliyoruz
                //    newNode.koltuklar.KoltukEkle(i);
                //}

                // YEni node liste sonuna ekliyoruz
                current.next = newNode;

            }

        }

        public SeferNode SeferBul(int seferNo)
        {
            SeferNode current = Shead;
            SeferNode aranan = new SeferNode();

            while (current != null)
            {
                if (current.sefer_n == seferNo)
                {
                    aranan.sefer_n = current.sefer_n;
                    aranan.guzergah = current.guzergah;
                    aranan.otobus_adi = current.otobus_adi;
                    aranan.plaka = current.plaka;
                    aranan.kaptan = current.kaptan;
                    aranan.seferTarih = current.seferTarih;
                    aranan.next = current.next;
                    aranan.Khead = current.Khead;

                    return aranan;
                    //Console.WriteLine($"Arana Node: {aranan.sefer_n} {aranan.plaka} {aranan.seferTarih}  Next Node: {aranan.next.sefer_n} {aranan.next.plaka}\n");


                }

                current = current.next;
            }

            //if (current.next == null)
            //{

            //}

            return new SeferNode();
        }

        public void SeferSatis(int seferNo, int satılanKoltuk, string yAdi, string ySoyad, string cinsiyet, string durum)
        {
            SeferNode current = Shead;
            KoltukList<T>.KoltukNode Kcurrent = Shead.Khead;

            KoltukList<T>.KoltukNode K = new KoltukList<T>.KoltukNode();
            K.koltuk_n = satılanKoltuk;
            K.yolcu_adi = yAdi;
            K.yolcu_soyadi = ySoyad;
            K.cinsiyet = cinsiyet;
            K.koltuk_durum = durum;

            SeferNode arananSefer = SeferBul(seferNo);

            // Seferleri sırayla gezme
            while (current.next != null)
            {
                // Satılan koltuk ilk seferden ise
                if (Shead.sefer_n == arananSefer.sefer_n)
                {

                    while (Kcurrent.next != null)
                    {
                        // İlk sefer İlk koltuk ** Çalışıyor **
                        if (Shead.Khead.koltuk_n == satılanKoltuk)
                        {
                            K.koltuk_fiyat = Shead.Khead.koltuk_fiyat;

                            K.next = Shead.Khead.next;
                            Shead.Khead = K;
                            break;
                        }
                        // Son koltuğu bulduk  ** Çalışıyor **
                        else if (Kcurrent.next.next == null)
                        {
                            K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                            K.next = Kcurrent.next.next;
                            Kcurrent.next = K;
                            break;
                        }
                        // ilk sefer aradaki koltuktan koltuk satma
                        else if (Kcurrent.next.koltuk_n == satılanKoltuk && Kcurrent.next.next != null)
                        {
                            K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                            K.next = Kcurrent.next.next;
                            Kcurrent.next = K;
                            break;
                        }
                        Kcurrent = Kcurrent.next;
                    }

                }

                // Herhangi seferden koltuk satılırsa
                else if (current.next.sefer_n == arananSefer.sefer_n && current.next.next != null)
                {
                    current = current.next;

                    // Seçilen seferin ilk Koltuğunu atadık
                    Kcurrent = current.Khead;

                    while (Kcurrent.next != null /*&& Kcurrent.next.next != null*/)
                    {
                        //  İlk koltuk ** çalışıyor **
                        if (current.Khead.koltuk_n == satılanKoltuk)
                        {
                            K.koltuk_n = current.Khead.koltuk_n;
                            K.koltuk_fiyat = current.Khead.koltuk_fiyat;

                            K.next = current.Khead.next;
                            current.Khead = K;
                        }
                        // Son koltuğu bulduk  ** çalışıyor **
                        else if (Kcurrent.next.koltuk_n == satılanKoltuk && Kcurrent.next.next == null)
                        {
                            K.koltuk_n = Kcurrent.next.koltuk_n;
                            K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                            K.next = null;
                            Kcurrent.next = K;
                            break;
                        }
                        // aradaki koltuktan koltuk satma ** çalışıyor **
                        else if (Kcurrent.next.koltuk_n == satılanKoltuk && Kcurrent.next.next != null)
                        {
                            K.koltuk_n = Kcurrent.next.koltuk_n;
                            K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                            K.next = Kcurrent.next.next;
                            Kcurrent.next = K;
                            break;
                        }


                        Kcurrent = Kcurrent.next;
                    }


                }

                current = current.next;
            }

            // Satılan koltuk son seferden ise
            if (current != null && current.sefer_n == seferNo)
            {
                //Seçilen seferin ilk Koltuğunu atadık
                Kcurrent = current.Khead;

                while (Kcurrent.next != null)
                {
                    //  İlk koltuk ** çalışıyor **
                    if (current.Khead.koltuk_n == satılanKoltuk)
                    {

                        K.koltuk_n = current.Khead.koltuk_n;
                        K.koltuk_fiyat = current.Khead.koltuk_fiyat;

                        K.next = current.Khead.next;
                        current.Khead = K;
                    }

                    // Son koltuğu bulduk  ** çalışıyor **
                    else if (Kcurrent.next.koltuk_n == satılanKoltuk && Kcurrent.next.next == null)
                    {
                        K.koltuk_n = Kcurrent.next.koltuk_n;
                        K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                        K.next = null;
                        Kcurrent.next = K;
                        break;
                    }
                    // aradaki koltuktan koltuk satma ** çalışıyor **
                    else if (Kcurrent.next.koltuk_n == satılanKoltuk && Kcurrent.next.next != null)
                    {
                        K.koltuk_n = Kcurrent.next.koltuk_n;
                        K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                        K.next = Kcurrent.next.next;
                        Kcurrent.next = K;
                        break;
                    }

                    Kcurrent = Kcurrent.next;
                }

            }

        }

        public void KaptanDegistirme(int seferNo, string yeniKaptan)
        {
            SeferNode current = Shead;
            SeferNode newNode = new SeferNode();

            //newNode.sefer_n = current.sefer_n;
            newNode.guzergah = current.guzergah;
            newNode.Khead = current.Khead;
            newNode.seferTarih = current.seferTarih;
            newNode.plaka = current.plaka;

            // Listede sadece bir sefer varsa 
            if (current.next == null && Shead.sefer_n == seferNo)
            {
                newNode.sefer_n = Shead.sefer_n;
                newNode.guzergah = Shead.guzergah;
                newNode.plaka = Shead.plaka;
                newNode.otobus_adi = Shead.otobus_adi;
                newNode.seferTarih = Shead.seferTarih;
                newNode.next = Shead.next;
                newNode.Khead = Shead.Khead;
                newNode.kaptan = yeniKaptan;

                newNode.next = Shead.next;
                Shead = newNode;
            }
            // listede iki eleman olursa current.next.next hata verir.
            else if (current.next != null && Shead.sefer_n == seferNo)
            {
                newNode.sefer_n = Shead.sefer_n;
                newNode.guzergah = Shead.guzergah;
                newNode.plaka = Shead.plaka;
                newNode.otobus_adi = Shead.otobus_adi;
                newNode.seferTarih = Shead.seferTarih;
                newNode.next = Shead.next;
                newNode.Khead = Shead.Khead;
                newNode.kaptan = yeniKaptan;

                newNode.next = Shead.next;
                Shead = newNode;
            }

            else
            {

                while (current.next.next != null)
                {
                    // İlk seferin kaptanının değiştirme 
                    if (Shead.sefer_n == seferNo )
                    {
                        newNode.sefer_n = Shead.sefer_n;
                        newNode.guzergah = Shead.guzergah;
                        newNode.plaka = Shead.plaka;
                        newNode.otobus_adi = Shead.otobus_adi;
                        newNode.seferTarih = Shead.seferTarih;
                        newNode.next = Shead.next;
                        newNode.Khead = Shead.Khead;
                        newNode.kaptan = yeniKaptan;

                        newNode.next = Shead.next;
                        Shead = newNode;
                        break;
                    }
                    // Aradaki seferden kaptan değiştirme 
                    else if (current.next.sefer_n == seferNo && current.next.next != null)
                    {
                        newNode.sefer_n = current.next.sefer_n;
                        newNode.guzergah = current.next.guzergah;
                        newNode.plaka = current.next.plaka;
                        newNode.otobus_adi = current.next.otobus_adi;
                        newNode.seferTarih = current.next.seferTarih;
                        newNode.next = current.next.next;
                        newNode.Khead = current.next.Khead;
                        newNode.kaptan = yeniKaptan;

                        newNode.next = current.next.next;
                        current.next = newNode;
                        break;
                    }

                    current = current.next;
                }

                //son seferdeki kaptanı değiştirme 
                if (current.next.sefer_n == seferNo && current.next.next == null)
                {
                    newNode.sefer_n = current.next.sefer_n;
                    newNode.guzergah = current.next.guzergah;
                    newNode.plaka = current.next.plaka;
                    newNode.otobus_adi = current.next.otobus_adi;
                    newNode.seferTarih = current.next.seferTarih;
                    newNode.next = current.next.next;
                    newNode.Khead = current.next.Khead;
                    newNode.kaptan = yeniKaptan;

                    newNode.next = current.next.next;
                    current.next = newNode;
                }
            }

        }

        public void SatisIptal(int seferNo, int koltukNo)
        {
            SeferNode current = Shead;
            KoltukList<T>.KoltukNode Kcurrent = Shead.Khead;

            KoltukList<T>.KoltukNode K = new KoltukList<T>.KoltukNode();

            SeferNode arananSefer = SeferBul(seferNo);

            K.yolcu_adi = "";
            K.yolcu_soyadi = "";
            K.cinsiyet = "";
            K.koltuk_durum = "Boş";

            // Seferleri sırayla gezme
            while (current.next != null)
            {
                // Satılan koltuk ilk seferden ise
                if (Shead.sefer_n == arananSefer.sefer_n)
                {

                    while (Kcurrent.next != null)
                    {
                        // İlk sefer İlk koltuk ** Çalışıyor **
                        if (Shead.Khead.koltuk_n == koltukNo)
                        {
                            // Koltuk Bilgileri sıfırlanıcak
                            K.koltuk_n = Shead.Khead.koltuk_n;

                            K.koltuk_fiyat = Shead.Khead.koltuk_fiyat;

                            K.next = Shead.Khead.next;
                            Shead.Khead = K;
                            break;
                        }
                        // Son koltuğu bulduk  ** Çalışıyor **
                        else if (Kcurrent.next.next == null)
                        {
                            K.koltuk_n = Kcurrent.next.koltuk_n;
                            K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                            K.next = Kcurrent.next.next;
                            Kcurrent.next = K;
                            break;
                        }
                        // ilk sefer aradaki koltuktan koltuk satma
                        else if (Kcurrent.next.koltuk_n == koltukNo && Kcurrent.next.next != null)
                        {
                            K.koltuk_n = Kcurrent.next.koltuk_n;
                            K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                            K.next = Kcurrent.next.next;
                            Kcurrent.next = K;
                            break;
                        }
                        Kcurrent = Kcurrent.next;
                    }

                }

                // Herhangi seferden koltuk satılırsa
                else if (current.next.sefer_n == arananSefer.sefer_n && current.next.next != null)
                {
                    current = current.next;

                    // Seçilen seferin ilk Koltuğunu atadık
                    Kcurrent = current.Khead;

                    while (Kcurrent.next != null /*&& Kcurrent.next.next != null*/)
                    {
                        //  İlk koltuk ** çalışıyor **
                        if (current.Khead.koltuk_n == koltukNo)
                        {
                            K.koltuk_n = current.Khead.koltuk_n;
                            K.koltuk_fiyat = current.Khead.koltuk_fiyat;

                            K.next = current.Khead.next;
                            current.Khead = K;
                        }
                        // Son koltuğu bulduk  ** çalışıyor **
                        else if (Kcurrent.next.koltuk_n == koltukNo && Kcurrent.next.next == null)
                        {
                            K.koltuk_n = Kcurrent.next.koltuk_n;
                            K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                            K.next = null;
                            Kcurrent.next = K;
                            break;
                        }
                        // aradaki koltuktan koltuk satma ** çalışıyor **
                        else if (Kcurrent.next.koltuk_n == koltukNo && Kcurrent.next.next != null)
                        {
                            K.koltuk_n = Kcurrent.next.koltuk_n;
                            K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                            K.next = Kcurrent.next.next;
                            Kcurrent.next = K;
                            break;
                        }


                        Kcurrent = Kcurrent.next;
                    }


                }

                current = current.next;
            }

            // Satılan koltuk son seferden ise
            if (current != null && current.sefer_n == seferNo)
            {
                //Seçilen seferin ilk Koltuğunu atadık
                Kcurrent = current.Khead;

                while (Kcurrent.next != null)
                {
                    //  İlk koltuk ** çalışıyor **
                    if (current.Khead.koltuk_n == koltukNo)
                    {

                        K.koltuk_n = current.Khead.koltuk_n;
                        K.koltuk_fiyat = current.Khead.koltuk_fiyat;

                        K.next = current.Khead.next;
                        current.Khead = K;
                    }

                    // Son koltuğu bulduk  ** çalışıyor **
                    else if (Kcurrent.next.koltuk_n == koltukNo && Kcurrent.next.next == null)
                    {
                        K.koltuk_n = Kcurrent.next.koltuk_n;
                        K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                        K.next = null;
                        Kcurrent.next = K;
                        break;
                    }
                    // aradaki koltuktan koltuk satma ** çalışıyor **
                    else if (Kcurrent.next.koltuk_n == koltukNo && Kcurrent.next.next != null)
                    {
                        K.koltuk_n = Kcurrent.next.koltuk_n;
                        K.koltuk_fiyat = Kcurrent.koltuk_fiyat;

                        K.next = Kcurrent.next.next;
                        Kcurrent.next = K;
                        break;
                    }

                    Kcurrent = Kcurrent.next;
                }

            }

        }

        public void Sil(int seferNo)
        {
            SeferNode current = Shead;

            // Listede sadece bir sefer varsa 
            if (current.next == null && Shead.sefer_n == seferNo)
            {
                Shead = null;
            }
            // listede iki eleman olursa current.next.next hata verir.
            else if (current.next != null && Shead.sefer_n == seferNo)
            {
                Shead = Shead.next;
            }

            else
            {

                while (current.next.next != null)
                {
                    //çok elemanlı listenin İlk seferin kaptanının değiştirme 
                    if (Shead.sefer_n == seferNo)
                    {
                        Shead = Shead.next;
                        break;
                    }
                    // çok elemanlı listenin seferden kaptan değiştirme 
                    else if (current.next.sefer_n == seferNo && current.next.next != null)
                    {
                        current.next = current.next.next;
                        break;
                    }

                    current = current.next;
                }

                //son seferdeki kaptanı değiştirme 
                if (current.next.sefer_n == seferNo && current.next.next == null)
                {
                    
                    current.next = current.next.next;
                }
            }

            
        }

        //public void SeferYazdır()
        //{
        //    KoltukList<T> k = new KoltukList<T>();
        //    SeferNode current = Shead;

        //    if (current == null)
        //    {
        //        Console.WriteLine("Sefer Yok");
        //    }
        //    else
        //    {
        //        while (current != null)
        //        {
        //            Console.WriteLine("\n- Sefer " + current.sefer_n + " Güzergah: " + current.guzergah + " " + current.otobus_adi + " Plaka: " + current.plaka + " Kaptan : " + current.kaptan + " Sefer Saati: " + current.seferTarih + " " + current.seferTarih.DayOfWeek + "\n");
        //            k.KoltukYazdır(current.Khead);
        //            //Console.WriteLine("\t---------------------------------");
        //            current = current.next;
        //        }
        //    }
        //}

        //public void SeferSil()
        //{
        //    SeferNode current = Shead;
        //    SeferNode newNode = new SeferNode();

        //    if (Shead == null)
        //    {
        //        Console.WriteLine("Liste Boş");
        //    }
        //    else if (current.next == null)
        //    {
        //        Shead = null;
        //    }
        //    else
        //    {

        //        while (current.next.next != null)
        //        {
        //            current = current.next;
        //        }
        //        current.next = null;
        //    }

        //}

        //public void AradanSeferSil(int sefer_no)
        //{
        //    SeferNode current = Shead;
        //    SeferNode newNode = new SeferNode();

        //    newNode.sefer_n = sefer_no;

        //    int dataHead = Convert.ToInt32(current.sefer_n.ToString());


        //    if (Shead == null)
        //    {
        //        Console.WriteLine("Listeniz de eleman yok !!");
        //    }
        //    else if (dataHead == sefer_no)
        //    {
        //        Shead = Shead.next;

        //    }
        //    else
        //    {
        //        var bas = Shead;
        //        while (dataHead + 1 != sefer_no)
        //        {
        //            dataHead = dataHead + 1;
        //            bas = bas.next;
        //        }
        //        bas.next = bas.next.next;
        //    }


        //}

        

    }
}

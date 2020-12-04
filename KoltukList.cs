using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobüsFirma
{
    public class KoltukList<T>
    {
        public class KoltukNode
        {
            public int koltuk_n;
            public int koltuk_fiyat;
            public string yolcu_adi;
            public string yolcu_soyadi;
            public string cinsiyet;
            public string koltuk_durum;
            public KoltukNode next;

        }

        public  KoltukNode Khead;

        public KoltukNode KoltukEkle(int Koltuk_no, int fiyat)
        {

            KoltukNode current = Khead;

            int i = 1;

            for (i = 1; i <= Koltuk_no; i++)
            {
                // newNode burada oluşturulmazsa sonsuz döngüye girer.
                KoltukNode newNode = new KoltukNode();
                if (i == 1)
                {
                    newNode.koltuk_n = i;
                    newNode.koltuk_durum = "Boş";
                    newNode.koltuk_fiyat = fiyat;
                    Khead = newNode;
                    current = Khead;
                    Console.WriteLine("\t\t Eklenen koltuk: " + newNode.koltuk_n + "-> Koltuk Fiyatı: " + newNode.koltuk_fiyat);
                }
                else
                {
                    //while (current.next != null)
                    //{
                    //    current = current.next;
                    //}
                    newNode.koltuk_n = i;
                    newNode.koltuk_durum = "Boş";
                    newNode.koltuk_fiyat = fiyat;
                    Console.WriteLine("\t\t Eklenen koltuk: " + newNode.koltuk_n + "-> Koltuk Fiyatı: " + newNode.koltuk_fiyat);
                    current.next = newNode;
                    current = current.next;
                    //current.next = null;
                }

            }

            return Khead;
        }
        
        public KoltukNode KoltukBul(int satılanKoltuk)
        {
            KoltukNode current = Khead;
            KoltukNode arananKoltuk;

            while (current.koltuk_n != satılanKoltuk)
            {
                current = current.next;
            }
            arananKoltuk = current;

            return arananKoltuk;
        }

        public void KoltukYazdır(KoltukNode head)
        {
            KoltukNode current = head;
            if (Khead == null)
            {
                Console.WriteLine("Khead boş");
            }
            while (current != null)
            {

                Console.WriteLine("\t\t Koltuk no: " + current.koltuk_n + " -> " + " Yolcu Adı :" + current.yolcu_adi + " Soyadı : " + current.yolcu_soyadi + " Cinsiyeti: " + current.cinsiyet + " Durum : " + current.koltuk_durum + " Fiyati : " + current.koltuk_fiyat);

                current = current.next;
            }

        }

    }
}

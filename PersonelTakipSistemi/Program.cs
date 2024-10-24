using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sirket sirket = new Sirket();

            while (true)
            {
                Console.WriteLine("\n1. Çalışan Ekle\n2. Maaş Güncelle\n3. Çalışanları Listele\n4. Çıkış");
                Console.Write("Bir seçenek girin: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Write("Çalışan Adı: ");
                        string ad = Console.ReadLine();
                        Console.Write("Pozisyon: ");
                        string pozisyon = Console.ReadLine();
                        Console.Write("Maaş: ");
                        decimal maas = Convert.ToDecimal(Console.ReadLine());

                        Personel yeniPersonel = new Personel(ad, pozisyon, maas);
                        sirket.CalisanEkle(yeniPersonel);
                        break;

                    case 2:
                        Console.Write("Maaşı güncellenecek çalışanın adı: ");
                        string guncellenecekAd = Console.ReadLine();
                        Console.Write("Yeni maaş: ");
                        decimal yeniMaas = Convert.ToDecimal(Console.ReadLine());

                        sirket.MaasGuncelle(guncellenecekAd, yeniMaas);
                        break;

                    case 3:
                        sirket.CalisanlariListele();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçenek!");
                        break;
                }
            }
        }
    }
    class Personel
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public decimal Maas { get; set; }

        public Personel(string ad, string pozisyon, decimal maas)
        {
            Ad = ad;
            Pozisyon = pozisyon;
            Maas = maas;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Pozisyon: {Pozisyon}, Maaş: {Maas} TL");
        }
    }
    class Sirket
    {
        private List<Personel> personeller = new List<Personel>();

        public void CalisanEkle(Personel personel)
        {
            personeller.Add(personel);
            Console.WriteLine($"{personel.Ad} çalışanı eklendi.");
        }

        public void MaasGuncelle(string ad, decimal yeniMaas)
        {
            foreach (var personel in personeller)
            {
                if (personel.Ad == ad)
                {
                    personel.Maas = yeniMaas;           
                    Console.WriteLine($"{ad} çalışanının maaşı güncellendi.");
                    return;
                }
            }
            Console.WriteLine($"{ad} isminde bir çalışan bulunamadı.");
        }

        public void CalisanlariListele()
        {
            Console.WriteLine("Şirket Çalışanları:");
            foreach (var personel in personeller)
            {
                personel.BilgileriYazdir();
            }
        }
    }
}

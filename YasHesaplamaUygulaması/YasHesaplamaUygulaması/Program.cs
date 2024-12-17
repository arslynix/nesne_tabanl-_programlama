using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasHesaplamaUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doğum tarihinizi girin. (GG//AA/YYYY) formatında");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthDate))
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;
                Console.WriteLine("Yaşınız: " + age);
            }
            else
            {
                Console.WriteLine("Geçersiz tarih formatı.");
            }
        }
    }
}

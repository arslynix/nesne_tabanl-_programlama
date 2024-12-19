using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)  // Sonsuz döngü başlatıyoruz
			{
				int sayi = 0;
				bool gecerliGirdi = false;

				while (!gecerliGirdi)
				{
					try
					{
						Console.Write("Lütfen bir sayı girin: ");
						string girdi = Console.ReadLine();
						sayi = int.Parse(girdi);
						if (sayi < 0)
						{
							throw new ArgumentException("Negatif bir sayı girdiniz. Pozitif bir sayı girin.");
						}
						gecerliGirdi = true;
					}
					catch (FormatException)
					{
						Console.WriteLine("Geçersiz giriş. Geçerli bir sayı girin.");
					}
					catch (ArgumentException ex)
					{
						Console.WriteLine(ex.Message);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Beklenmedik bir hata oluştu. Hata: " + ex.Message);
					}
				}

				Console.WriteLine($"Girilen pozitif sayi: {sayi}");

				// Kullanıcıya tekrar sayı girmek isteyip istemediğini soruyoruz.
				Console.Write("Yeni bir sayı girmek ister misiniz? (Evet/Hayır): ");
				string devam = Console.ReadLine().ToLower();

				if (devam != "evet")
				{
					Console.WriteLine("Programdan çıkılıyor.");
					break;  // Eğer kullanıcı "evet" dışında bir şey yazarsa döngüyü sonlandırır.
				}
			}
		}
	}
}

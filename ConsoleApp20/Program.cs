using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Bir sayı girin");
				int number = int.Parse(Console.ReadLine());
				Console.WriteLine("Girilen sayı: " + number);
			}
			catch (FormatException ex)
			{
				Console.WriteLine(" Hata: Geçersiz bir sayı girdiniz.");
			}
			finally
			{
				Console.WriteLine(" Girdi işlemi tamamlandı.");
					
			}
			Console.ReadLine();
		}
	}
}

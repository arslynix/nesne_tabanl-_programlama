using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int stok = 5;
			Console.WriteLine("stok miktarı: " + stok);
			try
			{
				Console.Write("Almak istediğiniz ürün miktarını girin: ");
				int miktar = int.Parse(Console.ReadLine());
				if (miktar > stok)
				{
					throw new OutOfMemoryException("Yetersiz stok.");
				}
				stok -= miktar;
				Console.WriteLine($"Satın alma başarılı. Kalan stok: {stok}");
			}
			catch (FormatException)
			{
				Console.WriteLine("Lütfen geçerli bir sayı girin.");
			}
			catch (OutOfStockException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

	}
	public class OutOfStockException: Exception
	{
		public OutOfStockException(string message) : base(message) { }
	}
}

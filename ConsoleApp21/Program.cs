using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    try
			{
				int yas = -5;
				if (yas < 0)
				{
					throw new Exception("Yaş negatif olamaz.");
				}
			}
			catch (CustomException ex)
			{
				Console.WriteLine("Özel Hata:" + ex.Message);
			}
		}
		public class CustomException : Exception
		{
			public CustomException(string message) : base(message) { }
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndsWithÇalışması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files = { "document.pdf", "image.pdf", "archive.zip", "report.docx", "presentation.pptx" };
            Console.WriteLine("PDF dosyaları:");
            foreach (string file in files)
            {
                if (file.EndsWith(".pdf"))
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_protected_private
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();  //Vehicle sınıfından bir vehicle nesnesi oluşturuluyor. bu nesne kurucu metod sayesinde alanlarına değer atıyor.
            vehicle.ShowFields(); //metodla çağrılarak bu değerler ekrana yazdırılıyor.

            vehicle.publicField = 30; //publicfield alanı 30 olarak değiştiriliyor.(yani public olduğu için dışardan erişilip değiştirilebilir.)
            Console.WriteLine("\n --- Vehicle nesnesinde publicField = 30 atandıktan sonra ---");
            vehicle.ShowFields();


            Console.WriteLine("\n--- Car sınıfı örneği ile ---");

            Car car = new Car();  //Car sınıfından bir car nesnesi oluşturuluyor.
            car.ShowInheritedfields();

            car.publicField = 40; //car nesnesinin publicfield alanı 40 olarak değiştiriliyor.
            Console.WriteLine("\n --- Car nesnesinde publicField = 40 atandıktan sonra ---");
            car.ShowFields();

            Console.ReadLine();

        }
    }
    public class Vehicle
    {
        private int privateField;
        protected int protectedField;
        public int publicField;

        public Vehicle()
        {
            privateField = 1;  //private alanın değeri 1 olarak ayarlanıyor.
            protectedField = 2;  //protected alanın değeri 2 olarak ayarlanıyor.
            publicField = 3;  //public alanın değeri 3 olarak ayarlanıyor.
        }
        public void ShowFields() //vehivle sınıfındaki alanların değerini ekrana yazdırıyor.
        {
            Console.WriteLine($"privateField: {privateField}");
            Console.WriteLine($"protectedField: {protectedField}");
            Console.WriteLine($"publicFields: {publicField}");
        }
    }
    public class Car : Vehicle  //protectedfield'e erişebiliyor çünkü bu protected tanımlı.publicfield'e erişebiliyor çünkü bu public tanımlı.
    {
        public void ShowInheritedfields() //miras alınan alanları ekrana yazdırıyor.
        {
            Console.WriteLine($"protectedField: {protectedField}");
            Console.WriteLine($"publicField: {publicField}");
        }
    }
}

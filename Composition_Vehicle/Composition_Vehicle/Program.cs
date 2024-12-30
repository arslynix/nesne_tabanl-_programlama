using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int days))
            {
                Console.WriteLine($"Kiralama Süresi: {days} gün");
            }
            else
            {
                Console.WriteLine("Yanlış bir girdi girdiniz.");
            }
            Car car = new Car { Brand = "Toyota", Model = "Corolla", DailyRate = 300 };
            Truck truck = new Truck { Brand = "Volvo", Model = "FH", DailyRate = 150 };
            Motorcycle motorcycle = new Motorcycle { Brand = "Yamaha", Model = "R1", DailyRate = 80 };

            Console.WriteLine($"Car: {car.Brand} {car.Model} Total Rental cost for {days} day: {car.CalculateRentalCost(days)}");
            Console.WriteLine($"Truck: {truck.Brand} {truck.Model} Total Rental cost for {days} day: {truck.CalculateRentalCost(days)}");
            Console.WriteLine($"Motorcycle: {motorcycle.Brand} {motorcycle.Model} Total Rental cost for {days} day: {motorcycle.CalculateRentalCost(days)}");
            Console.ReadLine();
        }
    }
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int DailyRate { get; set; }

        public abstract decimal CalculateRentalCost(int days);
    }
    public class Car: Vehicle
    {
        public override decimal CalculateRentalCost(int days)
        {
            return days * DailyRate;
            
        }
        
    }
    public class Truck: Vehicle
    {
        public override decimal CalculateRentalCost(int days)
        {
            return (days * DailyRate) + 50;
        }
    }
    public class Motorcycle: Vehicle
    {
        public override decimal CalculateRentalCost(int days)
        {
            return (days * DailyRate) * 0.9m;
        }
    }
}

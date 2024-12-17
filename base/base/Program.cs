using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Tesla", 120, 4);
            car.DisplayInfo();
        }
    }
    public class Vehicle
    {
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public Vehicle(string brand, int maxSpeed )
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
        }
    }
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car(string brand, int maxSpeed, int NumberOfDoors) :base(brand, maxSpeed)
        {
            this.NumberOfDoors = NumberOfDoors;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Max Speed: {MaxSpeed}km/h, NumberOfDoors: {NumberOfDoors}");
        }
    }

}

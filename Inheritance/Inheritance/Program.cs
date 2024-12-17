using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Brand = "Ferrari",
                Speed = 200,
                NumberOfDoors = 2
            };
            car.Drive();
            car.Honk();
            Console.ReadLine();
        }     
    }
    public class Vehicle
    {
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public void Drive()
        {
            Console.WriteLine($"{Brand} id driving at {Speed} km/h");
        }
    }
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public void Honk()
        {
            Console.WriteLine($"{Brand} is honking!");
        }

    }
   
}

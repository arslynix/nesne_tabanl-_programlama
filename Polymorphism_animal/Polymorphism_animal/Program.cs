using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();
            Animal animal3 = new Fish();

            animal1.Speak();
            animal2.Speak();
            animal3.Speak();
        }
    }
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }
    public class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class Cat: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }
    public class Fish: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Fish bloobs");
        }
    }
}

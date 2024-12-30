
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ISpeakable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISpeakable[] animals = { new Dog(), new Cat() };

            foreach (ISpeakable animal in animals)
            {
                animal.Speak();                
            }
            Console.ReadLine();
        }
    }
    public interface ISpeakable
    {
        void Speak();
    }
    public class Cat: ISpeakable
    {
        public void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }
    public class Dog: ISpeakable
    {
        public void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }
}

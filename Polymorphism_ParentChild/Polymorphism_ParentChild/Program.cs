using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ParentChild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Parent ChildAsParent = new Child();
            Child child = new Child();

            parent.Show();
            ChildAsParent.Show();
            child.Show();
            Console.ReadLine();
        }
    }
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent's show method");
        }
    }
    public class Child: Parent
    {
        public new void Show()
        {
            Console.WriteLine("Child's show method");
        }
    }
}

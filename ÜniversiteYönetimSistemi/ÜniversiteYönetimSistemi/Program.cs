using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteYönetimSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students { Name = "Seval", id = 123, Major = "Yönetim Bilişim Sistemleri" };
            Teachers teacher = new Teachers { Name = "Şaban Öztürk", id = 234, Subject = "Nesne Tabanlı Programlama" };
            Staff staff = new Staff { Name = "Buse", id = 345, Department = "3D Programlama" };

            Console.WriteLine($" Name: {student.Name}, id: {student.id}, {student.Major}");
            Console.WriteLine($" Name: {teacher.Name}, id: {teacher.id}, {teacher.Subject}");
            Console.WriteLine($" Name: {staff.Name}, İD: {staff.id}, {staff.Department}");
            Console.ReadLine();
        }
    }
    public abstract class Person
    {
        public string Name { get; set; }
        public int id { get; set; }
        public abstract void ShowInfo();
    }
    public class Students : Person
    {
        public string Major {  get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"Student: {Name}, ID: {id}, Major: {Major}");
        }
    }
    public class Teachers : Person
    {
        public string Subject { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"Teacher: {Name}, ID: {id}, Major: {Subject}");
        }
    }
    public class Staff : Person
    {
        public string Department { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"Staff: {Name}, ID: {id}, Department: {Department}");
        }
    }

}

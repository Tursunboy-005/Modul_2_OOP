using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student(12,"Tursunboy", "Raximjonov",2,5);

            Console.WriteLine(" ------------- 1  -------------------");

            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Lastname);
            Console.WriteLine(student.Group);
            Console.WriteLine(student.Grade);

            Console.WriteLine(" ----------------------- 2 ------------------");

            Student student1 = new Student();

            Console.WriteLine(student1.Id);
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Lastname);

            Console.ReadLine();
        }

    }
}

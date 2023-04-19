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

            Console.WriteLine(" --------------------- 1  -------------------");

            student.DisplayResult();
            
            Console.WriteLine(" ----------------------- 2 ------------------");

            Student student1 = new Student();

            Console.WriteLine(student1.Id);
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Lastname);

            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_OOP
{
    internal class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public int Group { get; private set; }
        public int Grade { get; private set; }

        public Student(int id, string name, string lastname, int group, int grade)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Group = group;
            Grade = grade;

        }

        public Student(int id, string name, string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
        }

        public Student()
        {
            Id = 12;
            Name = "Tursunboy";
            Lastname = "Raximjonov";
            Group = 1;
            Grade = 5;
        }

        public void SetExamResult(int a)
        {
            if(a <= 0) 
            {
                Console.WriteLine("Grade must be great than !0 ");
                return;
            }
            Grade = Grade;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"ID - {Id}, Name - {Name}, Lastname - {Lastname}, Group - {Group}, Grade - {Grade}");
        }
    }
}

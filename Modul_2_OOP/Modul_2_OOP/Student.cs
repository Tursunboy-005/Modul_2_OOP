using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_OOP
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Group { get; set; }
        public int Grade { get; set; }

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
    }
}

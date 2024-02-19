using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Student : Person
    {
        public int Rollno { get; set; } = 0;

        public Student(int age = 0, string name = "No name",
            int rollno = 0) : base(age, name)
        {
            Rollno = rollno;
        }
        public override void showInfo()
        {
            Console.WriteLine($"The age of {name} is {age} and has roll no.{Rollno} ");
        }
    }
}

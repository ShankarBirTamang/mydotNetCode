using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Person
    {
        protected int age;
        protected string name;
        private string location;

        public Person() : this(0, "No Name") { }
        public Person(int age) : this(age, "No Name") { }
        public Person(string name):this(0,name) { }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public virtual void showInfo()
        {
            Console.WriteLine($"The age of {name} is {age} ");
        }
        public int Ages
        {
            get { return age; }
            set { age = value; }
        }
        public string Names
        {
            get { return name; }
            set { name = value; }
        }
        public void setLocation(string loc)
        {
            this.location = loc;
        }
        public void getLocation()
        {
            Console.WriteLine($"The location of {Names} with age {age} is {location}.");
        }
    }
}

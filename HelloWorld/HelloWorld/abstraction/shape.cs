using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.abstraction
{
    abstract class Shape
    {
        public string Name { get; set; }
        public abstract double getArea();
        public virtual void getInfo()
        {
            Console.WriteLine($"This is {Name}.");
        }

    }
}

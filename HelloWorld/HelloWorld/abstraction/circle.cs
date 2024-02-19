using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.abstraction
{
     class  Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double rad) {
            Name = "Circle";
            Radius = rad;
        }
        public override double getArea()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"The area of {Name} is {this.getArea()}");
        }
    }
}

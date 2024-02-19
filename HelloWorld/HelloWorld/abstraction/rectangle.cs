using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.abstraction
{
     class Rectangle: Shape
    {   
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double l , double w)
        {
            Name = "Rectangle";
            Length = l;
            Width = w;
        }

        public override double getArea()
        {
            return Length * Width;
        }
        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"This is a {Name} with area {this.getArea()} .");
        }

    }
}

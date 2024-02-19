using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Collections
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }

        public Box(double length, double breadth, double height)
        {
            Length = length;
            Breadth = breadth;
            Height = height;
        }

        public Box() : this(1, 1, 1) { }

        //Operator overloading
        public static Box operator +(Box box1, Box box2)
        {
            Box box = new()
            {
                Length = box1.Length + box2.Length,
                Breadth = box1.Breadth + box2.Breadth,
                Height = box1.Height + box2.Height
            };
            return box;
        }
        public static Box operator - (Box box1, Box box2)
        {
            Box box = new()
            {
                Length = box1.Length - box2.Length,
                Breadth = box1.Breadth - box2.Breadth,
                Height = box1.Height - box2.Height
            };
            return box;
        }

        public static bool operator == (Box box1 , Box box2)
        {
            if ((box1.Length == box2.Length) && 
                (box1.Height == box2.Height) && 
                (box1.Breadth == box2.Breadth)) return true;
            else
                return false;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) &&
                (box1.Height != box2.Height) &&
                (box1.Breadth != box2.Breadth)) return true;
            else
                return false;
        }

        public override string ToString()
        {
            return String.Format("Box with Length : {0} ,Breadth : {1} & Height : {2}", Length, Breadth, Height);
        }

        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Breadth + b.Height) / 3;
        }

        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }
    }
}

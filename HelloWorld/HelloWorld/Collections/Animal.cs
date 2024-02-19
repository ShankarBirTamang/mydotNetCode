using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Collections
{
   class Animal
    {
        public string Name {  get; set; }
        public double Height {  get; set; }
        public double Weight { get; set; }
        public int AnimalId {  get; set; }
        public Animal (string name = "No Name ", double height = 0, double weight = 0 , int animalId =0)
        {
            Name = name; 
            Height = height;
            Weight = weight;
            AnimalId = animalId;
        }

        public override string ToString()
        {
            return String.Format("{0} weighs {1}lbs and is {2} inches tall", Name, Weight, Height);
        }
        public static void GetSum<T> (ref T num1  , ref T num2)
        {
            double dbX = Convert.ToDouble(num1);
            double dbY = Convert.ToDouble(num2);
            Console.WriteLine($"{dbX}+{dbY} = {dbX + dbY}");

        }
    }
}

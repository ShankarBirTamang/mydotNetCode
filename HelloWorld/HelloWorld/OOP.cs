using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LearnCSharp;

namespace OOP
{
    class ShapeArea
    {
        public static double GetArea(string shape = "", double length1 = 0, double length2 = 0)
        {
            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * (length2 / 2);
            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(length1, 2);
            }
            else
            {
                return -1;
            }
        }



    }
    struct Rectangle
    {
        public double length;
        public double width;

        public Rectangle(double l = 1
            , double b = 1)
        {
            length = l;
            width = b;
        }

        public double Area()
        {
            return length * width;
        }


    }

    class Animal
    {
        private string name;
        protected string sound;
        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();
        
        public void SetAnimalIDInfo(int idNum , string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the id of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakesSound()
        {
            Console.WriteLine($"{Name} says {Sound}.");
        }

        //public static int numOfAnimals = 0;
        //public const string SHELTER = "Billi's & Tom's Home ";
        //public readonly int idNum;

        public Animal() : this("No name", "No Sound") { } // <---- DEFAULT CONSTRUCTOR

        public Animal(string name) : this(name, "No Sound") { } // <---- ONE PARAMETER CONSTRUCTOR

        public Animal(string name , string sound )
        {
            //Name = name;
            //Sound = sound;
            this.name = name;
            this.sound = sound;
            //NumOfAnimals = 1;
            //Random rndm = new Random();
            //idNum = rndm.Next(1, 2147483640);
        }

        //public void MakeSound()
        //{
        //    Console.WriteLine("{0} says {1}", name, sound);
        //}

        //public static int GetAnimalNum()
        //{
        //    return numOfAnimals;
        //}

        // ---- CHECKs DIGIT IN NAME ----
        //public void SetName(string name)
        //{
        //    if (!name.Any(Char.IsDigit))
        //    {
        //        this.name = name;
        //    }
        //    else
        //    {
        //        this.name = "No Name";
        //        Console.WriteLine("Name cannot contains Numbers.");
        //    }
        //}

        //public string GetName() => name;

        // ---- FOR GETTERS & SETTERS USING PROPERTY ----
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("The sound is too long .");
                }
                else
                {
                    sound = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    Name = "No Name";
                   
                    Console.WriteLine("Name can't have digits.");
                }
                else
                {
                    Name = value;
                }
            }
        }

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No name";
                Console.WriteLine("Name cant have numbers");
            }
        }
        public string Owner { get; set; } = "No Owner";

        //public static int NumOfAnimals
        //{
        //    get { return numOfAnimals; }
        //    set { numOfAnimals += value; }
        //}

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }else
                {
                    return false;
                }
            }
        }


    }
    
    class AnimalIDInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "No Owner";
    }



    //    internal class Program
    //    {
    //        public static void Main()
    //        {
    //            //Console.WriteLine("Area of given shape : {0}", ShapeArea.GetArea("rectangle", 5, 6));

    //            // ---- Struct Rectangle ----
    //            //Rectangle rect;
    //            //rect.length = 50;
    //            //rect.width = 30;
    //            //Console.WriteLine("Area of Rectangle : {0}", rect.Area());

    //            // ---- Animal class ----
    //            //Animal cat1 = new Animal("Billi","meow");
    //            //Animal cat2 = new Animal("Tom", "meooooow");
    //            //Console.WriteLine("No of Animals : {0}", Animal.GetAnimalNum());
    //            //cat1.MakeSound();
    //            //cat2.MakeSound();

    //            // ---- NULL VALUE ----
    //            //int? randNum = null;
    //            //if (!randNum.HasValue)
    //            //{
    //            //    Console.WriteLine("randnum is null.");
    //            //}


    //            //Animal dog = new Animal();
    //            //dog.SetName("Captain");     // using setters
    //            //dog.Sound = "Howw!";        // using property ( alternative way )
    //            //Console.WriteLine("The dog is named {0} and it says {1}", dog.GetName(), dog.Sound);

    //            //dog.Owner = "Jangbu";
    //            //Console.WriteLine("The owner of {0} is {1}.", dog.GetName(), dog.Owner);
    //            //Console.WriteLine("The shelter id of {0} is {1}.", dog.GetName(), dog.idNum);
    //            //Console.WriteLine("# of Animals : {0}.", Animal.NumOfAnimals);


    //            Animal whiskers = new Animal()
    //            {
    //                Name = "whiskers",
    //                Sound = "meow"
    //            };
    //            Dog grover = new Dog()
    //            {
    //                Name = "Grover",
    //                Sound = "woof" ,
    //                Sound2 = "haaaw"
    //            };
    //            grover.Sound = "Wooooooooof";
    //            whiskers.MakesSound();
    //            grover.MakesSound();
    //            whiskers.SetAnimalIDInfo(12345,"Romeo bob");
    //            grover.SetAnimalIDInfo(12346, "Ram Singh");
    //            whiskers.GetAnimalIDInfo();


    //        }

    //    }
}

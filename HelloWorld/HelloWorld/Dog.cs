using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;

namespace LearnCSharp
{
     class Dog : Animal
    {
        public string Sound2 { set; get; } = "Grrrrrr";

        public override void MakesSound()
        {
            Console.WriteLine($"{Name} says {Sound} and also {Sound2}.");
        }
        
        // ---- CONSTRUCTOR ----
        public Dog(string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No Sound2"):base (name, sound)
        {
            Sound2 = sound2;
        }
    }

}

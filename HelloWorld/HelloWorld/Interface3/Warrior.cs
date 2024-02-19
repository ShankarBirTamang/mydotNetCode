using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Interface3
{
    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttkMax { get; set; }
        public double BlkMax { get; set; }

        Random rnd = new Random();

        public Warrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0, 
            double blkMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlkMax = blkMax;
        }

        public double Attack() => rnd.Next(1, (int)AttkMax);
        public virtual double Block() => rnd.Next(1, (int)BlkMax);
    }
}

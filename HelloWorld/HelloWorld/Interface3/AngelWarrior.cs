using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Interface3
{
    class AngelWarrior : Warrior
    {
        int flyingChance = 0;
        CanFly canFly = new CanFly();
        CantFly cantFly = new CantFly();

        public AngelWarrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blkMax = 0,
            int flyingChance = 0) : base(name,health , attkMax,blkMax)
        {
            this.flyingChance = flyingChance;
        }

        public override double Block()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);
            if(rndDodge < this.flyingChance)
            {
                Console.WriteLine($"{Name} {canFly.fly()}");
                return 10000;
            }
            else
            {
                Console.WriteLine($"{Name} {cantFly.fly()}");
                return base.Block();
            }
        }
    }
}

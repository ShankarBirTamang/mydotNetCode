using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Interface3
{
    class Battle
    {
        /* Start battle : 
         * Warrior1 attacks Warrior2 , warrior2 gets damage , Warrior2 health decreases
         * Get Attk Result
         * Warrior2 attacks Warrior1 , warrior1 gets damage , Warrior1 health decreases
         * Get Attk Result
        */
        public static void StartFight(Warrior warrior1 , Warrior warrior2)
        {
            while(true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over!!!");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over!!!");
                    break;
                }
            }

        }

        // Get Attack Result
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warA_AttkAmt = warriorA.Attack();
            double warB_BlockAmt = warriorB.Block();

            Console.WriteLine($"{warriorA.Name} Attacked Amt : {warA_AttkAmt}\n{warriorB.Name} Blocked Amt : {warB_BlockAmt}");

            double dmg2WarB = warA_AttkAmt - warB_BlockAmt;
            if (dmg2WarB > 0)
            {   
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else
            {
                dmg2WarB = 0;
            }
            Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name} and deals {dmg2WarB} damages.");
            Console.WriteLine("{0} Health : {1}\n",warriorB.Name,warriorB.Health);

            if(warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorous.", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else
            {
                return "Fight Again";
            }

        }
    }
}

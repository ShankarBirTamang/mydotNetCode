using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Threads
{
    class BankAcc
    {
        private Object accLock = new object();
        double Balance {  get; set; }
        string Name {  get; set; }

        public BankAcc(double bal)
        {
            Balance = bal;
        }
        public double WithDraw(double amt)
        {
            if((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;
            }
            lock (accLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Removed {0} and {1} left in account",amt , Balance-amt);
                    Balance -= amt;
                }
                return Balance;
            }
        }

        public void IssueWithDraw()
        {
            WithDraw(1); 
        }
    }
}

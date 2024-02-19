//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnCSharp.Threads
//{
//    internal class Program
//    {
        

//        public static void Main()
//        {
//            #region Thread example1
//            //static void Print1()
//            //{
//            //    for (int i = 0; i < 1000; i++)
//            //    {
//            //        Console.Write(1);
//            //    }
//            //}
//            //Thread t = new Thread(Print1);
//            //t.Start();
//            //for (int i = 0; i < 1000; i++)
//            //    Console.Write(0);

//            //int num = 1;
//            //for(int i = 0;i < 10; i++)
//            //{
//            //    Console.Write(num++);
//            //    Thread.Sleep(1000); //Delays 1 second
//            //}
//            //Console.WriteLine("Thread Ends!");


//            #endregion

//            #region Thread BankAcc Code
//            //BankAcc myAcc = new BankAcc(10);
//            //Thread[] threads = new Thread[15];

//            //Thread.CurrentThread.Name = "main";
//            //for (int i = 0; i < 15; i++)
//            //{
//            //    Thread t = new Thread(new ThreadStart(myAcc.IssueWithDraw));
//            //    t.Name = i.ToString();
//            //    threads[i] = t;
//            //}
//            //for (int i = 0; i < 15; i++)
//            //{
//            //    Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
//            //    threads[i].Start();
//            //    Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
//            //}
//            //Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);
//            //Console.WriteLine("Thread {0} Ending : {1}", Thread.CurrentThread.Name);
//            #endregion

//            #region Count number Code
//            //static void CountTo(int maxNum)
//            //{
//            //    for (int i = 0; i <= maxNum; i++)
//            //        Console.Write(i);
//            //    Console.WriteLine();
//            //}
            
//            //Thread t = new Thread(() => CountTo(10));
//            //t.Start();
//            //new Thread(() =>
//            //{
//            //    CountTo(5);
//            //    CountTo(6);
//            //}).Start();

//            #endregion




//        }
//    }
//    }

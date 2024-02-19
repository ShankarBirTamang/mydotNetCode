//using System.Globalization;
//using System.Reflection;
//using System.Text;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        //string fname = "Sankar";
//        //string lname = "Tamang";
//        //string name = $"My full name is : {fname} {lname}";
//        //Console.WriteLine("Hello "+name);

//        //Console.ReadLine();
//        //int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 5, 6, 7 } };
//        ////foreach (int i in numbers)
//        ////{
//        ////    Console.WriteLine(i);
//        ////}
//        //for(int i = 0; i < numbers.GetLength(0); i++)
//        //{   for(int j = 0;j < numbers.GetLength(1); j++)
//        //    {
//        //        Console.Write(numbers[i,j]+"\t");
//        //    }
//        //    Console.WriteLine();
//        //}

//        //Console.WriteLine(Math.Round(9.99));

//        //Pattern1
//        /*
//                            *
//                        *   *   *
//                    *   *   *   *   *    
//                *   *   *   *   *   *   *

//        */
//        //for(int i = 0; i < 5; i++)
//        //{
//        //    for (int j = 5; j >= i; j--)
//        //    {
//        //        Console.Write("   ");
//        //    }
//        //    for ( int j = 0; j < 2*i+1; j++)
//        //    {
//        //        Console.Write(" * ");
//        //    }
//        //    Console.WriteLine();
//        //}

//        //Console.WriteLine("Currency : {0:c}", 2345);
//        //Console.WriteLine("Pad with 0s : {0:d5}", 23);
//        //Console.WriteLine("3 decimals : {0:f2}", 23.4555555);
//        //Console.WriteLine("Commas : {0:n8}", 2300);

//        //string randomString = "I am learning CSharp.";
//        //Console.WriteLine("Length of RandomString : {0}",randomString.Length);
//        //Console.WriteLine("Index of am : {0}", randomString.IndexOf("am"));
//        //Console.WriteLine("String Contains am : {0}", randomString.Contains("am"));
//        //Console.WriteLine("Remove String : {0}", randomString.Remove(10, 3));
//        //Console.WriteLine("Insert String : {0}", randomString.Insert(10, " short"));
//        //Console.WriteLine("Replace String : {0}", randomString.Replace("am", "was"));
//        //Console.WriteLine("Compare A to B: {0}", String.Compare("A","B",StringComparison.OrdinalIgnoreCase));
//        //Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
//        //Console.WriteLine("Pad Left : {0}", randomString.PadLeft(40, '.'));
//        //Console.WriteLine("Pad Right : {0}", randomString.PadRight(30, '.'));
//        //Console.WriteLine("Trim : {0}", randomString.Trim( ));
//        //Console.WriteLine("UpperCase : {0} ", randomString.ToUpper());
//        //Console.WriteLine("LowerCase : {0}",randomString.ToLower());
//        //string newString = String.Format("{0} is learning {1} in the {2} with {3}.", "Ram", "CSharp", "library", "Hari");
//        //Console.WriteLine(newString);

//        //int[] randomNo = new int[3];
//        //randomNo[0] = 23;
//        //Console.WriteLine("randomNo 0 : {0}", randomNo[0]);

//        //string[] customers = { "Snkar", "hari ", "Sita" };
//        //var employees = new[] { "Mike ", "Shyam ", " Raju " };
//        //object[] randomArray = { "Donge", 13.44, 43 };
//        //Console.WriteLine("CustomersTypes: {0}\nEmployeesTypes: {1}\nrandomArrTypes: {2}",
//        //    customers.GetType(),employees.GetType(),randomArray.GetType());

//        //for(int i = 0; i< employees.Length; i++)
//        //{
//        //    Console.WriteLine("employees {0} Name: {1}",i  , employees[i]);
//        //}

//        //string[,] multiArrStrings = new string[2, 2] { { "A", "B" }, { "C","D"} };
//        ////Console.Write(multiArrStrings[0,1]);
//        ////Console.WriteLine(multiArrStrings.GetValue(0,0));
//        //for( int i = 0; i< multiArrStrings.GetLength(0); i++)
//        //{
//        //    for(int j=0; j< multiArrStrings.GetLength(0);j++)
//        //    {
//        //        Console.Write(multiArrStrings[i,j] + "\t");
//        //    }
//        //    Console.WriteLine();
//        //}

//        //// ----- FUNCTIONS ------
//        //static void printArray(int[] kArr , string msg)
//        //{
//        //    foreach(int i in kArr)
//        //    {
//        //        Console.WriteLine("{0} : {1}", msg, i);
//        //    }
//        //}
//        //// ----- ENDOFFUNCTIONS -----

//        //int[] randomNumber = { 2, 4, 6, 5, 9 };
//        //printArray(randomNumber, "For Each");
//        //Array.Sort(randomNumber);
//        //printArray(randomNumber, "Sorted");
//        //Array.Reverse(randomNumber);
//        //printArray(randomNumber, "Reversed");
//        //Console.WriteLine("Index of 6 : {0}", Array.IndexOf(randomNumber, 6));

//        //int[] srcArray = { 2, 4, 7 , 9 , 10 };
//        //int[] dstArray = new int[10];
//        //int startInd = 3;
//        //int length = 4;
//        ////Array.Copy(srcArray, startInd, dstArray, 0, length);
//        ////printArray(dstArray, "copy");
//        ////srcArray.CopyTo(dstArray, startInd);
//        //// printArray(dstArray, "Copy To");
//        //Console.WriteLine("Greater than 5 : {0} ", Array.Find(srcArray, ));

//        //int i = 1;
//        //while (i <= 20)
//        //{   
//        //    i++;
//        //    if (i % 2 == 1)
//        //    {
//        //        continue;
//        //    }
//        //    Console.WriteLine(i);
//        //    if (i == 12)
//        //    {
//        //        break; 
//        //    }
//        //}

//        // ----- GUESS FUNCTION -----
//        //void guessNumber(int min , int max)
//        //{
//        //    Random randm = new Random();
//        //    int secretNum = randm.Next(min, max);
//        //    int guessedNum = 0;
//        //    Console.WriteLine("Secret Number : {0}", secretNum);
//        //    do {
//        //        Console.WriteLine("Guess a secret Number between {0} to {1} : ", min, max);
//        //        guessedNum = Convert.ToInt32(Console.ReadLine());

//        //    } while (guessedNum != secretNum);
//        //    Console.WriteLine("Guessed Successfully ! The Secret Number is {0}.", secretNum);
//        //}
//        //guessNumber(1, 20); 
//        // ---- END OF FUNCTION -----


//        // ---- DIVISION FUNCTION ----
//        //void doDivision(int dividend , int divisor)
//        //{
//        //    try
//        //    {
//        //        Console.WriteLine("{0} / {1} : {2}", dividend, divisor, dividend / divisor);
//        //    }
//        //    catch(DivideByZeroException exp)
//        //    {
//        //        Console.WriteLine("You can't divide by Zero. \n" + exp.GetType().Name+"\n"+exp.Message);
//        //    }
//        //    catch(Exception ex)
//        //    {
//        //        Console.WriteLine("An error occured.\n" + ex.GetType().Name + "\n" + ex.Message);
//        //    }
//        //    finally
//        //    {
//        //        Console.WriteLine("Cleaning up .");
//        //    }
//        //}
//        //doDivision(10, 000);
//        // ---- END OF FUNCTION ----


//        // ---- STRING BUILDER ----
//        //StringBuilder sb = new StringBuilder("Random Text");
//        //StringBuilder sb2 = new StringBuilder("More Stuff", 256);
//        //Console.WriteLine("Capacity : {0}", sb2.Capacity);
//        //Console.WriteLine("Length : {0}", sb2.Length);
//        //sb2.AppendLine("\nMore Important Text.");
//        //Console.WriteLine(sb2.ToString());

//        //CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
//        //string bestCust = "Harry Smith";
//        //sb2.AppendFormat(enUS, "Best Customer : {0} ", bestCust);
//        //Console.WriteLine(sb2.ToString());

//        //sb2.Replace("Stuff", "Texts.");
//        //Console.WriteLine(sb2.ToString());
//        //sb2.Clear();
//        //sb2.Append("Random Text");
//        //Console.WriteLine(sb.Equals(sb2));
//        //sb2.Insert(11, " has been added.");
//        //Console.WriteLine(sb2.ToString());
//        //sb2.Remove(11, 9);
//        //Console.WriteLine(sb2.ToString());
//        // ---- END ----


//        // ------- FUNCTION ------
//        //void doubleIT(int x ,out int solution)
//        //{
//        //    solution = x * 2;
//        //}
//        //int solution;
//        //doubleIT(15, out solution);
//        //Console.WriteLine("Double of 15 : {0}", solution);
//        // ------ END ------


//        //// ------ SWAP FUNCTION ------
//        //void swapNum ( ref int num1 , ref int num2)
//        //{
//        //    int temp = num1;
//        //    num1 = num2;
//        //    num2 = temp;
//        //}
//        //int num1 = 5 , num2 = 8;
//        //Console.WriteLine("Before Swap , num1 : {0}  & num2 : {1} .", num1, num2);
//        //swapNum ( ref  num1 , ref num2);
//        //Console.WriteLine("After Swap , num1 : {0}  & num2 : {1} .", num1, num2);
//        //// ------ END OF FUNCTION ------


//        //// ------ FUNCTION ------
//        //double getMoreSum ( params double[] nums)
//        //{
//        //    double sum = 0;
//        //    foreach( double d in nums )
//        //    {
//        //        sum += d;
//        //    }
//        //    return sum;
//        //}
//        //Console.WriteLine("1+2+3+4 = {0}",getMoreSum(1,2,3,4 ));
//        //// ------ END OF FUNCTION ------


//        //// ------ NAMED PARAMETERS ------
//        //void personAge(string name , int age)
//        //{
//        //    Console.WriteLine("The age of {0} is {1} . ", name, age);
//        //}
//        //personAge(age: 25, name: "Snakar");
//        //// ------ END -------

//        // // ------ METHOD OVERLOADING ------ < use this function outside the main function >
//        // static double GetSum(double x = 1, double y = 1)
//        // {
//        //     return x + y;
//        // }
//        //static double GetSum(string x = "1", string y = "1")
//        // {
//        //     double dbX = Convert.ToDouble(x);
//        //     double dbY = Convert.ToDouble(y);
//        //     return dbX + dbY;
//        // }
//        // // ------ END OF OVERLOADING ------
//        //// ------ CALLING METHOD OVERLOADING FUCNTIONS ------
//        // Console.WriteLine("5 + 3.4 : {0} ",GetSum(5, 3.4));
//        // Console.WriteLine("5 + 3.4 : {0} ",GetSum("5", "3.4"));


//        // ------ DATE TIME ------
//        //DateTime awesomeDateTime = new DateTime(1996, 11, 06);
//        //Console.WriteLine("Day of the week : {0} ", awesomeDateTime.DayOfWeek);
//        //awesomeDateTime = awesomeDateTime.AddDays(25);
//        //awesomeDateTime = awesomeDateTime.AddMonths(1);
//        //awesomeDateTime = awesomeDateTime.AddYears(3);
//        //Console.WriteLine("New Date : {0} ", awesomeDateTime.Date);

//        //TimeSpan lunchTime = new TimeSpan(2, 40, 0);
//        //lunchTime = lunchTime.Subtract(new TimeSpan(0, 30, 0));
//        //Console.WriteLine("New Time : {0}",lunchTime);
//        // ------ END OF DATETIME ------


//    ////    ------ENUMERATION------
//    ////    ---- outside the main function ----
//    //    enum CarColor : byte
//    //{
//    //    orange = 1,
//    //    blue, pink, black, red, white
//    //}

//    //static void paintCar(CarColor color)
//    //{
//    //    Console.WriteLine("The car was painted with {0} color with code {1}.", color, (int)color);
//    //}
//    ////     ---- end of function ----

//    //CarColor car1 = CarColor.red;
//    //CarColor car2 = CarColor.white;
//    //paintCar(car1);
//    //paintCar(car2);

//    //     ------ END OF ENUMERATION ------
//    }
    

//}
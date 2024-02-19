//using System;
//using System.Collections.Generic;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Diagnostics;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace LearnCSharp.Collections
//{
//    public class Program
//    {
//        static void Main()
//        {
//            #region ArrayList Code

//            //ArrayList aList = new ArrayList();
//            //aList.Add("Sankar");
//            //aList.Add(39);
//            //Console.WriteLine("Count : {0}", aList.Count);
//            //Console.WriteLine("Capacity : {0}", aList.Capacity);
//            //foreach(var item in aList) Console.Write($" {item} ");
//            //Console.WriteLine();

//            //ArrayList aList2 = new ArrayList();
//            //aList2.AddRange(new Object[] { "One", "Two", "Three" });
//            //foreach (var item in aList2) Console.Write($" {item} ");
//            //Console.WriteLine();

//            //aList.AddRange(aList2);
//            //foreach (var item in aList) Console.Write($" {item} ");
//            //Console.WriteLine();

//            //aList2.Sort();
//            //foreach (var item in aList2) Console.Write($" {item} ");
//            //Console.WriteLine();

//            //aList2.Reverse();
//            //foreach (var item in aList2) Console.Write($" {item} ");
//            //Console.WriteLine();

//            //aList.Insert(1, "Nepal");
//            //foreach (var item in aList) Console.Write($" {item} ");
//            //Console.WriteLine();

//            //aList.RemoveAt(0);
//            //foreach (var item in aList) Console.Write($" {item} ");
//            //Console.WriteLine();

//            //aList.RemoveRange(0, 2); // Removes 0th and 1st index element
//            //foreach (var item in aList) Console.Write($" {item} ");
//            //Console.WriteLine();

//            //Console.WriteLine("Three Index: {0}", aList.IndexOf("Three"));
//            //Console.WriteLine();

//            ////Converting ArrayList ot string Array
//            //string[] myArray = (string[])aList.ToArray(typeof(string));
//            ////Converting String Array to ArrayList
//            //string[] countries = { "Nepal", "India ", "China", "Malaysia" };
//            //ArrayList countriesArrList = new ArrayList();
//            //countriesArrList.AddRange(countries);
//            //foreach (var item in countriesArrList) Console.Write($" {item} ");
//            //Console.WriteLine();
//            #endregion

//            #region Dictionaries Code

//            //// Initializing the dictionary with some key-value pairs
//            //Dictionary<string, string> antonym = new Dictionary<string, string>
//            //{
//            //    {"Ubiquitous","Rare" },
//            //    { "Ephermeral","Permanent" },
//            //    { "Mellifluous","Dissonant" },
//            //    {"Pernicious","Beneficial" }
//            //};
//            //// Adding multiple key-value pairs after initialization
//            //antonym.Add("Hot", "Cold");
//            //antonym.Add("Top", "Bottom");
//            //antonym.Add("High", "Low");

//            ////Console.WriteLine("Count: {0}", antonym.Count);     // Count of Dictionary 
//            ////Console.WriteLine("ContainsKey(\"Hot\") : {0}", antonym.ContainsKey("Hot"));

//            ////Getting Values from Key
//            ////antonym.TryGetValue("Hot", out string? antonymString);
//            ////Console.WriteLine($"Hot : {antonymString}");
//            ////Console.WriteLine("High : {0}", antonym["High"]);
//            ////Console.WriteLine();

//            //// Using the indexer to add or update multiple entries
//            //antonym["Up"] = "Down";
//            //antonym["Positive"] = "Negative";
//            //antonym["Polite"] = "Rude";

//            //// Displaying the dictionary
//            //foreach (KeyValuePair<string, string> pair in antonym)
//            //    Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
//            //Console.WriteLine();

//            //// Adding multiple key-value pairs at once
//            //var moreAntonym = new Dictionary<string, string>
//            //{
//            //    {"Happy","Sad" },
//            //    { "Winner","Loser" },
//            //    { "Good", "Bad" }
//            //};
//            //antonym = antonym.Union(moreAntonym).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

//            //// Displaying the updated dictionary
//            //foreach (KeyValuePair<string, string> pair in antonym)
//            //    Console.WriteLine("{0} : {1}", pair.Key, pair.Value);

//            #endregion

//            #region Queue Code FIFO

//            //Queue queue = new Queue();
//            //queue.Enqueue(1);
//            //queue.Enqueue(2);
//            //queue.Enqueue(3);
//            //queue.Enqueue(4);
//            //Console.WriteLine("1 in Queue : {0}", queue.Contains(1));
//            //Console.WriteLine("Remove : {0}", queue.Dequeue());
//            //Console.WriteLine("Peek 1 : {0}",queue.Peek());

//            ////Converting queue to array
//            //object[] numArray = queue.ToArray();
//            ////Displaying queue using Join
//            //Console.WriteLine(String.Join(",", numArray));
//            ////Displaying queue using foreach loop
//            //foreach(object o in queue) 
//            //    Console.WriteLine("Queue : {0}",o);
//            //queue.Clear();
//            #endregion

//            #region Stack Code
//            //Stack stack = new Stack();
//            //stack.Push(1);
//            //stack.Push(2);
//            //stack.Push(3);
//            //stack.Push(4);
//            //Console.WriteLine("Peek1 : {0}", stack.Peek());
//            //Console.WriteLine("Pop1 : {0}", stack.Pop());
//            //Console.WriteLine("Contains 1 : {0}", stack.Contains(1));

//            //object?[] numArray2 = stack.ToArray();
//            //Console.WriteLine(String.Join(",", numArray2));

//            //foreach (object o in stack)
//            //    Console.WriteLine($"Stack : {o}");


//            #endregion

//            #region Generics Code1

//            //GenericsList<string> countryList = new GenericsList<string>();
//            //countryList.AddItem("Nepal");
//            //countryList.AddItem("China");
//            //countryList.AddItem("India");

//            //for(int i=0; i < countryList.Length; i++) 
//            //    Console.WriteLine("Country index{0} : {1}",i,countryList.GetItem(i));
//            //Console.WriteLine();


//            //GenericsList<int> intList = new GenericsList<int> ();
//            //intList.AddItem(1);
//            //intList.AddItem(2);
//            //intList.AddItem(3);
//            //intList.AddItem(4);
//            //for(int i=0; i< intList.Length;i++)
//            //    Console.WriteLine("intList index{0} : {1}", i, intList.GetItem(i));

//            #endregion

//            #region Generics Code2
//            //List<Animal> animalList = new List<Animal>();
//            //List<int> numList = new List<int>();
//            //numList.Add(34);
//            //animalList.Add(new Animal() { Name = "Monkey" });
//            //animalList.Add(new Animal() { Name = "Tiger" });
//            //animalList.Add(new Animal() { Name = "Lion" });

//            //animalList.Insert(1, new Animal() { Name = "Leopard" });
//            //animalList.RemoveAt(1);
//            //Console.WriteLine("Number of Animals : {0}", animalList.Count());
//            //foreach (Animal a in animalList)
//            //    Console.WriteLine("Animal : {0}", a.Name);


//            //int x = 5, y = 4;
//            //Animal.GetSum<int>(ref x, ref y);

//            //string strx = "5", stry = "4";
//            //Animal.GetSum<string>(ref strx, ref stry);

//            //Rectangle<int> rec1 = new Rectangle<int>(20, 50);
//            //Console.WriteLine(rec1.GetArea());

//            //Rectangle<string> rec2 = new Rectangle<string>("20", "50");
//            //Console.WriteLine(rec2.GetArea());
//            #endregion

//            #region Delegates1 Code
//            //Defining delegates
//            //Arithmetic add, sub, addSub;
//            //add = new Arithmetic(Add);
//            //sub = new Arithmetic(Subtract);
//            //addSub = add + sub;


//            //Console.WriteLine($"Add {6} & {10}");
//            //add(6, 10);

//            //Console.WriteLine($"Add & Subtract {10} & {4}");
//            //addSub(10, 4);



//            #endregion

//            #region Delegates2 Code 
//            // Defining  Delegates
//            //doubleIt dbLit = x => x * 2;
//            //Console.WriteLine($"5 * 2 = {dbLit(5)}");

//            //List<int> numList = new List<int> { 1, 2, 6, 3, 9, 5 ,4 , 14};
//            //var evenList = numList.Where(a => a % 2 == 0).ToList();
//            //foreach (var j in evenList)
//            //    Console.Write(j+"\t");
//            //Console.WriteLine();

//            //var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();
//            //foreach (var j in rangeList)
//            //    Console.Write(j+"\t");
//            //Console.WriteLine();

//            //List<int> flipList = new List<int>();
//            //int i = 0;
//            //Random rnd = new Random();
//            //while (i < 100)
//            //{
//            //    flipList.Add(rnd.Next(1,3));
//            //    i++;
//            //}
//            //Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count());
//            //Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count());

//            //var nameList = new List<string> { "Sankar", "Ram", " Buddhha", "Sakar" };
//            //var snameList = nameList.Where(x => x.StartsWith("S"));
//            //foreach( var m in snameList)
//            //    Console.WriteLine(m);

//            //var one2ten = new List<int>();
//            //one2ten.AddRange(Enumerable.Range(1, 10));
//            //var squares = one2ten.Select(x => x * x);
//            //foreach (var l in squares)
//            //    Console.WriteLine(l);

//            //var list1 = new List<int> { 2, 3, 5 };
//            //var list2 = new List<int> { 1, 4, 7 };
//            //var sumList = list1.Zip(list2,(x,y) => x + y);
//            //foreach(var x in sumList)
//            //    Console.WriteLine(x); // outputs : 3    7   12

//            //var numList = new List<int> { 1, 2, 3, 4, 5, 4 , 2 , 3 ,6, 7 };
//            //var numList2 = new List<int> { 3 , 2 };
//            //Console.WriteLine("Sum : {0}",numList.Aggregate((a,b) => a + b));
//            //Console.WriteLine("Average : {0}", numList.AsQueryable().Average());
//            //Console.WriteLine("All > 3 : {0}", numList.All(x => x > 3));
//            //Console.WriteLine("Any > 3 : {0}", numList.Any(x => x > 3));
//            //Console.WriteLine("All < 10 : {0}", numList.All(x => x < 10));
//            //Console.WriteLine("Distinct : {0}", string.Join(",", numList.Distinct()));
//            //Console.WriteLine("Without Distinct : {0}", string.Join(",", numList));
//            //Console.WriteLine("Except numList2 : {0}", string.Join(",", numList.Except(numList2)));
//            //Console.WriteLine("Intersect numList2 : {0}", string.Join(",", numList.Intersect(numList2)));
//            #endregion

//            #region IEnumerable Code
//            //AnimalFarm myAnimals = new();
//            //myAnimals[0] = new Animal("Goat");
//            //myAnimals[1] = new Animal("Sheep");
//            //myAnimals[2] = new Animal("Cow");
//            //myAnimals[3] = new Animal("Buffalo");
//            //foreach (Animal i in myAnimals)
//            //    Console.WriteLine(i.Name);
//            #endregion

//            #region Operator Overloading Code
//            //Box box1 = new Box(2, 3, 4);
//            //Box box2 = new Box(1, 2, 3);
//            //Box box3 = box1 + box2;

//            //Console.WriteLine($"Box3 : {box3}");
//            //Console.WriteLine("Box3 int : {0}", (int)box3);

//            //Box box4 = (Box)4;
//            //Console.WriteLine($"Box4 : {box4}");
//            #endregion

//            #region Anonymous code
//            //var individual = new { Name = "Flower", Group = "Bunch" };
//            ////Console.WriteLine("{0} of {1}", individual.Group, individual.Name);

//            //var individuals = new[] { individual
//            //,new { Name = "Sheep",Group = "Herd" },
//            //new { Name = "Wolves",Group = "Pack" },
//            //new { Name = "Lion",Group = "Pride" },
//            //new { Name = "Bees",Group = "Hive" },
//            //new { Name = "Ants",Group = "Colony" },
//            //new { Name = "Fish",Group = "School" },
//            //};
//            //foreach(var i in individuals)
//            //    Console.WriteLine("{0} of {1}", i.Group, i.Name);
//            #endregion

//            #region Language Integrated Query (LINQ) Code
//            //string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Charlie D. Barkin", "Lassie", "Snoopy" };
//            //var dogSpaces = from dog in dogs
//            //                where dog.Contains(" ")
//            //                orderby dog descending
//            //                select dog;
//            //foreach (var i in dogSpaces)
//            //    Console.WriteLine(i);

//            //Query Function
//            //int[] intArray = QueryIntArray();
//            //foreach (int num in intArray)
//            //    Console.WriteLine(num);
//            #endregion

//            #region Language Integrated Query (LINQ) Code2
//            //ArrayList famAnimal = new()
//            //{
//            //    new Animal( name:"Heidi",weight:18,height:2.8 , animalId:1),
//            //    new Animal( name:"German Shepherd",weight:77,height:26, animalId:2),
//            //    new Animal( name:"Chihuahua",weight:7,height:4.4, animalId:3),
//            //    new Animal { Name = "Shrek", Height = 4 , Weight = 130,AnimalId = 2} ,
//            //    new Animal { Name = "Pug", Height = 12 , Weight = 6 ,AnimalId = 1} ,
//            //    new Animal { Name = "Beagle", Height = 15 , Weight = 23 ,AnimalId = 2} ,
//            //    new Animal { Name = "Congo", Height = 3.8 , Weight = 90 ,AnimalId = 3}
//            //};

//            //Owner[] owners = new[]
//            //{
//            //    new Owner { Name = "Sally Smith", OwnerID = 1 },
//            //    new Owner { Name = "Doug Parks", OwnerID = 2 },
//            //    new Owner { Name = "Paul Brooks", OwnerID = 3 },
//            //};
//            //var famAnimalEnum = famAnimal.OfType<Animal>(); // Making Enumerable 

//            ////var nameHeight = from a in famAnimalEnum
//            ////                 select new
//            ////                 {
//            ////                     a.Name,
//            ////                     a.Height
//            ////                 };
//            ////Array arrNameHeight = nameHeight.ToArray();

//            ////foreach (var i in arrNameHeight)
//            ////    Console.WriteLine(i.ToString());

//            ////var smAnimals = from animal in famAnimalEnum
//            ////                where animal.Weight <= 90
//            ////                orderby animal.Name
//            ////                select animal;
//            ////foreach (var animal in smAnimals)
//            ////    Console.WriteLine(animal.ToString());

//            ////var bigDogs = from dog in famAnimalEnum
//            ////              where (dog.Weight > 70) && (dog.Height > 25)
//            ////              orderby dog.Name
//            ////              select dog;
//            ////foreach (var dog in bigDogs)
//            ////    Console.WriteLine(dog.ToString());


//            ////var inerjoin = from animal in famAnimalEnum
//            ////               join owner in owners 
//            ////               on animal.AnimalId
//            ////               equals owner.OwnerID
//            ////               select new
//            ////               {
//            ////                   OwnerName = owner.Name,
//            ////                   AnimalName = animal.Name
//            ////               };
//            ////foreach (var i in inerjoin)
//            ////    Console.WriteLine(i);


//            //var groupJoin = from owner in owners
//            //                orderby owner.OwnerID
//            //                join animal in famAnimalEnum on owner.OwnerID
//            //                equals animal.AnimalId into ownerGroup
//            //                select new
//            //                {
//            //                    Owner = owner.Name ,
//            //                    Animals = from owner2 in ownerGroup
//            //                              orderby owner2.Name
//            //                              select owner2                            
//            //                };
            

//            //foreach (var ownerGroup in groupJoin)
//            //{
//            //    int totalAnimals = 0;
//            //    Console.WriteLine(ownerGroup.Owner);
//            //    foreach (var animal in ownerGroup.Animals)
//            //    {
//            //        Console.Write(++totalAnimals);
//            //        Console.WriteLine(") {0}", animal.Name);
//            //    }
//            //}

//            #endregion


//        }
//        #region Struct Rectangle code

//        public struct Rectangle<T>
//        {
//            private T length;
//            private T width;

//            public T Length { get { return length; } set { length = value; } }
//            public T Width { get { return width; } set { width = value; } }

//            public Rectangle(T w, T l)
//            {
//                width = w;
//                length = l;
//            }

//            public string GetArea()
//            {
//                double dblLength = Convert.ToDouble(Length);
//                double dblWidth = Convert.ToDouble(Width);
//                return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
//            }
//        }
//        #endregion

//        #region Delegates declaration code
//        /*
//         * Delegates are type-safe function pointers, essentially representing a reference to a method. They are used to create and pass methods as parameters, enabling a more flexible and extensible code structure.
//         */

//        public delegate void Arithmetic(double num1, double num2);
//        delegate double doubleIt(double val);
//        public static void Add(double num1, double num2)
//        {
//            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//        }
//        public static void Subtract(double num1, double num2)
//        {
//            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//        }
//        #endregion

//        #region Query Function
//        static int[] QueryIntArray()
//        {
//            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
//            var gt20 = from num in nums
//                       where num > 20
//                       orderby num
//                       select num;
//            foreach (int num in gt20)
//                Console.WriteLine(num);
//            Console.WriteLine($"Get Type : {gt20.GetType()}");

//            var listGT20 = gt20.ToList<int>();
//            var arrayGT20 = gt20.ToArray();

//            nums[0] = 40;
//            foreach (int num in gt20)
//                Console.WriteLine(num);
//            return arrayGT20;
//        }
//        #endregion
//    }
//}

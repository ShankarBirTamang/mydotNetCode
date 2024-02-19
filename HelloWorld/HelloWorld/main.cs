//using System;
//using System.Globalization;
//using System.Reflection;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using LearnCSharp;
//using LearnCSharp.abstraction;
//using LearnCSharp.Interface;
//using LearnCSharp.Interface3;


//internal class Program
//{
//    public static void Main()
//    {

//        // ---- INHERITANCE ----
//        //Person p1 = new Person(name:"Sankar",age:10);
//        //p1.showInfo();
//        //p1.Ages = 15;
//        //p1.showInfo();
//        //p1.Names = "Jangbu";
//        //p1.showInfo();

//        //Person p2 = new Person(40);
//        //p2.Names = "Hari";
//        //p2.showInfo();

//        //Person p3 = new Person("Ramesh");
//        //p3.Ages = 20;
//        //p3.showInfo();

//        //Student s1 = new Student(5,"sankar",20);
//        //s1.showInfo();
//        //Student s2 = new Student(name: "Jangbu");
//        //s2.Ages = 20;
//        //s2.Rollno = 12;
//        //s2.showInfo();
//        //s2.setLocation("Nepal");
//        //s2.getLocation();

//        // ---- ABSTRACTION ----
//        //Circle myCircle = new Circle(5);
//        //myCircle.getInfo();
//        //Rectangle rect = new Rectangle(5, 4);
//        //rect.getInfo();

//        //Shape[] shapes = { new Circle(6), new Rectangle(4, 6) };
//        //foreach (Shape shape in shapes)
//        //{
//        //    //shape.getInfo();
//        //    Console.WriteLine("{0} Area : {1}", shape.Name, shape.getArea());
//        //    Circle testCirc = shape as Circle;
//        //    if(testCirc == null)
//        //    {
//        //        Console.WriteLine("This is not a circle.");
//        //    }
//        //    if(shape is Circle)
//        //    {
//        //        Console.WriteLine("This is not a rectangle.");
//        //    }
//        //}
//        // ------ END OF ABSTRACTION ------


            
//        /// ------ INTERFACE 1 ------ ///
//        //Vehicle tesla = new Vehicle("Tesla", 4, 300);
//        //if(tesla is IDrivable)
//        //{
//        //    tesla.Move();
//        //    tesla.Stop();
//        //}
//        //else
//        //{
//        //    Console.Write("The {0} cannot be driven .", tesla.Brand);
//        //}
//        /// ------ END OF INTERFACE1 ------ ///



//        /// ------ INTERFACE 2 ------ ///
//        //IElectronicDevice myTV = TVRemote.GetDevice();
//        //PowerButton powerButton = new PowerButton(myTV);
//        //powerButton.Execute();
//        //for(int i = 1; i<= 5;i++) myTV.VolumeUp();
//        //myTV.VolumeDown();
//        //powerButton.Undo();
//        /// ------ END OF INTERFACE2 ------ ///



//        /// ------ INTERFACE 3 ------ ///
//        //AngelWarrior hanuman = new AngelWarrior("Hanuman", 75, 20, 10,50);
//        //Warrior rawan = new Warrior("Rawan",100,30,10);
//        //Battle.StartFight(hanuman, rawan);       
//        /// ------ END OF INTERFACE3 ------ ///
//    }
//}


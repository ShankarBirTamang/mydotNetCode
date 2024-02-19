using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LearnCSharp.Directories
{
    public class Program
    {
        public static void Main()
        {
            #region DirectoryInfo Code
            //DirectoryInfo currDir = new DirectoryInfo(".");
            //DirectoryInfo dereksDir = new DirectoryInfo(@"C:\Users\user");
            //Console.WriteLine(dereksDir.FullName);
            //Console.WriteLine(dereksDir.Name);
            //Console.WriteLine(dereksDir.Parent);
            //Console.WriteLine(dereksDir.Attributes);
            //Console.WriteLine(dereksDir.CreationTime);

            //DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\user\C#Data");
            //dataDir.Create();
            ////Directory.Delete(@"C:\Users\user\C#Data");
            //string[] customers =
            //{
            //    "Jung bahadur Thapa",
            //    "Amar Singh Thapa" ,
            //    "Prithvi Narayan Shah"
            //};
            //string textFilePath = @"C:\Users\user\C#Data\testfile1.txt";
            //File.WriteAllLines(textFilePath, customers);

            //foreach(string cust in File.ReadAllLines(textFilePath))
            //{
            //    Console.WriteLine("Customer : {0}",cust);
            //}
            //DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\user\C#Data");
            //FileInfo[] txtfiles = myDataDir.GetFiles("*.txt",SearchOption.AllDirectories);
            //Console.WriteLine("Matches : {0}", txtfiles.Length);
            //foreach(FileInfo file in txtfiles)
            //{
            //    Console.WriteLine(file.Name);
            //    Console.WriteLine(file.Length);
            //}
            #endregion

            #region FileStream Code
            //string textFilePath2 = @"C:\Users\user\C#Data\testfile2.txt";
            //FileStream fs = File.Open(textFilePath2,FileMode.Create);
            //string randString = "This is a random string";
            //byte[] rsByteArray = Encoding.Default.GetBytes(randString);
            //fs.Write(rsByteArray, 0, rsByteArray.Length);
            //fs.Position = 0;

            //byte[] fileByteArray = new byte[rsByteArray.Length];
            //for(int i = 0;i < rsByteArray.Length; i++)
            //{
            //    fileByteArray[i] = (byte)fs.ReadByte();
            //}
            //Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            //fs.Close();
            #endregion

            #region StreamWriter & StreamReader Code
            //string textFilePath3 = @"C:\Users\user\C#Data\testfilePath3.txt";
            //StreamWriter sw = new StreamWriter(textFilePath3);
            //sw.Write("This is a random");
            //sw.WriteLine(" Sentence");
            //sw.WriteLine("This is another sentence.");
            //sw.Close();

            //StreamReader sr = new StreamReader(textFilePath3);
            //Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));
            //Console.WriteLine("1st String : {0}", sr.ReadLine());
            //Console.WriteLine("EveryThing Else : {0}", sr.ReadToEnd());
            //sr.Close();

            #endregion

            #region BinaryWriter & BinaryReader Code
            //string textFilePath4 = @"C:\Users\user\C#Data\testfile4.txt";
            //FileInfo dataFile = new FileInfo(textFilePath4);
            //BinaryWriter bw = new BinaryWriter(dataFile.OpenWrite());
            //string randText = "Random Text";
            //int myAge = 27;
            //double height = 6.25;
            //bw.Write(randText);
            //bw.Write(myAge);
            //bw.Write(height);
            //bw.Close();

            //BinaryReader br = new BinaryReader(dataFile.OpenRead());
            //Console.WriteLine(br.ReadString());
            //Console.WriteLine(br.ReadInt32());
            //Console.WriteLine(br.ReadDouble());
            //br.Close();
            #endregion

           

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Collections
{
    /*
     Definition: Generics allow you to create classes, interfaces, and methods with placeholders for the data types they work with. This enables you to write code that can work with any data type   without sacrificing type safety.
     */
    public class GenericsList<T>
    {
        private List<T> list = new List<T>();
        public void AddItem(T item) { list.Add(item); }
        public T GetItem(int index) => list[index];
        
        //public int GetLenth() => list.Count;
        public int Length {  get { return list.Count; } }
    }
}

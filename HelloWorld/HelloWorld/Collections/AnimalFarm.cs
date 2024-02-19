using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Collections
{
    class AnimalFarm : IEnumerable
    { 
        private List<Animal> animalList = new();
        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }
        public AnimalFarm() { }

        public Animal this[int index]
        {
            get { return animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        public int Count
        {
            get { return animalList.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }
}

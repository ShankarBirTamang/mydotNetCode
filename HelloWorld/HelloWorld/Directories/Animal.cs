﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Directories
{
    [Serializable()]
    public class Animal : ISerializable
    {   
        public string Name {  get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        //public Animal() { }
        public Animal(string name="No name",double weight = 0 , double height = 0)
        {
            Name = name; Weight = weight; Height = height;
        }
        public override string ToString()
        {
            return String.Format("{0} weighs {1} lbs and is {2} inches tall.",Name , Weight,Height);
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
            info.AddValue("AnimalID", AnimalID);
        }
        public Animal(SerializationInfo info,StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
            AnimalID = (int)info.GetValue("AnimalID", typeof(int));
        }
    }
}

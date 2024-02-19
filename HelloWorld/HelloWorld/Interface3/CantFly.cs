using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Interface3
{
    class CantFly : Fly
    {
        public string fly()
        {
            return "Fails at Flying.";
        }
    }
}

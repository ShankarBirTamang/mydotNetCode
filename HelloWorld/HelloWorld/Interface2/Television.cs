using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Interface
{
    internal class Television : IElectronicDevice
    {
        public int Volume { get; set; } = 0;
        public void Off()
        {
            Console.WriteLine("The TV is OFF!");
        }

        public void On()
        {
            Console.WriteLine("The TV is ON!");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine("TV Volume : {0}", Volume);
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine("TV Volume : {0}", Volume);
        }
    }
}

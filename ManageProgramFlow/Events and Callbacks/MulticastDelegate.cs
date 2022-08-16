using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.Events_and_Callbacks
{
    public class MulticastDelegate
    {
        public void MethodOne()
        {
            Console.WriteLine("Called method one");
        }
        
        public void MethodTwo()
        {
            Console.WriteLine("Called method two");
        }

        public delegate void Del();

        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d(); //prints methods text
        }
    }
}

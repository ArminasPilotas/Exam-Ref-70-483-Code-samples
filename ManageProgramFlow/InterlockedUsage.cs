using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    public class InterlockedUsage
    {
        public static void InterlockedClassExample() //method uses Interlocked class for atomic execution
        {
            int n = 0;

            var increment = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            increment.Wait();
            Console.WriteLine(n);
        }
    }
}

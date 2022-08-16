using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ConcurrentCollections
{
    public class ConcurrentBagUsage
    {
        public static void ConcurrentBagExample()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            foreach (int value in Enumerable.Range(1, 10))
            {
                bag.Add(value);
            }

            int result;

            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }

            if (bag.TryPeek(out result))
            {
                Console.WriteLine($"Next item in bag is {result}");
            }
        }
    }
}

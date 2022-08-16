using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ConcurrentCollections
{
    public class ConcurrentDictionaryUsage
    {
        public static void ConcurrentDictionaryExample()
        {
            var dictionary = new ConcurrentDictionary<string, int>();

            if (dictionary.TryAdd("a", 1))
            {
                Console.WriteLine("Added to dictionary");
            }

            if (dictionary.TryUpdate("a", 2, 1))
            {
                Console.WriteLine("1 updated to 2");
            }

            int r1 = dictionary.AddOrUpdate("a", 3, (s, i) => i * 2);
            int r2 = dictionary.GetOrAdd("a", 3);
        }
    }
}

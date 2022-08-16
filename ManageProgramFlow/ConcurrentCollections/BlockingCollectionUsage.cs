using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.ConcurrentCollections
{
    public class BlockingCollectionUsage
    {
        public static void BlockCollection() //terminates when no data entry exist
        {
            BlockingCollection<string> col = new BlockingCollection<string>();

            Task read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take()); //removed from collection
                }
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrEmpty(s)) break;
                    col.Add(s); //adds string to collection
                }
            });

            write.Wait();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    public class BackgroundThread
    {
        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Background Thread iterating: {i}");
            }
        }

        public void MainMethod()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod))
            {
                IsBackground = true
                //IsBackground = false - foreground thread
            };
            t.Start();
        }
    }
}

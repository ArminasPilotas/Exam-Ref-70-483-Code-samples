using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTAThread
{
    public static class ThreadStaticAttribute
    {
        //[ThreadStatic] attribute makes property static for every thread
        public static int _field;
        public static void MainMethod()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();
            new Thread(() =>
            {
                for (int a = 0; a < 10; a++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();
            Console.ReadKey();
        }
    }
}

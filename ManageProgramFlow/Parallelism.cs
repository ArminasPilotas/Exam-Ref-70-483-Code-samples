using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    public class Parallelism
    {
        public void ParallelFor()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });
        }

        public void ParallelBreak()
        {
            Parallel.For(0, 100, (int i, ParallelLoopState state) =>
            {
                if (i == 50)
                {
                    Console.WriteLine($"Breaking loop at {i}");
                    state.Break();
                }
            });
        }
    }
}

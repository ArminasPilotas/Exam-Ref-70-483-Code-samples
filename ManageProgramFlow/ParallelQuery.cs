using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    public class ParallelQuery
    {
        public static void UnorderedParallelQuery()
        {
            var numbers = Enumerable.Range(0, 10);

            var parallelResult = numbers.AsParallel()
                .Where(x => x % 2 == 0)
                .ToArray();

            foreach(int value in parallelResult)
                Console.WriteLine(value);
        }

        public static void OrderedParallelQuery()
        {
            var numbers = Enumerable.Range(0, 10);

            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(x => x % 2 == 0)
                .ToArray();

            foreach (int value in parallelResult)
                Console.WriteLine(value);
        }

        public static void OrderedParallelQuery(int degreeOfParallelism) // max 64 processors
        {
            var numbers = Enumerable.Range(0, 10000);

            var parallelResult = numbers.AsParallel()
                .WithDegreeOfParallelism(degreeOfParallelism)
                .AsOrdered()
                .Where(x => x % 2 == 0)
                .ToArray();

            foreach (int value in parallelResult)
                Console.WriteLine(value);
        }

        public static void SequentialParallelQuery()
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(x => x % 2 == 0).AsSequential();

            foreach (int value in parallelResult.Take(5))
                Console.WriteLine(value);
        }

    }
}

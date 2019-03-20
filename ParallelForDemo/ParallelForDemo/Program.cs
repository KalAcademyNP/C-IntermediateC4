using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SequentialFor();
            //ParallelFor();
            ThreadingThruTask();
        }

        static void SequentialFor()
        {
            Console.WriteLine("Sequential For...");
            var watch = Stopwatch.StartNew();
            for (var i = 2; i < 20; i++)
            {
                Console.WriteLine($"root: {i}, sumrootN: {SumRootN(i)}");
            }
            Console.WriteLine($"Time taken: {watch.ElapsedMilliseconds}");
        }

        static void ParallelFor()
        {
            Console.WriteLine("Parallel For...");
            var watch = Stopwatch.StartNew();
            Parallel.For(2, 20, (i) =>
            {
                Console.WriteLine($"root: {i}, sumrootN: {SumRootN(i)}");
            });
            Console.WriteLine($"Time taken: {watch.ElapsedMilliseconds}");

        }

        static double SumRootN(int root)
        {
            double result = 0;
            for(var i = 1; i < 10000000; i++)
            {
                result += Math.Exp(Math.Log(i) / root);
            }
            return result;
        }


        static void ThreadingThruTask()
        {
            var t1 = new Task(() =>
            {
                Console.WriteLine("Hello world!");

            });
            t1.Start();
            Console.WriteLine("I am moving on...");

        }

 
    }
}

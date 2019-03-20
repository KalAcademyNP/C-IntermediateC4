using System;
using System.Threading;

namespace SemaphoreDemo
{
    class Program
    {
        static SemaphoreSlim sem = new SemaphoreSlim(3);

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
                new Thread(Enter).Start(i);
        }

        static void Enter(object id)
        {
            Console.WriteLine(id + " wants to enter");
            sem.Wait();
            Console.WriteLine(id + " is in!");
            Thread.Sleep(1000 * (int)id);
            Console.WriteLine(id + " is leaving");
            sem.Release();
        }
    }
}

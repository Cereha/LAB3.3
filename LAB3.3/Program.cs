using System;
using System.Diagnostics;
using System.Threading;

namespace LAB3._3
{
    class Program
    {
        private static Semaphore _semaphore = new Semaphore(3, 3, "LAB3._3");
        static void Main(string[] args)
        {
            if (_semaphore.WaitOne(1000))
            {
                Console.WriteLine("IM Alive");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                _semaphore.Release();
                _semaphore.Dispose();
            }
            else
            {
                Console.WriteLine("Cannot obtain semaphore");
            }
        }
    }
}

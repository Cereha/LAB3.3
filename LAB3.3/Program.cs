using System;

namespace LAB3._3
{
    class Program
    {
        private static Semaphore semaphore = new Semaphore(3, 3, "LAB3._3");
        static void Main(string[] args)
        {
            if (_semaphor.WaitOne(1000))
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

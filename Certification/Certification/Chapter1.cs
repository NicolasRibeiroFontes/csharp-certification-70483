using System;
using System.Threading;

namespace Certification
{
    public class Chapter1
    {
        public static void Run()
        {
            Console.WriteLine("Chapter 1");
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Workingona thread from threadpool");
            });

        }
    }
}

using System;
using System.Threading;

namespace Certification
{
    public class Chapter1
    {

        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc:{ 0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Run()
        {
            Console.WriteLine("Chapter 1");
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() => {
                while (!stopped) {
                    Console.WriteLine("Running..."); Thread.Sleep(1000);
                }
            }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            Console.WriteLine("Finish");
            t.Join();
        }
    }
}


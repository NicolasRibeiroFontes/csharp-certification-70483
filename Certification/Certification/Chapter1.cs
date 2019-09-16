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
                Console.WriteLine("ThreadProc:{0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Run()
        {
            Console.WriteLine("Chapter 1");
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}


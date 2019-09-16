using System;
using System.Threading;

namespace Certification
{
    public class Chapter1
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            return Thread.CurrentThread.ManagedThreadId;
        });
        public static void Run()
        {
            Console.WriteLine("Chapter 1");
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("ThreadA:{0}", x);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("ThreadB:{0}", x);
                }
            }).Start();
        }
    }
}

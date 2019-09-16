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

        [ThreadStatic]
        public static int _field;
        public static void Run()
        {
            Console.WriteLine("Chapter 1");
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("ThreadA:{0}", _field);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("ThreadB:{0}", _field);
                }
            }).Start();
        }

    }
}

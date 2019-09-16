using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Certification
{
    public class Chapter1
    {
        public static void Run()
        {
            Console.WriteLine("Chapter 1");
            Parallel.For(0, 10, i => { Thread.Sleep(1000); });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i => { Thread.Sleep(1000); });

        }
    }
}

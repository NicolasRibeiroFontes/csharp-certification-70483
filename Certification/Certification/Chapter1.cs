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
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) => {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
                return;
            });


        }
    }
}

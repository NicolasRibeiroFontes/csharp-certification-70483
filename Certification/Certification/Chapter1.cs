using System;
using System.Threading.Tasks;

namespace Certification
{
    public class Chapter1
    {
        public static void Run()
        {
            Console.WriteLine("Chapter 1");
            Task<int> t = Task.Run(() => {
                return 42;
            }).ContinueWith((i) => {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result); // Displays 84


        }
    }
}

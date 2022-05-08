using System;
using FizzBuzz;
using ViceSoftware.Services;

namespace ViceSoftware // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzzer();
            var s = new ViceSoftware.Services.PrimeService();
            var result = fb.doTheFizzBuzz(args, new Func<int, string>[]{s.IsPrime});
            foreach(var str in result) {
                Console.Write(str + "\n");
            }
        }
    }
}
using System;

namespace ViceSoftware // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args) {
                var input = int.Parse(arg);
                var match = false;

                if (input%3 == 0) {
                    Console.Write("Fizz");
                    match = true;
                } 
                
                if (input%5 == 0) {
                    Console.Write("Buzz");
                    match = true;
                } 
                
                if (!match) {
                    Console.Write(input);
                }

                Console.Write("\n");
            }

            Console.WriteLine("Messages processed: " + args.Length);
        }
    }
}
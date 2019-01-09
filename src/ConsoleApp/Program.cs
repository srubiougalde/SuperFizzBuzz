using System;
using Headspring.FizzBuzz;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzz = new ClassicFizzBuzz();
            var result = fizzbuzz.Evaluate(2, 35); 
            // var result = fizzbuzz.Evaluate(-35, -2); 
            // var result = fizzbuzz.Evaluate(1, 1000000000);

            Console.WriteLine("{0}", result);
        }
    }
}

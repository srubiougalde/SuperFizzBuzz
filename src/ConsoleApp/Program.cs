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

            result.ForEach(i => Console.WriteLine(i));         
        }
    }
}

using System;
using System.Collections.Generic;
using Headspring.FizzBuzz;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicFizzBuzz();
            SuperFizzBuzz();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void ClassicFizzBuzz()
        {
            var factory = new ClassicFizzBuzzFactory();
            var fizzbuzz = factory.GetFizzBuzz();
            var result = fizzbuzz.Evaluate(1, 100); 

            Console.WriteLine("{0}\n", result);
        }

        static void SuperFizzBuzz()
        {
            var tokens = new List<KeyValuePair<int, string>>();
            tokens.Add(new KeyValuePair<int, string>(3, "Fizz"));
            tokens.Add(new KeyValuePair<int, string>(7, "Buzz"));
            tokens.Add(new KeyValuePair<int, string>(38, "Bazz"));

            var factory = new SuperFizzBuzzFactory(tokens);
            var fizzbuzz = factory.GetFizzBuzz();
            var result = fizzbuzz.Evaluate(-12, 145); 

            Console.WriteLine("{0}\n", result);
        }
    }
}

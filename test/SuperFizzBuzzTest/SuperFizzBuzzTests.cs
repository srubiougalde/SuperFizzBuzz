using NUnit.Framework;
using System.Collections.Generic;
using Headspring.FizzBuzz;

namespace Headspring.FizzBuzzTests
{
    [TestFixture]
    public class SuperFizzBuzzTests
    {
        [TestCase(10, 1, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz")]
        public void Should_Evaluate_Input_Not_In_Incremental_Sequence(int a, int b, string r) {
            var FizzBuzz = new SuperFizzBuzz();
            var result = FizzBuzz.Evaluate(a, b);
            Assert.That(r, Is.EqualTo(result.ToString()));
        }

        [TestCase(1, 10, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz")]
        public void Should_Evaluate_Classic_FizzBuzz_With_Default_Constructor(int a, int b, string r)
        {
            var FizzBuzz = new SuperFizzBuzz();
            var result = FizzBuzz.Evaluate(a, b);
            Assert.That(r, Is.EqualTo(result.ToString()));
        }

        [TestCase(-10, 0, "Buzz,Fizz,-8,-7,Fizz,Buzz,-4,Fizz,-2,-1,FizzBuzz")]
        public void Should_Evaluate_Negative_Numbers(int a, int b, string r)
        {
            var FizzBuzz = new SuperFizzBuzz();
            var result = FizzBuzz.Evaluate(a, b);
            Assert.That(r, Is.EqualTo(result.ToString()));
        }

        [TestCase(1, 10, "1,2,Fizz,4,5,Fizz,Buzz,8,Fizz,10")]
        [TestCase(33, 40, "Fizz,34,Buzz,Fizz,37,Bazz,Fizz,40")]
        [TestCase(798, 798, "FizzBuzzBazz")]
        public void Should_Evaluate_Using_Tokens(int a, int b, string r)
        {
            var tokens = new List<KeyValuePair<int, string>>();
            tokens.Add(new KeyValuePair<int, string>(3, "Fizz"));
            tokens.Add(new KeyValuePair<int, string>(7, "Buzz"));
            tokens.Add(new KeyValuePair<int, string>(38, "Bazz"));

            var FizzBuzz = new SuperFizzBuzz(tokens);
            var result = FizzBuzz.Evaluate(a, b);
            Assert.That(r, Is.EqualTo(result.ToString()));
        }
    }
}
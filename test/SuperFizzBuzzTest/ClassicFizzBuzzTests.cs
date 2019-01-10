using NUnit.Framework;
using Headspring.FizzBuzz;

namespace Headspring.FizzBuzzTests
{
    [TestFixture]
    public class ClassicFizzBuzzTests
    {
        [TestCase(1, 10, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz")]
        [TestCase(11, 15, "11,Fizz,13,14,FizzBuzz")]
        [TestCase(11, 15, "11,Fizz,13,14,FizzBuzz")]
        public void Should_Evaluate_Classic_FizzBuzz(int a, int b, string r)
        {
            var fizzBuzz = new ClassicFizzBuzz(a, b);
            var result = fizzBuzz.Evaluate();
            Assert.That(r, Is.EqualTo(result.ToString()));
        }
    }
}
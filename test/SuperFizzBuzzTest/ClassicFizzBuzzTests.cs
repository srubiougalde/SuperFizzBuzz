using NUnit.Framework;
using Headspring.FizzBuzz;

namespace Headspring.FizzBuzzTests
{
    [TestFixture]
    public class ClassicFizzBuzzTests
    {
        public ClassicFizzBuzz FizzBuzz;

        [SetUp]
        public void Setup()
        {
            FizzBuzz = new ClassicFizzBuzz();
        }

        [TestCase(10, 0)]
        [TestCase(0, -10)]
        public void Should_Return_ArgumentException(int a, int b) {
            Assert.That(() => FizzBuzz.Evaluate(a, b), Throws.ArgumentException);
        }

        [TestCase(1, 10, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz")]
        [TestCase(11, 15, "11,Fizz,13,14,FizzBuzz")]
        [TestCase(11, 15, "11,Fizz,13,14,FizzBuzz")]
        public void Should_Evaluate_Classic_FizzBuzz(int a, int b, string r)
        {
            var result = FizzBuzz.Evaluate(a, b);
            Assert.That(r, Is.EqualTo(result.ToString()));
        }
    }
}
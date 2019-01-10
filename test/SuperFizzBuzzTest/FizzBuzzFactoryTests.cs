using NUnit.Framework;
using System.Collections.Generic;
using Headspring.FizzBuzz;

namespace Headspring.FizzBuzzTests
{
  [TestFixture]
  public class FizzBuzzFactoryTests
  {
    [TestCase(1,10)]
    public void Should_Return_ClassicFizzBuzz_Instance(int a, int b)
    {
      FizzBuzzFactory factory = null;
      factory = new ClassicFizzBuzzFactory(a, b);
      var fizzbuzz = factory.GetFizzBuzz();  
      Assert.That("Classic", Is.EqualTo(fizzbuzz.FizzBuzzType));
    }

    [TestCase(1,10)]
    public void Should_Return_SuperFizzBuzz_Instance(int a, int b)
    {
      FizzBuzzFactory factory = null;
      factory = new SuperFizzBuzzFactory(a, b);
      var fizzbuzz = factory.GetFizzBuzz();  
      Assert.That("Super", Is.EqualTo(fizzbuzz.FizzBuzzType));
    }
  }
}
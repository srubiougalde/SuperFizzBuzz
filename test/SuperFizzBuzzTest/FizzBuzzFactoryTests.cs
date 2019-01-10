using NUnit.Framework;
using System.Collections.Generic;
using Headspring.FizzBuzz;

namespace Headspring.FizzBuzzTests
{
  [TestFixture]
  public class FizzBuzzFactoryTests
  {
    [Test]
    public void Should_Return_ClassicFizzBuzz_Instance()
    {
      FizzBuzzFactory factory = null;
      factory = new ClassicFizzBuzzFactory();
      var fizzbuzz = factory.GetFizzBuzz();  
      Assert.That("Classic", Is.EqualTo(fizzbuzz.FizzBuzzType));
    }

    [Test]
    public void Should_Return_SuperFizzBuzz_Instance()
    {
      FizzBuzzFactory factory = null;
      factory = new SuperFizzBuzzFactory();
      var fizzbuzz = factory.GetFizzBuzz();  
      Assert.That("Super", Is.EqualTo(fizzbuzz.FizzBuzzType));
    }
  }
}
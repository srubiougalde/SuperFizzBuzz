using System;

namespace Headspring.FizzBuzz
{
  public class ClassicFizzBuzzFactory : FizzBuzzFactory
  {
    public override FizzBuzz GetFizzBuzz()
    {
      return new ClassicFizzBuzz();
    }
  }
}
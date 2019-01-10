using System;

namespace Headspring.FizzBuzz
{
  public class ClassicFizzBuzzFactory : FizzBuzzFactory
  {
    private int _start;
    private int _end;

    public ClassicFizzBuzzFactory(int start, int end)
    {
      _start = start;
      _end = end;
    }

    public override FizzBuzz GetFizzBuzz()
    {
      return new ClassicFizzBuzz(_start, _end);
    }
  }
}
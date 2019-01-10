using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
  public class SuperFizzBuzzFactory : FizzBuzzFactory
  {
    private int _start;
    private int _end;
    private List<KeyValuePair<int, string>> _tokens;

    public SuperFizzBuzzFactory(int start, int end) 
    {
      _start = start;
      _end = end;
    }

    public SuperFizzBuzzFactory(int start, int end, List<KeyValuePair<int, string>> tokens) 
    { 
      _start = start;
      _end = end;
      _tokens = tokens;
    }

    public override FizzBuzz GetFizzBuzz()
    {
      if (_tokens != null && _tokens.Count > 0) {
        return new SuperFizzBuzz(_start, _end, _tokens);
      }

      return new SuperFizzBuzz(_start, _end);
    }
  }
}
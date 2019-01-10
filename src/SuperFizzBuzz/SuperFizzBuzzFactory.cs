using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
  public class SuperFizzBuzzFactory : FizzBuzzFactory
  {
    private List<KeyValuePair<int, string>> _tokens;

    public SuperFizzBuzzFactory() 
    { 
    }

    public SuperFizzBuzzFactory(List<KeyValuePair<int, string>> tokens) 
    { 
      _tokens = tokens;
    }

    public override FizzBuzz GetFizzBuzz()
    {
      if (_tokens != null && _tokens.Count > 0) {
        return new SuperFizzBuzz(_tokens);
      }

      return new SuperFizzBuzz();
    }
  }
}
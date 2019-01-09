using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
    public class SuperFizzBuzz : BaseFizzBuzz
    {
        public SuperFizzBuzz() 
            : base() { }

        public SuperFizzBuzz(List<KeyValuePair<int, string>> tokens)
        {
            Tokens = tokens;
        }
    }
}

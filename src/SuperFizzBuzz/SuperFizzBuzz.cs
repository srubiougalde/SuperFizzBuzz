using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
    public class SuperFizzBuzz : FizzBuzz
    {
        private readonly string _fizzBuzzType;

        public SuperFizzBuzz(int start, int end) 
            : base(start, end)
        {
            _fizzBuzzType = "Super";
        }

        public SuperFizzBuzz(int start, int end, List<KeyValuePair<int, string>> tokens)
            : base(start, end)
        {
            _fizzBuzzType = "Super";
            Tokens = tokens;
        }

        public override string FizzBuzzType  
        {  
            get { return _fizzBuzzType; }  
        }
    }
}

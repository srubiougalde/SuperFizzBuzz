using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
    public class SuperFizzBuzz : FizzBuzz
    {
        private readonly string _fizzBuzzType;

        public SuperFizzBuzz() 
            : base()
        {
            _fizzBuzzType = "Super";
        }

        public SuperFizzBuzz(List<KeyValuePair<int, string>> tokens)
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

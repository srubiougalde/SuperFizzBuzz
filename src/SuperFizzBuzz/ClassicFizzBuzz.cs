using System;

namespace Headspring.FizzBuzz
{
    public class ClassicFizzBuzz : FizzBuzz
    {
        private readonly string _fizzBuzzType;

        public ClassicFizzBuzz() 
            : base() 
        {
            _fizzBuzzType = "Classic";
        }

        public override string FizzBuzzType  
        {  
            get { return _fizzBuzzType; }  
        }
    }
}

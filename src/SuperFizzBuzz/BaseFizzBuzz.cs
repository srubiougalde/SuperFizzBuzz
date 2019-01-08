using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
    public abstract class BaseFizzBuzz
    {  
        protected BaseFizzBuzz() {
            
        }

        public virtual string Evaluate(int start, int end) {
            throw new NotImplementedException();
        }    
    }
}

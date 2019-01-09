using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
    public abstract class BaseFizzBuzz
    {  
        protected BaseFizzBuzz() {
            
        }

        public virtual List<string> Evaluate(int start, int end) {
            if (start > end) {
                throw new ArgumentException();
            }

            var result = new List<string>();

            for (int i = start; i <= end; i++) {
                if (i%3 == 0 && i%5 == 0) {
                    result.Add("FizzBuzz");
                }
                else if (i%3 == 0) {
                    result.Add("Fizz");
                }
                else if (i%5 == 0) {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }
    }
}

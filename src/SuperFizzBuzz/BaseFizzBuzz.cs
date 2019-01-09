using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
    public abstract class BaseFizzBuzz
    {  
        protected List<KeyValuePair<int, string>> Tokens;

        protected BaseFizzBuzz() {
            Tokens = new List<KeyValuePair<int, string>>();
            Tokens.Add(new KeyValuePair<int, string>(3, "Fizz"));
            Tokens.Add(new KeyValuePair<int, string>(5, "Buzz"));
        }

        public virtual FizzBuzzResult Evaluate(int start, int end) {
            if (start > end) {
                throw new ArgumentException();
            }

            // size will determine the capacity of our result list
            var size = end - start + 1;
            var result = new FizzBuzzResult(start, end);

            foreach(var token in Tokens) {
                var factor = token.Key;
                var word = token.Value;

                var first = (start % factor) == 0 ? start : (start + factor - (start % factor));
                for (var i = first; i <= end; i += factor) {                    
                    result.Items[i - start] += token.Value;
                }
            }

            return result;
        }
    }
}

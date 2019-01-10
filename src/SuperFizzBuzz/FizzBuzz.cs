using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
    public abstract class FizzBuzz
    {  
        public abstract string FizzBuzzType { get; }

        protected List<KeyValuePair<int, string>> Tokens  { get; set; } 

        protected FizzBuzz() {
            Tokens = new List<KeyValuePair<int, string>>();
            Tokens.Add(new KeyValuePair<int, string>(3, "Fizz"));
            Tokens.Add(new KeyValuePair<int, string>(5, "Buzz"));
        }

        public FizzBuzzResult Evaluate(int start, int end) {
            if (start > end) {
                throw new ArgumentException();
            }

            // size will determine the capacity of our result list
            var size = end - start + 1;
            var result = new FizzBuzzResult(start, end);

            foreach(var token in Tokens) {
                var factor = token.Key;
                var word = token.Value;

                var next = GetNextCommonMultiple(start, factor);
                for (var i = next; i <= end; i += factor) {                    
                    result.Items[i - start] += token.Value;
                }
            }

            return result;
        }

        protected int GetNextCommonMultiple(int number, int factor) {
            var mod = number % factor;

            if (mod == 0)
            {
                return number;
            }

            if (number >= 0)
            {
                return number + factor - mod;
            }
            else
            {
                return number - mod;
            }
        }
    }
}

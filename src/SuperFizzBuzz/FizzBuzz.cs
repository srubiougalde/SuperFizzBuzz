using System;
using System.Collections.Generic;

namespace Headspring.FizzBuzz
{
    public abstract class FizzBuzz
    {  
        public abstract string FizzBuzzType { get; }

        protected int Start { get; set; }

        protected int End { get; set; }
        protected List<KeyValuePair<int, string>> Tokens  { get; set; } 

        protected FizzBuzz(int start, int end) {
            Start = start;
            End = end;

            Tokens = new List<KeyValuePair<int, string>>();
            Tokens.Add(new KeyValuePair<int, string>(3, "Fizz"));
            Tokens.Add(new KeyValuePair<int, string>(5, "Buzz"));
        }

        public FizzBuzzResult Evaluate() {
            var min = (Start <= End) ? Start : End;
            var max = (Start > End) ? Start : End; 

            // size will determine the capacity of our result list
            var size = max - min + 1;
            var result = new FizzBuzzResult(min, max);

            foreach(var token in Tokens) {
                var factor = token.Key;
                var word = token.Value;

                var next = GetNextCommonMultiple(min, factor);
                for (var i = next; i <= max; i += factor) {                    
                    result.Items[i - min] += token.Value;
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

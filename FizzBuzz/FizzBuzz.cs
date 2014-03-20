using System;
using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz(int topEnd)
            : this(0, topEnd)
        {}

        public FizzBuzz(int start, int topEnd)
        {
            _topEnd = topEnd;
            _start = start;

            if( _topEnd < _start)
            {
                throw new ArgumentException("Start value is greater than the Top End value");
            }
        }

        public IEnumerable<string> Results()
        {
            for (var i = _start; i <= _topEnd; i++)
            {
                var answer = string.Empty;
                if (i%3 == 0)
                {
                   answer = "Fizz";
                }
                
                if (i%5 == 0)
                {
                    answer += "Buzz";
                }

                if( string.IsNullOrEmpty(answer))
                {
                    answer = i.ToString(CultureInfo.InvariantCulture);
                }
                yield return answer;
            }
        }

        public IEnumerable<string> CustomRules(List<Rule> list)
        {
            for (var i = _start; i <= _topEnd; i++)
            {
                var answer = string.Empty;

                foreach (var rule in list)
                {
                    if (i % rule.Divisor == 0)
                    {
                        answer += rule.ReplaceWith;
                    }
                }

                if (string.IsNullOrEmpty(answer))
                {
                    answer = i.ToString(CultureInfo.InvariantCulture);
                }

                yield return answer;
            }
        }

        private readonly int _topEnd;
        private readonly int _start;

    }
}
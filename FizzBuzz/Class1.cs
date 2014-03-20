using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz(int topEnd)
            : this(0, topEnd)
        {

        }
        public FizzBuzz(int start, int topEnd)
        {
            _topEnd = topEnd;
            _start = start;

            if( _topEnd < _start)
            {
                throw new ArgumentException("Start value is greater than the Top End value");
            }
            _results = new List<string>();
        }

        public IEnumerable<string> Results()
        {
            for (int i = _start; i <= _topEnd; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                   yield return "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                   yield return "Fizz";
                }
                else if (i % 5 == 0)
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }

        private readonly int _topEnd;
        private readonly int _start;
        private readonly List<string> _results;
    }
}
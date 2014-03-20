using System;

namespace FizzBuzz
{
    public class Rule
    {
        public Rule(int divisor, string replaceWith)
        {
            Divisor = divisor;
            ReplaceWith = replaceWith;
        }
        
        public Rule()
        {
        }

        public int Divisor
        {
            get { return _divisor; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Can not divide by zero");
                }
                _divisor = value;
            }
        }

        public string ReplaceWith { get; set; }

        private int _divisor;
    }
}
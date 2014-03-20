using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // Program and Library for re-using.


        // 3 fizz, 5 buzz, 8 bazz, 10 bar etc.
        //Finish up test, modify program to support arbitrary tokens and divisors.
        // cedric@headspring.com

        static void Main(string[] args)
        {
            try
            {
                
                var lib = new FizzBuzz.FizzBuzz(1, 1000000000);
                foreach (var result in lib.Results())
                {
                    Console.WriteLine(result);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

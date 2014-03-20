using System;
using System.Collections.Generic;
using FizzBuzz;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                var lib = new FizzBuzz.FizzBuzz(1, 100);
                foreach (var result in lib.Results())
                {
                    Console.WriteLine(result);
                }

                foreach (var reply in lib.CustomRules(new List<Rule>
                {
                    new Rule{ Divisor = 8, ReplaceWith = "Bazz"},
                    new Rule{ Divisor = 10, ReplaceWith = "Bar"}
                }))
                {
                    Console.WriteLine(reply);
                }
                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
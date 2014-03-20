using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzTest
    {
        [Test]
        public void ThreeShouldReturnFizz()
        {
            var lib = new FizzBuzz.FizzBuzz(0, 3);
            var answers = lib.Results().ToArray();
            Assert.AreEqual("Fizz", answers[3]);
        }
    }
}

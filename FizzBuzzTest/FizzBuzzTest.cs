using System;
using System.Collections.ObjectModel;
using FizzBuzz;
using NUnit.Framework;
using System.Linq;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void ThreeReturnsFizz()
        {
            var lib = new FizzBuzz.FizzBuzz(3, 3);
            var answer = lib.Results().First();
            Assert.AreEqual("Fizz", answer);
        }

        [Test]
        public void FiveReturnsBuzz()
        {
            var lib = new FizzBuzz.FizzBuzz(5, 5);
            var answer = lib.Results().First();
            Assert.AreEqual("Buzz", answer);
        }

        [Test]
        public void FifteenReturnsFizzBuzz()
        {
            var lib = new FizzBuzz.FizzBuzz(15, 15);
            var answer = lib.Results().First();
            Assert.AreEqual("FizzBuzz", answer);
        }

        [Test]
        public void OneThroughFiveReturnsCorrectly()
        {
            var lib = new FizzBuzz.FizzBuzz(1, 5);
            var answer = lib.Results();
            var expected = new Collection<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz"
            };

            CollectionAssert.AreEqual(expected, answer);
        }
    }
}
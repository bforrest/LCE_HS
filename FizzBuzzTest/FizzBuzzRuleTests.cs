using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzRuleTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void RuleCannotHaveZeroDivisor()
        {
            var r = new Rule { Divisor = 0, ReplaceWith = "Ooops" };
        }

        [Test]
        public void NegativeThreeReturnsCorrectly()
        {
            var theRules = new List<Rule>
            {
                new Rule {Divisor = -3, ReplaceWith = "Below Zero"}
            };

            var buzzer = new FizzBuzz.FizzBuzz(3, 3);
            var reply = buzzer.CustomRules(theRules).First();

            Assert.AreEqual("Below Zero", reply);
        }

        [Test]
        public void EightRuleReturnsBazz()
        {
            var theRules = new List<Rule>
            {
                new Rule {Divisor = 8, ReplaceWith = "Bazz"}
            };

            var buzzer = new FizzBuzz.FizzBuzz(8, 8);
            var reply = buzzer.CustomRules(theRules).First();

            Assert.AreEqual("Bazz", reply);
        }

        [Test]
        public void TenRuleReturnsBar()
        {
            var theRules = new List<Rule>
            {
                new Rule {Divisor = 10, ReplaceWith = "Bar"}
            };

            var buzzer = new FizzBuzz.FizzBuzz(10, 10);
            var reply = buzzer.CustomRules(theRules).First();

            Assert.AreEqual("Bar", reply);
        }

        [Test]
        public void EightyReturnsBazzBarr()
        {
            var theRules = new List<Rule>
            {
                new Rule {Divisor = 8, ReplaceWith = "Bazz"},
                new Rule {Divisor = 10, ReplaceWith = "Bar"}
            };

            var buzzer = new FizzBuzz.FizzBuzz(80, 80);
            var reply = buzzer.CustomRules(theRules).First();

            Assert.AreEqual("BazzBar", reply);
        }

        [Test]
        public void EightThroughTenReturnsCorrectly()
        {
            var expected = new Collection<string>
            {
                "Bazz",
                "9",
                "Bar"
            };

            var theRules = new List<Rule>
            {
                new Rule {Divisor = 8, ReplaceWith = "Bazz"},
                new Rule {Divisor = 10, ReplaceWith = "Bar"}
            };

            var buzzer = new FizzBuzz.FizzBuzz(8, 10);
            var reply = buzzer.CustomRules(theRules).ToList();

            CollectionAssert.AreEqual(expected, reply);
        }
    }
}
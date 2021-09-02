using NUnit.Framework;
using Business;
using System.Collections;

namespace Business.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(1,"")]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(12, "Fizz")]
        [TestCase(15, "FizzBuzz")]
        public void Ask_GivenNumber_ReturnsString(int inputNumber, string expectedResult)
        {
            var result = FizzBuzz.Ask(inputNumber);
            Assert.AreEqual(expectedResult, result);
        }        
    }
}

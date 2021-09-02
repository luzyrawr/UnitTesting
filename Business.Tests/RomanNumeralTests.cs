using NUnit.Framework;
using Business;

namespace Business.Tests
{
    [TestFixture]
    public class RomanNumeralTests
    {
        [TestCase("I",1)]
        [TestCase("II", 2)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("IX", 9)]
        [TestCase("XI", 11)]
        [TestCase("XIV", 14)]
        [TestCase("XV", 15)]
        [TestCase("XVI", 16)]
        [TestCase("XIX", 19)]

        [TestCase("XX", 20)]
        [TestCase("XXIV", 24)]
        [TestCase("XL", 40)]
        [TestCase("LXXXIX", 89)]
        [TestCase("XCIV", 94)]
        [TestCase("XCVIII", 98)]
        [TestCase("XCIX", 99)]

        [TestCase("CC", 200)]
        [TestCase("CCXLIV", 244)]
        [TestCase("CD", 400)]
        [TestCase("DCCCXCIX", 899)]
        [TestCase("CMXLIV", 944)]
        [TestCase("CMLXXXVIII", 988)]
        [TestCase("CMXCIX", 999)]
        public void Parse_GivenString_ReturnsInt(string roman, int expectedResult)
        {
            Assert.AreEqual(expectedResult, RomanNumeral.Parse(roman));            
        }
    }
}

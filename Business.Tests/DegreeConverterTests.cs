using NUnit.Framework;
using Business;

namespace Business.Tests
{
    [TestFixture]
    public class DegreeConverterTests
    {

        [Test]
        public void ToFahrenheit_ZeroCelsius_Returns32()
        {
            var degreeConverter = new DegreeConverter();
            var result = degreeConverter.ToFahrenheit(celsius:0);
            Assert.AreEqual(32, result);
        }

        [Test]
        public void ToCelsius_OneFahrenheit_Returns0()
        {
            var degreeConverter = new DegreeConverter();
            var result = degreeConverter.ToCelsius(fahrenheit:1);
            Assert.AreEqual(0, result);
        }
    }
}
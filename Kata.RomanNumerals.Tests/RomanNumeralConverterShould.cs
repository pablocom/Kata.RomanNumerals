using NUnit.Framework;

namespace Kata.RomanNumerals.Tests
{
    public class RomanNumeralConverterShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(5, "V")]
        [TestCase(7, "VII")]
        [TestCase(10, "X")]
        [TestCase(18, "XVIII")]
        [TestCase(30, "XXX")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(19, "XIX")]
        public void TransformIntoRespectiveRomanNumeral(int number, string expectedRomanNumeral)
        {
            var romanNumeral = RomanNumeralConverter.NumberToRomanNumeral(number);

            Assert.That(romanNumeral, Is.EqualTo(expectedRomanNumeral));
        }
    }
}
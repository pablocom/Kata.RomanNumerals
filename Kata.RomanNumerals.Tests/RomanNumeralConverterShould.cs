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
        [TestCase(50, "L")]
        [TestCase(40, "XL")]
        [TestCase(100, "C")]
        [TestCase(90, "XC")]
        [TestCase(500, "D")]
        [TestCase(400, "CD")]
        [TestCase(1000, "M")]
        [TestCase(900, "CM")]
        [TestCase(1492, "MCDXCII")]
        public void TransformIntoRespectiveRomanNumeral(int number, string expectedRomanNumeral)
        {
            var romanNumeral = RomanNumeralConverter.NumberToRomanNumeral(number);

            Assert.That(romanNumeral, Is.EqualTo(expectedRomanNumeral));
        }
    }
}
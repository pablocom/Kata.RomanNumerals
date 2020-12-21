using System.Collections.Generic;
using System.Text;

namespace Kata.RomanNumerals
{
    public static class RomanNumeralConverter
    {
        public static string NumberToRomanNumeral(int number)
        {
            var sb = new StringBuilder();

            foreach (var arabicToRomanNumeral in ArabicToRomanNumeral.All)
            {
                while (number >= arabicToRomanNumeral.Arabic)
                {
                    sb.Append(arabicToRomanNumeral.Character);
                    number -= arabicToRomanNumeral.Arabic;
                }
            }

            return sb.ToString();
        }
    }

    public class ArabicToRomanNumeral
    {
        private static readonly ArabicToRomanNumeral Thousand = new ArabicToRomanNumeral(1000, "M");
        private static readonly ArabicToRomanNumeral NineHundred = new ArabicToRomanNumeral(900, "CM");
        private static readonly ArabicToRomanNumeral FiveHundred = new ArabicToRomanNumeral(500, "D");
        private static readonly ArabicToRomanNumeral FortyHundred = new ArabicToRomanNumeral(400, "CD");
        private static readonly ArabicToRomanNumeral Hundred = new ArabicToRomanNumeral(100, "C");
        private static readonly ArabicToRomanNumeral Ninety = new ArabicToRomanNumeral(90, "XC");
        private static readonly ArabicToRomanNumeral Fifty = new ArabicToRomanNumeral(50, "L");
        private static readonly ArabicToRomanNumeral Forty = new ArabicToRomanNumeral(40, "XL");
        private static readonly ArabicToRomanNumeral Ten = new ArabicToRomanNumeral(10, "X");
        private static readonly ArabicToRomanNumeral Nine = new ArabicToRomanNumeral(9, "IX");
        private static readonly ArabicToRomanNumeral Five = new ArabicToRomanNumeral(5, "V");
        private static readonly ArabicToRomanNumeral Four = new ArabicToRomanNumeral(4, "IV");
        private static readonly ArabicToRomanNumeral One = new ArabicToRomanNumeral(1, "I");

        public static readonly IEnumerable<ArabicToRomanNumeral> All = new[]
        {
            Thousand,
            NineHundred,
            FiveHundred,
            FortyHundred,
            Hundred,
            Ninety,
            Fifty,
            Forty,
            Ten,
            Nine,
            Five,
            Four,
            One
        };
        
        public string Character { get; }
        public int Arabic { get; }

        private ArabicToRomanNumeral(int arabic, string character)
        {
            Character = character;
            Arabic = arabic;
        }
    }
}
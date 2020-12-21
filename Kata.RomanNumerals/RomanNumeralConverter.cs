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
        private static readonly ArabicToRomanNumeral Ten = new ArabicToRomanNumeral(10, "X");
        private static readonly ArabicToRomanNumeral Nine = new ArabicToRomanNumeral(9, "IX");
        private static readonly ArabicToRomanNumeral Five = new ArabicToRomanNumeral(5, "V");
        private static readonly ArabicToRomanNumeral Four = new ArabicToRomanNumeral(4, "IV");
        private static readonly ArabicToRomanNumeral One = new ArabicToRomanNumeral(1, "I");

        public static readonly IEnumerable<ArabicToRomanNumeral> All = new[] { Ten, Nine, Five, Four, One };
        
        public string Character { get; }
        public int Arabic { get; }

        private ArabicToRomanNumeral(int arabic, string character)
        {
            Character = character;
            Arabic = arabic;
        }
    }
}
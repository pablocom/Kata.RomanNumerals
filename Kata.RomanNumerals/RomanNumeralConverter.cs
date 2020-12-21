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
                if (number >= arabicToRomanNumeral.Arabic)
                {
                    sb.Append(arabicToRomanNumeral.Character);
                    number -= arabicToRomanNumeral.Arabic;
                }
            }

            for (var i = 1; i <= number; i++)
                sb.Append('I');

            return sb.ToString();
        }
    }

    public class ArabicToRomanNumeral
    {
        public static readonly ArabicToRomanNumeral Ten = new ArabicToRomanNumeral(10, 'X');
        public static readonly ArabicToRomanNumeral Five = new ArabicToRomanNumeral(5, 'V');

        public static readonly IEnumerable<ArabicToRomanNumeral> All = new[] { Ten, Five };
        
        public char Character { get; }
        public int Arabic { get; }

        public ArabicToRomanNumeral(int arabic, char character)
        {
            Character = character;
            Arabic = arabic;
        }
    }
}
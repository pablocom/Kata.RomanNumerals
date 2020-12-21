using System.Text;

namespace Kata.RomanNumerals
{
    public static class RomanNumeralConverter
    {
        public static string NumberToRomanNumeral(int number)
        {
            var sb = new StringBuilder();

            if (number >= 5)
            {
                sb.Append('V');
                number = number - 5;
            }

            
            for (var i = 1; i <= number; i++)
                sb.Append('I');

            return sb.ToString();
        }
    }
}
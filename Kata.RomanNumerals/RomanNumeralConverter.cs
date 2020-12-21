using System.Text;

namespace Kata.RomanNumerals
{
    public static class RomanNumeralConverter
    {
        public static string NumberToRomanNumeral(int number)
        {
            var sb = new StringBuilder();

            foreach (var arabicToRomanNumeral in ArabicToRomanNumerals.All)
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
}
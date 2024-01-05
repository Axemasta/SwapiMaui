using System.Globalization;
using System.Text;

namespace SwapiApp.Converters;

public class RomanNumeralConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is null)
        {
            return null;
        }

        if (value is not int number)
        {
            throw new NotSupportedException($"Value must be of type {typeof(int)}");
        }

        return ToRomanNumber(number);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
    
    private string ToRomanNumber(int number)
    {
        // https://stackoverflow.com/a/24672262/8828057
        StringBuilder result = new StringBuilder();
        int[] digitsValues = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        string[] romanDigits = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        while (number > 0)
        {
            for (int i = digitsValues.Count() - 1; i >= 0; i--)
                if (number / digitsValues[i] >= 1)
                {
                    number -= digitsValues[i];
                    result.Append(romanDigits[i]);
                    break;
                }
        }
        return result.ToString();
    }
}
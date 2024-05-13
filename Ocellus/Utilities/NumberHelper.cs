using System.Globalization;

namespace Ocellus;

public static class NumberHelper
{
    public static string SeparateNumberByThousands(int number)
    {
        var numberFormat = new NumberFormatInfo(); // culture-invariant
        numberFormat.NumberGroupSeparator = " ";
        return string.Format(numberFormat, "{0:N0}", number);
    }
}
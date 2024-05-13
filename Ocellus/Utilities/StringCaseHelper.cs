namespace Ocellus;

public static class StringCaseHelper
{
    public static string ToKebabCase(this string input)
        => input.Replace(" ", "-");

    public static string FromKebabCase(this string input)
        => input.Replace("-", " ");
}
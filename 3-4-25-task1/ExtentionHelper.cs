using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp;

public static class ExtentionHelper
{
    public static bool IsAlpha(this string str)
    {
        if (Regex.IsMatch(str, @"^[A-Za-z\s]+$"))
            return true;
        return false;
    }
    public static bool IsValidPassword(this string str)
    {
        if (Regex.IsMatch(str, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$"))
            return true;
        return false;
    }
    public static bool IsValidUsername(this string str)
    {
        if (Regex.IsMatch(str, @"^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$"))
            return true;
        return false;
    }
    public static bool IsValidDate(this DateOnly date)
    {
        if (date.Year >= 1970)
            return true;
        return false;
    }
    public static string Capitalize(this string str)
    {
        return new StringBuilder(char.ToUpper(str[0]))
            .Append(str[1..]
            .ToLower())
            .ToString();
    }
}



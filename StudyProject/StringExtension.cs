namespace StudyProject;

internal static class StringExtension
{
    public static bool IsPalindrome(this string str)
    {
        bool result = true;
        string strHandled = str.StringTreated();
        char[] arrayChar = strHandled.ToCharArray();
        int halfLength = arrayChar.Length / 2;

        for (int i = 0; i < halfLength; i++)
        {
            char currentLetter = arrayChar[i];
            char comparisionLetter = arrayChar[GetLastIndex(arrayChar.Length) - i];

            if (IsDifferentChar(currentLetter, comparisionLetter))
            {
                result = false;
                break;
            }
        }

        return result;
    }

    static int GetLastIndex(int length) => length - 1;

    static bool IsDifferentChar(char valueOne, char valueTwo) => valueOne != valueTwo;

    public static bool IsPalindromeLinq(this string str)
    {
        var strHandled = str.StringTreated();
        return strHandled.SequenceEqual(strHandled.Reverse());
    }

    static string StringTreated(this string str) => str.ToLower().Replace(" ", string.Empty);
}

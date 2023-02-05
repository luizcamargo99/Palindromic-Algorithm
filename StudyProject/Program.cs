
Console.WriteLine(IsPalindrome("rodador")); // true
Console.WriteLine(IsPalindrome("mamam")); // true
Console.WriteLine(IsPalindrome("rir")); // true
Console.WriteLine(IsPalindrome("Livre do poder vil")); // true
Console.WriteLine(IsPalindrome("O trote torto")); // true

Console.WriteLine(IsPalindrome("amor")); // false
Console.WriteLine(IsPalindrome("celular")); // false
Console.WriteLine(IsPalindrome("caneta")); // false
Console.WriteLine(IsPalindrome("pc")); // false
Console.WriteLine(IsPalindrome("abac")); // false

bool IsPalindrome(string str)
{
    bool result = true;
    string strHandled = str.ToLower().Replace(" ", string.Empty);
    char[] arrayChar = strHandled.ToCharArray();
    int halfLength = arrayChar.Length / 2;

    for (int i = 0; i < arrayChar.Length; i++)
    {
        if (ComparasionEnded(halfLength, i))
            break;

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

bool ComparasionEnded(int halfLength, int currentIndex) => halfLength < (currentIndex + 1);

int GetLastIndex(int length) => length - 1;

bool IsDifferentChar(char valueOne, char valueTwo) => valueOne != valueTwo;


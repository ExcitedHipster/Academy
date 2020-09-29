namespace ConsoleApp7
{
    public interface IStringHelper
    {
        bool ContainsSubstring(string inputString, string substring);
        bool ContainsVowel(string inputString);
        string ReverseString(string inputString);
    }
}
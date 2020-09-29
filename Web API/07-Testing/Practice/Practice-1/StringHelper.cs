using Practice_1;
using System;

namespace ConsoleApp7
{
    public class StringHelper : IStringHelper
    {
        private readonly IHttpService _httpService;
        public StringHelper(IHttpService httpService)
        {
            _httpService = httpService;

        }

        private char[] _vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

        public bool ContainsVowel(string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                foreach (char ch in _vowels)
                {
                    if (inputString.ToLower().Contains(ch))
                        return true;
                }
            }
            return false;
        }

        public string ReverseString(string inputString)
        {

            if (!string.IsNullOrEmpty(inputString))
            {
                char[] charArray = inputString.ToCharArray();
                Array.Reverse(charArray);

             
                return new string(charArray);
            }
            return string.Empty;
        }

        public bool ContainsSubstring(string inputString, string substring)
        {
            if (!string.IsNullOrEmpty(inputString) && !string.IsNullOrEmpty(substring))
                return inputString.IndexOf(substring) != -1 ? true : false;
            return false;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_Week1.Library
{
    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            char[] reverse = word.ToCharArray();
            Array.Reverse(reverse);
            if (word.ToCharArray().Equals(reverse))
            {
                return true;
            }
            else
                return false;
        }
    }
}

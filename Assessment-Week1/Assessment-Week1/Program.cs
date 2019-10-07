using System;
using Assessment_Week1.Library;
using Xunit;

namespace Assessment_Week1
{
    public class Program
    {
        [Fact]
        public void PalindromeShouldPalindrome()
        {
            var test = new Palindrome();

            test.IsPalindrome("Anna");

            Assert.Equal(expected:true)
        }
    }
}

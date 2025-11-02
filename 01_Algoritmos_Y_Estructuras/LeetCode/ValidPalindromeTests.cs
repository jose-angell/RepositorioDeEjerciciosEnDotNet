using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ValidPalindromeTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("A man, a plan, a canal: Panama")]
        public void ValidPalindrome_ReturnTrue(string s)
        {
            // Act
            var actua = new ValidPalindrome();
            var result = actua.Solution(s);

            // Assert
            Assert.True(result);
        }


        [Theory]
        [InlineData(".qw")]
        [InlineData(" 1s")]
        [InlineData("race a car")]
        public void ValidPalindrome_ReturnFalse(string s)
        {
            // Act
            var actua = new ValidPalindrome();
            var result = actua.Solution(s);

            // Assert
            Assert.False(result);
        }
    }
}

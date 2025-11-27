using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class ReverseStringTests
    {
        [Theory]
        [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
        [InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
        [InlineData(new char[] { 'H' }, new char[] { 'H' })]
        [InlineData(new char[] { 'a', 'b', 'c' }, new char[] { 'c', 'b', 'a' })]

        public void ReverseString_withSucces(char[] s, char[] expected)
        {
            // Act
            var act = new ReverseString();
            act.Solution(s);
            // Assert
            Assert.Equal(expected, s);
        }
    }
}

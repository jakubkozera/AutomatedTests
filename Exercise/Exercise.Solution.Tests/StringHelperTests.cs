using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;


namespace Exercise.Solution.Tests
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData("ala  ma kota", "kota ma  ala")]
        [InlineData("To jest zdanie testowe", "testowe zdanie jest To")]
        [InlineData("This test checks reversing words", "words reversing checks test This")]
        public void ReverseWords_ForGivenSentance_ReturnsReversedSentence(string sentence, string expectedResult)
        {
            // act
            string result = StringHelper.ReverseWords(sentence);

            // assert
            result.Should().Be(expectedResult);
        }


        [Theory]
        [InlineData("ala")]
        [InlineData("aLa")]
        [InlineData("kajak")]
        [InlineData("KAJAK")]
        [InlineData("pop")]
        public void IsPalindrome_ForAPalindromWord_ReturnsTrueValue(string word)
        {
            // act

            bool result = StringHelper.IsPalindrome(word);

            // assert

            result.Should().Be(true);
        }

        [Theory]
        [InlineData("Ala")]
        [InlineData("alA")]
        [InlineData("Kuba")]
        [InlineData("test")]
        public void IsPalindrome_ForANonPalindromWord_ReturnsFalseValue(string word)
        {
            // act

            bool result = StringHelper.IsPalindrome(word);

            // assert

            result.Should().Be(false);
        }
    }
}

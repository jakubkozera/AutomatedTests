using System;
using System.Net.Http;
using System.Text;
using Xunit;

namespace MyProject.Tests
{
    public class StringBuilderTests
    {
        [Fact]
        public void Append_ForTwoStrings_ReturnsConcatenatedString()
        {
            // arrange

            StringBuilder sb = new StringBuilder();

            // act
            sb.Append("test")
                .Append("test2");

            string result = sb.ToString();


            // assert

            Assert.Equal("testtest2", result);

        }

    }
}
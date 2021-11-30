using System;
using System.Collections.Generic;
using Xunit;

namespace LeapYearKata.Test
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(400, "Leap Year!")]
        [InlineData(800, "Leap Year!")]
        [InlineData(4000, "Leap Year!")]
        [InlineData(1300, "Not Leap Year!")]
        [InlineData(2300, "Not Leap Year!")]
        [InlineData(16, "Leap Year!")]
        [InlineData(28, "Leap Year!")]
        [InlineData(123, "Not Leap Year!")]
        [InlineData(13, "Not Leap Year!")]
        [InlineData(2237, "Not Leap Year!")]
        public void CheckIsLeapOrNotLeapYear(int year, string expected)
        {
            string actual = LeapYearChecker.CheckIsLeapYear(year);
            Assert.Equal(expected, actual);

        }
    }
}
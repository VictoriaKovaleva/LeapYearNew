using System;
using System.Collections.Generic;
using Xunit;

namespace LeapYearKata.Test
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(2000, "Leap Year!")]
        [InlineData(2004, "Leap Year!")]
        [InlineData(2005, "Not Leap Year!")]
        [InlineData(1350, "Not Leap Year!")]
        public void CheckIsLeapOrNotLeapYear(int year, string expected)
        {
            string actual = LeapYearChecker.CheckIsLeapYear(year);
            Assert.Equal(expected, actual);

        }
    }
}
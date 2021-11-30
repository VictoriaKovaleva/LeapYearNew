using System;
using System.Collections.Generic;
using Xunit;

namespace LeapYearKata.Test
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(400, "Leap Year!")]
        public void CheckIsLeapOrNotLeapYear(int year, string expected)
        {
            string actual = LeapYearChecker.CheckIsLeapYear(year);
            Assert.Equal(expected, actual);

        }
    }
}
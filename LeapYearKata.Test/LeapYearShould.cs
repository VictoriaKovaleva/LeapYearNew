using System;
using System.Collections.Generic;
using Xunit;

namespace LeapYearKata.Test
{
    public class LeapYearShould
    {
        [Fact]
        public void ReturnLeapYearFor2000()
        {
            string actual = LeapYearChecker.CheckIsLeapYear(2000);
            Assert.Equal("Leap Year!", actual);
        }
        
    }
}
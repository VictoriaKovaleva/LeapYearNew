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
        
        [Fact]
        public void ReturnLeapYearFor2004()
        { 
            string actual = LeapYearChecker.CheckIsLeapYear(2004);
            Assert.Equal("Leap Year!", actual);
        }

        [Fact]
        public void ReturnNotLeapYearFor2005()
        {
            string actual = LeapYearChecker.CheckIsLeapYear(2005);
            Assert.Equal("Not Leap Year!", actual);

        }
        
    }
}
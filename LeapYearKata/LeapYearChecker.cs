namespace LeapYearKata
{
    public static class LeapYearChecker
    {
        public static string CheckIsLeapYear(int year)
        {
            if (year % 400 == 0 || year % 4 == 0)
                return "Leap Year!";

            return "Not Leap Year!";
        }
    }
}
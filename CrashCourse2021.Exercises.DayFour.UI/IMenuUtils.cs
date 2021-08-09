using System;

namespace CrashCourse2021.Exercises.DayFour.UI
{
    public interface IMenuUtils
    {
        public void ReadIntegerFromString(string headline, out int choice);

        public void ReadMinimumLengthString(string headline, out string newString, int minimumLength);

        public void ReadDateFrom(string headline, out DateTime date);
    }
}
using System;
using CrashCourse2020ExercisesDayFourUI.Constants;

namespace CrashCourse2020ExercisesDayFourUI.Utils
{
    public class MenuUtils: IMenuUtils
    {
        public void ReadIntegerFromString(string headline, out int choice)
        {
            if (!string.IsNullOrEmpty(headline))
            {
                Console.WriteLine(headline);
            }
            var stringValue = Console.ReadLine();
            int intValue;
            while (!int.TryParse(stringValue, out intValue))
            {   Console.Clear();
                Console.WriteLine(MenuConstants.StringIsNotANumber);
                stringValue = Console.ReadLine();
            }
            choice = intValue;
        }
        
        
        public void ReadMinimumLengthString(string headline, out string newString, int minimumLength)
        {
            if (!string.IsNullOrEmpty(headline))
            {
                Console.WriteLine(headline);
            }
            var stringValue = Console.ReadLine();
            while (stringValue.Length < minimumLength)
            {   Console.Clear();
                Console.WriteLine(MenuConstants.StringIsNotLongEnough);
                stringValue = Console.ReadLine();
            }
            newString = stringValue;
        }
        
        public void ReadDateFrom(string headline, out DateTime date)
        {
            if (!string.IsNullOrEmpty(headline))
            {
                Console.WriteLine(headline);
            }
            var stringValue = Console.ReadLine();
            
            while (!DateTime.TryParse(stringValue, out date))
            {   Console.Clear();
                Console.WriteLine(MenuConstants.ThisIsNotAllowedDateFormat);
                stringValue = Console.ReadLine();
            }
        }
    }
}
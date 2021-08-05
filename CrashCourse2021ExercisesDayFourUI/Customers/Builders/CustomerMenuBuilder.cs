using System;
using CrashCourse2021ExercisesDayFourUI.Constants;
using CrashCourse2021ExercisesDayFourUI.MenuAreas;

namespace CrashCourse2021ExercisesDayFourUI.Customers.Builders
{
    public class CustomerMenuBuilder: CustomerBuilder
    {
         public override string GetConsoleOutputAsString()
        {
            var areaMenu = $"Welcome to the Customer area, you now have the following choices\n";
            var optionsArray = Enum.GetValues(typeof(CRUDMenuOptions));
            foreach(CRUDMenuOptions option in optionsArray )
            {
                if (option == CRUDMenuOptions.Unknown)
                {
                    continue;
                }
                var addLine = $"{(int)option}: {Enum.GetName(typeof(CRUDMenuOptions), option)} \n";
                areaMenu = string.Concat(areaMenu, addLine);
            }
            return $"{areaMenu}{MenuConstants.Line}";
        }
        
    }
}
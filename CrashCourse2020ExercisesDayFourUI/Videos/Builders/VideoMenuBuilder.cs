using System;
using CrashCourse2020ExercisesDayFourModels;
using CrashCourse2020ExercisesDayFourUI.Constants;
using CrashCourse2020ExercisesDayFourUI.MenuAreas;

namespace CrashCourse2020ExercisesDayFourUI.Videos.Builders
{
    public class VideoMenuBuilder: VideoBuilder
    {
         public override string GetConsoleOutputAsString()
        {
            var areaMenu = $"Welcome to the Video area, you now have the following choices\n";
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
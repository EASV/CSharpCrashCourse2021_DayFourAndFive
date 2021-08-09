using CrashCourse2021.Exercises.DayFour.UI.Utils;
using CrashCourse2021.Exercises.DayFour.Services;
using CrashCourse2021.Exercises.DayFour.Services.Implementation;

namespace CrashCourse2021.Exercises.DayFour.UI.Videos
{
    public abstract class VideoBuilder: IConsoleOutputBuilder
    {
        protected readonly VideoService videoService;
        protected readonly MenuUtils menuUtils;
        protected VideoBuilder()
        {
            videoService = new VideoService();
            menuUtils = new MenuUtils();
        }

        public abstract string GetConsoleOutputAsString();
        
    }
}
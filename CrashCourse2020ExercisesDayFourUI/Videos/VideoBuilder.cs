using CrashCourse2020ExercisesDayFourService;
using CrashCourse2020ExercisesDayFourService.Videos;
using CrashCourse2020ExercisesDayFourUI.Utils;

namespace CrashCourse2020ExercisesDayFourUI.Videos
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
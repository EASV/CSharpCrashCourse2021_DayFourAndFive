using CrashCourse2021ExercisesDayFourService;
using CrashCourse2021ExercisesDayFourService.Videos;
using CrashCourse2021ExercisesDayFourUI.Utils;

namespace CrashCourse2021ExercisesDayFourUI.Videos
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
using CrashCourse2020ExercisesDayFourUI.Constants;

namespace CrashCourse2020ExercisesDayFourUI.Videos.Builders
{
    public class VideoPrintAllBuilder: VideoBuilder
    {
        public override string GetConsoleOutputAsString()
        {
            var printAllString = "";
            foreach (var video in videoService.ReadAll())
            {
                printAllString = $"{printAllString}" +
                                 $"{MenuConstants.Line}" +
                                 $"Id: {video.Id} \n" +
                                 $"Title: {video.Title} \n" +
                                 $"Storyline: {video.StoryLine} \n" +
                                 $"Release Year: {video.ReleaseDate.Year}\n";
            }
            return printAllString;
        }
    }
}
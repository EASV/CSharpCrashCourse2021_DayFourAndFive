using CrashCourse2021.Exercises.DayFour.Models;

namespace CrashCourse2021.Exercises.DayFour.UI.Videos.Builders
{
    public class VideoByIdBuilder: VideoBuilder
    {
        private Video _video;
        public override string GetConsoleOutputAsString()
        {
            if (_video == null)
            {
                return $"Video with not found!\n";
            }
            return $"Id: {_video.Id} \n" +
                   $"Title: {_video.Title} \n" +
                   $"Storyline: {_video.StoryLine} \n" +
                   $"Release Year: {_video.ReleaseDate.Year}\n";
        }
        
        public void CreateVideoData()
        {
            menuUtils.ReadIntegerFromString("Type in the Id of the item you search for:", out var id);
            _video = videoService.ReadById(id);
        }
    }
}
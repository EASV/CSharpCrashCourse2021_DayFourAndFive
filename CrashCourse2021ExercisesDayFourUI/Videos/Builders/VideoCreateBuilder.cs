using CrashCourse2021ExercisesDayFourModels;

namespace CrashCourse2021ExercisesDayFourUI.Videos.Builders
{
    public class VideoCreateBuilder: VideoBuilder
    {
        private Video _video;
        public void CreateVideoData()
        {
            menuUtils.ReadMinimumLengthString("Type in A Title for yor Video:", out var title, 2);
            menuUtils.ReadMinimumLengthString("Type in A StoryLine for yor Video:",out var storyLine, 2);
            menuUtils.ReadDateFrom("Type in A ReleaseDate (2012-02-22/year-month-date) for yor Video:", out var releaseDate);

            _video = new Video{Title = title, StoryLine = storyLine, ReleaseDate = releaseDate};
        }
        
        public override string GetConsoleOutputAsString()
        {
            if (_video == null)
            {
                return "Video Not Set!";
            }
            var video = videoService.Create(_video.Title, _video.StoryLine, _video.ReleaseDate);
            return video != null ? $"Video with ID: {video.Id} Created" : $"Something Went HORRIBLY WRONG!!!!\n";
        }
    }
}
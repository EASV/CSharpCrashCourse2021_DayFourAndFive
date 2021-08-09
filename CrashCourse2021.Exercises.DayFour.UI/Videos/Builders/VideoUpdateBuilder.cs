using CrashCourse2021.Exercises.DayFour.Models;

namespace CrashCourse2021.Exercises.DayFour.UI.Videos.Builders
{
    public class VideoUpdateBuilder: VideoBuilder
    {
        private Video _video;
        public void UpdateVideoData()
        {
            menuUtils.ReadIntegerFromString("Type in the Id of the item you want to update:", out var id);
            var video = videoService.ReadById(id);
            if (video != null)
            {
                menuUtils.ReadMinimumLengthString(
                    $"Write new Title for yor Video\nCurrent: {video.Title}",
                    out var title
                    , 2);
                menuUtils.ReadMinimumLengthString(
                    $"Write new StoryLine for yor Video\nCurrent: {video.StoryLine}",
                    out var storyLine, 
                    2);
                menuUtils.ReadDateFrom(
                    $"Write new ReleaseDate (2012-02-22/year-month-date) for yor Video\nCurrent: {video.ReleaseDate.ToLongDateString()}",
                    out var releaseDate);
                _video = new Video{Title = title, StoryLine = storyLine, ReleaseDate = releaseDate};
            }
        }
        
        public override string GetConsoleOutputAsString()
        {
            if (_video == null)
            {
                return "Video Not Set!";
            }
            var video = videoService.Update(_video.Id, _video.Title, _video.StoryLine, _video.ReleaseDate);
            return video != null ? $"Video with ID: {video.Id} is Updated" : $"Something Went HORRIBLY WRONG!!!!\n";
        }
    }
}
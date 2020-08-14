
namespace CrashCourse2020ExercisesDayFourUI.Videos.Builders
{
    public class VideoDeleteBuilder: VideoBuilder
    {
        private int _id;
        public void DeleteVideoData()
        {
            menuUtils.ReadIntegerFromString("Type in the Id of the item you want to update:", out var id);
            _id = id;
        }
        
        public override string GetConsoleOutputAsString()
        {
            var deleted = videoService.Delete(_id);
            return deleted
                ? $"Video with ID: {_id}, has been successfully Deleted"
                : $"OH NO! Video with ID: {_id}, Was NOT deleted";
        }
    }
}
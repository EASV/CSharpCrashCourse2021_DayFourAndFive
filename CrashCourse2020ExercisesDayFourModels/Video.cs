using System;

namespace CrashCourse2020ExercisesDayFourModels
{
    public class Video: EntityModel
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string StoryLine { get; set; }
    }
}
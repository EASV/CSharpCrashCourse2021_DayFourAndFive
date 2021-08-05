using System;
using System.Collections.Generic;
using CrashCourse2021ExercisesDayFourModels;

namespace CrashCourse2021ExercisesDayFourService.Videos
{
    public interface IVideoService
    {
        List<Video> ReadAll();
        Video ReadById(int id);
        Video Create(string title, string storyLine, DateTime releaseDate);

        Video Update(int id, string title, string storyLine, DateTime releaseDate);
        bool Delete(int id);
    }
}
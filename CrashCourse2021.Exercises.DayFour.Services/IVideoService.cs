using System;
using System.Collections.Generic;
using CrashCourse2021.Exercises.DayFour.Models;

namespace CrashCourse2021.Exercises.DayFour.Services
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
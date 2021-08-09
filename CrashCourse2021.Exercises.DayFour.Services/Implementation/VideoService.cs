using System;
using System.Collections.Generic;
using CrashCourse2021.Exercises.DayFour.DataLayer;
using CrashCourse2021.Exercises.DayFour.Models;

namespace CrashCourse2021.Exercises.DayFour.Services.Implementation
{
    public class VideoService: IVideoService
    {
        private readonly VideoTable _table;
        public VideoService()
        {
            _table = VideoTable.GetInstance();
        }
        
        public List<Video> ReadAll()
        {
            return _table.GetAllVideos();
        }

        public Video ReadById(int id)
        {
            return _table.GetVideo(id);
        }

        public Video Create(string title, string storyLine, DateTime releaseDate)
        {
            return _table.AddVideo(new Video
            {
                Title = title,
                StoryLine = storyLine,
                ReleaseDate = releaseDate
            });
        }

        public Video Update(int id, string title, string storyLine, DateTime releaseDate)
        {
            return _table.UpdateVideo(new Video
            {
                Id = id,
                Title = title,
                StoryLine = storyLine,
                ReleaseDate = releaseDate
            });
        }

        public bool Delete(int id)
        {
            return _table.DeleteVideo(id);
        }
    }
}
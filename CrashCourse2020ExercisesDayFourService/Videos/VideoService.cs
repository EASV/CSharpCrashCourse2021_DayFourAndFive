using System;
using System.Collections.Generic;
using CrashCourse2020ExercisesDayFourDataLayer;
using CrashCourse2020ExercisesDayFourModels;

namespace CrashCourse2020ExercisesDayFourService.Videos
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
            return this._table.GetAllVideos();
        }

        public Video ReadById(int id)
        {
            return this._table.GetVideo(id);
        }

        public Video Create(string title, string storyLine, DateTime releaseDate)
        {
            return this._table.AddVideo(new Video
            {
                Title = title,
                StoryLine = storyLine,
                ReleaseDate = releaseDate
            });
        }

        public Video Update(int id, string title, string storyLine, DateTime releaseDate)
        {
            return this._table.UpdateVideo(new Video
            {
                Id = id,
                Title = title,
                StoryLine = storyLine,
                ReleaseDate = releaseDate
            });
        }

        public bool Delete(int id)
        {
            return this._table.DeleteVideo(id);
        }
    }
}
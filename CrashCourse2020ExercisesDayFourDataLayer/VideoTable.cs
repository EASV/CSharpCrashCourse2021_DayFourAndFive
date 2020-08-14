using System;
using System.Collections.Generic;
using System.Linq;
using CrashCourse2020ExercisesDayFourModels;

namespace CrashCourse2020ExercisesDayFourDataLayer
{
    public class VideoTable
    {
        private static int _id;
        private static VideoTable _instance;
        private static List<Video> _videos;

        private VideoTable()
        {
            _videos = new List<Video>();
            _id = 0;
            InitVideos();
        }

        public static VideoTable GetInstance()
        {
            return _instance ??= new VideoTable();
        }

        private void InitVideos()
        {
            _videos.Add(new Video
            {
                Id = ++_id,
                Title = "Gone with the SNOUT",
                ReleaseDate = DateTime.Now.AddYears(-100),
                StoryLine = "Bad Ass movie about Snouts \nAnd the dream of being the next MASTER Snout!"
            });
        }

        public List<Video> GetAllVideos()
        {
            return _videos;
        }

        public Video GetVideo(int id)
        {
            return _videos.Find(video => video.Id == id);
        }

        public Video AddVideo(Video video)
        {
            video.Id = ++_id;
            _videos.Add(video);
            return video;
        }

        public Video UpdateVideo(Video video)
        {
            var videoToUpdate = _videos.FirstOrDefault(vid => vid.Id == video.Id);
            videoToUpdate.Title = video.Title;
            videoToUpdate.ReleaseDate = video.ReleaseDate;
            videoToUpdate.StoryLine = video.StoryLine;
            return videoToUpdate;
        }

        public bool DeleteVideo(int id)
        {
            _videos = _videos.Where(video => video.Id != id).ToList();
            return _videos.FirstOrDefault(video => video.Id == id) == null;
        }
    }
}
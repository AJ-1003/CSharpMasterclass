using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class VideoPost : Post
    {
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        protected bool isPlaying = false;
        public int currentTime;
        public string duration;
        Timer timer;
        TimeSpan ts;

        public VideoPost()
        {

        }

        public VideoPost(string title, string sentByUsername, bool isPublic, string videoUrl, int length)
        {
            Id = GetNextId();
            Title = title;
            SentByUsername = sentByUsername;
            IsPublic = isPublic;
            VideoURL = videoUrl;
            Length = length;
        }

        public override string ToString()
        {
            return $"{Id} - {Title} - {SentByUsername} - {VideoURL}";
        }

        public void PlayVideo()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        public void TimerCallback(Object o)
        {
            if (currentTime < Length)
            {
                currentTime++;
                ts = TimeSpan.FromSeconds(currentTime);
                duration = ts.ToString(@"hh\:mm\:ss");
                Console.WriteLine($"Video at {duration}");
                GC.Collect();
            }
            else
            {
                StopVideo();
            }
        }

        public void StopVideo()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {duration}");
                currentTime = 0;
                timer.Dispose();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EventExample
    {
        public class VideoPlayer
        {
            public event EventHandler VideoStarted;
            public void PlayVideo(string videoName)
            {
                Console.WriteLine($"Playing video: {videoName}");
                OnVideoStarted();
            }
            protected virtual void OnVideoStarted()
            {
                VideoStarted?.Invoke(this, EventArgs.Empty);
            }
        }
        public class User
        {
            public void Subscribe(VideoPlayer videoPlayer)
            {
                videoPlayer.VideoStarted += VideoPlayer_VideoStarted;
            }
            private void VideoPlayer_VideoStarted(object sender, EventArgs e)
            {
                Console.WriteLine("Video has started!");
            }
        }
    }
}

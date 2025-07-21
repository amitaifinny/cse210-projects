public class VideoManager
{
    private List<Video> _videos = new List<Video>();

    public void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }
}
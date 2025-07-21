using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Benefits of OOP", "Kevin", 500);
        video1.AddComment(new Comment("OOP Fan", "This video perfectly explains why OOP is so powerful. Clear and concise!"));
        video1.AddComment(new Comment("NewbieDev", "I'm just starting out with programming, and this really helped clarify some concepts. Thanks, Kevin!"));
        video1.AddComment(new Comment("CodeCritic", "Good overview, but I'd love to see more code examples in a follow-up video."));
        

        Video video2 = new Video("Exploring Quantum Computing", "Dr. Anya Sharma", 850);
        video2.AddComment(new Comment("PhysicsLover", "Absolutely fascinating! Dr. Sharma breaks down complex ideas beautifully."));
        video2.AddComment(new Comment("FutureTech", "Quantum computing still feels like sci-fi, but this video makes it feel a little closer. Amazing!"));
        video2.AddComment(new Comment("CuriousMind", "Are there any real-world applications of quantum computing happening now? Would love to know more."));
        

        Video video3 = new Video("The Art of Storytelling in Film", "Sarah Jenkins", 1500);
        video3.AddComment(new Comment("FilmBuff", "Sarah's insights on narrative structure are always top-tier. Essential viewing for aspiring filmmakers!"));
        video3.AddComment(new Comment("Screenwriter247", "This made me look at my current script with fresh eyes. Thank you for this!"));
        video3.AddComment(new Comment("Viewer_X", "I never realized how much thought goes into storytelling. Great analysis!"));
        

        Video video4 = new Video("Beginner's Guide to Photography", "LensMaster Phil", 720);
        video4.AddComment(new Comment("ShutterBug", "Phil's tips are always so practical for beginners. My photos are already improving!"));
        video4.AddComment(new Comment("AmateurSnap", "Great advice on lighting! My biggest struggle solved."));
        video4.AddComment(new Comment("PhotoQuest", "Could you do a video on post-processing for beginners next?"));

        VideoManager Videos = new VideoManager();
        Videos.AddVideo(video1);
        Videos.AddVideo(video2);
        Videos.AddVideo(video3);
        Videos.AddVideo(video4);

        Videos.DisplayVideos();

    }
}
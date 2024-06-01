using System;

class Program{
    static void InitializeProgram(List<Video> videoList)
    {
        Comment comment1;Comment comment2;Comment comment3;
        Video video;List<Comment> commentList;

        comment1 = new Comment("Kevinfortier556", "Damn, I have a ton of respect for you standing up for those struggling in the tech community. You're a real one");
        comment2 = new Comment("danylo.s", "Influencers are contributing to the problem.");
        comment3 = new Comment("BassHuey", "Yea the guys saying its a skill issue either have a job or have no clue or both.");
        commentList = new List<Comment>{comment1,comment2,comment3};
        video = new Video("Theo Throwaways",
        "A rant about the 2024 tech job market.", 500, commentList);
        videoList.Add(video);

        comment1 = new Comment("user-qe2ps9vm9o", "TLDW: spend 3 years investing in yourself and it will pay off for the rest of your life.");
        comment2 = new Comment("waynelast1685", "My HUGE mistake. Be BOLD. Make BIG changes quickly...");
        comment3 = new Comment("KeithTharp", "I started a coding bootcamp at 50 years old, 4 years ago during COVID. I now have a great software engineering job.");
        commentList = new List<Comment>{comment1,comment2,comment3};
        video = new Video("Travis Media",
        "Why You'll WASTE The Next 3 Years. ", 340, commentList);
        videoList.Add(video);

        comment1 = new Comment("kebogu6123", "Your arms are more jacked than mine, therefore i believe you");
        comment2 = new Comment("Loma008", "I failed my final 70/200. Last semester...");
        comment3 = new Comment("Lee-gvjv", "Jeff bezos hidden brother.");
        commentList = new List<Comment>{comment1,comment2,comment3};
        video = new Video("The Math Sorcerer",
        "It Only Takes Two Weeks", 410, commentList);
        videoList.Add(video);
    }
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>{};
        InitializeProgram(videoList);
        foreach(Video video in videoList)
        {
            video.Display();
            Console.WriteLine();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
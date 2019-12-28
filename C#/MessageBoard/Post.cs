using System;

namespace MessageBoard
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; private set; }
        public int Vote { get; private set; }

        public Post(string title)
        {
            Vote = 0;
            TimeCreated = DateTime.Now;
            Title = title;
        }

        public void Upvote()
        {
            ++Vote;
        }

        public void Downvote()
        {
            --Vote;
        }
    }
}

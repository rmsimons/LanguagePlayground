using System;

namespace MessageBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post("Idealism of posting without a description");
            post1.Upvote();
            post1.Upvote();
            post1.Downvote();
            post1.Upvote();
            post1.Downvote();
            post1.Upvote();
            post1.Upvote();

            Console.WriteLine("Current vote: " + post1.Vote);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post();

            newPost.Title = "My First Post";
            newPost.Description = "This post exists to test our knowledge of encapsulation in OOP";

            newPost.PrintPost();

            newPost.UpVote();
            newPost.UpVote();
            newPost.UpVote();
            newPost.UpVote();
            newPost.UpVote();

            newPost.PrintPost();

            newPost.DownVote();
            newPost.DownVote();
            newPost.DownVote();
            
            newPost.PrintPost();

            Console.WriteLine("Should throw exception - about to try to go into negative votes");
            newPost.DownVote();
            newPost.DownVote();
            newPost.DownVote();
            


        }

    }
}

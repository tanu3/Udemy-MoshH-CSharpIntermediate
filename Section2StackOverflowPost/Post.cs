using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2StackOverflowPost
{
    class Post
    {
        private String title;
        private String description;
        private DateTime creationDate;
        private int currentVoteValue = 0;

        public String Title 
        {
            get { return title; }
            set { title = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime CreationDate 
        { 
            get { return creationDate; } 
        }
        public int CurrentVoteValue 
        {
            get { return currentVoteValue; }
        }

        public Post()
        {
            this.creationDate = DateTime.Now;
        }

        public Post(String title, String description) : this()
        {
            this.Title = title;
            this.Description = description;
        }
                
        public int UpVote()
        {
            return this.currentVoteValue++;
        }

        public int DownVote()
        {
            if (this.currentVoteValue == 0)
            {
                throw new InvalidOperationException("Can't downvote a post that is at vote value of zero");
            }

            return this.currentVoteValue--;
        }

        public void PrintPost()
        {
            Console.WriteLine("Values before up and down voting:");
            Console.WriteLine("Title: {0}", this.Title);
            Console.WriteLine("Description: {0} ", this.Description);
            Console.WriteLine("Current vote value: {0}", this.CurrentVoteValue);
            Console.ReadLine();
        }
       
    

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class Post
    {
        private static int currentPostId;

        // protected proerties can be used by the base class and any derived classes
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SentByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            Id = 0;
            Title = "First Post";
            SentByUsername = "Ian";
            IsPublic = true;
        }

        public Post(string title, string sentByUsername, bool isPublic)
        {
            Id = GetNextId();
            Title = title;
            SentByUsername = sentByUsername;
            IsPublic = isPublic;
        }

        public int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - {SentByUsername}");
        }
    }
}

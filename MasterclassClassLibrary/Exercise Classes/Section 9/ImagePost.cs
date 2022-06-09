using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sentByUsername, bool isPublic, string imageUrl)
        {
            Id = GetNextId();
            Title = title;
            SentByUsername = sentByUsername;
            IsPublic = isPublic;
            ImageURL = imageUrl;
        }

        public override string ToString()
        {
            return $"{Id} - {Title} - {SentByUsername} - {ImageURL}";
        }
    }
}

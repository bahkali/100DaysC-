using System.Collections.Generic;

namespace FeedApp.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }

        public string Content { get; set; }

        public string CreatorName { get; set; }
    }
}
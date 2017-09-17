using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LukesBlog.DataAccessLayer.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public DateTime DatePosted { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int ID { get; set; }
        public DateTime DatePosted { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public int Likes { get; set; }

        public int BlogPostID { get; set; }
        public BlogPost CurrentBlogPost { get; set; }
        
    }
}
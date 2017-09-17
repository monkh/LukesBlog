using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LukesBlog.DataAccessLayer.Models;

namespace LukesBlog.DataAccessLayer.Repositories
{
    public class BlogPostRepository : Repository<BlogPost>
    {
        public List<BlogPost> GetBlogPostByID(int id)
        {
            return DbSet.Where(p => p.ID.Equals(id)).ToList();
        }
        
    }
}
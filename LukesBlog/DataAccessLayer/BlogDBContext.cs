using LukesBlog.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LukesBlog.DataAccessLayer
{
    public class BlogDBContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
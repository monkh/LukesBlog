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
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasRequired<BlogPost>(c => c.CurrentBlogPost)
                .WithMany(bp => bp.Comments)
                .HasForeignKey<int>(c => c.BlogPostID);

            modelBuilder.Entity<BlogPost>()
                .Property(m => m.Authored)
                .IsOptional();

            modelBuilder.Entity<BlogPost>()
                .Property(t => t.Body)
                .HasMaxLength(4000);


        }
    }
}
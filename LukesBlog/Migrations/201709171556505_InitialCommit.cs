namespace LukesBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DatePosted = c.DateTime(nullable: false),
                        Title = c.String(),
                        Body = c.String(),
                        Author = c.String(),
                        Likes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DatePosted = c.DateTime(nullable: false),
                        Name = c.String(),
                        Body = c.String(),
                        Likes = c.Int(nullable: false),
                        BlogPostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BlogPosts", t => t.BlogPostID, cascadeDelete: true)
                .Index(t => t.BlogPostID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "BlogPostID", "dbo.BlogPosts");
            DropIndex("dbo.Comments", new[] { "BlogPostID" });
            DropTable("dbo.Comments");
            DropTable("dbo.BlogPosts");
        }
    }
}

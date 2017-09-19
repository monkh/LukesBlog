namespace LukesBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTags123andimgsrc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "tag1", c => c.String(maxLength: 20));
            AddColumn("dbo.BlogPosts", "tag2", c => c.String(maxLength: 20));
            AddColumn("dbo.BlogPosts", "tag3", c => c.String(maxLength: 20));
            AddColumn("dbo.BlogPosts", "imgsrc", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogPosts", "imgsrc");
            DropColumn("dbo.BlogPosts", "tag3");
            DropColumn("dbo.BlogPosts", "tag2");
            DropColumn("dbo.BlogPosts", "tag1");
        }
    }
}

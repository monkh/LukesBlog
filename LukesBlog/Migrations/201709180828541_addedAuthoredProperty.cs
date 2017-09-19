namespace LukesBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAuthoredProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "Authored", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogPosts", "Authored");
        }
    }
}

namespace LukesBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeAuthoredOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BlogPosts", "Authored", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BlogPosts", "Authored", c => c.Boolean(nullable: false));
        }
    }
}

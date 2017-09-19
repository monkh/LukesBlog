namespace LukesBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMaxLengths : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BlogPosts", "Title", c => c.String(maxLength: 250));
            AlterColumn("dbo.BlogPosts", "Author", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BlogPosts", "Author", c => c.String());
            AlterColumn("dbo.BlogPosts", "Title", c => c.String());
        }
    }
}

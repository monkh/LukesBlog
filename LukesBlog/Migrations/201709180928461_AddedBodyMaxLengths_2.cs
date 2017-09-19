namespace LukesBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBodyMaxLengths_2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BlogPosts", "Body", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BlogPosts", "Body", c => c.String());
        }
    }
}

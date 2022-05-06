namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.friends", "post_writtenPost", c => c.String());
            AddColumn("dbo.friends", "post_imgPath", c => c.String());
            AddColumn("dbo.friends", "post_comment", c => c.String());
            AddColumn("dbo.friends", "post_likes", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.friends", "post_likes");
            DropColumn("dbo.friends", "post_comment");
            DropColumn("dbo.friends", "post_imgPath");
            DropColumn("dbo.friends", "post_writtenPost");
        }
    }
}

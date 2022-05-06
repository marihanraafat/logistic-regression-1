namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f12 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.posts", "comment");
            //DropColumn("dbo.posts", "likes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.posts", "likes", c => c.Int(nullable: false));
            AddColumn("dbo.posts", "comment", c => c.String());
        }
    }
}

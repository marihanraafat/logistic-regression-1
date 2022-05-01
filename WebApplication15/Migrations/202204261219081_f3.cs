namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.friends", "imagePpath", c => c.String());
            AddColumn("dbo.friends", "country", c => c.String());
            AddColumn("dbo.friends", "city", c => c.String());
            AddColumn("dbo.friends", "email", c => c.String());
            AddColumn("dbo.friends", "mobile", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.friends", "mobile");
            DropColumn("dbo.friends", "email");
            DropColumn("dbo.friends", "city");
            DropColumn("dbo.friends", "country");
            DropColumn("dbo.friends", "imagePpath");
        }
    }
}

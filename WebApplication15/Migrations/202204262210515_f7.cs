namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.friends", "imagePpath2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.friends", "imagePpath2");
        }
    }
}

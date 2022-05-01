namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f6 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE friends SET imagePpath = '\\img\\images\\img.jpeg' WHERE id=5");
        }
        
        public override void Down()
        {
        }
    }
}

namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f11 : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE posts DROP COLUMN likes,comment;");
        }
        
        public override void Down()
        {
        }
    }
}

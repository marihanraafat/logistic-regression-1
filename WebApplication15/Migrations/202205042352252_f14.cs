namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f14 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM posts WHERE id = 1028");
            Sql("DELETE FROM posts WHERE id = 1031");
        }
        
        public override void Down()
        {
        }
    }
}

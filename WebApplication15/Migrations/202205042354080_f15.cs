namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f15 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM posts WHERE id = 1027");
        }
        
        public override void Down()
        {
        }
    }
}

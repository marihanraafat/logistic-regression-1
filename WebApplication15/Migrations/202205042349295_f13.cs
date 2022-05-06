namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f13 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM posts WHERE id = 1029");
            Sql("DELETE FROM posts WHERE id = 1030");
        }
        
        public override void Down()
        {
        }
    }
}

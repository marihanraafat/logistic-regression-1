namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f16 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM posts WHERE id = 1026");
            Sql("DELETE FROM posts WHERE id = 1025");
            Sql("DELETE FROM posts WHERE id = 1024");
            Sql("DELETE FROM posts WHERE id = 1023");
        }
        
        public override void Down()
        {
        }
    }
}

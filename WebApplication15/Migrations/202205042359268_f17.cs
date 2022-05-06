namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f17 : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from posts");
        }
        
        public override void Down()
        {
        }
    }
}

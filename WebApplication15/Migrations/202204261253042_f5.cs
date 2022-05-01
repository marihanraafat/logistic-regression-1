namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f5 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM friends WHERE name = 'Null'");
        }
        
        public override void Down()
        {
        }
    }
}

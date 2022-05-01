namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO friends VALUES('Osama Emam');");
        }
        
        public override void Down()
        {
        }
    }
}

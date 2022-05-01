namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFriend : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO friends VALUES('Nourhan Reda');");
            Sql("INSERT INTO friends VALUES('Ali Ehab');");
            Sql("INSERT INTO friends VALUES('Mayada Adel');");
            
        }
        
        public override void Down()
        {
        }
    }
}

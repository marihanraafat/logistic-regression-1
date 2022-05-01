namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f8 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE friends SET imagePpath2 = '\\img\\images\\mero.jpeg' WHERE id=5");
            Sql("UPDATE friends SET imagePpath2 = '\\img\\images\\nour-profile.jpg' WHERE id=6");
            Sql("UPDATE friends SET imagePpath2 = '\\img\\images\\mayada-profile.jpg' WHERE id=7");
            Sql("UPDATE friends SET imagePpath2 = '\\img\\images\\osama-profile.jpg' WHERE id=8");
        }
        
        public override void Down()
        {
        }
    }
}

namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f41 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO friends VALUES('Marihan Raafat','\\img\\images\\mero.jpeg','Giza','6-october','marihanmariham1234@gmail.com','01100042795');");
            Sql("INSERT INTO friends VALUES('Nourhan Reda','\\img\\images\\nour-cover.jpg','Cairo','imbaba','noyrReda@gmail.com','01234567891');");
            Sql("INSERT INTO friends VALUES('Mayada Adel','\\img\\images\\mayada-cover.jpg','Giza','6-october','mayadaAdel@gmail.com','01115467844');");
            Sql("INSERT INTO friends VALUES('Osama Emam','\\img\\images\\osama-cover.jpg','Cairo','Fifth District','osamaEmam@gmail.com','01023768965');");
        }
        
        public override void Down()
        {
        }
    }
}

namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        writtenPost = c.String(),
                        imgPath = c.String(),
                        comment = c.String(),
                        likes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.friends", "post_id", c => c.Int());
            CreateIndex("dbo.friends", "post_id");
            AddForeignKey("dbo.friends", "post_id", "dbo.posts", "id");

        }
        
        public override void Down()
        {
            AddColumn("dbo.friends", "post_likes", c => c.Int(nullable: false));
            AddColumn("dbo.friends", "post_comment", c => c.String());
            AddColumn("dbo.friends", "post_imgPath", c => c.String());
            AddColumn("dbo.friends", "post_writtenPost", c => c.String());

        }
    }
}

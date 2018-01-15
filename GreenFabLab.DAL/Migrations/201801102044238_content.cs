namespace GreenFabLab.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class content : DbMigration
    {
        public override void Up()
        {
           
              
           
            
            CreateTable(
                "dbo.WebsiteContent",
                c => new
                    {
                        WebsiteContentID = c.Int(nullable: false, identity: true),
                        ContentLbl = c.String(),
                        Content = c.String(),
                        ContentTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WebsiteContentID)
                .ForeignKey("dbo.ContentType_Master", t => t.ContentTypeID)
                .Index(t => t.ContentTypeID);
            
            CreateTable(
                "dbo.ContentType_Master",
                c => new
                    {
                        ContentTypeID = c.Int(nullable: false, identity: true),
                        ContentType = c.String(),
                        ContentTypeCode = c.String(),
                    })
                .PrimaryKey(t => t.ContentTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WebsiteContent", "ContentTypeID", "dbo.ContentType_Master");
            DropIndex("dbo.WebsiteContent", new[] { "ContentTypeID" });
            DropTable("dbo.ContentType_Master");
            DropTable("dbo.WebsiteContent");
        }
    }
}

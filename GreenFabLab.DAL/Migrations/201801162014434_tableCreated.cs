namespace GreenFabLab.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Telephone = c.String(),
                        Country = c.String(),
                        PostCode = c.String(),
                        ProjectSection = c.String(),
                        Mobile = c.String(),
                        DOB = c.DateTime(),
                        RegDocumentPath = c.String(),
                        MedicineReceipt = c.String(),
                        FlatHouseNameNumber = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        CreatedByID = c.Int(),
                        ModifiedByID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID);
            
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
            DropTable("dbo.Users");
        }
    }
}

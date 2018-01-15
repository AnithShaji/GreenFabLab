namespace GreenFabLab.DAL.Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}

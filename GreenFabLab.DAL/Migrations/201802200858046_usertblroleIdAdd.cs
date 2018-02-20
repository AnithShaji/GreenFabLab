namespace GreenFabLab.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertblroleIdAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserRoleID", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "UserRoleID");
            AddForeignKey("dbo.Users", "UserRoleID", "dbo.UserRole", "UserRoleID");
            DropColumn("dbo.Users", "MedicineReceipt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "MedicineReceipt", c => c.String());
            DropForeignKey("dbo.Users", "UserRoleID", "dbo.UserRole");
            DropIndex("dbo.Users", new[] { "UserRoleID" });
            DropColumn("dbo.Users", "UserRoleID");
        }
    }
}

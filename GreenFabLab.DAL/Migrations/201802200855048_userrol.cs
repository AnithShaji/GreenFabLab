namespace GreenFabLab.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userrol : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        UserRoleID = c.Int(nullable: false, identity: true),
                        UserRoleName = c.String(),
                        UserRoleCode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserRoleID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserRole");
        }
    }
}

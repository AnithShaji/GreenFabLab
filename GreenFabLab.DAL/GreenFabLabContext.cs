using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using GreenFabLab.DAL.Migration;
using GreenFabLab.DTO;
using GreenFabLab.DAL.Migrations;

namespace GreenFabLab.DAL
{
  
public partial class GreenFabLabContext : DbContext
{
    public GreenFabLabContext()
        : base("name=GreenFabLabContext")
    {
        Database.SetInitializer(new MigrateDatabaseToLatestVersion<GreenFabLabContext, Configuration>());
    }


    #region Master tables    
    public DbSet<ContentType_Master> ContentType_Master;
    //public DbSet<UserStatus_Master> UserStatus_Masters;
    #endregion

    public DbSet<Users> Users { get; set; }
    public DbSet<WebsiteContent> WebsiteContent { get; set; }
    //public DbSet<DTO.Medicine> Medicine { get; set; }
    //public DbSet<User_MedicineRelation> User_MedicineRelation { get; set; }
    //public DbSet<User_EducationRelation> User_EducationRelation { get; set; }
    //public DbSet<User_FoodRelation> User_FoodRelation { get; set; }
    //public DbSet<User_TrainingRelation> User_TrainingRelation { get; set; }
    //public DbSet<Food> Food { get; set; }
    //public DbSet<Training> Training { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //#region Master tables
        //modelBuilder.Entity<UserType>();
        modelBuilder.Entity<ContentType_Master>();
        //#endregion

        modelBuilder.Entity<Users>();
        modelBuilder.Entity<WebsiteContent>();
        //modelBuilder.Entity<Permissions>();
        //modelBuilder.Entity<DTO.Medicine>();

        //modelBuilder.Entity<User_EducationRelation>();
        //modelBuilder.Entity<User_FoodRelation>();
        //modelBuilder.Entity<User_TrainingRelation>();
        //modelBuilder.Entity<Food>();
        //modelBuilder.Entity<Training>();
    }
}

}
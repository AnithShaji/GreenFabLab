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
        public DbSet<UserRole> UserRole;
        #endregion

        public DbSet<Users> Users { get; set; }
        public DbSet<WebsiteContent> WebsiteContent { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //#region Master tables
            //modelBuilder.Entity<UserType>();
            modelBuilder.Entity<ContentType_Master>();
            modelBuilder.Entity<UserRole>();
            //#endregion

            modelBuilder.Entity<Users>();
            modelBuilder.Entity<WebsiteContent>();
            //modelBuilder.Entity<Permissions>();

        }
    }

}
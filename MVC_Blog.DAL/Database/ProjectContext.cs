using MVC_Blog.DAL.Mappings;
using MVC_Blog.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace MVC_Blog.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        //:base(nameOrConnectionString:"Server=;Database=;Uid=;Pwd=;")
        //:base(nameOrConnectionString: "Server=;Database=;Trusted_Connection=true;")
        //: base(nameOrConnectionString: "Server=;Database=;Trusted_Connection=true;")
        :base(nameOrConnectionString:"defaultConnection")
        {
            //Database.Connection.ConnectionString= @"Server=DESKTOP-VRS35K1\SQLSERVER2017EXP;Database=NBUY_MOD_DB;Uid=gulnihal;Password=123;";

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ContactPageMappings());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AboutPage> AboutPage { get; set; }

        public DbSet<ContactPage> ContactPage { get; set; }
    }
}

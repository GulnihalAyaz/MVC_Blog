namespace MVC_Blog.DAL.Migrations
{
    using MVC_Blog.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Blog.DAL.Database.ProjectContext>
    //DbMigrationsConfiguration'dan geliyor ve ProjectContext için çalýþýyor.
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_Blog.DAL.Database.ProjectContext context)
        {
            if (!context.AboutPage.Any())
            {
                var aboutPage = new AboutPage
                {
                    TitleName = "Örnek baþlýk",
                    AboutDescription = "Seed ile gelen içerik bu þekilde kullanýlmalýdýr."
                };
                context.AboutPage.Add(aboutPage);
                context.SaveChanges();

            }
            //Normalde seedin içi boþtu bunlarý biz yazdýk biþey denemek için

            //  This method will be called after migrating to the latest version.
            

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

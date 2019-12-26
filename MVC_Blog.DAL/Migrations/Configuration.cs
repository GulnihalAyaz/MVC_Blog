namespace MVC_Blog.DAL.Migrations
{
    using MVC_Blog.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Blog.DAL.Database.ProjectContext>
    //DbMigrationsConfiguration'dan geliyor ve ProjectContext i�in �al���yor.
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
                    TitleName = "�rnek ba�l�k",
                    AboutDescription = "Seed ile gelen i�erik bu �ekilde kullan�lmal�d�r."
                };
                context.AboutPage.Add(aboutPage);
                context.SaveChanges();

            }
            //Normalde seedin i�i bo�tu bunlar� biz yazd�k bi�ey denemek i�in

            //  This method will be called after migrating to the latest version.
            

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

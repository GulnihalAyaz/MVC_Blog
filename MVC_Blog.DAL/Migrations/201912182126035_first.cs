namespace MVC_Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "blog.About",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TitleName = c.String(),
                        AboutDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "blog.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        LinkedInProfile = c.String(),
                        GitHubProfile = c.String(),
                        TitleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("blog.Contact");
            DropTable("blog.About");
        }

        //Burda migration yap�l�rken �nce down metodu �al���r. Nas�l yap�ld�ysa tam tersi �ekilde �al���r. Daha sonra Up �al���r down'�n yapt�klar�n�n tam tersini yapar.
        //Teknik olarak bunlar fluent API ye benziyor
    }
}

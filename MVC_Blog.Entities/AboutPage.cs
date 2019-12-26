using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog.Entities
{
    [Table(name:"About", Schema ="blog")]
    //bu data annotation. Sırf bir tane attribute kullanmak için bir kütüphaneyi dahil etmek zorunda kaldık kodumuza.
    public class AboutPage
    {

        public int Id { get; set; }
         
        public string TitleName { get; set; }

        public string AboutDescription { get; set; }
    }
}

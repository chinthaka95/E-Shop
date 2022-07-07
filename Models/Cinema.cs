using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class Cinema
    {

        [Key]
        public int Id { get; set; }

        [Display(Name= "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Descrption { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        [Required (ErrorMessage ="You must enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter a price")]
        public int Price { get; set; }  

    }
}

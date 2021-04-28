using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Field Required.")]
        public string categoryName { get; set; }

        public string categoryDescription { get; set; }

        public virtual List<Item> items { get; set; }
    }
}

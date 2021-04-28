using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Field Required.")]
        public string itemName { get; set; }

        [Required(ErrorMessage = "Field Required.")]
        public string itemCode { get; set; }

        public string itemDescription { get; set; }

        [ForeignKey("category")]
        public int categoryId { get; set; }

        public virtual Category category { get; set; }
    }
}

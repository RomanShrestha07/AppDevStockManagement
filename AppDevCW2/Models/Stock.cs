using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Models
{
    public class Stock
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Field Required.")]
        public int quantity { get; set; }

        [ForeignKey("item")]
        public int itemId { get; set; }

        public virtual Item item { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Models
{
    public class SaleDetail
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Field Required.")]
        public int quantity { get; set; }


        [Required(ErrorMessage = "Field Required.")]
        public int unitPrice { get; set; }


        [Required(ErrorMessage = "Field Required.")]
        public int totalAmount { get; set; }


        [ForeignKey("sale")]
        public int saleId { get; set; }

        public virtual Sale sale { get; set; }


        [ForeignKey("item")]
        public int itemId { get; set; }

        public virtual Item item { get; set; }
    }
}

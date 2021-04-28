using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Models
{
    public class Sale
    {
        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "Field Required.")]
        public int billNum { get; set; }


        [Required(ErrorMessage = "Field Required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime saleDate { get; set; }


        [ForeignKey("customer")]
        public int customerId { get; set; }

        public virtual Customer customer { get; set; }
    }
}

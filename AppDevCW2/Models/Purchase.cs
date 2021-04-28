using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Models
{
    public class Purchase
    {
        [Key]
        public int id { get; set; }


        public string vendor { get; set; }


        [Required(ErrorMessage = "Field Required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime purchaseDate { get; set; }


        [Required(ErrorMessage = "Field Required.")]
        public int billNumber { get; set; }
    }
}

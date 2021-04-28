using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Field Required.")]
        public string customerName { get; set; }

        public string customerAddress { get; set; }

        public int customerContact { get; set; }

        public string customerEmail { get; set; }
    }
}

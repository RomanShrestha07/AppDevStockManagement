using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.ViewModels
{
    public class NotBoughtViewModel
    {
        public int customerId { get; set; }

        public string customerName { get; set; }

        public string customerEmail { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime lastSaleDate { get; set; }
    }
}

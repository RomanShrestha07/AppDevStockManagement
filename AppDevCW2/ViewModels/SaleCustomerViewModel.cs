using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.ViewModels
{
    public class SaleCustomerViewModel
    {
        public int customerId { get; set; }

        public string customerName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime saleDate { get; set; }

        public int saleQuantity { get; set; }

        public int unitPrice { get; set; }

        public int totalAmount { get; set; }

        public string itemName { get; set; }
    }
}

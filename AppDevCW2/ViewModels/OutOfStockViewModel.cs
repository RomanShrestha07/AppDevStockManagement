using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.ViewModels
{
    public class OutOfStockViewModel
    {
        public int itemId { get; set; }

        public string itemName { get; set; }

        public string itemCode { get; set; }

        public int itemQuantity { get; set; }
    }
}

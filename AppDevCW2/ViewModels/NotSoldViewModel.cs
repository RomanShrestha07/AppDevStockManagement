using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.ViewModels
{
    public class NotSoldViewModel
    {
        public int itemId { get; set; }

        public string itemName { get; set; }

        public string itemCode { get; set; }

        public int itemQuantity { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime lastSaleDate { get; set; }
    }
}

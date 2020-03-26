using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzatoryApp.Models
{
    public class InventoryModel
    {
        [Required(ErrorMessage = "You must enter a product name")]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Product Name")]
        public string ItemName { get; set; }

        [Range(1, 9999, ErrorMessage = "enter amount under 10000")]
        [Required(ErrorMessage = "You must enter an amount needed")]
        [Display(Name = "Stock Needed")]
        public int StockNeeded { get; set; }

        [Range(0, 9999)]
        [Required(ErrorMessage = "You must enter the amount in stock")]
        [Display(Name = "Amount Currently On Hand")]
        public int OnHand { get; set; }

    }
}

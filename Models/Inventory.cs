using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzatoryApp.Models
{
    public class Inventory
    {
        public string ItemName { get; set; }
        public int StockNeeded { get; set; }
        public int OnHand { get; set; }

    }
}

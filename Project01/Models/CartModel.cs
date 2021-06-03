using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class CartModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int TotalPrice { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }

    }
}

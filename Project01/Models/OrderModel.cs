using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        //public int ItemId { get; set; }
    }
}

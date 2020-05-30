using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Address { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int ZipCode { get; set; }
        public int PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsigidiyorOOP_Example.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int MasterOrderId { get; set; }
        public int ProductId { get; set; }
        public decimal ProductCount { get; set; }
        public decimal OrderPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsigidiyorOOP_Example.Entities
{
    public class MasterOrder
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderDate { get; set; }
    }
}

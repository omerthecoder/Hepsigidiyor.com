using HepsigidiyorOOP_Example.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsigidiyorOOP_Example.FakeDb
{
    public static class Database
    {
        public static int ProductIdNumber = 0;
        public static List<Product> Products = new List<Product>();

        public static int OrderIdNumber = 0;
        public static List<Order> Orders = new List<Order>();

        //public static int MasterOrderIdNumber = 0;
        public static List<MasterOrder> MasterOrders = new List<MasterOrder>();
    }
}

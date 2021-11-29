using HepsigidiyorOOP_Example.Entities;
using HepsigidiyorOOP_Example.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsigidiyorOOP_Example.Repositories
{
    class OrderRepository
    {
        public void Add(Order or)
        {
            if (or != null)
            {
                int i = ++Database.OrderIdNumber;
                or.Id = i;
                Database.Orders.Add(or);
            }
        }
        public List<Order> Get()
        {
            return Database.Orders;
        }
        public void Delete(int id)
        {
            Order or = FindById(id);
            if (or != null)
            {
                Database.Orders.Remove(or);
            }
        }
        public Order FindById(int id)
        {
            Order or = Database.Orders.FirstOrDefault(t0 => t0.Id == id);
            return or;
        }
        public void Update(Order or)
        {
            Order o = FindById(or.Id);
            if (o != null)
            {
                o.ProductId = or.ProductId;
                o.ProductCount = or.ProductCount;
                o.OrderPrice = or.OrderPrice;
            }
        }
    }
}

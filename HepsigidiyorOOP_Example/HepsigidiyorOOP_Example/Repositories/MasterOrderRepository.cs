using HepsigidiyorOOP_Example.Entities;
using HepsigidiyorOOP_Example.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsigidiyorOOP_Example.Repositories
{
    public class MasterOrderRepository
    {
        public void Add(MasterOrder mr)
        {
            if (mr != null)
            {
                //int i = ++Database.MasterOrderIdNumber;
                //mr.Id = i;
                Database.MasterOrders.Add(mr);
            }
        }
        public List<MasterOrder> Get()
        {
            return Database.MasterOrders;
        }
        public void Delete(int id)
        {
            MasterOrder mr = FindById(id);
            if (mr != null)
            {
                Database.MasterOrders.Remove(mr);
            }
        }
        public MasterOrder FindById(int id)
        {
            MasterOrder mr = Database.MasterOrders.FirstOrDefault(t0 => t0.Id == id);
            return mr;
        }
        public void Update(MasterOrder mr)
        {
            MasterOrder m = FindById(mr.Id);
            if (m != null)
            {
                m.OrderDate = mr.OrderDate;
                m.TotalPrice = mr.TotalPrice;
            }
        }
    }
}

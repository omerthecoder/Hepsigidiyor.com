using HepsigidiyorOOP_Example.Entities;
using HepsigidiyorOOP_Example.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsigidiyorOOP_Example.Repositories
{
    public class ProductRepository
    {
        public void Add(Product pr)
        {
            if (pr!=null)
            {
                int i = ++Database.ProductIdNumber;
                pr.Id = i;
                Database.Products.Add(pr);
            }
        }
        public List<Product> Get()
        {
            return Database.Products;
        }
        public void Delete(int id)
        {
            Product pr = FindById(id);
            if (pr!=null)
            {
                Database.Products.Remove(pr);
            }
        }
        public Product FindById(int id)
        {
            Product pr = Database.Products.FirstOrDefault(t0 => t0.Id == id);
            return pr;
        }
        public void Update(Product pr)
        {
            Product p = FindById(pr.Id);
            if (p!=null)
            {
                p.ProductName = pr.ProductName;
                p.ProductPrice = pr.ProductPrice;
            }
        }
       
    }
}

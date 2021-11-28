using HepsigidiyorOOP_Example.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsigidiyorOOP_Example.Repositories
{
    public class DummyData
    {
        ProductRepository PR = new ProductRepository();
        Product product1 = new Product();
        Product product2 = new Product();
        Product product3 = new Product();
        Product product4 = new Product();
        Product product5 = new Product();

        public void Seed()
        {
            product1.ProductName = "Notebook";
            product1.ProductPrice = 15000;
            product2.ProductName = "Elektrikli Süpürge";
            product2.ProductPrice = 3000;
            product3.ProductName = "Fırın";
            product3.ProductPrice = 1000;
            product4.ProductName = "Buzdolabı";
            product4.ProductPrice = 8000;
            product5.ProductName = "Gitar";
            product5.ProductPrice = 5500;
            PR.Add(product1);
            PR.Add(product2);
            PR.Add(product3);
            PR.Add(product4);
            PR.Add(product5);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.Demo
{
    class ProductDemo
    {
        public Product createProductTest(int id, string name, int categoryId)
        {
            Product product = new Product(id, name, categoryId);
            return product;
        }
        public void printProductTest(Product product)
        {
            Console.WriteLine("Product {" + product.getId() + ", " + product.getName() + ", " + product.getCategoryId() + "}");
        }
    }
}

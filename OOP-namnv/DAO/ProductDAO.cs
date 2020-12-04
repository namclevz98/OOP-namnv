using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.DAO
{
    class ProductDAO:BaseDAO
    {
        public ProductDAO()
        {
            tableName = Database.PRODUCT;
        }       
        public Product findById(int id)
        {
            var data = Database.getInstance();
            var productList = data.selectTable(Database.PRODUCT);
            foreach (Product product in productList)
            {
                if (product.getId() == id)
                    return product;
            }
            return null;
        }
        public Product findByName(string name)
        {
            var data = Database.getInstance();
            foreach(Product product in data.selectTable(Database.PRODUCT))
            {
                if(product.getName().Equals(name))
                {
                    return product;
                }
            }
            return null;
        }
        public ArrayList search(string name)
        {
            var data = Database.getInstance();
            ArrayList productList = new ArrayList();
            foreach (Product product in data.selectTable(Database.PRODUCT))
            {
                if (product.getName().Contains(name))
                {
                    productList.Add(product);
                }
            }
            return productList;
        }
    }
}

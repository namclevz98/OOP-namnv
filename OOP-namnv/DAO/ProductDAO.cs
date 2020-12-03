using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.DAO
{
    class ProductDAO
    {
        public bool insert(Product product)
        {
            var data = Database.getInstance();
            return Convert.ToBoolean(data.insertTable(Database.PRODUCT, product));
        }
        public bool update(Product product)
        {
            var data = Database.getInstance();
            return Convert.ToBoolean(data.updateTable(Database.PRODUCT, product));
        }
        public bool delete(Product product)
        {
            var data = Database.getInstance();
            var result = data.deleteTable(Database.PRODUCT, product);
            return result;
        }
        public ArrayList findAll()
        {
            var data = Database.getInstance();
            var productList = data.selectTable(Database.PRODUCT);
            return productList;
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

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
            var result = data.insertTable(Database.PRODUCT, product);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool update(Product product)
        {
            var data = Database.getInstance();
            var result = data.updateTable(Database.PRODUCT, product);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                if (product.id == id)
                    return product;
            }
            return null;
        }
    }
}

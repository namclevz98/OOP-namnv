using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv
{
    class DatabaseDemo
    {
        public void insertTableTest<T>(string name, T row)
        {
            var data = Database.getInstance();
            data.insertTable(name, row);
        }
        public ArrayList selectTableTest(string name)
        {
            var data = Database.getInstance();
            return data.selectTable(name);
        }
        public void updateTableTest<T>(string name, T row)
        {
            var data = Database.getInstance();
            data.updateTable(name, row);
        }
        public void deleteTableTest<T>(string name, T row)
        {
            var data = Database.getInstance();
            data.deleteTable(name, row);
        }
        public void truncateTableTest(string name)
        {
            var data = Database.getInstance();
            data.truncateTable(name);
        }
        public void initDatabase()
        {
            var data = Database.getInstance();
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product(i, "PRODUCT" + i, i);
                Category category = new Category(i, "CATEGORY" + i);
                Accessory accessory = new Accessory(i, "ACCESSORY" + i);
                data.insertTable(Database.PRODUCT, product);
                data.insertTable(Database.CATEGORY, category);
                data.insertTable(Database.ACCESSORY, accessory);
            }
        }
        public void printDatabaseTest(string name)
        {
            var data = Database.getInstance();
            int i;
            if (name.Equals(Database.PRODUCT))
            {
                var productList = data.selectTable(name);
                for (i = 0; i < productList.Count; i++)
                {
                    Product product = (Product)Convert.ChangeType(productList[i], typeof(Product));
                    Console.WriteLine("Product {" + product.id + ", " + product.name + ", " + product.categoryId +"}");
                }
            }
            if (name.Equals(Database.CATEGORY))
            {
                var categoryList = data.selectTable(name);
                for (i = 0; i < categoryList.Count; i++)
                {
                    Category category = (Category)Convert.ChangeType(categoryList[i], typeof(Category));
                    Console.WriteLine("Category {" + category.id + ", " + category.name + "}");
                }
            }
            if (name.Equals(Database.ACCESSORY))
            {
                var accessoryList = data.selectTable(name);
                for (i = 0; i < accessoryList.Count; i++)
                {
                    Accessory accessory = (Accessory)Convert.ChangeType(accessoryList[i], typeof(Accessory));
                    Console.WriteLine("Accessory {" + accessory.id + ", " + accessory.name + "}");
                }
            }
        }
        public void updateTableTest<T> (string name, T row, int id)
        {
            var data = Database.getInstance();
            data.updateTable(name, row, id);
        }    
    }
}

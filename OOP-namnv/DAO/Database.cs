using System;
using OOP_namnv.Entity;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_namnv
{
    class Database
    {
        private ArrayList productTable = new ArrayList();

        private ArrayList categoryTable = new ArrayList();

        private ArrayList accessoryTable = new ArrayList();

        private static Database instance;

        public const string PRODUCT = "productTable";
        public const string CATEGORY = "categoryTable";
        public const string ACCESSORY = "accessoryTable";

        public static Database getInstance()
        {
            if(instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public int insertTable<T>(string name, T  row )
        {
            if(name.Equals(PRODUCT))
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                productTable.Add(product);
                return 1;
            }
            if (name.Equals(CATEGORY))
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                categoryTable.Add(category);
                return 1;
            }
            if (name.Equals(ACCESSORY))
            {
                Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                accessoryTable.Add(accessory);
                return 1;
            }
            return 0;
        }

        public ArrayList selectTable (string name)
        {
            
            if (name.Equals(PRODUCT))
            {
                return productTable;
            }
            if (name.Equals(CATEGORY))
            {
                return categoryTable;
            }
            if (name.Equals(ACCESSORY))
            {
                return accessoryTable;
            }
            return null;
        }
        public int updateTable<T>(string name, T row)
        {
            if (name.Equals(PRODUCT))
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                for(int i = 0; i < productTable.Count; i++)
                {
                    Product productTemp = (Product)Convert.ChangeType(productTable[i], typeof(Product));
                    if (productTemp.getId() == product.getId() )
                    {
                        productTable[i] = product;
                        return 1;
                    }
                }                
            }
            if (name.Equals(CATEGORY))
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    Category categoryTemp = (Category)Convert.ChangeType(categoryTable[i], typeof(Category));
                    if (categoryTemp.getId() == category.getId())
                    {
                        categoryTable[i] = category;
                        return 1;
                    }
                }
            }
            if (name.Equals(ACCESSORY))
            {
                Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    Accessory accessoryTemp = (Accessory)Convert.ChangeType(accessoryTable[i], typeof(Accessory));
                    if (accessoryTemp.getId() == accessory.getId())
                    {
                        accessoryTable[i] = accessory;
                        return 1;
                    }
                }
            }
            return 0;
        }
        public bool deleteTable<T>(string name, T row)
        {
            if (name.Equals(PRODUCT))
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                productTable.Remove(product);
                return true;
            }
            if (name.Equals(CATEGORY))
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                categoryTable.Remove(category);
                return true;
            }
            if (name.Equals(ACCESSORY))
            {
                Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                accessoryTable.Remove(accessory);
                return true;
            }
            return false;
        }
        public void truncateTable(string name)
        {
            if (name.Equals(PRODUCT))
            {
                productTable.Clear();
            }
            if (name.Equals(CATEGORY))
            {
                categoryTable.Clear();
            }
            if (name.Equals(ACCESSORY))
            {
                accessoryTable.Clear();
            }
        }

        public int updateTable<T> (string name, T row, int id )
        {
            if(name.Equals(PRODUCT))
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                for (int i = 0; i < productTable.Count; i++)
                {
                    Product productTemp = (Product)Convert.ChangeType(productTable[i], typeof(Product));
                    if (productTemp.getId() == id)
                    {
                        productTable[i] = product;
                        return 1;
                    }
                }
            }            
            if(name.Equals(CATEGORY))
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    Category categoryTemp = (Category)Convert.ChangeType(categoryTable[i], typeof(Category));
                    if (categoryTemp.getId() == id)
                    {
                        categoryTable[i] = category;
                        return 1;
                    }
                }
            }
            if (name.Equals(ACCESSORY))
            {
                Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    Accessory accessoryTemp = (Accessory)Convert.ChangeType(accessoryTable[i], typeof(Accessory));
                    if (accessoryTemp.getId() == id)
                    {
                        accessoryTable[i] = accessory;
                        return 1;
                    }
                }
            }
            return 0;
        }

    }
}

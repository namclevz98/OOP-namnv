using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.DAO
{
    public abstract class BaseDAO
    {
        private Database db;
        protected string tableName;

        public BaseDAO()
        {
            db = Database.getInstance();
        }
        public bool insert<T>(T row)
        {
            return Convert.ToBoolean(db.insertTable(tableName, row));
        }
        public bool update<T>(T row)
        {
            return Convert.ToBoolean(db.updateTable(tableName, row));
        }
        public bool delete<T>(T row)
        {
            return Convert.ToBoolean(db.deleteTable(tableName, row));
        }
        public ArrayList findAll()
        {
            return db.selectTable(tableName);
        }
        public ArrayList search(string name)
        {
            ArrayList list = new ArrayList();
            if(tableName.Equals(Database.PRODUCT))
            {
                foreach (Product product in db.selectTable(tableName))
                {
                    if (product.getName().Contains(name))
                    {
                        list.Add(product);
                    }
                }
                return list;
            }
            if (tableName.Equals(Database.CATEGORY))
            {
                foreach (Category category in db.selectTable(tableName))
                {
                    if (category.getName().Contains(name))
                    {
                        list.Add(category);
                    }
                }
                return list;
            }
            if (tableName.Equals(Database.ACCESSORY))
            {
                foreach (Accessory accessory in db.selectTable(tableName))
                {
                    if (accessory.getName().Contains(name))
                    {
                        list.Add(accessory);
                    }
                }
                return list;
            }
            return null;

        }

    }
}

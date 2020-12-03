using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.DAO
{
    class CategoryDAO
    {
        public bool insert(Category category)
        {
            var data = Database.getInstance();
            return Convert.ToBoolean(data.insertTable(Database.CATEGORY, category));
        }    
        public bool update(Category category)
        {
            var data = Database.getInstance();
            return Convert.ToBoolean(data.updateTable(Database.CATEGORY, category));
        }
        public bool delete(Category category)
        {
            var data = Database.getInstance();
            var result = data.deleteTable(Database.CATEGORY, category);
            return result;
        }
        public ArrayList findAll()
        {
            var data = Database.getInstance();
            var categoryList = data.selectTable(Database.CATEGORY);
            return categoryList;
        }
        public Category findById(int id)
        {
            var data = Database.getInstance();
            var categoryList = data.selectTable(Database.CATEGORY);
            foreach(Category category in categoryList)
            {
                if (category.getId() == id)
                    return category;
            }
            return null;
        }
        public Category findByName(string name)
        {
            var data = Database.getInstance();
            foreach (Category category in data.selectTable(Database.CATEGORY))
            {
                if (category.getName().Equals(name))
                {
                    return category;
                }
            }
            return null;
        }
        public ArrayList search(string name)
        {
            var data = Database.getInstance();
            ArrayList categoryList = new ArrayList();
            foreach (Category category in data.selectTable(Database.CATEGORY))
            {
                if (category.getName().Contains(name))
                {
                    categoryList.Add(category);
                }
            }
            return categoryList;
        }
    }
}

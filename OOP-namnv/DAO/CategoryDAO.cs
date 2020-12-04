using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.DAO
{
    class CategoryDAO : BaseDAO, IDao
    {
        public CategoryDAO()
        {
            tableName = Database.CATEGORY;
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

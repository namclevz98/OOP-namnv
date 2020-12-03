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
            var result = data.insertTable(Database.CATEGORY, category);
            if(result == 1)
            {
                return true;            
            }
            else
            {
                return false;
            }

        }    
        public bool update(Category category)
        {
            var data = Database.getInstance();
            var result = data.updateTable(Database.CATEGORY, category);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                if (category.id == id)
                    return category;
            }
            return null;
        }
    }
}

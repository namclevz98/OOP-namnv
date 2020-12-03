using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.Demo
{
    class CategoryDemo
    {
        public Category categoryDemo(int id, string name)
        {
            Category category = new Category(id, name);
            return category;
        }
        public void printCategoryDemo(Category category)
        {
            Console.WriteLine("Category {" + category.getId() + ", " + category.getName() + "}");
        }
    }
}

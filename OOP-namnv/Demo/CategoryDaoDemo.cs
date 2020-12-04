using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.DAO;
using OOP_namnv.Entity;

namespace OOP_namnv.Demo
{
    class CategoryDaoDemo
    {
        private CategoryDAO categoryDAO;
        public CategoryDaoDemo()
        {
            categoryDAO = new CategoryDAO();
        }
        public bool insertTest(Category category)
        {
            return categoryDAO.insert(category);
        }
        public bool updateTest(Category category)
        {
            return categoryDAO.update(category);
        }
        public bool deleteTest(Category category)
        {
            return categoryDAO.delete(category);
        }
        public ArrayList findAllTest()
        {
            return categoryDAO.findAll();
        }
        public Category findByIdTest(int id)
        {
            return categoryDAO.findById(id);
        }
        public Category findByNameTest(string name)
        {
            return categoryDAO.findByName(name);
        }
        public ArrayList searchTest(string name)
        {
            return categoryDAO.search(name);
        }
    }
}

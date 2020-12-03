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
        public void insertTest(Category category)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            categoryDAO.insert(category);
        }
        public void updateTest(Category category)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            categoryDAO.update(category);
        }
        public void deleteTest(Category category)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            categoryDAO.delete(category);
        }
        public ArrayList findAllTest()
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            return categoryDAO.findAll();
        }
        public Category findByIdTest(int id)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            return categoryDAO.findById(id);
        }
    }
}

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
    class ProductDaoDemo
    {
        public void insertTest(Product product)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.insert(product);
        }
        public void updateTest(Product product)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.update(product);
        }
        public void deleteTest(Product product)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.delete(product);
        }
        public ArrayList findAllTest()
        {
            ProductDAO productDAO = new ProductDAO();
            return productDAO.findAll();
        }
        public Product findByIdTest(int id)
        {
            ProductDAO productDAO = new ProductDAO();
            return productDAO.findById(id);
        }

    }
}

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
        private ProductDAO productDAO;
        public ProductDaoDemo()
        {
            productDAO = new ProductDAO();
        }
        public bool insertTest(Product product)
        {
            return productDAO.insert(product);
        }
        public bool updateTest(Product product)
        {
            return productDAO.update(product);
        }
        public bool deleteTest(Product product)
        {
            return productDAO.delete(product);
        }
        public ArrayList findAllTest()
        {
            return productDAO.findAll();
        }
        public Product findByIdTest(int id)
        {
            return productDAO.findById(id);
        }
        public Product findByNameTest(string name)
        {
            return productDAO.findByName(name);
        }
        public ArrayList searchTest(string name)
        {
            return productDAO.search(name);
        }

    }
}

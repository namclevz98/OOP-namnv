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
    class AccessoryDaoDemo
    {
        private AccessoryDAO accessoryDAO;
        public AccessoryDaoDemo()
        {
            accessoryDAO = new AccessoryDAO();
        }
        public bool insertTest(Accessory accessory)
        {
            return accessoryDAO.insert(accessory);
        }
        public bool updateTest(Accessory accessory)
        {
            return accessoryDAO.update(accessory);
        }
        public bool deleteTest(Accessory accessory)
        {
            return accessoryDAO.delete(accessory);
        }
        public ArrayList findAllTest()
        {
            return accessoryDAO.findAll();
        }
        public Accessory findByIdTest(int id)
        {
            return accessoryDAO.findById(id);
        }
        public Accessory findByNameTest(string name)
        {
            return accessoryDAO.findByName(name);
        }
        public ArrayList searchTest(string name)
        {
            return accessoryDAO.search(name);
        }
    }
}

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
        public void insertTest(Accessory accessory)
        {
            AccessoryDAO accessoryDAO = new AccessoryDAO();
            accessoryDAO.insert(accessory);
        }
        public void updatetTest(Accessory accessory)
        {
            AccessoryDAO accessoryDAO = new AccessoryDAO();
            accessoryDAO.update(accessory);
        }
        public void deletetTest(Accessory accessory)
        {
            AccessoryDAO accessoryDAO = new AccessoryDAO();
            accessoryDAO.delete(accessory);
        }
        public ArrayList findAllTest()
        {
            AccessoryDAO accessoryDAO = new AccessoryDAO();
            return accessoryDAO.findAll();
        }
        public Accessory findByIdTest(int id)
        {
            AccessoryDAO accessoryDAO = new AccessoryDAO();
            return accessoryDAO.findById(id);
        }
    }
}

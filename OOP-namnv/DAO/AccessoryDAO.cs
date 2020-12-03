using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.DAO
{
    class AccessoryDAO
    {
        public bool insert(Accessory accessory)
        {
            var data = Database.getInstance();
            var result = data.insertTable(Database.ACCESSORY, accessory);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool update(Accessory accessory)
        {
            var data = Database.getInstance();
            return Convert.ToBoolean(data.updateTable(Database.ACCESSORY, accessory));
        }
        public bool delete(Accessory accessory)
        {
            var data = Database.getInstance();
            var result = data.deleteTable(Database.ACCESSORY, accessory);
            return result;
        }
        public ArrayList findAll()
        {
            var data = Database.getInstance();
            var accessoryList = data.selectTable(Database.ACCESSORY);
            return accessoryList;
        }
        public Accessory findById(int id)
        {
            var data = Database.getInstance();
            var accessoryList = data.selectTable(Database.ACCESSORY);
            foreach (Accessory accessory in accessoryList)
            {
                if (accessory.id == id)
                    return accessory;
            }
            return null;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.DAO
{
    class AccessoryDAO : BaseDAO
    {
        public AccessoryDAO()
        {
            tableName = Database.ACCESSORY;
        }
        public Accessory findById(int id)
        {
            var data = Database.getInstance();
            var accessoryList = data.selectTable(Database.ACCESSORY);
            foreach (Accessory accessory in accessoryList)
            {
                if (accessory.getId() == id)
                    return accessory;
            }
            return null;
        }
        public Accessory findByName(string name)
        {
            var data = Database.getInstance();
            foreach (Accessory accessory in data.selectTable(Database.ACCESSORY))
            {
                if (accessory.getName().Equals(name))
                {
                    return accessory;
                }
            }
            return null;
        }
        public ArrayList search(string name)
        {
            var data = Database.getInstance();
            ArrayList accessoryList = new ArrayList();
            foreach (Accessory accessory in data.selectTable(Database.ACCESSORY))
            {
                if (accessory.getName().Contains(name))
                {
                    accessoryList.Add(accessory);
                }
            }
            return accessoryList;
        }
    }
}


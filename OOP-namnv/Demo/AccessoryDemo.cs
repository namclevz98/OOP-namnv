using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv.Demo
{
    class AccessoryDemo
    {
        public Accessory createAccessoryDemo(int id, string name)
        {
            Accessory accessory = new Accessory(id, name);
            return accessory;
        }
        public void printAccessoryDemo(Accessory accessory)
        {
            Console.WriteLine("Accessory {" + accessory.getId() + ", " + accessory.getName() + "}");
        }
    }
}

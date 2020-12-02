using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;

namespace OOP_namnv
{
    class DatabaseDemo
    {
        public void insertTableTest(string name, int row)
        {
            var data = Database.getInstance();
            data.insertTable(name, row);
        }
        public ArrayList selectTableTest(string name)
        {
            var data = Database.getInstance();
            return data.selectTable(name);
        }
        public void updateTableTest(string name, int row)
        {
            var data = Database.getInstance();
            data.updateTable(name, row);
        }
        public void deleteTableTest(string name, int row)
        {
            var data = Database.getInstance();
            data.deleteTable(name, row);
        }
        public void truncateTableTest(string name)
        {
            var data = Database.getInstance();
            data.truncateTable(name);
        }
    }
}

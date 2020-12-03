using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_namnv.DAO
{
    public abstract class BaseDAO
    {
        public string tableName;
        public bool insert<T>(T row)
        {
            var data = Database.getInstance();
            return Convert.ToBoolean(data.insertTable(tableName, row));
        }
        public bool update<T>(T row)
        {
            var data = Database.getInstance();
            return Convert.ToBoolean(data.updateTable(tableName, row));
        }
        public bool delete<T>(T row)
        {
            var data = Database.getInstance();
            return Convert.ToBoolean(data.deleteTable(tableName, row));
        }
        public ArrayList findAll<T>()
        {
            var data = Database.getInstance();
            return data.selectTable(tableName);
        }

    }
}

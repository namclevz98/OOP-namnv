using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_namnv
{
    class Program
    {
        static void Main(string[] args)
        {
            Database data = new Database();
            DatabaseDemo dbDemo = new DatabaseDemo();
            dbDemo.initDatabase();
            dbDemo.printDatabaseTest(Database.PRODUCT);
            Console.ReadKey();
        }
    }
}

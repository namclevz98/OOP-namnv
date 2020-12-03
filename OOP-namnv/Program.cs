using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_namnv.Entity;
using OOP_namnv.DAO;
using OOP_namnv.Demo;

namespace OOP_namnv
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDemo productDemo = new ProductDemo();
            var product = productDemo.createProductTest(10, "test", 1);
            DatabaseDemo dbDemo = new DatabaseDemo();
            dbDemo.initDatabase();
            dbDemo.insertTableTest(Database.PRODUCT, product);
            dbDemo.printDatabaseTest(Database.PRODUCT);

            Console.ReadKey();
        }
    }
}

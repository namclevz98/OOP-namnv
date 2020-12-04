using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_namnv.DAO
{
    interface IDao
    {
        bool insert<T>(T row);
        bool update<T>(T row);
        bool delete<T>(T row);
        ArrayList findAll();
        ArrayList search(string name);
    }
}

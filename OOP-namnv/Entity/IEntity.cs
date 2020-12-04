using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_namnv.Entity
{
    interface IEntity
    {
        int getId();
        void setId(int Id);
        string getName();
        void setName(string name);
    }
}

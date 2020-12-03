using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_namnv.Entity
{
    class Product:BaseRow
    {
        private int categoryId;

        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
        public int getCategoryId()
        {
            return categoryId;
        }
        public void setCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }
    }
}
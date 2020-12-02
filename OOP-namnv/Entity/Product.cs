using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_namnv.Entity
{
    class Product
    {
        public int id;
        public string name;
        public int categoryId;

        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(int id)
        {
            this.id = id;
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
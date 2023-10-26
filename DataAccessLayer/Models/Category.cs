using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Category
    {
        public string CategoryName { get; set; }

        public Category()
        {

        }
        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }


    }
}

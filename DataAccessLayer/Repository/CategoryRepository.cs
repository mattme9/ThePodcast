using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void addCategory()
        {

        }

        public void removeCategory()
        {

        }

        public void SaveCategory(string categoryName)
        {
            FileStream fs = new FileStream("filename.txt", FileMode.Append, FileAccess.Write);

            StreamWriter stream = new StreamWriter(fs);

            stream.WriteLine(categoryName);

            fs.Close();
            stream.Close();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            FileStream fs = new FileStream("filename.txt", FileMode.Open, FileAccess.Read);

            StreamReader stream = new StreamReader(fs);

            stream.ReadToEnd();
        }


    }
}

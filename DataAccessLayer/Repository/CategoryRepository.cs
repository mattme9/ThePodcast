using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void ChangeCategory(string oldCat, string newCat)
        {
            List<Category> list = GetAllCategories();
            List<Category> newList = new List<Category>();

            foreach (Category category in list)
            {
                if (category.CategoryName.Equals(oldCat))
                {
                    category.CategoryName = newCat;
                }
                newList.Add(category);
            }
            using(FileStream fs = new FileStream("filename.txt", FileMode.Create, FileAccess.Write))
            using(StreamWriter stream = new StreamWriter(fs))
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    stream.Write(newList[i].CategoryName);
                    if (i < newList.Count - 1)
                    {
                        stream.Write(",");
                    }
                }
            } 
        }

        public void removeCategory(string cat)
        {
            List<Category> list = GetAllCategories(); //Hämtar den nuvarande listan
            List<Category> newCats = new List<Category>(); //Den kommande uppdaterade listan

                foreach (Category category in list)
                {
                    if (!category.CategoryName.Equals(cat))
                    {
                        newCats.Add(category);
                    }
                }
                using (FileStream fs = new FileStream("filename.txt", FileMode.Create, FileAccess.Write))
                using (StreamWriter stream = new StreamWriter(fs))
                {

                for (int i = 0; i < newCats.Count; i++)
                {
                    stream.Write(newCats[i].CategoryName);
                    if (i < newCats.Count - 1)
                    {
                        stream.Write(",");
                    }
                }
            }        
        }

        public void AddAndSaveCategory(Category category)
        {
            using (FileStream fs = new FileStream("filename.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter stream = new StreamWriter(fs))
            {
                stream.Write(category.CategoryName + ",");
            }
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                FileStream fs = new FileStream("filename.txt", FileMode.Open, FileAccess.Read);
                StreamReader stream = new StreamReader(fs);

                string line = stream.ReadToEnd();
                string[] parts = line.Split(',');
                foreach (string part in parts)
                {
                    Category category = new Category(part);
                    categories.Add(category);
                }
                stream.Close();
                fs.Close();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return categories;
        }
    }
}

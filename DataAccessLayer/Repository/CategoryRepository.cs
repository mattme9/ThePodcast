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
        public void addCategory(Category category)
        {

        }

        public void removeCategory(string cat)
        {
            List<Category> list = new List<Category>();
            using (FileStream fs = new FileStream("filename.txt", FileMode.Open, FileAccess.ReadWrite))
            using (StreamWriter stream = new StreamWriter(fs))
            {
                list = GetAllCategories();
                foreach(Category category in list)
                {
                    if(category.CategoryName == cat)
                    {
                        list.Remove(category);
                    }
                }
                //Fortsätt på detta och gör klart skiten. Kanske göra en metod som tar emot
                //en lista och sparar ner alles. Auf Wiedersehen!
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
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return categories;


        }


    }
}

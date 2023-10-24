using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ICategoryRepository
    {
        void removeCategory(string cat);
        void AddAndSaveCategory(Category category);
        void ChangeCategory(string oldCat, string newCat);
        List<Category> GetAllCategories();
    }
}

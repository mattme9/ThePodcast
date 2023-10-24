using DataAccessLayer.Interfaces;
using DataAccessLayer.Repository;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controller
{
    public class CategoryController
    {
        private readonly ICategoryRepository catRepository;
        public CategoryController() 
        { 
            catRepository = new CategoryRepository();
        }

        public List<Category> getCategories()
        {
            return catRepository.GetAllCategories();
        }

        public void AddAndSaveCategory(Category category)
        {
            catRepository.AddAndSaveCategory(category);
        }

        public void removeCategory(string cat)
        {
            catRepository.removeCategory(cat);
        }
        
    }
}

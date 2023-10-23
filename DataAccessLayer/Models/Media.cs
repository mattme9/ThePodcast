using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public abstract class Media
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

        public Media(string title, string name, string description, Category category)
        {
            Title = title;
            Name = name;
            Description = description;
            Category = category;
        }
    }
}

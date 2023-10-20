using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast : Media
    {
        public Category Category { get; set; }
        public int Episodes { get; set; }

        public Podcast(Category category, int episodes) 
        {
            Category = category;
            Episodes = episodes;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " " + Category.CategoryName + " " + Episodes;
        }
    }
}

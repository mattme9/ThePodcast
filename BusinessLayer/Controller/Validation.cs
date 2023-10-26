using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;



namespace BusinessLayer.Controller
{
    public class Validation
    {
        public Boolean CheckIfEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return true; 
            }
            
             return false; 
            
        }

        public Boolean CheckIfCategoryExists(string input)
        {
            //loopa igenom lista där vi sparat kategorier
            //kolla om kategori finns
            return false;
            
        }

        public Boolean CheckIfUnique(string input, List<string> currentCategories)
        {
            Boolean unique = true;
            int i = 0;

            while (i < currentCategories.Count())
            {
                if (currentCategories.Contains(input))
                {
                    unique = false;
                    return unique;
                }
                i++;
            }


            return unique;

        }

        public Boolean URLisValid(string url)
        {

            return RSSFeeder.URLisRSS(url);
        }
    }

}

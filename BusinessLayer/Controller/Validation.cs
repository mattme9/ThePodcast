using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controller
{
    public class Validation
    {
        public Boolean checkIfEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            { return false; }
            else 
            { return true; }
        }

        public Boolean checkIfCategoryExists(string input)
        {
            //loopa igenom lista där vi sparat kategorier
            //kolla om kategori finns
            return false;
            
        }

        public Boolean checkIfUnique(string input, List<string> currentCategories)
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
    }
}

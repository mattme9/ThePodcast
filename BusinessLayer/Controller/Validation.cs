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
            
        }
    }
}

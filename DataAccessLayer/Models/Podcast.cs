using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Podcast : Media
    {
        public Guid Id { get; set; }
        public IEnumerable<Episodes> Episodes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Models
{
    public class Podcast : Media
    {
        public Guid Id { get; set; }
        public IEnumerable<Episodes> Episodes { get; set; }

        public Podcast(string title, string name, string description, Category category, Guid id, IEnumerable<Episodes> episodes)
            : base (title, name, description, category)
        {
            Id = id;
            Episodes = episodes;
        }
    }
}

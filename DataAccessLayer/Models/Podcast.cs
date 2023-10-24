using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Models
{
    public class Podcast
    {
        public Guid Id { get; set; }
        public IEnumerable<Episodes>? Episodes { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

        public Podcast()
        {

        }
        public Podcast(string title, string name, string description, Category category, Guid id, IEnumerable<Episodes> episodes)
        {
            Id = id;
            Episodes = episodes;
        }
    }
}

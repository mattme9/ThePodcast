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
        public string Url { get; set; }
        public IEnumerable<Episode> Episodes { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int TotalEpisodes { get; set; }
        public Category Category { get; set; }

        public Podcast()
        {

        }
        public Podcast(int totalEpisodes, string title, string name, string url, Category category,  IEnumerable<Episode> episodes)
        {
            Name = name;
            Title = title;
            Category = category;
            TotalEpisodes = totalEpisodes;
            Episodes = episodes;
            Url = url;
        }
    }
}

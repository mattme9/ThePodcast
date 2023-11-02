using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DataAccessLayer.Models
{
    [Serializable]
    public class Podcast
    {
        public string Url { get; set; }
        [XmlElement]
        public List<Episode> Episodes { get; set; }
        [XmlElement]
        public string Title { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public int TotalEpisodes { get; set; }
        [XmlElement]
        public Category Category { get; set; }

        public Podcast()
        {

        }
        public Podcast(int totalEpisodes, string title, string name, string url, Category category,  List<Episode> episodes)
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

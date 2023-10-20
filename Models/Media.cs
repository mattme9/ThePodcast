using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{

    [Serializable]
    [XmlInclude(typeof(Podcast))]
    public abstract class Media
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public Media()
        {

        }
        public Media(string name, string title)
        {
            Name = name;
            Title = title;
        }

        public virtual string DisplayInfo()
        {
            return Name + " " + Title;
        }
    }
}

using DataAccessLayer.Models;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Xml.Serialization;

namespace DataAccessLayer
{

    //Denna klass ska hantera användarens datafil (XML Serializer etc).
    public class DataManager
    {

        public void SavePodcastData(List<Podcast> podcastList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            FileStream fs = new FileStream("data.xml", FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(fs, podcastList);
            fs.Close();

        }

        public List<Podcast> GetPodcastData()
        {
            List<Podcast> podcasts;
            XmlSerializer xmlSerializer = new XmlSerializer (typeof(List<Podcast>));
            FileStream fs = new FileStream("data.xml", FileMode.Open, FileAccess.Read);

            podcasts = (List<Podcast>)xmlSerializer.Deserialize(fs);
            fs.Close();
            return podcasts;
        }
    }
}
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Threading.Channels;

namespace DataAccessLayer
{
    public class RSSFeeder
    {

        public RSSFeeder()
        {

        }

        public Podcast FetchChannel(string url)
        {
            XmlReader xmlReader = XmlReader.Create(url);
            SyndicationFeed sf = SyndicationFeed.Load(xmlReader);

            Podcast podcast = new Podcast();

            podcast.Title = sf.Title.Text;
            podcast.Description = sf.Description.Text;

            return podcast;
        }

        public List<Podcast> FetchRSS(string url)
        {
            XmlReader xmlreader = XmlReader.Create(url);
            SyndicationFeed flow = SyndicationFeed.Load(xmlreader);

            List<Podcast> podcastList = new List<Podcast>();

            foreach (SyndicationItem item in flow.Items)
            {
                Podcast podcast = new Podcast();

                podcast.Description = item.PublishDate.ToString();
                podcast.Title = item.Title.Text;

                podcastList.Add(podcast);
            }

            return podcastList;

        }

        //XmlReader xmlreader = new XmlReader

    }
}

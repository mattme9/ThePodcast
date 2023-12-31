﻿using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Threading.Channels;
using System.Reflection;
using System.Diagnostics;

namespace DataAccessLayer
{
    public class RSSFeeder
    {

        public RSSFeeder()
        {

        }

        public async Task<Podcast> GetPodcast(string url, string podcastName, string category)
        {
            XmlReader xmlReader = XmlReader.Create(url);
            SyndicationFeed sf = await Task.Run(() => SyndicationFeed.Load(xmlReader));

            string title = sf.Title.Text;
            string description = sf.Description.Text;

            Category cat = new Category(category);

            List<Episode> episodeList = await getEpisodes(url);

            int count = 0;
            foreach (Episode episode in episodeList)
            {
                count++;
            }

            Podcast podcast = new Podcast(count, title, podcastName, url, cat, episodeList);
            return podcast;
        }

        public async Task<List<Episode>> getEpisodes(string url)
        {
            List<Episode> itemList = new List<Episode>();

            XmlReader xmlReader = XmlReader.Create(url);
            SyndicationFeed sf = SyndicationFeed.Load(xmlReader);

            foreach (SyndicationItem item in sf.Items)
            {
                string title = item.Title.Text;
                string summary = item.Summary.Text;
                Episode episode = new Episode(title, summary);

                itemList.Add(episode);
            }

            return itemList;
        }

        public static bool URLisRSS(string url)
        {
            try
            {
                SyndicationFeed aFeed = SyndicationFeed.Load(XmlReader.Create(url));

                foreach (SyndicationItem item in aFeed.Items)
                {
                    Debug.Print(item.Title.Text);
                }
                return true;
            }
            catch (Exception)
            {   
                return false;
            }
          

        }


        //Gamla metoder

        /*
        public Podcast FetchRSS(string url)
        {
            XmlReader xmlreader = XmlReader.Create(url);
            SyndicationFeed flow = SyndicationFeed.Load(xmlreader);

            List<Episode> episodeList = new List<Episode>();
            Podcast podcast = new Podcast();

            //string title, string name, string description,
            //string url, Category category, Guid id,
            //IEnumerable <Episode> episodes

            foreach (SyndicationItem item in flow.Items)
            {
                Episode episode = new Episode();

                episode.Description = item.PublishDate.ToString();
                episode.Title = item.Title.Text;

                episodeList.Add(episode);
            }

            return episodeList;

        }
        */

        //XmlReader xmlreader = new XmlReader

    }
}

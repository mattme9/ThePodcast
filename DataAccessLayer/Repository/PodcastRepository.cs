﻿using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class PodcastRepository : IPodcastRepository
    {
        public PodcastRepository() { 
       
        }

        public void CreatePodcast(Podcast model)
        {
            throw new NotImplementedException();
        }

        public void DeletePodcast(Podcast model)
        {
            throw new NotImplementedException();
        }

        public void UpdatePodcast(Podcast model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Podcast> GetAllPodcasts()
        {
            throw new NotImplementedException();
        }
    }
}

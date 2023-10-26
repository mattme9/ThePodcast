using DataAccessLayer.Models;
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

        public IEnumerable<Podcast> GetAllPodcasts()
        {
            throw new NotImplementedException();
        }

        void IPodcastRepository.CreatePodcast(Podcast model)
        {
            throw new NotImplementedException();
        }

        void IPodcastRepository.UpdatePodcast(Podcast model)
        {
            throw new NotImplementedException();
        }

        void IPodcastRepository.DeletePodcast(Podcast model)
        {
            throw new NotImplementedException();
        }

        void IPodcastRepository.SavePodcastListToXML(List<Podcast> list)
        {
            throw new NotImplementedException();
        }
    }
}

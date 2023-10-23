using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EpisodeRepository : IEpisodeRepository
    {
        public EpisodeRepository() { 
        
        }

        public void CreateEpisode()
        {
            throw new NotImplementedException();
        }

        public void DeleteEpisode()
        {
            throw new NotImplementedException();
        }

        public void UpdateEpisode()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Episodes> GetAllEpisodesFromPodcast(Guid podcastId)
        {
            throw new NotImplementedException();
        }
    }
}

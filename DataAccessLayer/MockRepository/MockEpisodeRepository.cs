using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class MockEpisodeRepository : IEpisodeRepository
    {
        public MockEpisodeRepository() { 
       
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
            var mockListWithEpisodes = new List<Episodes>();

            mockListWithEpisodes.Add(
                new Episodes
                {
                    Id = new Guid(),
                    Description = "Description",
                }
            );

        return mockListWithEpisodes;
        }

    }
}

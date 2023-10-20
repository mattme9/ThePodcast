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

        public void Create(PodcastModel model) 
        {
           
        }
        public void Update(PodcastModel model)
        {

        }
        public void Delete(PodcastModel model)
        {

        }

        public IEnumerable<Episodes> GetAllEpisodesFromPodast(Guid podcastId) 
        {
            var mockListWithEpisodes = new List<Episodes>();

            mockListWithEpisodes.Add(
                new Episodes
                {
                    Id = new Guid(),
                    Title = "Kalles film",
                    Description = "Description",
                }
            );

        return mockListWithEpisodes;
        }
    }
}

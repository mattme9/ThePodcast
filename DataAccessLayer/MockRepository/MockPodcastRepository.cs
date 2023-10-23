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
    public class MockPodcastRepository : IPodcastRepository
    {
        public MockPodcastRepository() { 
       
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

       /* public IEnumerable<Podcast> GetAllPodcasts()
        {
            var mockListWithPodcasts = new List<Podcast>();

            mockListWithPodcasts.Add(
                new Podcast
                {
                    Id = new Guid(),
                    Title = "Kalles film",
                    Name = "Name",
                    Description = "Description",
                    Category = "Category"
                }
            );

            return mockListWithPodcasts;
        } */

    }
}

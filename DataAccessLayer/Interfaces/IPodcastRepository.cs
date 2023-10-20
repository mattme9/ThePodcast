using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IPodcastRepository
    {
        public void Create(PodcastModel model);
        public void Update(PodcastModel model);
        public void Delete(PodcastModel model);
        public IEnumerable<Episodes> GetAllEpisodesFromPodcast(Guid podcastId);
    }
}

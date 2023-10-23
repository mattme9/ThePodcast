using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IEpisodeRepository
    {
        void CreateEpisode();
        void DeleteEpisode();
        void UpdateEpisode();
        public IEnumerable<Episodes> GetAllEpisodesFromPodcast(Guid podcastId);
    }
}

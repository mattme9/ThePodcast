using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controller
{
    public class EpisodesController
    {
        private readonly IEpisodeRepository _episodesRepository;

        public EpisodesController()
        {
            _episodesRepository = new EpisodeRepository();
        }

        /*
        public List<Episode> GetAllEpisodesInOrder(Guid podcastId)
        {
            if (podcastId == null || podcastId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(podcastId));
            }

            var episodes = _episodesRepository.GetAllEpisodesFromPodcast(podcastId).ToList();

            if (!episodes.Any())
            {
                return new List<Episode>();
            }

            var orderedPodcastListByName = episodes.OrderBy(podcast => podcast.Title).ToList();

            return orderedPodcastListByName;
        }
        */
    }
}

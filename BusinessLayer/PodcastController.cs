using DataAccessLayer.Models;
using DataAccessLayer.Repository;

namespace BusinessLayer
{
    //Denna klass används till att komma åt DataAccessLayer
    public class PodcastController
    {
        private readonly IPodcastRepository _podcastRepository;
        public PodcastController() 
        { 
            _podcastRepository = new PodcastRepository();
        }

        //public void createPod()

        public List<Episodes> GetAllEpisodesInOrder(Guid podcastId)
        {
            if(podcastId == null || podcastId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(podcastId));
            }

            var episodes = _podcastRepository.GetAllEpisodesFromPodcast(podcastId).ToList();

            if (!episodes.Any())
            {
                return new List<Episodes>();
            }

            var orderedPodcastListByName = episodes.OrderBy(podcast => podcast.Title).ToList(); 

            return orderedPodcastListByName;
        }
    }
}
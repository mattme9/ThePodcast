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

        //public void createPodcast()

       
    }
}
using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;

namespace BusinessLayer
{
    //Denna klass används till att komma åt DataAccessLayer
    public class PodcastController
    {
        private readonly IPodcastRepository _podcastRepository;
        RSSFeeder feeder = new RSSFeeder();
        public PodcastController() 
        { 
            _podcastRepository = new PodcastRepository();
            feeder = new RSSFeeder();
        }

        public Podcast FetchPodsByURL(string url)
        {
            return feeder.FetchChannel(url);
        }

        //public void createPodcast()

       
    }
}
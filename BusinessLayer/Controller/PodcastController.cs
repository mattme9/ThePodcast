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

        public List<Podcast> FetchPodsByURL(string url)
        {
            return feeder.FetchRSS(url);
        }

        //public void createPodcast()

       
    }
}
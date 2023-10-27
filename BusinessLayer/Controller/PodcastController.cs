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
        DataManager dataManager = new DataManager();
        public PodcastController() 
        { 
            _podcastRepository = new PodcastRepository();
            feeder = new RSSFeeder();
        }

        public Podcast CreatePodcast(string url, string podName, string category)
        {
                return feeder.GetPodcast(url, podName, category);  
        }

        public void SavePodcastListToXML(List<Podcast> podcastList)
        {
            dataManager.SavePodcastData(podcastList);
        }

        public List<Podcast> GetPodcastListFromXML()
        {
            return dataManager.GetPodcastData();
        }

        //public void createPodcast()

       
    }
}
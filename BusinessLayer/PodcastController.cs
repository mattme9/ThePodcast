namespace BusinessLayer
{
    // Denna klass används för att komma åt DataAccessLayer
    public class PodcastController
    {
        //private IPodcastRepository podcastRepository;

        public PodcastController()
        {
            // podcastRepository = new PodcastRepository();
        }

        // public void createPod()

        // public List<Podcast> GetAllPodcasts

        public Boolean validate(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            return true;
        }

        public Boolean addCategory(string newCategory)
        {
            return true;
        }
    }
}

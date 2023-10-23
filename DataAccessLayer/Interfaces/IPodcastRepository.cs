using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DataAccessLayer.Repository
{
    public interface IPodcastRepository
    {
        public void CreatePodcast(Podcast model);
        public void UpdatePodcast(Podcast model);
        public void DeletePodcast(Podcast model);
        // public IEnumerable<Podcast> GetAllPodcasts();
    }
}

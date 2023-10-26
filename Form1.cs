using BusinessLayer;
using BusinessLayer.Controller;
using DataAccessLayer.Models;
using System.Windows.Forms;

namespace ThePodcast
{
    public partial class Form1 : Form
    {
        private Validation validation = new Validation();
        private CategoryController categoryController = new CategoryController();
        private PodcastController podcastController = new PodcastController();
        private List<Podcast> podcasts = new List<Podcast>();
        private Podcast thisPodcast;

        public Form1()
        {
            InitializeComponent();
            fillCategories();

        }

        private void fillCategories()
        {
            categoryListBox.Items.Clear();
            boxCategory.Items.Clear();
            List<Category> categories = categoryController.getCategories();
            foreach (var category in categories)
            {
                boxCategory.Items.Add(category.CategoryName);
                categoryListBox.Items.Add(category.CategoryName);
            }
            if (boxCategory.Items.Count > 0)
            {
                boxCategory.SelectedIndex = 0;
            }
        }



        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            String input = categoryNameTxt.Text;

            Boolean validated = validation.checkIfEmpty(input);
            if (!validated)
            {
                MessageBox.Show("Text field is empty.");
                //Lägg till validering för dubblering
            }
            else
            {
                Category category = new Category(input);
                categoryController.AddAndSaveCategory(category);
                categoryListBox.Items.Add(category.CategoryName);
                boxCategory.Items.Add(category.CategoryName);

            }

        }

        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem != null)
            {
                string cat = categoryListBox.SelectedItem.ToString();
                categoryController.removeCategory(cat);
                fillCategories();
            }
            else
            {
                MessageBox.Show("You must select a category to delete.");
            }
        }

        private void changeCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryListBox.SelectedItem != null)
                {
                    //Hämtar de gamla värdet
                    string oldCat = categoryListBox.SelectedItem.ToString();
                    //Hämtar de nya värdet
                    string newCat = categoryNameTxt.Text;
                    categoryController.changeCategoryName(oldCat, newCat);
                    fillCategories();
                }
                else
                {
                    MessageBox.Show("You must select a category.");
                }
            }
            catch (Exception en)
            {
                Console.WriteLine(en.Message);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validation.checkIfEmpty(txtUrl.Text) &&
                validation.checkIfEmpty(podcastNameTxt.Text) &&
                validation.checkIfEmpty(boxCategory.SelectedItem.ToString()))
            {

                string url = txtUrl.Text;
                string podName = podcastNameTxt.Text;
                string category = boxCategory.SelectedItem.ToString();

                //Podcast podcast = podcastController.FetchPodsByURL(url);

                Podcast podcast = podcastController.CreatePodcast(url, podName, category);
                podcasts.Add(podcast);
                //Sparar data på datorn
                podcastController.SavePodcastListToXML(podcasts);

                //Loopa igenom detta senare
                int rowIndex = podcastGridView.Rows.Add();
                podcastGridView.Rows[rowIndex].Cells["Episode"].Value = podcast.TotalEpisodes;
                podcastGridView.Rows[rowIndex].Cells["Title"].Value = podcast.Title;
                podcastGridView.Rows[rowIndex].Cells["Category"].Value = podcast.Category.CategoryName;
                podcastGridView.Rows[rowIndex].Cells["customName"].Value = podcast.Name;

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem != null)
            {
                categoryNameTxt.Text = categoryListBox.SelectedItem.ToString();
            }
        }

        private void podcastGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            episodeListBox.Items.Clear();
            if (podcastGridView.SelectedRows.Count > 0)
            {
                string title = podcastGridView.SelectedRows[0].Cells["Title"].Value.ToString();

                //episodeListBox.Items.Add(cellValue);

                foreach (Podcast poo in podcasts)
                {
                    if (poo.Title.Equals(title))
                    {
                        foreach (Episode ep in poo.Episodes)
                        {
                            episodeListBox.Items.Add(ep.Title);
                        }
                    }
                }

            }
        }

        private void episodeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            summaryBox.Items.Clear();

            string title = podcastGridView.SelectedRows[0].Cells["Title"].Value.ToString();
            string episode = episodeListBox.SelectedItem.ToString();

            foreach (Podcast poo in podcasts)
            {
                if (poo.Title.Equals(title))
                {
                    foreach (Episode ep in poo.Episodes)
                    {
                        if (ep.Title.Equals(episode))
                        {
                            summaryBox.Items.Add(ep.Description);
                        }
                    }
                }
            }
        }
    }
}
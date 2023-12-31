using BusinessLayer;
using BusinessLayer.Controller;
using DataAccessLayer.Models;
using System.Reflection;
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
            fillPodcasts();
        }

        private void fillPodcasts()
        {
            podcastGridView.Rows.Clear();
            podcasts = podcastController.GetPodcastListFromXML();

            foreach (Podcast podcast in podcasts)
            {
                int rowIndex = podcastGridView.Rows.Add();
                podcastGridView.Rows[rowIndex].Cells["Episode"].Value = podcast.TotalEpisodes;
                podcastGridView.Rows[rowIndex].Cells["Title"].Value = podcast.Title;
                podcastGridView.Rows[rowIndex].Cells["Category"].Value = podcast.Category.CategoryName;
                podcastGridView.Rows[rowIndex].Cells["customName"].Value = podcast.Name;
            }


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
            ComboBox comboBox = boxCategory;


            List<String> currentItems = new List<String>();

            foreach (var item in boxCategory.Items)
            {
                currentItems.Add(item.ToString());
            }


            Boolean validated = !validation.CheckIfEmpty(input);
            Boolean unique = validation.CheckIfUnique(input, currentItems);


            if (!validated)
            {
                MessageBox.Show("Text field is empty.");
                //L�gg till validering f�r dubblering
            }
            if (!unique)
            {
                MessageBox.Show("Category name is not unique");
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
                DialogResult result = MessageBox.Show("Are you sure you want to delete the category?", "Confirmation window", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string cat = categoryListBox.SelectedItem.ToString();
                    categoryController.removeCategory(cat);
                    fillCategories();
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("No category selected.");
            }
        }

        private void changeCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryListBox.SelectedItem != null)
                {
                    //H�mtar de gamla v�rdet
                    string oldCat = categoryListBox.SelectedItem.ToString();
                    //H�mtar de nya v�rdet
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {

            List<string> currentPodcastNames = podcasts.Select(podcast => podcast.Name).ToList();
            List<string> currentPodcastTitles = podcasts.Select(podcast => podcast.Title).ToList();

            string podcastName = podcastNameTxt.Text;


            if (validation.CheckIfEmpty(txtUrl.Text) ||
                validation.CheckIfEmpty(podcastNameTxt.Text) ||
                validation.CheckIfEmpty(boxCategory.SelectedItem?.ToString()))
            {
                MessageBox.Show("Error! N�got f�lt �r tomt.");
                return;
            }
            if (!validation.URLisValid(txtUrl.Text))
            {
                MessageBox.Show("There is a problem with your URL");
                return;
            }

            if (!validation.CheckIfUnique(podcastName, currentPodcastNames))
            {
                MessageBox.Show("This name already exists");
                return;
            }
            string url = txtUrl.Text;
            string category = boxCategory.SelectedItem.ToString();
            Podcast podcast = await podcastController.CreatePodcast(url, podcastName, category);
            podcasts.Add(podcast);


            podcastController.SavePodcastListToXML(podcasts);

            int rowIndex = podcastGridView.Rows.Add();
            podcastGridView.Rows[rowIndex].Cells["Episode"].Value = podcast.TotalEpisodes;
            podcastGridView.Rows[rowIndex].Cells["Title"].Value = podcast.Title;
            podcastGridView.Rows[rowIndex].Cells["Category"].Value = podcast.Category.CategoryName;
            podcastGridView.Rows[rowIndex].Cells["customName"].Value = podcast.Name;
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (podcastGridView.SelectedRows.Count > 0)
            {
                string title = podcastGridView.SelectedRows[0].Cells["Title"].Value.ToString();
                DataGridViewRow selectedRow = podcastGridView.SelectedRows[0];
                podcastGridView.Rows.Remove(selectedRow);
                foreach (Podcast pod in podcasts)
                {
                    if (pod.Title.Equals(title))
                    {
                        podcasts.Remove(pod);
                        podcastController.SavePodcastListToXML(podcasts);
                        episodeListBox.Items.Clear();
                        break;
                    }
                }
                fillPodcasts();
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //F� namnet att dyka upp i Namn-box vid klick
            //H�mta vald namn i datagridview
            string name = podcastGridView.SelectedRows[0].Cells["customName"].Value.ToString();
            string newName = podcastNameTxt.Text;
            string newCat = boxCategory.SelectedItem.ToString();
            //foreach leta upp titel i podcasts och byt v�rde p� pod.Name
            if (!validation.CheckIfEmpty(newName))
            {
                foreach (Podcast pod in podcasts)
                {
                    if (pod.Name.Equals(name))
                    {
                        pod.Name = newName;
                        pod.Category.CategoryName = newCat;
                    }
                }
                podcastController.SavePodcastListToXML(podcasts);
                fillPodcasts();
            }
            else
            {
                MessageBox.Show("Name can not be empty.");
            }

            //podcastController.SavePodcastListToXML(podcasts)


        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem != null)
            {
                categoryNameTxt.Text = categoryListBox.SelectedItem.ToString();
            }
        }

        private void podcastGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            episodeListBox.Items.Clear();
            if (podcastGridView.SelectedRows.Count > 0)
            {
                string title = podcastGridView.SelectedRows[0].Cells["Title"].Value.ToString();

                var selectedPodcast = podcasts.FirstOrDefault(p => p.Title.Equals(title));

                if (selectedPodcast != null)
                {
                    podcastNameTxt.Text = selectedPodcast.Name;
                    episodeListBox.Items.AddRange(selectedPodcast.Episodes.Select(ep => ep.Title).ToArray());
                }
            }
        }

        private void episodeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            string title = podcastGridView.SelectedRows[0].Cells["Title"].Value.ToString();
            string episode = episodeListBox.SelectedItem.ToString();

            var selectedEpisodeDescription = podcasts
                .Where(p => p.Title.Equals(title))
                .SelectMany(p => p.Episodes)
                .FirstOrDefault(ep => ep.Title.Equals(episode))?.Description;

            if (selectedEpisodeDescription != null)
            {
                textBox1.Text = selectedEpisodeDescription;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
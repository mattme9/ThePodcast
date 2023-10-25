using BusinessLayer;
using BusinessLayer.Controller;
using DataAccessLayer.Models;

namespace ThePodcast
{
    public partial class Form1 : Form
    {
        private Validation validation = new Validation();
        private CategoryController categoryController = new CategoryController();
        private PodcastController podcastController = new PodcastController();

        public Form1()
        {
            InitializeComponent();
            fillCategories();

        }
        //HEj
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


            List<String> currentCategories = new List<String>();

            foreach (var item in boxCategory.Items)
            {
                currentCategories.Add(item.ToString());
            }

            Boolean validated = validation.checkIfEmpty(input);
            Boolean unique = validation.checkIfUnique(input, currentCategories);


            if (!validated)
            {
                MessageBox.Show("Text field is empty.");
                //Lägg till validering för dubblering
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

                //Loopa igenom detta senare
                int rowIndex = podcastGridView.Rows.Add();
                podcastGridView.Rows[rowIndex].Cells["Episode"].Value = podcast.TotalEpisodes;
                podcastGridView.Rows[rowIndex].Cells["Title"].Value = podcast.Title;
                podcastGridView.Rows[rowIndex].Cells["Category"].Value = podcast.Category;
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
    }
}
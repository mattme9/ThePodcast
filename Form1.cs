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
            boxCategory.SelectedIndex = 0;
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
            if (validation.checkIfEmpty(txtUrl.Text))
            {
                string url = txtUrl.Text;
                Podcast podcast = podcastController.FetchPodsByURL(url);
                //foreach (Podcast pod in podLista)
                //{
                int rowIndex = podcastGridView.Rows.Add();
                podcastGridView.Rows[rowIndex].Cells["Title"].Value = podcast.Title;
                podcastGridView.Rows[rowIndex].Cells["Category"].Value = boxCategory.SelectedItem;
                //podcastGridView.Rows.Add(pod.Title);
                //}

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
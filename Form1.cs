using BusinessLayer.Controller;
using DataAccessLayer.Models;

namespace ThePodcast
{
    public partial class Form1 : Form
    {
        Validation validation = new Validation();
        private CategoryController categoryController = new CategoryController();

        public Form1()
        {
            InitializeComponent();
            fillCategories();

        }

        private void fillCategories()
        {
            categoryListBox.Items.Clear();
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
               string cat = categoryListBox.SelectedItem.ToString();
            categoryController.removeCategory(cat);
               
        }

        private void changeCategoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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
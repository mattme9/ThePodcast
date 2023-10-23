using Models;
using BusinessLayer;

namespace ThePodcast
{
    public partial class Form1 : Form
    {

        List<string> categories = new List<string> { "Humor", "Krim", "Dokumentär" };
        PodcastController podcastController = new PodcastController();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            boxCategory.Items.AddRange(categories.ToArray());
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            string newCategory = CategoryTxt.Text;

            Boolean validated = podcastController.validate(newCategory);
            Boolean success = false;

            if (!validated)
            {
                MessageBox.Show("Textield can't be empty.");
            }

            else
            {
                podcastController.addCategory(newCategory);

                if (success)
                {
                    MessageBox.Show("New category added.");
                }
            }


        }

        private void changeCategory_Click(object sender, EventArgs e)
        {

        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
using BusinessLayer.Controller;

namespace ThePodcast
{
    public partial class Form1 : Form
    {
        Validation validation = new Validation();
        

        public Form1()
        {
            InitializeComponent();
        }

      

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            String input = categoryNameTxt.Text;

            Boolean validated = validation.checkIfEmpty(input);
            if (!validated)
            {
                MessageBox.Show("Text field is empty.");
            }
            else
            {

            }
            
        }

        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {

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
    }
}
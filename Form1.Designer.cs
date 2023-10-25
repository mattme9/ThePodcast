namespace ThePodcast
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUrl = new TextBox();
            lblUrl = new Label();
            lblCategory = new Label();
            boxCategory = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnChange = new Button();
            podcastNameTxt = new TextBox();
            lblName = new Label();
            episodeListBox = new ListBox();
            episodeListLbl = new Label();
            changeCategoryBtn = new Button();
            deleteCategoryBtn = new Button();
            addCategoryBtn = new Button();
            modifyCategoryLbl = new Label();
            categoryNameTxt = new TextBox();
            categoryListBox = new ListBox();
            podcastGridView = new DataGridView();
            Episodes = new DataGridViewTextBoxColumn();
            customName = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)podcastGridView).BeginInit();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(20, 112);
            txtUrl.Margin = new Padding(5);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(477, 39);
            txtUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(20, 75);
            lblUrl.Margin = new Padding(5, 0, 5, 0);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(60, 32);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "URL:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 170);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(115, 32);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // boxCategory
            // 
            boxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            boxCategory.FormattingEnabled = true;
            boxCategory.Location = new Point(20, 206);
            boxCategory.Margin = new Padding(5);
            boxCategory.Name = "boxCategory";
            boxCategory.Size = new Size(152, 40);
            boxCategory.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 286);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 46);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(184, 286);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 46);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(346, 286);
            btnChange.Margin = new Padding(5);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(153, 46);
            btnChange.TabIndex = 6;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // podcastNameTxt
            // 
            podcastNameTxt.Location = new Point(224, 208);
            podcastNameTxt.Margin = new Padding(5);
            podcastNameTxt.Name = "podcastNameTxt";
            podcastNameTxt.Size = new Size(272, 39);
            podcastNameTxt.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(224, 171);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 9;
            lblName.Text = "Name:";
            // 
            // episodeListBox
            // 
            episodeListBox.FormattingEnabled = true;
            episodeListBox.ItemHeight = 32;
            episodeListBox.Location = new Point(873, 356);
            episodeListBox.Name = "episodeListBox";
            episodeListBox.Size = new Size(360, 452);
            episodeListBox.TabIndex = 10;
            // 
            // episodeListLbl
            // 
            episodeListLbl.AutoSize = true;
            episodeListLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            episodeListLbl.Location = new Point(950, 237);
            episodeListLbl.Name = "episodeListLbl";
            episodeListLbl.Size = new Size(213, 65);
            episodeListLbl.TabIndex = 11;
            episodeListLbl.Text = "Episode";
            // 
            // changeCategoryBtn
            // 
            changeCategoryBtn.Location = new Point(1564, 286);
            changeCategoryBtn.Margin = new Padding(5);
            changeCategoryBtn.Name = "changeCategoryBtn";
            changeCategoryBtn.Size = new Size(153, 46);
            changeCategoryBtn.TabIndex = 18;
            changeCategoryBtn.Text = "Change";
            changeCategoryBtn.UseVisualStyleBackColor = true;
            changeCategoryBtn.Click += changeCategoryBtn_Click;
            // 
            // deleteCategoryBtn
            // 
            deleteCategoryBtn.Location = new Point(1402, 286);
            deleteCategoryBtn.Margin = new Padding(5);
            deleteCategoryBtn.Name = "deleteCategoryBtn";
            deleteCategoryBtn.Size = new Size(153, 46);
            deleteCategoryBtn.TabIndex = 17;
            deleteCategoryBtn.Text = "Delete";
            deleteCategoryBtn.UseVisualStyleBackColor = true;
            deleteCategoryBtn.Click += deleteCategoryBtn_Click;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.Location = new Point(1239, 286);
            addCategoryBtn.Margin = new Padding(5);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(153, 46);
            addCategoryBtn.TabIndex = 16;
            addCategoryBtn.Text = "Add";
            addCategoryBtn.UseVisualStyleBackColor = true;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // modifyCategoryLbl
            // 
            modifyCategoryLbl.AutoSize = true;
            modifyCategoryLbl.Location = new Point(1239, 200);
            modifyCategoryLbl.Margin = new Padding(5, 0, 5, 0);
            modifyCategoryLbl.Name = "modifyCategoryLbl";
            modifyCategoryLbl.Size = new Size(115, 32);
            modifyCategoryLbl.TabIndex = 13;
            modifyCategoryLbl.Text = "Category:";
            // 
            // categoryNameTxt
            // 
            categoryNameTxt.Location = new Point(1239, 237);
            categoryNameTxt.Margin = new Padding(5);
            categoryNameTxt.Name = "categoryNameTxt";
            categoryNameTxt.Size = new Size(477, 39);
            categoryNameTxt.TabIndex = 12;
            // 
            // categoryListBox
            // 
            categoryListBox.FormattingEnabled = true;
            categoryListBox.ItemHeight = 32;
            categoryListBox.Location = new Point(1240, 356);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(477, 452);
            categoryListBox.TabIndex = 19;
            categoryListBox.SelectedIndexChanged += categoryListBox_SelectedIndexChanged;
            // 
            // podcastGridView
            // 
            podcastGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            podcastGridView.Columns.AddRange(new DataGridViewColumn[] { Episodes, customName, Title, Category });
            podcastGridView.Location = new Point(12, 356);
            podcastGridView.Name = "podcastGridView";
            podcastGridView.RowHeadersWidth = 82;
            podcastGridView.RowTemplate.Height = 41;
            podcastGridView.Size = new Size(855, 452);
            podcastGridView.TabIndex = 20;
            // 
            // Episodes
            // 
            Episodes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Episodes.HeaderText = "Episode";
            Episodes.MinimumWidth = 10;
            Episodes.Name = "Episode";
            // 
            // customName
            // 
            customName.HeaderText = "Name";
            customName.MinimumWidth = 10;
            customName.Name = "customName";
            customName.Width = 200;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 10;
            Title.Name = "Title";
            Title.Width = 200;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 10;
            Category.Name = "Category";
            Category.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 872);
            Controls.Add(podcastGridView);
            Controls.Add(categoryListBox);
            Controls.Add(changeCategoryBtn);
            Controls.Add(deleteCategoryBtn);
            Controls.Add(addCategoryBtn);
            Controls.Add(modifyCategoryLbl);
            Controls.Add(categoryNameTxt);
            Controls.Add(episodeListLbl);
            Controls.Add(episodeListBox);
            Controls.Add(lblName);
            Controls.Add(podcastNameTxt);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(boxCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblUrl);
            Controls.Add(txtUrl);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)podcastGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Label lblUrl;
        private Label lblCategory;
        private ComboBox boxCategory;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnChange;
        private TextBox podcastNameTxt;
        private Label lblName;
        private ListBox episodeListBox;
        private Label episodeListLbl;
        private Button changeCategoryBtn;
        private Button deleteCategoryBtn;
        private Button addCategoryBtn;
        private Label modifyCategoryLbl;
        private TextBox categoryNameTxt;
        private ListBox categoryListBox;
        private DataGridView podcastGridView;
        private DataGridViewTextBoxColumn Episodes;
        private DataGridViewTextBoxColumn customName;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Category;
    }
}
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
            changeCategoryBtn = new Button();
            deleteCategoryBtn = new Button();
            addCategoryBtn = new Button();
            modifyCategoryLbl = new Label();
            categoryNameTxt = new TextBox();
            categoryListBox = new ListBox();
            podcastGridView = new DataGridView();
            Episode = new DataGridViewTextBoxColumn();
            customName = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)podcastGridView).BeginInit();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(23, 56);
            txtUrl.Margin = new Padding(3, 2, 3, 2);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(259, 23);
            txtUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(23, 38);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(31, 15);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "URL:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 83);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // boxCategory
            // 
            boxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            boxCategory.FormattingEnabled = true;
            boxCategory.Location = new Point(23, 100);
            boxCategory.Margin = new Padding(3, 2, 3, 2);
            boxCategory.Name = "boxCategory";
            boxCategory.Size = new Size(84, 23);
            boxCategory.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 137);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(111, 137);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(199, 137);
            btnChange.Margin = new Padding(3, 2, 3, 2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(82, 22);
            btnChange.TabIndex = 6;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // podcastNameTxt
            // 
            podcastNameTxt.Location = new Point(133, 101);
            podcastNameTxt.Margin = new Padding(3, 2, 3, 2);
            podcastNameTxt.Name = "podcastNameTxt";
            podcastNameTxt.Size = new Size(148, 23);
            podcastNameTxt.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(133, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Name:";
            // 
            // episodeListBox
            // 
            episodeListBox.FormattingEnabled = true;
            episodeListBox.ItemHeight = 15;
            episodeListBox.Location = new Point(531, 167);
            episodeListBox.Margin = new Padding(2, 1, 2, 1);
            episodeListBox.Name = "episodeListBox";
            episodeListBox.Size = new Size(274, 214);
            episodeListBox.TabIndex = 10;
            episodeListBox.SelectedIndexChanged += episodeListBox_SelectedIndexChanged;
            // 
            // changeCategoryBtn
            // 
            changeCategoryBtn.Location = new Point(988, 137);
            changeCategoryBtn.Margin = new Padding(3, 2, 3, 2);
            changeCategoryBtn.Name = "changeCategoryBtn";
            changeCategoryBtn.Size = new Size(80, 22);
            changeCategoryBtn.TabIndex = 18;
            changeCategoryBtn.Text = "Change";
            changeCategoryBtn.UseVisualStyleBackColor = true;
            changeCategoryBtn.Click += changeCategoryBtn_Click;
            // 
            // deleteCategoryBtn
            // 
            deleteCategoryBtn.Location = new Point(900, 137);
            deleteCategoryBtn.Margin = new Padding(3, 2, 3, 2);
            deleteCategoryBtn.Name = "deleteCategoryBtn";
            deleteCategoryBtn.Size = new Size(80, 22);
            deleteCategoryBtn.TabIndex = 17;
            deleteCategoryBtn.Text = "Delete";
            deleteCategoryBtn.UseVisualStyleBackColor = true;
            deleteCategoryBtn.Click += deleteCategoryBtn_Click;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.Location = new Point(813, 137);
            addCategoryBtn.Margin = new Padding(3, 2, 3, 2);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(80, 22);
            addCategoryBtn.TabIndex = 16;
            addCategoryBtn.Text = "Add";
            addCategoryBtn.UseVisualStyleBackColor = true;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // modifyCategoryLbl
            // 
            modifyCategoryLbl.AutoSize = true;
            modifyCategoryLbl.Location = new Point(810, 97);
            modifyCategoryLbl.Name = "modifyCategoryLbl";
            modifyCategoryLbl.Size = new Size(58, 15);
            modifyCategoryLbl.TabIndex = 13;
            modifyCategoryLbl.Text = "Category:";
            // 
            // categoryNameTxt
            // 
            categoryNameTxt.Location = new Point(813, 114);
            categoryNameTxt.Margin = new Padding(3, 2, 3, 2);
            categoryNameTxt.Name = "categoryNameTxt";
            categoryNameTxt.Size = new Size(257, 23);
            categoryNameTxt.TabIndex = 12;
            // 
            // categoryListBox
            // 
            categoryListBox.FormattingEnabled = true;
            categoryListBox.ItemHeight = 15;
            categoryListBox.Location = new Point(813, 167);
            categoryListBox.Margin = new Padding(2, 1, 2, 1);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(142, 214);
            categoryListBox.TabIndex = 19;
            categoryListBox.SelectedIndexChanged += categoryListBox_SelectedIndexChanged;
            // 
            // podcastGridView
            // 
            podcastGridView.AllowUserToAddRows = false;
            podcastGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            podcastGridView.Columns.AddRange(new DataGridViewColumn[] { Episode, customName, Title, Category });
            podcastGridView.Location = new Point(23, 167);
            podcastGridView.Margin = new Padding(2, 1, 2, 1);
            podcastGridView.Name = "podcastGridView";
            podcastGridView.ReadOnly = true;
            podcastGridView.RowHeadersWidth = 82;
            podcastGridView.RowTemplate.Height = 41;
            podcastGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            podcastGridView.Size = new Size(503, 212);
            podcastGridView.TabIndex = 20;
            podcastGridView.CellClick += podcastGridView_CellClick;
            // 
            // Episode
            // 
            Episode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Episode.HeaderText = "Episode";
            Episode.MinimumWidth = 10;
            Episode.Name = "Episode";
            Episode.ReadOnly = true;
            // 
            // customName
            // 
            customName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customName.HeaderText = "Name";
            customName.MinimumWidth = 10;
            customName.Name = "customName";
            customName.ReadOnly = true;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 10;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 10;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(530, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(274, 151);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 578);
            Controls.Add(textBox1);
            Controls.Add(podcastGridView);
            Controls.Add(categoryListBox);
            Controls.Add(changeCategoryBtn);
            Controls.Add(deleteCategoryBtn);
            Controls.Add(addCategoryBtn);
            Controls.Add(modifyCategoryLbl);
            Controls.Add(categoryNameTxt);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button changeCategoryBtn;
        private Button deleteCategoryBtn;
        private Button addCategoryBtn;
        private Label modifyCategoryLbl;
        private TextBox categoryNameTxt;
        private ListBox categoryListBox;
        private DataGridView podcastGridView;
        private DataGridViewTextBoxColumn Episodes;
        private DataGridViewTextBoxColumn Episode;
        private DataGridViewTextBoxColumn customName;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Category;
        private TextBox textBox1;
    }
}
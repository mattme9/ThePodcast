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
            summaryBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)podcastGridView).BeginInit();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(43, 119);
            txtUrl.Margin = new Padding(5);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(477, 39);
            txtUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(43, 82);
            lblUrl.Margin = new Padding(5, 0, 5, 0);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(60, 32);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "URL:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(43, 177);
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
            boxCategory.Location = new Point(43, 213);
            boxCategory.Margin = new Padding(5);
            boxCategory.Name = "boxCategory";
            boxCategory.Size = new Size(152, 40);
            boxCategory.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 293);
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
            btnDelete.Location = new Point(207, 293);
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
            btnChange.Location = new Point(369, 293);
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
            podcastNameTxt.Location = new Point(247, 215);
            podcastNameTxt.Margin = new Padding(5);
            podcastNameTxt.Name = "podcastNameTxt";
            podcastNameTxt.Size = new Size(272, 39);
            podcastNameTxt.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(247, 178);
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
            episodeListBox.Location = new Point(986, 356);
            episodeListBox.Name = "episodeListBox";
            episodeListBox.Size = new Size(505, 452);
            episodeListBox.TabIndex = 10;
            episodeListBox.SelectedIndexChanged += episodeListBox_SelectedIndexChanged;
            // 
            // changeCategoryBtn
            // 
            changeCategoryBtn.Location = new Point(1834, 293);
            changeCategoryBtn.Margin = new Padding(5);
            changeCategoryBtn.Name = "changeCategoryBtn";
            changeCategoryBtn.Size = new Size(149, 46);
            changeCategoryBtn.TabIndex = 18;
            changeCategoryBtn.Text = "Change";
            changeCategoryBtn.UseVisualStyleBackColor = true;
            changeCategoryBtn.Click += changeCategoryBtn_Click;
            // 
            // deleteCategoryBtn
            // 
            deleteCategoryBtn.Location = new Point(1672, 293);
            deleteCategoryBtn.Margin = new Padding(5);
            deleteCategoryBtn.Name = "deleteCategoryBtn";
            deleteCategoryBtn.Size = new Size(149, 46);
            deleteCategoryBtn.TabIndex = 17;
            deleteCategoryBtn.Text = "Delete";
            deleteCategoryBtn.UseVisualStyleBackColor = true;
            deleteCategoryBtn.Click += deleteCategoryBtn_Click;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.Location = new Point(1509, 293);
            addCategoryBtn.Margin = new Padding(5);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(149, 46);
            addCategoryBtn.TabIndex = 16;
            addCategoryBtn.Text = "Add";
            addCategoryBtn.UseVisualStyleBackColor = true;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // modifyCategoryLbl
            // 
            modifyCategoryLbl.AutoSize = true;
            modifyCategoryLbl.Location = new Point(1505, 207);
            modifyCategoryLbl.Margin = new Padding(5, 0, 5, 0);
            modifyCategoryLbl.Name = "modifyCategoryLbl";
            modifyCategoryLbl.Size = new Size(115, 32);
            modifyCategoryLbl.TabIndex = 13;
            modifyCategoryLbl.Text = "Category:";
            // 
            // categoryNameTxt
            // 
            categoryNameTxt.Location = new Point(1509, 244);
            categoryNameTxt.Margin = new Padding(5);
            categoryNameTxt.Name = "categoryNameTxt";
            categoryNameTxt.Size = new Size(473, 39);
            categoryNameTxt.TabIndex = 12;
            // 
            // categoryListBox
            // 
            categoryListBox.FormattingEnabled = true;
            categoryListBox.ItemHeight = 32;
            categoryListBox.Location = new Point(1509, 356);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(261, 452);
            categoryListBox.TabIndex = 19;
            categoryListBox.SelectedIndexChanged += categoryListBox_SelectedIndexChanged;
            // 
            // podcastGridView
            // 
            podcastGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            podcastGridView.Columns.AddRange(new DataGridViewColumn[] { Episode, customName, Title, Category });
            podcastGridView.Location = new Point(43, 356);
            podcastGridView.Name = "podcastGridView";
            podcastGridView.ReadOnly = true;
            podcastGridView.RowHeadersWidth = 82;
            podcastGridView.RowTemplate.Height = 41;
            podcastGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            podcastGridView.Size = new Size(934, 452);
            podcastGridView.TabIndex = 20;
            podcastGridView.CellContentClick += podcastGridView_CellContentClick;
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
            // summaryBox
            // 
            summaryBox.FormattingEnabled = true;
            summaryBox.HorizontalScrollbar = true;
            summaryBox.ItemHeight = 32;
            summaryBox.Location = new Point(986, 143);
            summaryBox.MultiColumn = true;
            summaryBox.Name = "summaryBox";
            summaryBox.Size = new Size(505, 196);
            summaryBox.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2082, 1012);
            Controls.Add(summaryBox);
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
        private ListBox summaryBox;
    }
}
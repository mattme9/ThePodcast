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
            listPoddar = new ListBox();
            textBox1 = new TextBox();
            lblName = new Label();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(20, 112);
            txtUrl.Margin = new Padding(5, 5, 5, 5);
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
            lblUrl.Click += label1_Click;
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
            lblCategory.Click += label1_Click_1;
            // 
            // boxCategory
            // 
            boxCategory.FormattingEnabled = true;
            boxCategory.Location = new Point(20, 206);
            boxCategory.Margin = new Padding(5, 5, 5, 5);
            boxCategory.Name = "boxCategory";
            boxCategory.Size = new Size(152, 40);
            boxCategory.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 286);
            btnAdd.Margin = new Padding(5, 5, 5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 46);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(184, 286);
            btnDelete.Margin = new Padding(5, 5, 5, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 46);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(346, 286);
            btnChange.Margin = new Padding(5, 5, 5, 5);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(153, 46);
            btnChange.TabIndex = 6;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // listPoddar
            // 
            listPoddar.FormattingEnabled = true;
            listPoddar.ItemHeight = 32;
            listPoddar.Location = new Point(20, 366);
            listPoddar.Margin = new Padding(5, 5, 5, 5);
            listPoddar.Name = "listPoddar";
            listPoddar.Size = new Size(477, 452);
            listPoddar.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 208);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 39);
            textBox1.TabIndex = 8;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 848);
            Controls.Add(lblName);
            Controls.Add(textBox1);
            Controls.Add(listPoddar);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(boxCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblUrl);
            Controls.Add(txtUrl);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
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
        private ListBox listPoddar;
        private TextBox textBox1;
        private Label lblName;
    }
}
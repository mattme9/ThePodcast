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
            listBox1 = new ListBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(11, 54);
            txtUrl.Margin = new Padding(3, 2, 3, 2);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(259, 23);
            txtUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(11, 37);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(31, 15);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "URL:";
            lblUrl.Click += label1_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(11, 82);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            lblCategory.Click += label1_Click_1;
            // 
            // boxCategory
            // 
            boxCategory.FormattingEnabled = true;
            boxCategory.Location = new Point(11, 99);
            boxCategory.Margin = new Padding(3, 2, 3, 2);
            boxCategory.Name = "boxCategory";
            boxCategory.Size = new Size(84, 23);
            boxCategory.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 136);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(100, 136);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(187, 136);
            btnChange.Margin = new Padding(3, 2, 3, 2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(82, 22);
            btnChange.TabIndex = 6;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // listPoddar
            // 
            listPoddar.FormattingEnabled = true;
            listPoddar.ItemHeight = 15;
            listPoddar.Items.AddRange(new object[] { "Pod 1", "Pod 2", "Pod 3..." });
            listPoddar.Location = new Point(11, 173);
            listPoddar.Margin = new Padding(3, 2, 3, 2);
            listPoddar.Name = "listPoddar";
            listPoddar.Size = new Size(259, 214);
            listPoddar.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 100);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(122, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Name:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Episode 1", "Episode 2", "Episode 3..." });
            listBox1.Location = new Point(292, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(303, 304);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(384, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 11;
            label1.Text = "Episodes";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(616, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 97);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 13;
            label2.Text = "Category:";
            // 
            // button1
            // 
            button1.Location = new Point(616, 144);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(697, 144);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(778, 144);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(616, 173);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(237, 154);
            listBox2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 398);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private ListBox listBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
    }
}
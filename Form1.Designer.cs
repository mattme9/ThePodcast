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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            listBox2 = new ListBox();
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
            // 
            // listPoddar
            // 
            listPoddar.FormattingEnabled = true;
            listPoddar.ItemHeight = 32;
            listPoddar.Location = new Point(20, 366);
            listPoddar.Margin = new Padding(5);
            listPoddar.Name = "listPoddar";
            listPoddar.Size = new Size(477, 452);
            listPoddar.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 208);
            textBox1.Margin = new Padding(5);
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(583, 189);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(442, 452);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(693, 112);
            label1.Name = "label1";
            label1.Size = new Size(213, 65);
            label1.TabIndex = 11;
            label1.Text = "Episodes";
            // 
            // button1
            // 
            button1.Location = new Point(1431, 174);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 18;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1269, 174);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(153, 46);
            button2.TabIndex = 17;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1106, 174);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(153, 46);
            button3.TabIndex = 16;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1106, 88);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 13;
            label4.Text = "Category:";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1106, 125);
            textBox3.Margin = new Padding(5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(477, 39);
            textBox3.TabIndex = 12;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 32;
            listBox2.Location = new Point(1106, 240);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(477, 420);
            listBox2.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 848);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox3);
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
            Margin = new Padding(5);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox textBox3;
        private ListBox listBox2;
    }
}
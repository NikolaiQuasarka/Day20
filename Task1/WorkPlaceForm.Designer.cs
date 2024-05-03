namespace Task1
{
    partial class WorkPlaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            buttonAddWorKPlace = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxRequiredExperience = new TextBox();
            textBoxPost = new TextBox();
            textBoxCompany = new TextBox();
            bindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Места работы";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(400, 177);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAddWorKPlace);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxRequiredExperience);
            groupBox2.Controls.Add(textBoxPost);
            groupBox2.Controls.Add(textBoxCompany);
            groupBox2.Location = new Point(424, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 203);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Новое место работы";
            // 
            // buttonAddWorKPlace
            // 
            buttonAddWorKPlace.Location = new Point(117, 153);
            buttonAddWorKPlace.Name = "buttonAddWorKPlace";
            buttonAddWorKPlace.Size = new Size(94, 29);
            buttonAddWorKPlace.TabIndex = 6;
            buttonAddWorKPlace.Text = "Добавить";
            buttonAddWorKPlace.UseVisualStyleBackColor = true;
            buttonAddWorKPlace.Click += buttonAddWorKPlace_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 105);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 5;
            label3.Text = "Требуемый опыт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 72);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Должность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 39);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "Компания";
            // 
            // textBoxRequiredExperience
            // 
            textBoxRequiredExperience.Location = new Point(154, 102);
            textBoxRequiredExperience.Name = "textBoxRequiredExperience";
            textBoxRequiredExperience.Size = new Size(125, 27);
            textBoxRequiredExperience.TabIndex = 2;
            // 
            // textBoxPost
            // 
            textBoxPost.Location = new Point(154, 69);
            textBoxPost.Name = "textBoxPost";
            textBoxPost.Size = new Size(125, 27);
            textBoxPost.TabIndex = 1;
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(154, 36);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(125, 27);
            textBoxCompany.TabIndex = 0;
            // 
            // WorkPlaceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 233);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WorkPlaceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkPlaceForm";
            FormClosing += WorkPlaceForm_FormClosing;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button buttonAddWorKPlace;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxRequiredExperience;
        private TextBox textBoxPost;
        private TextBox textBoxCompany;
        private BindingSource bindingSource1;
    }
}
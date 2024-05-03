namespace Task1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dcc = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            comboBoxWorkPlace = new ComboBox();
            label9 = new Label();
            comboBoxAddress = new ComboBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            buttonAddStudent = new Button();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dateTimePickerBirhtDay = new DateTimePicker();
            textBoxAverageMark = new TextBox();
            textBoxGroup = new TextBox();
            textBoxCourse = new TextBox();
            textBoxSpeculity = new TextBox();
            textBoxFullName = new TextBox();
            Addresses = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, dcc, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(875, 510);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "FullName";
            Column1.HeaderText = "ФИО";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 71;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirthDay";
            Column2.HeaderText = "День Рождения";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 135;
            // 
            // dcc
            // 
            dcc.DataPropertyName = "Speculity";
            dcc.HeaderText = "Специальность";
            dcc.MinimumWidth = 6;
            dcc.Name = "dcc";
            dcc.ReadOnly = true;
            dcc.Width = 145;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Course";
            Column3.HeaderText = "Курс";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 70;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Group";
            Column4.HeaderText = "Группа";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 87;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "AverageMark";
            Column5.HeaderText = "Средний бал";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 118;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Gender";
            Column6.HeaderText = "Пол";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 66;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Address";
            Column7.HeaderText = "Адрес проживания";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 158;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 536);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Студенты";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxWorkPlace);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBoxAddress);
            groupBox2.Controls.Add(radioButtonFemale);
            groupBox2.Controls.Add(radioButtonMale);
            groupBox2.Controls.Add(buttonAddStudent);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTimePickerBirhtDay);
            groupBox2.Controls.Add(textBoxAverageMark);
            groupBox2.Controls.Add(textBoxGroup);
            groupBox2.Controls.Add(textBoxCourse);
            groupBox2.Controls.Add(textBoxSpeculity);
            groupBox2.Controls.Add(textBoxFullName);
            groupBox2.Location = new Point(899, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 498);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Новый студент";
            // 
            // comboBoxWorkPlace
            // 
            comboBoxWorkPlace.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWorkPlace.FormattingEnabled = true;
            comboBoxWorkPlace.Location = new Point(170, 418);
            comboBoxWorkPlace.Name = "comboBoxWorkPlace";
            comboBoxWorkPlace.Size = new Size(191, 28);
            comboBoxWorkPlace.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(56, 421);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 19;
            label9.Text = "Место работы";
            // 
            // comboBoxAddress
            // 
            comboBoxAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddress.FormattingEnabled = true;
            comboBoxAddress.Location = new Point(170, 370);
            comboBoxAddress.Name = "comboBoxAddress";
            comboBoxAddress.Size = new Size(191, 28);
            comboBoxAddress.TabIndex = 3;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(269, 316);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(92, 24);
            radioButtonFemale.TabIndex = 18;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Женский";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(170, 318);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(93, 24);
            radioButtonMale.TabIndex = 17;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Мужской";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(151, 463);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(94, 29);
            buttonAddStudent.TabIndex = 16;
            buttonAddStudent.Text = "Добавить";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 373);
            label8.Name = "label8";
            label8.Size = new Size(151, 20);
            label8.TabIndex = 15;
            label8.Text = "Адресс проживания";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 318);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 14;
            label7.Text = "Пол";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 85);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 9;
            label2.Text = "День Рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 278);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 13;
            label6.Text = "Средний бал";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 185);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 12;
            label5.Text = "Группа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 233);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 11;
            label4.Text = "Курс";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 135);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 10;
            label3.Text = "Специальность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 8;
            label1.Text = "ФИО";
            // 
            // dateTimePickerBirhtDay
            // 
            dateTimePickerBirhtDay.Format = DateTimePickerFormat.Short;
            dateTimePickerBirhtDay.Location = new Point(170, 80);
            dateTimePickerBirhtDay.MinDate = new DateTime(1931, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirhtDay.Name = "dateTimePickerBirhtDay";
            dateTimePickerBirhtDay.Size = new Size(191, 27);
            dateTimePickerBirhtDay.TabIndex = 7;
            // 
            // textBoxAverageMark
            // 
            textBoxAverageMark.Location = new Point(170, 275);
            textBoxAverageMark.Name = "textBoxAverageMark";
            textBoxAverageMark.Size = new Size(191, 27);
            textBoxAverageMark.TabIndex = 5;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(170, 182);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(191, 27);
            textBoxGroup.TabIndex = 4;
            // 
            // textBoxCourse
            // 
            textBoxCourse.Location = new Point(170, 230);
            textBoxCourse.Name = "textBoxCourse";
            textBoxCourse.Size = new Size(191, 27);
            textBoxCourse.TabIndex = 3;
            // 
            // textBoxSpeculity
            // 
            textBoxSpeculity.Location = new Point(170, 132);
            textBoxSpeculity.Name = "textBoxSpeculity";
            textBoxSpeculity.Size = new Size(191, 27);
            textBoxSpeculity.TabIndex = 2;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(170, 26);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(191, 27);
            textBoxFullName.TabIndex = 0;
            // 
            // Addresses
            // 
            Addresses.Location = new Point(933, 516);
            Addresses.Name = "Addresses";
            Addresses.Size = new Size(163, 29);
            Addresses.TabIndex = 3;
            Addresses.Text = "Адресса";
            Addresses.UseVisualStyleBackColor = true;
            Addresses.Click += Addresses_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1124, 516);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 4;
            button1.Text = "Места работы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 573);
            Controls.Add(button1);
            Controls.Add(Addresses);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Университет";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePickerBirhtDay;
        private TextBox textBoxAverageMark;
        private TextBox textBoxGroup;
        private TextBox textBoxCourse;
        private TextBox textBoxSpeculity;
        private TextBox textBoxFullName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dcc;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Button buttonAddStudent;
        private ComboBox comboBoxAddress;
        private Button Addresses;
        private ComboBox comboBoxWorkPlace;
        private Label label9;
        private Button button1;
    }
}

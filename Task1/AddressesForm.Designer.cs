namespace Task1
{
    partial class AddressesForm
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
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            buttonAddAddress = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxApartment = new TextBox();
            textBoxHouse = new TextBox();
            textBoxStreet = new TextBox();
            textBoxTown = new TextBox();
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(355, 234);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 260);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Адресса";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAddAddress);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxApartment);
            groupBox2.Controls.Add(textBoxHouse);
            groupBox2.Controls.Add(textBoxStreet);
            groupBox2.Controls.Add(textBoxTown);
            groupBox2.Location = new Point(436, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 260);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Новый адресс";
            // 
            // buttonAddAddress
            // 
            buttonAddAddress.Location = new Point(115, 210);
            buttonAddAddress.Name = "buttonAddAddress";
            buttonAddAddress.Size = new Size(94, 29);
            buttonAddAddress.TabIndex = 8;
            buttonAddAddress.Text = "Добавить";
            buttonAddAddress.UseVisualStyleBackColor = true;
            buttonAddAddress.Click += buttonAddAddress_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 160);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Квартира";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Дом";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 75);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Улица";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Город";
            // 
            // textBoxApartment
            // 
            textBoxApartment.Location = new Point(170, 157);
            textBoxApartment.Name = "textBoxApartment";
            textBoxApartment.Size = new Size(125, 27);
            textBoxApartment.TabIndex = 3;
            // 
            // textBoxHouse
            // 
            textBoxHouse.Location = new Point(170, 114);
            textBoxHouse.Name = "textBoxHouse";
            textBoxHouse.Size = new Size(125, 27);
            textBoxHouse.TabIndex = 2;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(170, 72);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(125, 27);
            textBoxStreet.TabIndex = 1;
            // 
            // textBoxTown
            // 
            textBoxTown.Location = new Point(170, 39);
            textBoxTown.Name = "textBoxTown";
            textBoxTown.Size = new Size(125, 27);
            textBoxTown.TabIndex = 0;
            // 
            // AddressesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 289);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AddressesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddressesForm";
            FormClosing += AddressesForm_FormClosing;
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxApartment;
        private TextBox textBoxHouse;
        private TextBox textBoxStreet;
        private TextBox textBoxTown;
        private Button buttonAddAddress;
    }
}
namespace Session5_LoyaltyApp
{
    partial class LoyaltyManagementPage
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
            button3 = new Button();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            membershipStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LoyaltyPoints = new DataGridViewTextBoxColumn();
            totalSpendingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            loyaltyProgramBindingSource = new BindingSource(components);
            label9 = new Label();
            textBox6 = new TextBox();
            customerBindingSource1 = new BindingSource(components);
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loyaltyProgramBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(420, 457);
            button3.Name = "button3";
            button3.Size = new Size(61, 29);
            button3.TabIndex = 12;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 461);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(206, 457);
            button2.Name = "button2";
            button2.Size = new Size(87, 29);
            button2.TabIndex = 10;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 100);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 9;
            label2.Text = "Search by name, ID, or email";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, membershipStatusDataGridViewTextBoxColumn, LoyaltyPoints, totalSpendingDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(41, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(655, 250);
            dataGridView1.TabIndex = 8;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "Customer Id";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // membershipStatusDataGridViewTextBoxColumn
            // 
            membershipStatusDataGridViewTextBoxColumn.DataPropertyName = "MembershipStatus";
            membershipStatusDataGridViewTextBoxColumn.HeaderText = "Membership Status";
            membershipStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            membershipStatusDataGridViewTextBoxColumn.Name = "membershipStatusDataGridViewTextBoxColumn";
            membershipStatusDataGridViewTextBoxColumn.ReadOnly = true;
            membershipStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // LoyaltyPoints
            // 
            LoyaltyPoints.HeaderText = "Loyalty Points";
            LoyaltyPoints.MinimumWidth = 6;
            LoyaltyPoints.Name = "LoyaltyPoints";
            LoyaltyPoints.ReadOnly = true;
            LoyaltyPoints.Width = 125;
            // 
            // totalSpendingDataGridViewTextBoxColumn
            // 
            totalSpendingDataGridViewTextBoxColumn.DataPropertyName = "TotalSpending";
            totalSpendingDataGridViewTextBoxColumn.HeaderText = "Total Spending";
            totalSpendingDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalSpendingDataGridViewTextBoxColumn.Name = "totalSpendingDataGridViewTextBoxColumn";
            totalSpendingDataGridViewTextBoxColumn.ReadOnly = true;
            totalSpendingDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(models.Customer);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(655, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.Location = new Point(718, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 813);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // button6
            // 
            button6.Location = new Point(250, 331);
            button6.Name = "button6";
            button6.Size = new Size(162, 29);
            button6.TabIndex = 14;
            button6.Text = "Recalculate Points";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(161, 331);
            button5.Name = "button5";
            button5.Size = new Size(73, 29);
            button5.TabIndex = 13;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(15, 331);
            button4.Name = "button4";
            button4.Size = new Size(131, 29);
            button4.TabIndex = 12;
            button4.Text = "Save Changes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", loyaltyProgramBindingSource, "Points", true));
            numericUpDown1.Location = new Point(167, 277);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(174, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // loyaltyProgramBindingSource
            // 
            loyaltyProgramBindingSource.DataSource = typeof(models.LoyaltyProgram);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 279);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 10;
            label9.Text = "Loyalty Points:";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", customerBindingSource1, "MembershipStatus", true));
            textBox6.Location = new Point(167, 225);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(174, 27);
            textBox6.TabIndex = 9;
            // 
            // customerBindingSource1
            // 
            customerBindingSource1.DataSource = typeof(models.Customer);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 228);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 8;
            label8.Text = "Membership Status:";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", customerBindingSource1, "Email", true));
            textBox5.Location = new Point(167, 178);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(174, 27);
            textBox5.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 181);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", customerBindingSource1, "LastName", true));
            textBox4.Location = new Point(167, 128);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(174, 27);
            textBox4.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 131);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 4;
            label6.Text = "Last Name:";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", customerBindingSource1, "FirstName", true));
            textBox3.Location = new Point(167, 83);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(174, 27);
            textBox3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 86);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 2;
            label5.Text = "First Name:";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", customerBindingSource1, "CustomerId", true));
            textBox2.Location = new Point(167, 35);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 38);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 0;
            label4.Text = "Customer ID:";
            // 
            // LoyaltyManagementPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 909);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "LoyaltyManagementPage";
            Text = "Belle Croissant Lyonnais - Loyalty Management";
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loyaltyProgramBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label3;
        private Button button2;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn membershipStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LoyaltyPoints;
        private DataGridViewTextBoxColumn totalSpendingDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private BindingSource loyaltyProgramBindingSource;
        private BindingSource customerBindingSource1;
    }
}
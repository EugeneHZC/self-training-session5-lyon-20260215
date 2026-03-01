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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
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
            // 
            // LoyaltyManagementPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 909);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
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
    }
}
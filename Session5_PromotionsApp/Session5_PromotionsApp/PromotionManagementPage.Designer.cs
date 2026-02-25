namespace Session5_PromotionsApp
{
    partial class PromotionManagementPage
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
            promotionNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            applicableProductsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minimumOrderValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewLinkColumn();
            DeleteAction = new DataGridViewLinkColumn();
            promotionBindingSource = new BindingSource(components);
            button2 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            numericUpDown3 = new NumericUpDown();
            promotionBindingSource1 = new BindingSource(components);
            label10 = new Label();
            numericUpDown2 = new NumericUpDown();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            listBox1 = new ListBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { promotionNameDataGridViewTextBoxColumn, discountTypeDataGridViewTextBoxColumn, discountValueDataGridViewTextBoxColumn, applicableProductsDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, minimumOrderValueDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, Actions, DeleteAction });
            dataGridView1.DataSource = promotionBindingSource;
            dataGridView1.Location = new Point(41, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(775, 248);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // promotionNameDataGridViewTextBoxColumn
            // 
            promotionNameDataGridViewTextBoxColumn.DataPropertyName = "PromotionName";
            promotionNameDataGridViewTextBoxColumn.HeaderText = "Promotion Name";
            promotionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            promotionNameDataGridViewTextBoxColumn.Name = "promotionNameDataGridViewTextBoxColumn";
            promotionNameDataGridViewTextBoxColumn.ReadOnly = true;
            promotionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountTypeDataGridViewTextBoxColumn
            // 
            discountTypeDataGridViewTextBoxColumn.DataPropertyName = "DiscountType";
            discountTypeDataGridViewTextBoxColumn.HeaderText = "Discount Type";
            discountTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountTypeDataGridViewTextBoxColumn.Name = "discountTypeDataGridViewTextBoxColumn";
            discountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            discountTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountValueDataGridViewTextBoxColumn
            // 
            discountValueDataGridViewTextBoxColumn.DataPropertyName = "DiscountValue";
            discountValueDataGridViewTextBoxColumn.HeaderText = "Discount Value";
            discountValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountValueDataGridViewTextBoxColumn.Name = "discountValueDataGridViewTextBoxColumn";
            discountValueDataGridViewTextBoxColumn.ReadOnly = true;
            discountValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicableProductsDataGridViewTextBoxColumn
            // 
            applicableProductsDataGridViewTextBoxColumn.DataPropertyName = "ApplicableProducts";
            applicableProductsDataGridViewTextBoxColumn.HeaderText = "Applicable Products";
            applicableProductsDataGridViewTextBoxColumn.MinimumWidth = 6;
            applicableProductsDataGridViewTextBoxColumn.Name = "applicableProductsDataGridViewTextBoxColumn";
            applicableProductsDataGridViewTextBoxColumn.ReadOnly = true;
            applicableProductsDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // minimumOrderValueDataGridViewTextBoxColumn
            // 
            minimumOrderValueDataGridViewTextBoxColumn.DataPropertyName = "MinimumOrderValue";
            minimumOrderValueDataGridViewTextBoxColumn.HeaderText = "Minimum Order Value";
            minimumOrderValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            minimumOrderValueDataGridViewTextBoxColumn.Name = "minimumOrderValueDataGridViewTextBoxColumn";
            minimumOrderValueDataGridViewTextBoxColumn.ReadOnly = true;
            minimumOrderValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            priorityDataGridViewTextBoxColumn.ReadOnly = true;
            priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.Resizable = DataGridViewTriState.True;
            Actions.SortMode = DataGridViewColumnSortMode.Automatic;
            Actions.Width = 72;
            // 
            // DeleteAction
            // 
            DeleteAction.HeaderText = "";
            DeleteAction.MinimumWidth = 6;
            DeleteAction.Name = "DeleteAction";
            DeleteAction.ReadOnly = true;
            DeleteAction.Resizable = DataGridViewTriState.True;
            DeleteAction.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteAction.Width = 72;
            // 
            // promotionBindingSource
            // 
            promotionBindingSource.DataSource = typeof(models.Promotion);
            // 
            // button2
            // 
            button2.Location = new Point(41, 386);
            button2.Name = "button2";
            button2.Size = new Size(195, 44);
            button2.TabIndex = 3;
            button2.Text = "Add New Promotion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(numericUpDown3);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(41, 449);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 587);
            panel2.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(136, 519);
            button4.Name = "button4";
            button4.Size = new Size(82, 37);
            button4.TabIndex = 19;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(20, 519);
            button3.Name = "button3";
            button3.Size = new Size(82, 37);
            button3.TabIndex = 18;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DataBindings.Add(new Binding("Value", promotionBindingSource1, "Priority", true));
            numericUpDown3.Location = new Point(193, 465);
            numericUpDown3.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(253, 27);
            numericUpDown3.TabIndex = 17;
            // 
            // promotionBindingSource1
            // 
            promotionBindingSource1.DataSource = typeof(models.Promotion);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 467);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 16;
            label10.Text = "Priority:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DataBindings.Add(new Binding("Value", promotionBindingSource1, "MinimumOrderValue", true));
            numericUpDown2.Location = new Point(193, 420);
            numericUpDown2.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(253, 27);
            numericUpDown2.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 422);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 14;
            label9.Text = "Minimm Order Value:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(193, 375);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(253, 27);
            dateTimePicker2.TabIndex = 13;
            dateTimePicker2.Value = new DateTime(2026, 2, 9, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 380);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 12;
            label8.Text = "End Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(193, 330);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2026, 2, 9, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 335);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 10;
            label7.Text = "Start Date:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(193, 223);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(253, 84);
            listBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 287);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 8;
            label6.Text = "Applicable Products:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", promotionBindingSource1, "DiscountValue", true));
            numericUpDown1.Location = new Point(193, 168);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(253, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 170);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 5;
            label5.Text = "Discount Value:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(193, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 28);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", promotionBindingSource1, "PromotionName", true));
            textBox1.Location = new Point(193, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 120);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 2;
            label4.Text = "Discount Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 73);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 1;
            label3.Text = "Promotion Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(20, 21);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // PromotionManagementPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 1063);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "PromotionManagementPage";
            Text = "Belle Croissant Lyonnais - Promotion Management";
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(panel2, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn promotionNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn applicableProductsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minimumOrderValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Actions;
        private DataGridViewLinkColumn DeleteAction;
        private BindingSource promotionBindingSource;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private NumericUpDown numericUpDown3;
        private Label label10;
        private NumericUpDown numericUpDown2;
        private Label label9;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ListBox listBox1;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private BindingSource promotionBindingSource1;
    }
}
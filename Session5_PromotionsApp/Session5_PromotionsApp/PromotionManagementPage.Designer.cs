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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).BeginInit();
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
            // 
            // PromotionManagementPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 478);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "PromotionManagementPage";
            Text = "Belle Croissant Lyonnais - Promotion Management";
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(button2, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).EndInit();
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
    }
}
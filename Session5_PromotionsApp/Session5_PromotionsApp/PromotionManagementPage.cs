using Session5_PromotionsApp.models;

namespace Session5_PromotionsApp
{
    public partial class PromotionManagementPage : Form1
    {
        private List<Promotion> promotions = new List<Promotion>();
        private List<Product> products = new List<Product>();

        public PromotionManagementPage()
        {
            InitializeComponent();
            LoadProducts();
            LoadData();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Percentage");
            comboBox1.Items.Add("Fixed Amount");
        }

        private void LoadProducts()
        {
            products = Helper.db.Products.ToList();
            listBox1.DataSource = products;
            listBox1.DisplayMember = "ProductName";
            listBox1.ValueMember = "ProductId";
        }

        private void LoadData()
        {
            promotions = Helper.db.Promotions.ToList();

            panel2.Hide();

            LoadTable();
        }

        private void LoadTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.ClearSelection();

            foreach (var promotion in promotions)
            {
                var productIds = promotion.ApplicableProducts.Split(",").ToList();

                var productsInPromotion = string.Join(",", products.Where(x => productIds.Contains(x.ProductId.ToString())).Select(x => x.ProductName).ToList());

                dataGridView1.Rows.Add(
                    promotion.PromotionName,
                    promotion.DiscountType == "FixedAmount" ? "Fixed Amount" : promotion.DiscountType,
                    promotion.DiscountValue,
                    productsInPromotion,
                    promotion.StartDate,
                    promotion.EndDate,
                    promotion.MinimumOrderValue,
                    promotion.Priority
                );

                dataGridView1.Rows[^1].Tag = promotion;
            }
        }

        private void ResetForm()
        {
            listBox1.ClearSelected();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetForm();

            if (e.RowIndex < 0) return;

            var promotionSelected = dataGridView1.Rows[e.RowIndex].Tag as Promotion;

            if (e.ColumnIndex == 8)
            {
                // edit button clicked
                panel2.Show();
                label2.Text = "Edit Promotion";

                promotionBindingSource1.ResetCurrentItem();
                promotionBindingSource1.DataSource = promotionSelected;
                dateTimePicker1.Value = promotionSelected.StartDate.ToDateTime(TimeOnly.MinValue);
                dateTimePicker2.Value = promotionSelected.EndDate.ToDateTime(TimeOnly.MinValue);
                comboBox1.SelectedItem = promotionSelected.DiscountType == "FixedAmount" ? "Fixed Amount" : "Percentage";

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    var item = listBox1.Items[i] as Product;
                    var productId = item.ProductId;

                    if (promotionSelected.ApplicableProducts.Split(",").ToList().Contains(productId.ToString()))
                    {
                        listBox1.SelectedItems.Add(item);
                    }
                }
            }
            else if (e.ColumnIndex == 9)
            {
                // delete button clicked
                if (MessageBox.Show("Are you sure you want to delete this promotion?", "Delete Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Helper.db.Promotions.Remove(promotionSelected);
                    Helper.db.SaveChanges();
                    LoadData();
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                e.Value = "Edit";
            }
            else if (e.ColumnIndex == 9)
            {
                e.Value = "Delete";
            }
        }

        // add new promotion button
        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();

            var newPromotion = new Promotion()
            {
                PromotionId = 0,
                DiscountValue = 0,
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                EndDate = DateOnly.FromDateTime(DateTime.Now),
                MinimumOrderValue = 0,
                Priority = 0
            };

            promotionBindingSource1.ResetCurrentItem();
            promotionBindingSource1.DataSource = newPromotion;
            comboBox1.SelectedIndex = 0;
            panel2.Show();
            label2.Text = "Add New Promotion";
        }

        // Save button clicked
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || comboBox1.SelectedIndex == 0 || numericUpDown1.Value <= 0)
            {
                return;
            }

            var promotion = (Promotion)promotionBindingSource1.Current;

            promotion.DiscountType = comboBox1.SelectedItem.ToString();

            promotion.ApplicableProducts = string.Join(",", listBox1.SelectedItems.Cast<Product>().Select(x => x.ProductId.ToString()).ToList());

            promotion.StartDate = DateOnly.FromDateTime(dateTimePicker1.Value);
            promotion.EndDate = DateOnly.FromDateTime(dateTimePicker2.Value);

            if (promotion.StartDate > promotion.EndDate)
            {
                MessageBox.Show("Invalid date range.", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (promotion.DiscountType == "Fixed Amount")
            {
                promotion.DiscountType = "FixedAmount";
            }

            if (promotion.PromotionId == 0)
            {
                Helper.db.Add(promotion);
            }
            else
            {
                Helper.db.Entry(promotion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            Helper.db.SaveChanges();

            Dictionary<Promotion, string> conflictedPromotions = getConflictProducts(promotion);

            while (conflictedPromotions.Count > 0)
            {
                this.Hide();
                new ConflictResolutionWizard(promotion, conflictedPromotions).ShowDialog();
                this.Show();
                promotion = Helper.db.Promotions.ToList().First(x => x.PromotionId == promotion.PromotionId);
                conflictedPromotions = getConflictProducts(promotion);
            }

            LoadData();
        }

        private Dictionary<Promotion, string> getConflictProducts(Promotion promotion)
        {
            var applicableProducts = promotion.ApplicableProducts.Split(",");
            var allPromotions = Helper.db.Promotions.ToList();

            Dictionary<Promotion, string> conflictedPromotions = new Dictionary<Promotion, string>();

            foreach (var promo in allPromotions)
            {
                var products = promo.ApplicableProducts.Split(",");

                if (promo.PromotionId != promotion.PromotionId && products.Any(x => applicableProducts.Contains(x)) &&
                    promo.StartDate <= promotion.EndDate && promotion.StartDate <= promo.EndDate && promo.Priority == promotion.Priority)
                {
                    var productConflicted = products.Intersect(applicableProducts).ToList();
                    conflictedPromotions[promo] = string.Join(",", productConflicted);
                }
            }

            return conflictedPromotions;
        }

        // cancel button
        private void button4_Click(object sender, EventArgs e)
        {
            Helper.db.ChangeTracker.Entries().ToList().ForEach(x => x.State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);
            dataGridView1.ClearSelection();
            panel2.Hide();
        }
    }
}

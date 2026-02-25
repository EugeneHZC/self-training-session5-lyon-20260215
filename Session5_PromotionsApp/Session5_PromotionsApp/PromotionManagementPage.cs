using Session5_PromotionsApp.models;

namespace Session5_PromotionsApp
{
    public partial class PromotionManagementPage : Form1
    {
        private List<Promotion> promotions = new List<Promotion>();
        private List<Product> products = new List<Product>();
        private string currentOperation = "";

        public PromotionManagementPage()
        {
            InitializeComponent();
            LoadData();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Percentage");
            comboBox1.Items.Add("Fixed Amount");

            LoadProducts();
        }

        private void LoadProducts()
        {
            products = Helper.db.Products.ToList();
            listBox1.DataSource = products.Select(x => x.ProductName).ToList();
        }

        private void LoadData()
        {
            promotions = Helper.db.Promotions.ToList();

            panel2.Hide();

            LoadTable();
        }

        private void LoadTable()
        {
            dataGridView1.DataSource = promotions;
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

            var promotionSelected = promotions[e.RowIndex];

            if (e.ColumnIndex == 8)
            {
                panel2.Show();
                label2.Text = "Edit Promotion";

                promotionBindingSource1.ResetCurrentItem();
                promotionBindingSource1.DataSource = promotionSelected;
                dateTimePicker1.Value = promotionSelected.StartDate.ToDateTime(TimeOnly.MinValue);
                dateTimePicker2.Value = promotionSelected.EndDate.ToDateTime(TimeOnly.MinValue);
                comboBox1.SelectedItem = promotionSelected.DiscountType == "FixedAmount" ? "Fixed Amount" : "Percentage";
                currentOperation = "edit";

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    var item = listBox1.Items[i].ToString();
                    if (promotionSelected.ApplicableProducts.Split(",").Contains(item))
                    {
                        listBox1.SelectedItems.Add(item);
                    }
                }
            }
            else if (e.ColumnIndex == 9)
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();

            var newPromotion = new Promotion()
            {
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                EndDate = DateOnly.FromDateTime(DateTime.Now),
                MinimumOrderValue = 0
            };

            promotionBindingSource1.ResetCurrentItem();
            promotionBindingSource1.DataSource = newPromotion;
            comboBox1.SelectedIndex = 0;
            panel2.Show();
            label2.Text = "Add New Promotion";
            currentOperation = "add";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var promotion = (Promotion)promotionBindingSource1.Current;

            promotion.DiscountType = comboBox1.SelectedItem.ToString();

            promotion.ApplicableProducts = string.Join(",", listBox1.SelectedItems.Cast<string>());

            promotion.StartDate = DateOnly.FromDateTime(dateTimePicker1.Value);
            promotion.EndDate = DateOnly.FromDateTime(dateTimePicker2.Value);

            if (promotion.DiscountType == "Fixed Amount")
            {
                promotion.DiscountType = "FixedAmount";
            }

            if (currentOperation == "add")
            {
                Helper.db.Add(promotion);
            }
            else if (currentOperation == "edit")
            {
                Helper.db.Entry(promotion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            else
            {
                return;
            }

            Helper.db.SaveChanges();

            LoadData();
        }
    }
}

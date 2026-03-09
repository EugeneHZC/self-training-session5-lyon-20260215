using Microsoft.EntityFrameworkCore;
using Session5_LoyaltyApp.models;

namespace Session5_LoyaltyApp
{
    public partial class LoyaltyManagementPage : Form1
    {
        private List<Customer> customers = new List<Customer>();
        private List<LoyaltyProgram> loyaltyPrograms = new List<LoyaltyProgram>();

        private int maxPages;
        private int currentPage = 0;
        private int points = 0;

        public LoyaltyManagementPage()
        {
            InitializeComponent();
            LoadData();
            button8.Visible = false;
        }

        private void LoadData()
        {
            loyaltyPrograms = Helper.db.LoyaltyPrograms.ToList();
            customers = Helper.db.Customers.Include(x => x.Orders).ToList();

            LoadTable();
        }

        private void LoadTable()
        {
            dataGridView1.Enabled = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            var query = textBox1.Text.Trim().ToLower();
            var temp = customers.Where(x => $"{x.FirstName} {x.LastName}".ToLower().Contains(query) ||
                x.Email.ToLower().Contains(query) ||
                x.CustomerId.ToString().Contains(query))
                .OrderByDescending(x => x.CustomerId)
                .ToList();

            maxPages = (int)Math.Ceiling(temp.Count / 10.0);
            currentPage = 0;

            foreach (var c in temp)
            {
                dataGridView1.Rows.Add(
                    c.CustomerId,
                    c.FirstName,
                    c.LastName,
                    c.Email,
                    loyaltyPrograms.FirstOrDefault(x => x.CustomerId == c.CustomerId).MembershipTier,
                    loyaltyPrograms.FirstOrDefault(x => x.CustomerId == c.CustomerId).Points,
                    c.TotalSpending
                );
                dataGridView1.Rows[^1].Tag = c;
            }

            LoadPage();

            dataGridView1.ClearSelection();
            groupBox1.Hide();
            groupBox2.Hide();
            dataGridView1.Enabled = true;
        }

        private void LoadPage()
        {
            var firstRow = currentPage * 10;
            var lastRow = firstRow + 10;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = row.Index >= firstRow && row.Index <= lastRow;
            }

            label3.Text = $"Page {currentPage + 1} of {maxPages}";
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            button2.Enabled = currentPage != 0;
            button3.Enabled = currentPage != maxPages - 1;
        }

        // previous button
        private void button2_Click(object sender, EventArgs e)
        {
            currentPage--;
            currentPage = Math.Max(0, Math.Min(maxPages - 1, currentPage));
            LoadPage();
        }

        // next button
        private void button3_Click(object sender, EventArgs e)
        {
            currentPage++;
            currentPage = Math.Max(0, Math.Min(maxPages - 1, currentPage));
            LoadPage();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            groupBox1.Show();
            customerBindingSource1.ResetCurrentItem();
            loyaltyProgramBindingSource.ResetCurrentItem();

            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.Enabled)
            {
                var customer = dataGridView1.SelectedRows[0].Tag as Customer;
                customerBindingSource1.DataSource = customer;
                loyaltyProgramBindingSource.DataSource = loyaltyPrograms.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
            }
        }

        // cancel button
        private void button5_Click(object sender, EventArgs e)
        {
            Helper.db.ChangeTracker.Entries().ToList().ForEach(x => x.State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);
            dataGridView1.ClearSelection();
            groupBox1.Hide();
        }

        // save button
        private void button4_Click(object sender, EventArgs e)
        {
            var loyaltyProgram = loyaltyProgramBindingSource.Current as LoyaltyProgram;
            Helper.db.LoyaltyPrograms.Entry(loyaltyProgram).State = EntityState.Modified;
            Helper.db.SaveChanges();
            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK);
            dataGridView1.ClearSelection();
            groupBox1.Hide();
            LoadTable();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(200);
            LoadTable();
        }

        // recalculate points button
        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            var customer = dataGridView1.SelectedRows[0].Tag as Customer;
            int bonus;
            int pointsPer10Euros = customer.MembershipStatus switch
            {
                "Basic" => 10,
                "Silver" => 12,
                "Gold" => 15,
                _ => 0
            };

            points = 0;

            dataGridView2.DataSource = null;
            dataGridView2.ClearSelection();

            foreach (var order in customer.Orders)
            {
                int amount = (int)(order.TotalAmount - order.DiscountAmount) / 10;
                bonus = 0;

                if (order.PromotionId != null)
                {
                    bonus += 5;
                }

                if ((customer.JoinDate?.Month, customer.JoinDate?.Day) == (order.OrderDate.Month, order.OrderDate.Day))
                {
                    bonus += 25;
                }

                dataGridView2.Rows.Add(order.OrderDate, order.TotalAmount, amount * pointsPer10Euros, bonus);

                points += amount * pointsPer10Euros + bonus;
            }

            label10.Text = $"Total Points: {points}";
        }

        // confirm update button under order table
        private void button7_Click(object sender, EventArgs e)
        {
            var loyaltyProgram = loyaltyProgramBindingSource.Current as LoyaltyProgram;
            loyaltyProgram.Points = points;
            numericUpDown1.Value = points;
            MessageBox.Show("Points updated successfully.", "Success", MessageBoxButtons.OK);
            groupBox2.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button8.Visible = numericUpDown1.Value >= 1000;
        }

        // redeem rewards button
        private void button8_Click(object sender, EventArgs e)
        {
            var customer = dataGridView1.SelectedRows[0].Tag as Customer;
            var loyalty = loyaltyPrograms.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
            new RedeemRewardsPage(customer, loyalty).ShowDialog();
            loyaltyProgramBindingSource.ResetCurrentItem();
            loyaltyProgramBindingSource.DataSource = loyalty;
            LoadTable();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            currentPage = 0;
            LoadPage();
        }
    }
}

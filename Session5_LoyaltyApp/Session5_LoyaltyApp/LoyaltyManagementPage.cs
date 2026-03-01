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

        public LoyaltyManagementPage()
        {
            InitializeComponent();
            LoadData();
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

            var results = temp.Skip(currentPage * 10)
                    .Take(10)
                    .ToList();

            foreach (var c in results)
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

            label3.Text = $"Page {currentPage + 1} of {maxPages}";

            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            button2.Enabled = currentPage != 0;
            button3.Enabled = currentPage != maxPages - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPage--;
            currentPage = Math.Max(0, Math.Min(maxPages - 1, currentPage));
            LoadTable();
            UpdateButtonState();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentPage++;
            currentPage = Math.Max(0, Math.Min(maxPages - 1, currentPage));
            LoadTable();
            UpdateButtonState();
        }
    }
}

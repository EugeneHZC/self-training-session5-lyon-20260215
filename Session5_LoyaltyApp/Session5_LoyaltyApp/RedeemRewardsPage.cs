using Session5_LoyaltyApp.models;

namespace Session5_LoyaltyApp
{
    public partial class RedeemRewardsPage : Form1
    {
        private Customer customer;
        private LoyaltyProgram loyaltyProgram;

        public RedeemRewardsPage(Customer customer, LoyaltyProgram loyaltyProgram)
        {
            InitializeComponent();
            this.customer = customer;
            this.loyaltyProgram = loyaltyProgram;

            if (customer.MembershipStatus == "Gold")
            {
                button4.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newPromotion = new Promotion()
            {
                PromotionName = "5 euros discount on next purchase",
                DiscountType = "FixedAmount",
                DiscountValue = 5,
                ApplicableProducts = string.Join(",", Helper.db.Products.Select(x => x.ProductName).ToList()),
                StartDate = DateOnly.FromDateTime(DateTime.Today),
                EndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(30)),
                MinimumOrderValue = 0,
                Priority = 99,
                QuantityBasedRules = null
            };

            this.loyaltyProgram.Points -= 1000;
            Helper.db.Promotions.Add(newPromotion);
            Helper.db.SaveChanges();

            MessageBox.Show("5 euros discount applied to next purchase.", "Success", MessageBoxButtons.OK);
            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK);

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newPromotion = new Promotion()
            {
                PromotionName = "10% discount on next purchase",
                DiscountType = "Percentage",
                DiscountValue = 10,
                ApplicableProducts = string.Join(",", Helper.db.Products.Select(x => x.ProductName).ToList()),
                StartDate = DateOnly.FromDateTime(DateTime.Today),
                EndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(30)),
                MinimumOrderValue = 0,
                Priority = 99,
                QuantityBasedRules = null
            };

            this.loyaltyProgram.Points -= 1000;
            Helper.db.Promotions.Add(newPromotion);
            Helper.db.SaveChanges();

            MessageBox.Show("10% discount applied to next purchase.", "Success", MessageBoxButtons.OK);
            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK);

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var tierUpgrade = this.loyaltyProgram.MembershipTier switch
            {
                "Basic" => "Silver",
                "Silver" => "Gold",
                _ => ""
            };

            customer.MembershipStatus = tierUpgrade;
            loyaltyProgram.MembershipTier = tierUpgrade;

            loyaltyProgram.Points -= 1000;
            Helper.db.Entry(this.customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Helper.db.Entry(this.loyaltyProgram).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Helper.db.SaveChanges();

            MessageBox.Show("Membership tier upgraded.", "Success", MessageBoxButtons.OK);
            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK);

            this.Close();
        }
    }
}

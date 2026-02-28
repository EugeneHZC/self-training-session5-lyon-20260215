using Session5_PromotionsApp.models;

namespace Session5_PromotionsApp
{
    public partial class ConflictResolutionWizard : Form1
    {
        private Dictionary<Promotion, string> conflictedPromotions;
        public string conflictedProducts;
        private const int maxStepIndex = 4;

        public ConflictResolutionWizard(Promotion promotion, Dictionary<Promotion, string> conflictedPromotions)
        {
            InitializeComponent();
            ConflictResolutionWizardHelper.promotion = promotion;
            this.conflictedPromotions = conflictedPromotions;
            LoadData();
            button3.Enabled = false;
        }

        private void LoadData()
        {
            promotionBindingSource.DataSource = ConflictResolutionWizardHelper.promotion;
            textBox2.Text = $"{ConflictResolutionWizardHelper.promotion.DiscountType} {ConflictResolutionWizardHelper.promotion.DiscountValue}{(ConflictResolutionWizardHelper.promotion.DiscountType == "Percentage" ? "%" : " euros")}";
            textBox4.Text = $"{ConflictResolutionWizardHelper.promotion.StartDate} - {ConflictResolutionWizardHelper.promotion.EndDate}";

            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;

            for (int i = 0; i < conflictedPromotions.Count(); i++)
            {
                var promo = conflictedPromotions.ToList()[i];
                RadioButton radioButton = new RadioButton();
                radioButton.Tag = promo;
                radioButton.AutoSize = true;
                radioButton.MaximumSize = new Size(500, 0);
                radioButton.Text = $"Conflict {i + 1}\n" +
                    $"Existing Promotion: {promo.Key.PromotionName}\n" +
                    $"Conflicting Product: {promo.Value}\n" +
                    $"Date Range: {promo.Key.StartDate} - {promo.Key.EndDate}\n" +
                    $"Priority: {promo.Key.Priority}\n";
                flowLayoutPanel1.Controls.Add(radioButton);
            }
        }

        private void UpdateButton()
        {
            button2.Enabled = tabControl1.SelectedIndex != maxStepIndex;
            button3.Enabled = tabControl1.SelectedIndex != 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
            tabControl1.SelectedIndex = Math.Max(0, Math.Min(maxStepIndex, tabControl1.SelectedIndex));
            UpdateButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
            tabControl1.SelectedIndex = Math.Max(0, Math.Min(maxStepIndex, tabControl1.SelectedIndex));
            UpdateButton();
        }
    }
}

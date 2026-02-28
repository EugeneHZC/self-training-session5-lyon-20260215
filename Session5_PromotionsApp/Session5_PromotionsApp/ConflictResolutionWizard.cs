using Session5_PromotionsApp.models;

namespace Session5_PromotionsApp
{
    public partial class ConflictResolutionWizard : Form1
    {
        private Dictionary<Promotion, string> allConflictedPromotions;
        private Promotion currentPromotion;
        private Promotion selectedConflictPromo;
        private string conflictedProducts;
        private const int maxStepIndex = 4;
        private int priorityChanged;

        public ConflictResolutionWizard(Promotion currentPromotion, Dictionary<Promotion, string> allConflictedPromotions)
        {
            InitializeComponent();
            this.currentPromotion = currentPromotion;
            this.allConflictedPromotions = allConflictedPromotions;
            tabControl1.SelectedIndex = 0;
            UpdatePage();
            button3.Enabled = false;
        }

        private void LoadStep1()
        {
            promotionBindingSource.DataSource = currentPromotion;
            textBox2.Text = $"{currentPromotion.DiscountType} {currentPromotion.DiscountValue}{(currentPromotion.DiscountType == "Percentage" ? "%" : " euros")}";
            textBox4.Text = $"{currentPromotion.StartDate} - {currentPromotion.EndDate}";

            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;

            for (int i = 0; i < allConflictedPromotions.Count(); i++)
            {
                var promo = allConflictedPromotions.ToList()[i];
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

        private void LoadStep2()
        {
            promotionBindingSource1.DataSource = selectedConflictPromo;
            textBox7.Text = conflictedProducts;
            textBox8.Text = $"{selectedConflictPromo.StartDate} - {selectedConflictPromo.EndDate}";
            textBox11.Text = $"{currentPromotion.StartDate} - {currentPromotion.EndDate}";
        }

        private void UpdateButton()
        {
            button2.Enabled = tabControl1.SelectedIndex != maxStepIndex;
            button3.Enabled = tabControl1.SelectedIndex != 0;
        }

        private void UpdatePage()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    LoadStep1();
                    break;
                case 1:
                    LoadStep2();
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRadioButton = flowLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

            if (selectedRadioButton != null)
            {
                var selected = (KeyValuePair<Promotion, string>)selectedRadioButton.Tag;
                selectedConflictPromo = selected.Key;
                conflictedProducts = selected.Value;

                tabControl1.SelectedIndex++;
                tabControl1.SelectedIndex = Math.Max(0, Math.Min(maxStepIndex, tabControl1.SelectedIndex));
                UpdateButton();
            }

            UpdatePage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
            tabControl1.SelectedIndex = Math.Max(0, Math.Min(maxStepIndex, tabControl1.SelectedIndex));
            UpdateButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            priorityChanged = (int)numericUpDown1.Value;
        }
    }
}

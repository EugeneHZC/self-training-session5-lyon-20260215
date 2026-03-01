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
        private int? priorityChanged = 0;
        private DateOnly? startDate;
        private DateOnly? endDate;
        private bool dateValid = false;
        private bool itemsValid = false;
        private List<string> productsToRemove;
        private int pixelsPerDay = 10;

        public ConflictResolutionWizard(Promotion currentPromotion, Dictionary<Promotion, string> allConflictedPromotions)
        {
            InitializeComponent();
            this.currentPromotion = currentPromotion;
            this.allConflictedPromotions = allConflictedPromotions;
            tabControl1.SelectedIndex = 0;
            UpdatePage();
            button3.Enabled = false;
            label24.Visible = false;
            label24.ForeColor = ColorTranslator.FromHtml("#7a8c69");
        }

        private void ResetAll()
        {
            flowLayoutPanel1.Controls.Clear();
            UpdatePage();
            button3.Enabled = false;
            label24.Visible = false;
            checkedListBox1.Items.Clear();
            dateValid = false;
            startDate = null;
            endDate = null;
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

            var latestEndDate = Math.Max(currentPromotion.EndDate.DayNumber, selectedConflictPromo.EndDate.DayNumber);
            var earliestStartDate = Math.Min(currentPromotion.StartDate.DayNumber, selectedConflictPromo.StartDate.DayNumber);

            var currPromotionDateDiff = currentPromotion.EndDate.DayNumber - currentPromotion.StartDate.DayNumber;
            var conflictedPromotionDateDiff = selectedConflictPromo.EndDate.DayNumber - selectedConflictPromo.StartDate.DayNumber;

            var conflictPromoXPos = (selectedConflictPromo.StartDate.DayNumber - earliestStartDate) * pixelsPerDay;
            var currPromoXPos = (currentPromotion.StartDate.DayNumber - earliestStartDate) * pixelsPerDay;
            progressBar1.Location = new System.Drawing.Point(conflictPromoXPos, 20);
            progressBar2.Location = new System.Drawing.Point(currPromoXPos, 100);

            if (selectedConflictPromo.EndDate > currentPromotion.EndDate)
            {
                progressBar2.Width = (currPromotionDateDiff) * pixelsPerDay;
            }
            else
            {
                progressBar1.Width = (conflictedPromotionDateDiff) * pixelsPerDay;
            }

            progressBar1.BackColor = Color.LightGray;
            progressBar2.BackColor = Color.Gray;

            label38.Text = selectedConflictPromo.PromotionName;
            label37.Text = currentPromotion.PromotionName;

            label36.Text = currentPromotion.StartDate > selectedConflictPromo.StartDate ? $"{selectedConflictPromo.StartDate:yyyy-MM-dd}" : $"{currentPromotion.StartDate:yyyy-MM-dd}";
            label35.Text = currentPromotion.EndDate > selectedConflictPromo.EndDate ? $"{currentPromotion.EndDate:yyyy-MM-dd}" : $"{selectedConflictPromo.StartDate:yyyy-MM-dd}";
        }

        private void LoadStep4()
        {
            textBox13.Text = $"{currentPromotion.StartDate} - {currentPromotion.EndDate}";

            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(conflictedProducts.Split(","));

            button2.Enabled = false;
            button2.Text = "Save";

            GetNewDate();
        }

        private void UpdateButton()
        {
            button2.Enabled = tabControl1.SelectedIndex != maxStepIndex;
            button3.Enabled = tabControl1.SelectedIndex != 0;
        }

        private void UpdatePage()
        {
            button2.Text = "Next";

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    LoadStep1();
                    break;
                case 1:
                    LoadStep2();
                    break;
                case 3:
                    LoadStep4();
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
                UpdatePage();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
            tabControl1.SelectedIndex = Math.Max(0, Math.Min(maxStepIndex, tabControl1.SelectedIndex));
            UpdateButton();
            UpdatePage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetAll();
            tabControl1.SelectedIndex = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the new/modified promotion? No changes will be made to the database.", "Cancel Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Helper.db.ChangeTracker.Entries().ToList().ForEach(x => x.State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);

                MessageBox.Show("Changes cancelled. No modifications were made.", "Cancelled", MessageBoxButtons.OK);

                ResetAll();
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (priorityChanged != null && startDate != null && endDate != null)
            {
                currentPromotion.StartDate = startDate ?? currentPromotion.StartDate;
                currentPromotion.EndDate = endDate ?? currentPromotion.EndDate;
                currentPromotion.Priority = priorityChanged ?? 0;

                if (productsToRemove != null && productsToRemove.Count > 0)
                {
                    var currProducts = currentPromotion.ApplicableProducts.Split(",").ToList();
                    productsToRemove.ForEach(x => currProducts.Remove(x));
                    currentPromotion.ApplicableProducts = string.Join(",", currProducts);
                }

                Helper.db.Promotions.Entry(currentPromotion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            Helper.db.SaveChanges();

            MessageBox.Show("Changes saved successfully", "Success", MessageBoxButtons.OKCancel);

            ResetAll();
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            priorityChanged = (int)numericUpDown1.Value;
        }

        private void GetNewDate()
        {
            dateValid = false;
            label24.Visible = false;
            button2.Enabled = false;
            startDate = DateOnly.FromDateTime(dateTimePicker1.Value);
            endDate = DateOnly.FromDateTime(dateTimePicker2.Value);

            if (startDate > endDate)
            {
                endDate = startDate;
                dateTimePicker2.Value = dateTimePicker1.Value;
            }

            if (startDate <= currentPromotion.EndDate && currentPromotion.StartDate <= endDate && !itemsValid)
            {
                return;
            }

            label24.Visible = true;
            button2.Enabled = true;
            dateValid = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GetNewDate();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            GetNewDate();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label24.Visible = false;
            itemsValid = false;

            var oriProducts = currentPromotion.ApplicableProducts.Split(",");

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                var item = checkedListBox1.Items[i];

                if (!checkedListBox1.CheckedItems.Contains(item) && oriProducts.Contains(item.ToString()) && !dateValid)
                {
                    return;
                }
            }

            productsToRemove = checkedListBox1.CheckedItems.Cast<String>().ToList();
            label24.Visible = true;
            button2.Enabled = true;
            itemsValid = true;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}

using Session5_PromotionsApp.models;

namespace Session5_PromotionsApp
{
    public partial class PromotionManagementPage : Form1
    {
        private List<Promotion> promotions = new List<Promotion>();

        public PromotionManagementPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            promotions = Helper.db.Promotions.ToList();

            LoadTable();
        }

        private void LoadTable()
        {
            dataGridView1.DataSource = promotions;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}

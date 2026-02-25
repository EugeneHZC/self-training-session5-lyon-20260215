using System.Drawing.Text;

namespace Session5_PromotionsApp
{
    public partial class Form1 : Form
    {
        private PrivateFontCollection font = new PrivateFontCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;


            this.BackColor = ColorTranslator.FromHtml("#fffaf0");

            panel1.BackColor = ColorTranslator.FromHtml("#d4a017");

            font.AddFontFile("Montserrat-SemiBold.ttf");
            font.AddFontFile("OpenSans-Regular.ttf");

            LoadControl(this);

            button1.BackColor = ColorTranslator.FromHtml("#c75d4d");

            label1.Font = new Font(font.Families[0], 12);
            label1.Text = this.Text;
        }

        private void LoadControl(Control control)
        {
            foreach (Control c in control.Controls)
            {
                LoadControl(c);
            }

            //control.Font = new Font(font.Families[1], 8);

            if (control is Button button)
            {
                button.Font = new Font(font.Families[0], 9);
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = ColorTranslator.FromHtml("#a4c2d6");
            }
            else if (control is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = "dd/MM/yyyy";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

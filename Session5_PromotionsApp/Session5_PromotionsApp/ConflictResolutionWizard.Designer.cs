namespace Session5_PromotionsApp
{
    partial class ConflictResolutionWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label12 = new Label();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox5 = new TextBox();
            promotionBindingSource = new BindingSource(components);
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 98);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 626);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 593);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 349);
            label12.MaximumSize = new Size(700, 0);
            label12.Name = "label12";
            label12.Size = new Size(583, 20);
            label12.TabIndex = 59;
            label12.Text = "The following conflicts were detected. Please select a conflict to resolve and click Next.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(46, 312);
            label8.Name = "label8";
            label8.Size = new Size(182, 23);
            label8.TabIndex = 58;
            label8.Text = "Step 1: List of Conflicts";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(46, 389);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(710, 182);
            flowLayoutPanel1.TabIndex = 57;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", promotionBindingSource, "Priority", true));
            textBox5.Location = new Point(162, 252);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(360, 27);
            textBox5.TabIndex = 56;
            // 
            // promotionBindingSource
            // 
            promotionBindingSource.DataSource = typeof(models.Promotion);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 255);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 55;
            label7.Text = "Priority:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 205);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(360, 27);
            textBox4.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 208);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 53;
            label6.Text = "Date Range:";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", promotionBindingSource, "ApplicableProducts", true));
            textBox3.Location = new Point(162, 160);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(360, 27);
            textBox3.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 163);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 51;
            label5.Text = "Products:";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", promotionBindingSource, "DiscountType", true));
            textBox2.Location = new Point(162, 115);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(360, 27);
            textBox2.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 118);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 49;
            label4.Text = "Discount:";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", promotionBindingSource, "PromotionName", true));
            textBox1.Location = new Point(162, 72);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(360, 27);
            textBox1.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 75);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 47;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(39, 25);
            label2.Name = "label2";
            label2.Size = new Size(302, 28);
            label2.TabIndex = 46;
            label2.Text = "New/Edited Promotion Details";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 593);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 593);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 593);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(792, 593);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 727);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 52);
            panel2.TabIndex = 22;
            // 
            // button4
            // 
            button4.Location = new Point(527, 3);
            button4.Name = "button4";
            button4.Size = new Size(82, 29);
            button4.TabIndex = 22;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(627, 3);
            button3.Name = "button3";
            button3.Size = new Size(68, 29);
            button3.TabIndex = 21;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(711, 3);
            button2.Name = "button2";
            button2.Size = new Size(68, 29);
            button2.TabIndex = 20;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ConflictResolutionWizard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 779);
            Controls.Add(panel2);
            Controls.Add(tabControl1);
            Name = "ConflictResolutionWizard";
            Text = "ConflictResolutionWizard";
            Controls.SetChildIndex(tabControl1, 0);
            Controls.SetChildIndex(panel2, 0);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label12;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private BindingSource promotionBindingSource;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
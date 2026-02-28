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
            textBox7 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            promotionBindingSource1 = new BindingSource(components);
            label9 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox9 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox10 = new TextBox();
            label16 = new Label();
            textBox11 = new TextBox();
            label17 = new Label();
            textBox12 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            tabPage3 = new TabPage();
            numericUpDown2 = new NumericUpDown();
            label20 = new Label();
            numericUpDown1 = new NumericUpDown();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            tabPage4 = new TabPage();
            label24 = new Label();
            checkedListBox1 = new CheckedListBox();
            label25 = new Label();
            label26 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label27 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label28 = new Label();
            textBox13 = new TextBox();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            tabPage5 = new TabPage();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage4.SuspendLayout();
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
            tabControl1.Size = new Size(875, 626);
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
            tabPage1.Size = new Size(867, 593);
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
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label19);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(867, 593);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(215, 477);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(360, 27);
            textBox7.TabIndex = 59;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(36, 480);
            label11.Name = "label11";
            label11.Size = new Size(148, 20);
            label11.TabIndex = 58;
            label11.Text = "Conflicting Product:";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", promotionBindingSource1, "Priority", true));
            textBox6.Location = new Point(215, 425);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(360, 27);
            textBox6.TabIndex = 57;
            // 
            // promotionBindingSource1
            // 
            promotionBindingSource1.DataSource = typeof(models.Promotion);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(36, 428);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 56;
            label9.Text = "Priority:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(215, 378);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(360, 27);
            textBox8.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(36, 381);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 54;
            label10.Text = "Date Range:";
            // 
            // textBox9
            // 
            textBox9.DataBindings.Add(new Binding("Text", promotionBindingSource1, "PromotionName", true));
            textBox9.Location = new Point(215, 332);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(360, 27);
            textBox9.TabIndex = 53;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(36, 335);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 52;
            label13.Text = "Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(36, 283);
            label14.Name = "label14";
            label14.Size = new Size(193, 28);
            label14.TabIndex = 51;
            label14.Text = "Existing Promotion";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(29, 24);
            label15.Name = "label15";
            label15.Size = new Size(221, 23);
            label15.TabIndex = 50;
            label15.Text = "Step 2: Conflict Notification";
            // 
            // textBox10
            // 
            textBox10.DataBindings.Add(new Binding("Text", promotionBindingSource, "Priority", true));
            textBox10.Location = new Point(215, 211);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(360, 27);
            textBox10.TabIndex = 49;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(36, 214);
            label16.Name = "label16";
            label16.Size = new Size(65, 20);
            label16.TabIndex = 48;
            label16.Text = "Priority:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(215, 164);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(360, 27);
            textBox11.TabIndex = 47;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(36, 167);
            label17.Name = "label17";
            label17.Size = new Size(94, 20);
            label17.TabIndex = 46;
            label17.Text = "Date Range:";
            // 
            // textBox12
            // 
            textBox12.DataBindings.Add(new Binding("Text", promotionBindingSource, "PromotionName", true));
            textBox12.Location = new Point(215, 118);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(360, 27);
            textBox12.TabIndex = 45;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(36, 121);
            label18.Name = "label18";
            label18.Size = new Size(55, 20);
            label18.TabIndex = 44;
            label18.Text = "Name:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label19.Location = new Point(29, 71);
            label19.Name = "label19";
            label19.Size = new Size(302, 28);
            label19.TabIndex = 43;
            label19.Text = "New/Edited Promotion Details";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(numericUpDown2);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(numericUpDown1);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(label23);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(867, 593);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DataBindings.Add(new Binding("Value", promotionBindingSource, "Priority", true));
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(202, 67);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(221, 27);
            numericUpDown2.TabIndex = 57;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(34, 115);
            label20.MaximumSize = new Size(700, 0);
            label20.Name = "label20";
            label20.Size = new Size(686, 40);
            label20.TabIndex = 56;
            label20.Text = "Changing priority may affect how promotions are applied and stacked. Higher nmbers indicate higher priority.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(202, 176);
            numericUpDown1.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(221, 27);
            numericUpDown1.TabIndex = 55;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(34, 178);
            label21.Name = "label21";
            label21.Size = new Size(93, 20);
            label21.TabIndex = 54;
            label21.Text = "New Priority:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(34, 69);
            label22.Name = "label22";
            label22.Size = new Size(111, 20);
            label22.TabIndex = 53;
            label22.Text = "Current Priority:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(30, 28);
            label23.Name = "label23";
            label23.Size = new Size(186, 23);
            label23.TabIndex = 52;
            label23.Text = "Step 3: Priority Change";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(checkedListBox1);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(dateTimePicker2);
            tabPage4.Controls.Add(label27);
            tabPage4.Controls.Add(dateTimePicker1);
            tabPage4.Controls.Add(label28);
            tabPage4.Controls.Add(textBox13);
            tabPage4.Controls.Add(label29);
            tabPage4.Controls.Add(label30);
            tabPage4.Controls.Add(label31);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(867, 593);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(23, 441);
            label24.Name = "label24";
            label24.Size = new Size(375, 20);
            label24.TabIndex = 69;
            label24.Text = "Conflict resolved! You can proceed to save the changes.";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(23, 310);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(450, 114);
            checkedListBox1.TabIndex = 68;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(23, 270);
            label25.Name = "label25";
            label25.Size = new Size(322, 20);
            label25.TabIndex = 67;
            label25.Text = "Select products to remove from the promotion:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(23, 224);
            label26.Name = "label26";
            label26.Size = new Size(174, 28);
            label26.TabIndex = 66;
            label26.Text = "Product Removal";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(566, 160);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 65;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(432, 165);
            label27.Name = "label27";
            label27.Size = new Size(107, 20);
            label27.TabIndex = 64;
            label27.Text = "New End Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(157, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 63;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(23, 165);
            label28.Name = "label28";
            label28.Size = new Size(113, 20);
            label28.TabIndex = 62;
            label28.Text = "New Start Date:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(189, 111);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(269, 27);
            textBox13.TabIndex = 61;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(23, 114);
            label29.Name = "label29";
            label29.Size = new Size(142, 20);
            label29.TabIndex = 60;
            label29.Text = "Current Date Range:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(23, 69);
            label30.Name = "label30";
            label30.Size = new Size(173, 28);
            label30.TabIndex = 59;
            label30.Text = "Date Adjustment";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(23, 21);
            label31.Name = "label31";
            label31.Size = new Size(264, 23);
            label31.TabIndex = 58;
            label31.Text = "Step 4: Date/Product Adjustment";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(867, 593);
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
            panel2.Size = new Size(875, 52);
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
            button4.Click += button4_Click;
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
            ClientSize = new Size(875, 779);
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
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
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox9;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox10;
        private Label label16;
        private TextBox textBox11;
        private Label label17;
        private TextBox textBox12;
        private Label label18;
        private Label label19;
        private BindingSource promotionBindingSource1;
        private NumericUpDown numericUpDown2;
        private Label label20;
        private NumericUpDown numericUpDown1;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private CheckedListBox checkedListBox1;
        private Label label25;
        private Label label26;
        private DateTimePicker dateTimePicker2;
        private Label label27;
        private DateTimePicker dateTimePicker1;
        private Label label28;
        private TextBox textBox13;
        private Label label29;
        private Label label30;
        private Label label31;
    }
}
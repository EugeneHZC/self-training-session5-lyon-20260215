namespace Session5_LoyaltyApp
{
    partial class RedeemRewardsPage
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(819, 145);
            button5.Name = "button5";
            button5.Size = new Size(75, 29);
            button5.TabIndex = 10;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(539, 145);
            button4.Name = "button4";
            button4.Size = new Size(263, 29);
            button4.TabIndex = 9;
            button4.Text = "Upgrade to next membership tier";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(299, 145);
            button3.Name = "button3";
            button3.Size = new Size(234, 29);
            button3.TabIndex = 8;
            button3.Text = "10% discount on next purchase";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 145);
            button2.Name = "button2";
            button2.Size = new Size(270, 29);
            button2.TabIndex = 7;
            button2.Text = "5 euros discount on next purchase";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 100);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 6;
            label2.Text = "Choose a reward option:";
            // 
            // RedeemRewardsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Name = "RedeemRewardsPage";
            Text = "RedeemRewardsPage";
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(button5, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
    }
}
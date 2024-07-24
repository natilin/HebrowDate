namespace HebrowDate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox_days = new ComboBox();
            comboBox_month_days = new ComboBox();
            comboBox_month = new ComboBox();
            comboBox_year = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 32);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(670, 131);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = " היום בשבוע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 131);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "היום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 131);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 3;
            label4.Text = "חודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 131);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 4;
            label5.Text = "שנה";
            // 
            // comboBox_days
            // 
            comboBox_days.FormattingEnabled = true;
            comboBox_days.Location = new Point(670, 189);
            comboBox_days.Name = "comboBox_days";
            comboBox_days.Size = new Size(118, 33);
            comboBox_days.TabIndex = 5;
            // 
            // comboBox_month_days
            // 
            comboBox_month_days.FormattingEnabled = true;
            comboBox_month_days.Location = new Point(460, 189);
            comboBox_month_days.Name = "comboBox_month_days";
            comboBox_month_days.Size = new Size(118, 33);
            comboBox_month_days.TabIndex = 6;
            // 
            // comboBox_month
            // 
            comboBox_month.FormattingEnabled = true;
            comboBox_month.Location = new Point(249, 189);
            comboBox_month.Name = "comboBox_month";
            comboBox_month.Size = new Size(118, 33);
            comboBox_month.TabIndex = 7;
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Location = new Point(83, 189);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.Size = new Size(118, 33);
            comboBox_year.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(335, 327);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "שלח";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox_year);
            Controls.Add(comboBox_month);
            Controls.Add(comboBox_month_days);
            Controls.Add(comboBox_days);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox_days;
        private ComboBox comboBox_month_days;
        private ComboBox comboBox_month;
        private ComboBox comboBox_year;
        private Button button1;
    }
}

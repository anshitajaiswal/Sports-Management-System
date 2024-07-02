namespace sportsmanagementsystem
{
    partial class addgame
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 66);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Game ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 141);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "Game Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 66);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 2;
            label3.Text = "Start Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 121);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 3;
            label4.Text = "End Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 191);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 4;
            label5.Text = "Location:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 255);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 5;
            label6.Text = "Home Team ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(475, 316);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 6;
            label7.Text = "Away Team ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 29);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(606, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 29);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(606, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 29);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(606, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 29);
            textBox4.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(162, 148);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(771, 420);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 12;
            button1.Text = "Add the game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(34, 21);
            label8.Name = "label8";
            label8.Size = new Size(345, 28);
            label8.TabIndex = 15;
            label8.Text = "enter the game details to be added";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(606, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 29);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(606, 313);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 29);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(606, 373);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 29);
            textBox7.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(475, 376);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 18;
            label9.Text = "Team ID:";
            // 
            // addgame
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 494);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addgame";
            Text = "addgame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
    }
}
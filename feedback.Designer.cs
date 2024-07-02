namespace sportsmanagementsystem
{
    partial class feedback
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
            label3 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 6;
            label3.Text = "Give Feedback";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 34);
            textBox2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(119, 269);
            button4.Name = "button4";
            button4.Size = new Size(167, 39);
            button4.TabIndex = 14;
            button4.Text = "submit review";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(161, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 34);
            textBox5.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(47, 122);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 16;
            label6.Text = "user name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(47, 200);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 17;
            label7.Text = "feedback";
            // 
            // feedback
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 340);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "feedback";
            Text = "feedback";
            Load += feedback_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox2;
        private Button button4;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
    }
}
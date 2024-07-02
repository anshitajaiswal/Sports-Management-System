namespace sportsmanagementsystem
{
    partial class Financials2
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
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 29);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 187);
            label3.Name = "label3";
            label3.Size = new Size(197, 21);
            label3.TabIndex = 8;
            label3.Text = "Average Salary of Coaches:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 134);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 7;
            label2.Text = "Salary:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Futura-Bold", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(31, 20);
            label1.Name = "label1";
            label1.Size = new Size(301, 62);
            label1.TabIndex = 6;
            label1.Text = "FINANCIAL";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 29);
            textBox2.TabIndex = 11;
            // 
            // Financials2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 310);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Financials2";
            Text = "Financials2";
            Load += Financials2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
    }
}
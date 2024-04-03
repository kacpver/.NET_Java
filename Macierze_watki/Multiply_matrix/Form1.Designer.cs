namespace Multiply_matrix
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox8 = new TextBox();
            label4 = new Label();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(63, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(63, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(348, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63, 27);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 60);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "1st matrix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 60);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "2nd matrix";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(46, 156);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(344, 415);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(421, 156);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(344, 415);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(795, 156);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(344, 415);
            textBox7.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(822, 82);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Multiply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 60);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 11;
            label3.Text = "Thread";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(505, 84);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(86, 27);
            textBox8.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 59);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 13;
            label4.Text = "Seed";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(664, 82);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(91, 27);
            textBox9.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 651);
            Controls.Add(textBox9);
            Controls.Add(label4);
            Controls.Add(textBox8);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Multiply matrix";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label label3;
        private TextBox textBox8;
        private Label label4;
        private TextBox textBox9;
    }
}

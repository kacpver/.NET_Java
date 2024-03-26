using System.Windows.Forms;

namespace APIOkienkowa
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
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(150, 377);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Vineta BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(494, 52);
            label1.TabIndex = 1;
            label1.Text = "Currency converter";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CHF", "EUR", "CZK", "PLN", "GBP" });
            comboBox1.Location = new Point(59, 333);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(76, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "CHF", "EUR", "CZK", "PLN", "GBP" });
            comboBox2.Location = new Point(254, 333);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(76, 28);
            comboBox2.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(32, 59);
            monthCalendar1.MaxDate = new DateTime(2024, 3, 5, 0, 0, 0, 0);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(2013, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 300);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 300);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(403, 59);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 202);
            textBox3.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(612, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
    }
}

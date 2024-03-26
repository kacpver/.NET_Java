namespace Currencies_API
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(276, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 207);
            textBox1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(88, 70);
            monthCalendar1.MaxDate = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(2013, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 350);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 27);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(352, 349);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "USD", "CHF", "EUR", "CZK", "PLN", "GBP" });
            comboBox1.Location = new Point(202, 348);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(90, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "--select--";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "USD", "CHF", "EUR", "CZK", "PLN", "GBP" });
            comboBox2.Location = new Point(483, 349);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(90, 28);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "--select--USD";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Vineta BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(494, 52);
            label1.TabIndex = 1;
            label1.Text = "Currency converter";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(676, 70);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Clear DB";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Button button2;
    }
}

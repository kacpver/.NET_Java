namespace Aplikacja
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
            NumberItems = new TextBox();
            Seed = new TextBox();
            Capacity = new TextBox();
            ListItems = new TextBox();
            Result = new TextBox();
            Button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // NumberItems
            // 
            NumberItems.Location = new Point(21, 37);
            NumberItems.Name = "NumberItems";
            NumberItems.ScrollBars = ScrollBars.Vertical;
            NumberItems.Size = new Size(125, 27);
            NumberItems.TabIndex = 0;
            NumberItems.KeyPress += NumberItems_KeyPress;
            // 
            // Seed
            // 
            Seed.Location = new Point(21, 90);
            Seed.Name = "Seed";
            Seed.Size = new Size(125, 27);
            Seed.TabIndex = 1;
            Seed.KeyPress += Seed_KeyPress;
            // 
            // Capacity
            // 
            Capacity.Location = new Point(21, 143);
            Capacity.Name = "Capacity";
            Capacity.Size = new Size(125, 27);
            Capacity.TabIndex = 2;
            Capacity.KeyPress += Capacity_KeyPress;
            // 
            // ListItems
            // 
            ListItems.Location = new Point(226, 37);
            ListItems.Multiline = true;
            ListItems.Name = "ListItems";
            ListItems.ReadOnly = true;
            ListItems.ScrollBars = ScrollBars.Vertical;
            ListItems.Size = new Size(191, 401);
            ListItems.TabIndex = 3;
            // 
            // Result
            // 
            Result.Location = new Point(21, 238);
            Result.Multiline = true;
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.ScrollBars = ScrollBars.Vertical;
            Result.Size = new Size(199, 200);
            Result.TabIndex = 4;
            // 
            // Button
            // 
            Button.Location = new Point(21, 183);
            Button.Name = "Button";
            Button.Size = new Size(125, 29);
            Button.TabIndex = 5;
            Button.Text = "Solve";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 6;
            label1.Text = "Number of items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 7;
            label2.Text = "Seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 8;
            label3.Text = "Capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 14);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 9;
            label4.Text = "List of items";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 215);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Result";
            // 
            // Form1
            // 
            AcceptButton = Button;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(439, 460);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Button);
            Controls.Add(Result);
            Controls.Add(ListItems);
            Controls.Add(Capacity);
            Controls.Add(Seed);
            Controls.Add(NumberItems);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Problem plecakowy";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumberItems;
        private TextBox Seed;
        private TextBox Capacity;
        private TextBox ListItems;
        private TextBox Result;
        private Button Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

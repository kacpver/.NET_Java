namespace Multiply_matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            int row1 = int.Parse(textBox1.Text);
            int col1 = int.Parse(textBox2.Text);
            int row2 = int.Parse(textBox3.Text);
            int col2 = int.Parse(textBox4.Text);
            int seed = int.Parse(textBox8.Text);
            int n = int.Parse(textBox9.Text);
            decimal DItemOnThread = ((decimal)row1 * col2) / n;
            int IItemOnThread = Decimal.ToInt32(Math.Ceiling(DItemOnThread));
            if (col1 == row2)
            {
                Matrix one = new Matrix(row1, col1, true, seed);
                Matrix two = new Matrix(row2, col2, true, seed);
                Matrix result = new Matrix(row1, col2, false, 0);
                //Thread[] threads = new Thread[n];


                for (int i = 0; i < one.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < one.matrix.GetLength(1); j++)
                    {
                        textBox5.AppendText(one.matrix[i, j].ToString() + " ");
                    }
                    textBox5.AppendText(Environment.NewLine);
                }

                for (int i = 0; i < two.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < two.matrix.GetLength(1); j++)
                    {
                        textBox6.AppendText(two.matrix[i, j].ToString() + " ");
                    }
                    textBox6.AppendText(Environment.NewLine);
                }
                int CounterCell = 0;
                int NumberOfThread = 0;
                for (int i = 0; i < one.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < two.matrix.GetLength(1); j++)
                    {

                        //if (CounterCell == IItemOnThread)
                        //{
                        //    CounterCell = 0;
                        //    threads[NumberOfThread].Start();
                        //    NumberOfThread++;
                        //}
                        //threads[NumberOfThread] = new Thread(() =>
                        result.multiplication(one, two, i, j);
                        //CounterCell++;
                    }         
                }

                //foreach (var x in threads)
                //    x.Start();

                //foreach (Thread x in threads)
                //    x.Join();

                for (int i = 0; i < result.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < result.matrix.GetLength(1); j++)
                    {
                        textBox7.AppendText(result.matrix[i, j].ToString() + " ");
                    }
                    textBox7.AppendText(Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Wrong matrix dimension");
            }
        }
    }
}

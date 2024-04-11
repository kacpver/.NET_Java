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
            int seed1 = int.Parse(textBox8.Text);
            int seed2 = int.Parse(textBox10.Text);
            int n = int.Parse(textBox9.Text);
            int IItemOnThread = Decimal.ToInt32(Math.Ceiling(((decimal)row1 * col2) / n));
            if (col1 == row2)
            {
                Matrix one = new Matrix(row1, col1, true, seed1);
                Matrix two = new Matrix(row2, col2, true, seed2);
                Matrix result = new Matrix(row1, col2, false, 0);
                Thread[] threads = new Thread[n];

                //one.printMatrix(textBox5);
                //two.printMatrix(textBox6);

                for (int k = 0; k < n; k++)
                {
                    int rStart = (k * IItemOnThread) / col2;
                    int cStart = (k * IItemOnThread) % col2;

                    threads[k] = new Thread(() =>
                    {
                        bool limit = false;
                        int CounterCell = 0;
                        for (int r = rStart; r < row1; r++)
                        {
                            for (int c = cStart; c < col2; c++)
                            {
                                if (CounterCell == IItemOnThread)
                                {
                                    CounterCell = 0;
                                    limit = true;
                                    break;
                                }

                                result.multiplication(one, two, r, c);
                                CounterCell++;
                            }
                            cStart = 0;
                            if (limit) break;
                        }
                    }
                  );
                }
                var watch = System.Diagnostics.Stopwatch.StartNew();
                foreach (Thread t in threads) { t.Start(); }
                foreach (Thread t in threads) { t.Join(); }
                watch.Stop();
                textBox11.Text = ((watch.Elapsed.TotalMicroseconds)/1000).ToString();
                //Parallel.For
                var watchParallel = System.Diagnostics.Stopwatch.StartNew();

                Parallel.For(0, n, k =>
                {
                    int rStart = (k * IItemOnThread) / col2;
                    int cStart = (k * IItemOnThread) % col2;
                    bool limit = false;
                    int CounterCell = 0;

                    for (int r = rStart; r < row1; r++)
                    {
                        for (int c = cStart; c < col2; c++)
                        {
                            if (CounterCell == IItemOnThread)
                            {
                                CounterCell = 0;
                                limit = true;
                                break;
                            }

                            result.multiplication(one, two, r, c);
                            CounterCell++;
                        }
                        cStart = 0;
                        if (limit) break;
                    }
                });

                watchParallel.Stop();
                textBox12.Text = ((watchParallel.Elapsed.TotalMicroseconds)/1000).ToString();

                
            
            //7 godzin póŸniej... Dzia³aaaaaaaaaaaaaa!!!!!!

            //result.printMatrix(textBox7);

        }
            else
            {
                MessageBox.Show("Wrong matrix dimension");
            }
        }
    }
}
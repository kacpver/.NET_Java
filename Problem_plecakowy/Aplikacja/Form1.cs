using Problem_plecakowy;

namespace Aplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, EventArgs e)
        {
            ListItems.Clear();
            int n = int.Parse(NumberItems.Text);
            int seed = int.Parse(Seed.Text);
            Problem problem = new Problem(n, seed);
            //(ListItems.Text) = problem.ToString();
            ListItems.AppendText(problem.ToString());
            ListItems.AppendText(Environment.NewLine);
            problem.Sorting();
            int capacity = int.Parse(Capacity.Text);
            Result result = problem.Solve(capacity);
            Result.Text = result.ToString();


        }

        private void NumberItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void Seed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void Capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button.PerformClick();
            }
        }
    }
}

using System;
using System.DirectoryServices;
using System.Windows.Forms;

namespace Num_Ana_Machine_Problem_4
{
    public partial class Form1 : Form
    {

        static double a, b;
        int n;


        public Form1()
        {
            InitializeComponent();
        }

        private void predefinedButton_Click(object sender, EventArgs e)
        {
            a = double.Parse(a_textBox.Text);
            b = double.Parse(b_textBox.Text);
            n = int.Parse(n_textBox.Text);
            double h = (b - a) / n;

            double result = PreDefined_TrapezoidalRule(a, b, n, h);
            predefined_result.Text = result.ToString();
            deltaPredefined.Text = h.ToString();
        }

        static double Function(double x)
        {
            return Math.Pow(x, 2) * Math.Exp(Math.Sin(x));
        }

        static double PreDefined_TrapezoidalRule(double a, double b, int n, double h)
        {
            double sum = 0.5 * (Function(a) + Function(b));

            for(int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += Function(x);
            }

            return sum * h;
        }
    }
}

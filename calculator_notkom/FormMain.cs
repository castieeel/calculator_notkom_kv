using calculator_notkom.Core;
using calculator_notkom.Core.Interfaces;
using System;
using System.Windows.Forms;

namespace calculator_notkom
{
    public partial class FormMain : Form
    {
        #region Fields
        private ICalculator _calculator;
        private IEngeneerCalculator _engeneerCalculator;
        double a, b, c;
        string action;
        #endregion

        public FormMain()
        {
            InitializeComponent();            
            _calculator = new EngeneerCalculator(new Calculator());
            _engeneerCalculator = new EngeneerCalculator(new Calculator());
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            ActiveControl = tb_calc;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_calc.Text += (sender as Button).Text;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tb_calc.Text);
            action = (sender as Button).Text;
            tb_calc.Clear();
        }

        private void btn_pl_mn_Click(object sender, EventArgs e)
        {
            if (tb_calc.Text != "")
                if (tb_calc.Text[0] == '-')
                    tb_calc.Text = tb_calc.Text.Remove(0, 1);
                else tb_calc.Text = '-' + tb_calc.Text;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            if (tb_calc.Text != "")
                tb_calc.Text = tb_calc.Text.Remove(tb_calc.Text.Length - 1, 1);

        }


        private void btn_eq_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_calc.Text != "")
                {
                    b = Convert.ToDouble(tb_calc.Text);
                }

                switch (action)
                {
                    case "+":
                        c = _calculator.Sum(a, b);
                        break;
                    case "-":
                        c = _calculator.Sub(a, b);
                        break;
                    case "X":
                        c = _calculator.Sub(a, b);
                        break;
                    case "/":                       
                        c = _calculator.Dev(a, 0);
                        break;
                    case "√":
                        c = _engeneerCalculator.SqrtX(a, b);
                        break;
                    case "x^2":
                        c = _engeneerCalculator.DegreeY(a, b);
                        break;
                    case "x√":
                        c = _engeneerCalculator.Sqrt(a);
                        break;
                    case "x^y":
                        c = _engeneerCalculator.Square(a);
                        break;
                    case "n!":
                        c = _engeneerCalculator.Factorial(a);
                        break;
                }
                tb_calc.Text = c.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            tb_calc.Clear();
        }
    }
}

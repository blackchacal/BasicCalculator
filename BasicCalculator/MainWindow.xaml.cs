using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool isNegative = false;
        double result = 0;
        char lastOperation = '\0';
        bool clearText = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private double operate(double val, char operation)
        {
            switch (lastOperation)
            {
                case '+':
                    result += val;
                    break;

                case '-':
                    result -= val;
                    break;

                case '*':
                    result *= val;
                    break;

                case '/':
                    result /= val;
                    break;

                default:
                    result = val;
                    break;
            }
            lastOperation = operation;
            return result;
        }

        private void insertNumberOrSymbol(string symbol)
        {
            if (clearText)
            {
                ResultText.Text = "";
                clearText = false;
            }
            ResultText.Text += symbol;
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            double val = Convert.ToDouble(ResultText.Text);
            ResultText.Text = "";
            ResultText.Text = operate(val, '+').ToString();
            clearText = true;
            OperationsText.Text = result.ToString() + " " + lastOperation.ToString();
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            double val = Convert.ToDouble(ResultText.Text);
            ResultText.Text = "";
            ResultText.Text = operate(val, '-').ToString();
            clearText = true;
            OperationsText.Text = result.ToString() + " " + lastOperation.ToString();
        }

        private void btn_prod_Click(object sender, RoutedEventArgs e)
        {
            double val = Convert.ToDouble(ResultText.Text);
            ResultText.Text = "";
            ResultText.Text = operate(val, '*').ToString();
            clearText = true;
            OperationsText.Text = result.ToString() + " " + lastOperation.ToString();
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            double val = Convert.ToDouble(ResultText.Text);
            ResultText.Text = "";
            ResultText.Text = operate(val, '/').ToString();
            clearText = true;
            OperationsText.Text = result.ToString() + " " + lastOperation.ToString();
        }

        private void btn_res_Click(object sender, RoutedEventArgs e)
        {
            double val = Convert.ToDouble(ResultText.Text);
            double res = operate(val, '=');
            ResultText.Text = res.ToString();
            OperationsText.Text += " " + val.ToString() + " " + lastOperation.ToString() + " " + res.ToString();
            result = 0;
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("1");
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("2");
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("3");
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("4");
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("5");
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("6");
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("7");
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("8");
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("9");
        }

        private void btn_pm_Click(object sender, RoutedEventArgs e)
        {
            if (isNegative)
            {
                string t = ResultText.Text.Substring(1);
                ResultText.Text = t;
                //insertNumberOrSymbol(t);
            }
            else
            {
                string t = ResultText.Text;
                ResultText.Text = "-" + t;
                //insertNumberOrSymbol("-" + t);
            }
            isNegative = !isNegative;
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol("0");

        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            insertNumberOrSymbol(".");
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "0";
            OperationsText.Text = "";
            isNegative = false;
            clearText = true;
        }
    }
}
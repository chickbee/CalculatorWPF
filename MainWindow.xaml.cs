using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string count = "0";
        static double prevNum;
        static double total;

        static bool start = true;
        static char mathOperation;
        static bool isUnique = true;
        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "1";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "1";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 1 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "2";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "2";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 2 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "3";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "3";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 3 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "4";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "4";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 4 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "5";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "5";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 5 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "6";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "6";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 6 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "7";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "7";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 7 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "8";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "8";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 8 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "9";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "9";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 9 has been pressed");
            Trace.WriteLine(count);
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                count = "0";
            }
            else
            {

                if (count.Length < 9)
                {
                    count = count + "0";
                }
            }

            start = false;

            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button 0 has been pressed");
            Trace.WriteLine(count);
        }
        private void ButtonPos_Neg_Click(object sender, RoutedEventArgs e)
        {
            count = (Convert.ToDouble(count) * (-1)).ToString();
            Display.Text = count.ToString();

            // debug
            Trace.WriteLine("Button +/- has been pressed");
            Trace.WriteLine(count);
        }
        private void ButtonDec_Click(object sender, RoutedEventArgs e)
        {
            count = count + ".";
            Display.Text = count;

            // debug
            Trace.WriteLine("Button . has been pressed");
            Trace.WriteLine(count);
        }
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (!start && isUnique)
            {
                switch (mathOperation)
                {
                    case '+':
                        total = Convert.ToDouble(prevNum) + Convert.ToDouble(count);
                        Display.Text = total.ToString();
                        isUnique = false;
                        break;
                    case '-':
                        total = Convert.ToDouble(prevNum) - Convert.ToDouble(count);
                        Display.Text = total.ToString();
                        isUnique = false;
                        break;
                    case '*':
                        total = Convert.ToDouble(prevNum) * Convert.ToDouble(count);
                        Display.Text = total.ToString();
                        isUnique = false;
                        break;
                    case '/':
                        total = Convert.ToDouble(prevNum) / Convert.ToDouble(count);
                        Display.Text = total.ToString();
                        isUnique = false;
                        break;
                }
            }
            else if (!isUnique)
            {
                switch (mathOperation)
                {
                    case '+':
                        total = total + Convert.ToDouble(count);
                        Display.Text = total.ToString();
                        isUnique = false;
                        break;
                    case '-':
                        total = total - Convert.ToDouble(count);
                        Display.Text = total.ToString();
                        isUnique = false;
                        break;
                    case '*':
                        total = total * Convert.ToDouble(count);
                        Display.Text = total.ToString();
                        isUnique = false;
                        break;
                    case '/':
                        total = total / Convert.ToDouble(count);
                        Display.Text = total.ToString();
                        isUnique = false;
                        break;
                }
            }

            // debug
            Trace.WriteLine("Button = has been pressed");
            Trace.WriteLine(total);
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            prevNum = Convert.ToDouble(count);
            start = true;
            mathOperation = '+';

            // debug
            Trace.WriteLine("Button + has been pressed");
            Trace.WriteLine(prevNum);
        }
        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            prevNum = Convert.ToDouble(count);
            start = true;
            mathOperation = '-';

            // debug
            Trace.WriteLine("Button - has been pressed");
            Trace.WriteLine(prevNum);
        }
        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {
            prevNum = Convert.ToDouble(count);
            start = true;
            mathOperation = '*';

            // debug
            Trace.WriteLine("Button - has been pressed");
            Trace.WriteLine(prevNum);
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            prevNum = Convert.ToDouble(count);
            start = true;
            mathOperation = '/';

            // debug
            Trace.WriteLine("Button - has been pressed");
            Trace.WriteLine(prevNum);
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            start = true;
            prevNum = 0;
            isUnique = true;
            count = "0";

            Display.Text = count;
            // debug
            Trace.WriteLine("Button Clear has been pressed");
            Trace.WriteLine("count: " + count);
            Trace.WriteLine("prevNum: " + prevNum.ToString());
            Trace.WriteLine("total: " + total.ToString());
        }
    }
}

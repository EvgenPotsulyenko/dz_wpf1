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
using System.Windows.Shapes;

namespace dz_wpf1
{
    /// <summary>
    /// Логика взаимодействия для kalkulator.xaml
    /// </summary>
    public partial class kalkulator : Window
    {
        double FirstValue;
        double SecondValue;
        string arithmetic;
        public kalkulator()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Example.Text += "1";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Example.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Example.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Example.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Example.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Example.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Example.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Example.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Example.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Example.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Example.Text += ".";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            FirstValue = double.Parse(Example.Text);
            Example.Text += "+";
            arithmetic = "+";

        }
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            FirstValue = double.Parse(Example.Text);
            Example.Text += "-";
            arithmetic = "-";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            FirstValue = double.Parse(Example.Text);
            Example.Text += "*";
            arithmetic = "*";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            FirstValue = double.Parse(Example.Text);
            Example.Text += "/";
            arithmetic = "/";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Example.Text = "";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            LastExaple.Text = "";
            Example.Text = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            LastExaple.Text = Example.Text;
            double outcome;
            char[] s = Example.Text.ToCharArray();
            int i = 0;
                while (s[i] != Convert.ToChar("+") && s[i] != Convert.ToChar("-") && s[i] != Convert.ToChar("*") && s[i] != Convert.ToChar("/"))
                {
                    s[i] = '0';
                    i++;
                }
                if (s[i] == Convert.ToChar("+") | s[i] == Convert.ToChar("-") | s[i] == Convert.ToChar("*") | s[i] == Convert.ToChar("/"))
                {
                    s[i] = '0';
                }
            SecondValue = double.Parse(s);

            if (arithmetic == "+")
            {
                outcome = (FirstValue + SecondValue);
                Example.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "-")
            {
                outcome = (FirstValue - SecondValue);
                Example.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "*")
            {
                outcome = (FirstValue * SecondValue);
                Example.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "/")
            {
                if (SecondValue == 0)
                {
                    Example.Text = "НЕ ДОПУСТИМАЯ ОПЕРАЦИЯ";
                }
                else
                {
                    outcome = FirstValue / SecondValue;
                    Example.Text = Convert.ToString(outcome);
                    FirstValue = outcome;
                }
            }          

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            string s = Example.Text;
            s = s.Substring(0,s.Length - 1);
            Example.Text = s;
        }
    }
}

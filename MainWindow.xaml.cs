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

namespace Calculator_wpf
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

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "7";
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "4";
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "1";
        }


        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "8";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "5";
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "2";
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "0";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "9";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "6";
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += "3";
        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            lbl_resultText.Content += ".";
        }

        private void divise_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            string? number = MathFunction();
            if (result == 0) result = float.Parse(number!);
            else result *= float.Parse(number!);
            lbl_resultText.Content += "/";
        }

        private void btn_vurma_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            string? number = MathFunction();
            if (result == 0) result = float.Parse(number!);
            else result *= float.Parse(number!);
            lbl_resultText.Content += "*";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            string? number = MathFunction();
            if (result == 0) result = float.Parse(number!);
            else result *= float.Parse(number!);
            lbl_resultText.Content += "-";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Visibility = Visibility.Visible;
            string? number = MathFunction();
            if (result == 0) result = float.Parse(number!);
            else result *= float.Parse(number!);
            lbl_resultText.Content += "+";
        }
        double result = 0;
        bool check = true;

        public string MathFunction()
        {
            string? resultText = lbl_resultText.Content.ToString();
            string? number = null;
            int index;
            if (check)
            {
                index = -1;

                for (int i = 0; i < resultText!.Length; i++)
                {
                    if (resultText[i] == '+' || resultText[i] == '-' || resultText[i] == '*' || resultText[i] == '/')
                    {
                        index = i;
                    }
                }
                if (index == -1)
                {
                    for (int i = 0; i < resultText.Length; i++)
                    {
                        number += resultText[i];
                    }
                }
                else
                {
                    for (int i = index + 1; i < resultText.Length; i++)
                    {

                        number += resultText[i];
                    }

                }

            }
            else
            {
                index = resultText!.LastIndexOf('+');
                for (int i = index + 1; i < resultText.Length; i++)
                {

                    number += resultText[i];
                }

            }
            return number!;
        }
        public int EqualFunc(ref int index)
        {
            string? resultText = lbl_resultText.Content.ToString();
            for (int i = 0; i < resultText.Length; i++)
            {
                if (resultText[i] == '+' || resultText[i] == '-' || resultText[i] == '*' || resultText[i] == '/')
                {
                    index = i;
                }
            }

            return index;
        }
        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            int index = -1; string? number = null;
            string? resultText = lbl_resultText.Content.ToString();
            if (check)
            {
                int LastSymbolIndex = EqualFunc(ref index);
                for (int i = LastSymbolIndex + 1; i < resultText.Length; i++)
                {

                    number += resultText[i];
                }

                if (resultText[LastSymbolIndex] == '+') result += float.Parse(number!);
                else if (resultText[LastSymbolIndex] == '-') result -= float.Parse(number!);
                else if (resultText[LastSymbolIndex] == '*') result *= float.Parse(number!);
                else if (resultText[LastSymbolIndex] == '/') result /= float.Parse(number!);

                check = false;
            }

            lbl_result.Content = result.ToString();

        }

        private void btn_percentage_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_result.Content != "0")
            {
                result /= 100;
                lbl_result.Content = result.ToString();
            }
        }

        private void btn_root_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_result.Content != "0")
            {
                result = Math.Sqrt(result);
                lbl_result.Content = result.ToString();
            }
        }

        private void btn_power_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_result.Content != "0")
            {
                result = Math.Pow(result, 2);
                lbl_result.Content = result.ToString();
            }
        }

        private void btn_1x_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_result.Content != "0")
            {
                result = 1 / result;
                lbl_result.Content = result.ToString();
            }
        }

        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
           lbl_result.Content = "0";
            result = 0;
            check = true;
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            string? resultText = lbl_resultText.Content.ToString();
            string copy=null;
            for (int i = 0; i <resultText!.Length-1 ; i++)
            {
                copy += resultText[i];
            }
            lbl_resultText.Content = copy;
        }
        private void btn_pos_neg_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_result.Content != "0")
            {
                result *= -1;
               lbl_result.Content = result.ToString();
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            lbl_resultText.Content = null;
            lbl_result.Content = "0";
            result = 0;
            lbl_resultText.Visibility = Visibility.Hidden;
            check = true;
        }

    }
}

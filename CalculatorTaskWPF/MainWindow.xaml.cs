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

namespace CalculatorTaskWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNumber;
        string operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberButtonClick(object sender, RoutedEventArgs e)
        {
            resultLabel.Content += (sender as Button).Content.ToString();
        }
        
        private void additionButtonClick(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(resultLabel.Content);
            operation = "+";
            resultLabel.Content = null;
        }
        
        private void subtractButtonClick(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(resultLabel.Content);
            operation = "-";
            resultLabel.Content = null;
        }
        
        private void multiplicationButtonClick(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(resultLabel.Content);
            operation = "*";
            resultLabel.Content = null;
        }
        
        private void divisionButtonClick(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(resultLabel.Content);
            operation = "/";
            resultLabel.Content = null;
        }

        private void equalButtonClick(object sender, RoutedEventArgs e)
        {
            double secondNumber;
            secondNumber = Convert.ToDouble(resultLabel.Content);
            double result;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                resultLabel.Content = Convert.ToString(result);
                firstNumber = result;
            }

            if (operation == "-")
            {
                result = firstNumber - secondNumber;
                resultLabel.Content = Convert.ToString(result);
                firstNumber = result;
            }

            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                resultLabel.Content = Convert.ToString(result);
                firstNumber = result;
            }

            if (operation == "/")
            {
                result = firstNumber / secondNumber;
                resultLabel.Content = Convert.ToString(result);
                firstNumber = result;
            }
        }

        private void removeButtonClick(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Length > 0)
            {
                resultLabel.Content = resultLabel.Content?.ToString().Remove(resultLabel.Content.ToString().Length - 1, 1);
            }
        }

        private void clearButtonClick(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = null;
        }
    }
}

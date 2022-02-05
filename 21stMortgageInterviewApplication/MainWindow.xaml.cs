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
using _21stMortgageInterviewApplication.Models;
using _21stMortgageInterviewApplication.Helper;

namespace _21stMortgageInterviewApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] numbersArray;
        public MainWindow()
        {
            InitializeComponent();
            UserInput userInput = new UserInput();
            this.DataContext = userInput;
        }

        private void btnFindLargestValue_Click(object sender, RoutedEventArgs e)
        {
            numbersArray = getuserinput();
            int largestNumber = IntArrayOperations.FindLargeNumber(numbersArray);
            bool isLargestNumberPositive = IntArrayOperations.IsPositive(largestNumber);
            txtResult.Text = largestNumber.ToString();
            ApplyStyles(isLargestNumberPositive);
        }

        private void btnFindSumofOddNumbers_Click(object sender, RoutedEventArgs e)
        {
            numbersArray = getuserinput();
            int sumofOddNumbers = IntArrayOperations.FindSumofOddNumbers(numbersArray);
            bool isSumofOddNumbersPositive = IntArrayOperations.IsPositive(sumofOddNumbers);
            txtResult.Text = sumofOddNumbers.ToString();
            ApplyStyles(isSumofOddNumbersPositive);
        }

        private void btnFindSumofEvenNumbers_Click(object sender, RoutedEventArgs e)
        {
            numbersArray = getuserinput();
            int sumofEvenNumbers = IntArrayOperations.FindSumofEvenNumbers(numbersArray);
            bool isSumofEvenNumbersPositive = IntArrayOperations.IsPositive(sumofEvenNumbers);
            txtResult.Text = sumofEvenNumbers.ToString();
            ApplyStyles(isSumofEvenNumbersPositive);
        }
        private void ApplyStyles(bool isLargestNumberPositive)
        {
            if (isLargestNumberPositive)
            {
                txtResult.FontSize = 16;
                txtResult.FontFamily = new FontFamily("Arial");
                txtResult.Foreground = Brushes.Green;
            }
            else
            {
                txtResult.FontSize = 16;
                txtResult.FontFamily = new FontFamily("Arial");
                txtResult.Foreground = Brushes.Red;
            }
        }

        private int[] getuserinput()
        {
            UserInput userInput = this.DataContext as UserInput;
            string strInput = userInput.UserInputText.ToString();
            int[] numbersArray = StringtoIntArray.StringToIntArrayMap(strInput);
            return numbersArray;
        }
    }
}

using System.Windows;
using System;
namespace Exercise03
{
    public partial class MainWindow : Window
    {
        private Random randomNumber = new Random();
        private int counter = 0;
        private double total = 0;
        private double average;
        private int number;
        public MainWindow()
        {
            InitializeComponent();
            
        }



        private void GenerateRandomNumber_Button_Click(object sender, RoutedEventArgs e)
        {
            number = randomNumber.Next(200, 400);
            counter += 1;
            total += number;
            average = total / counter;
            randomTextBox.Text = $"{number}";
            averageTextBox.Text = $"{average}";
            sumTextBox.Text = $"{total}";
        }

        private void ConvertedNumber_TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}

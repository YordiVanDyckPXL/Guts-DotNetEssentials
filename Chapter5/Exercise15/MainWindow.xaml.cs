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

namespace Exercise15
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



        private void ConvertSecondsToHoursMinutesSeconds(int seconds, out int total_hours, out int total_minutes, out int total_seconds)
        {
            total_hours = seconds / 3600;
            total_minutes = seconds / 60 % 60;
            total_seconds = seconds % 60;
            
        }

        private void secondsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ConvertButton_Click_1(object sender, RoutedEventArgs e)
        {
            int seconds = Convert.ToInt32(secondsTextBox.Text);
            // TODO: convert with one method
            int hours, minutes, total_seconds;
            ConvertSecondsToHoursMinutesSeconds(seconds, out hours,out minutes,  out total_seconds);
            MessageBox.Show(hours + " hours " + minutes + " minutes " + total_seconds + " seconds");
        }
    }
}

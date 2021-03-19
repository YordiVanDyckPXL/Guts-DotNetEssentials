using System.Windows;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Controls;
namespace Exercise10
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();


            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            progress.ValueChanged += Progress_ValueChanged;
        }

        private void Progress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (progress.Value == progress.Maximum)
            {
                test.Text = "to long";
                OkButton.IsEnabled = false;
                CancelButton.IsEnabled = false;
                timer.Stop();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progress.Value += 10;
            
        }
    }
}

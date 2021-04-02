using System;

using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace BeetleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Beetle _beetle;
        private DispatcherTimer timer;
        private string _direction = "";
        private double  _changePositionValue;
        public MainWindow()
        {
            InitializeComponent();
            sizeSlider.ValueChanged += SizeSlider_ValueChanged;
            speedSlider.ValueChanged += SpeedSlider_ValueChanged;
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
                   
               _beetle.ChangePosition(ref _changePositionValue, ref _direction);
                     
        }

        private void SpeedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            speedLabel.Content = Convert.ToString(speedSlider.Value);
        }

        private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sizeLabel.Content = Convert.ToString(Convert.ToInt32(sizeSlider.Value));
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (startButton.Content.Equals("Stop"))
            {
                _direction = "";
                timer.Stop();
                startButton.Content = "Start";
            }
            else 
            {
                
                _beetle = new Beetle(Convert.ToDouble(speedSlider.Value), Convert.ToInt32(sizeSlider.Value), paperCanvas, paperCanvas.Width/2, paperCanvas.Height/2);
                startButton.Content = "Stop";
                _changePositionValue = Convert.ToDouble(speedSlider.Value);
                timer.Start();
            }
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            _direction = "Up";
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            _direction = "Left";
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            _direction = "Down";
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            sizeSlider.Value = sizeSlider.Minimum;
            speedSlider.Value = speedSlider.Minimum;

            Beetle.destroyBeetle(_beetle);
            timer.Stop();
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            _direction = "Right";
        }
    }
};


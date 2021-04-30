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
        private DispatcherTimer _timer;
        private double _distance = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            sizeSlider.ValueChanged += SizeSlider_ValueChanged;
            speedSlider.ValueChanged += SpeedSlider_ValueChanged;
            _timer = new DispatcherTimer();
            _timer.Tick += Timer_Tick;
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _distance += Convert.ToDouble(sizeSlider.Value) / 100;
            _beetle.ChangePosition();
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

                messageLabel.Content = $"total distance in meter: {Math.Round(_distance, 2)}" ;
                _timer.Stop();
                startButton.Content = "Start";
                sizeSlider.IsEnabled = true;
                speedSlider.IsEnabled = true;
            }
            else 
            {
                if (_beetle == null)
                {
                    _beetle = new Beetle(paperCanvas, Convert.ToInt32(paperCanvas.Width / 2), Convert.ToInt32(paperCanvas.Height / 2), Convert.ToInt32(sizeSlider.Value));
                }
                else
                {
                    
                    _beetle.IsVisible = true;
                }   
                
                startButton.Content = "Stop";
               
                _beetle.Speed = Convert.ToDouble(speedSlider.Value);
                sizeSlider.IsEnabled = false;
                speedSlider.IsEnabled = false;
                _timer.Start();
                _timer.Interval = TimeSpan.FromMilliseconds(_beetle.Speed);
            }
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            
           _beetle.Up = true;
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            _beetle.Right = false;
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            _beetle.Up = false;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            _distance = 0;
            sizeSlider.Value = sizeSlider.Minimum;
            speedSlider.Value = speedSlider.Minimum;
            _beetle.IsVisible = false;
            startButton.Content = "Start";
            
            //Beetle.destroyBeetle(_beetle);
            _timer.Stop();
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            _beetle.Right = true;
        }
    }
};


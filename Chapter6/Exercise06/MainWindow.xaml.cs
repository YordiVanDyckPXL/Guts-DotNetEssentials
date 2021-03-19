using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Controls;
namespace Exercise06
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private Rectangle secondsRectangle = new Rectangle();
        private Rectangle minutesRectangle = new Rectangle();
        public MainWindow()
        {
            InitializeComponent();
            createRectangle(drawingArea, new SolidColorBrush(Colors.Black), Convert.ToInt32(gapSlider.Value), 10, secondsRectangle);
            createRectangle(drawingArea, new SolidColorBrush(Colors.Black), Convert.ToInt32(gapSlider.Value), 20, minutesRectangle);
            timer.Start();
            timer.Interval = TimeSpan.FromSeconds(0.2);
            
            timer.Tick += Timer_Tick;
            gapSlider.ValueChanged += GapSlider_ValueChanged;
           
            
        }

        private void GapSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
         
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var timeSpan = TimeSpan.FromMinutes(gapSlider.Value);
            if (minutesRectangle.Width != Convert.ToInt32(gapSlider.Value)) { 
                if (secondsRectangle.Width < 60) {
                    secondsRectangle.Width += 1;
                }
            
                if (secondsRectangle.Width == 60)
                {
                    minutesRectangle.Width += 1;
                    secondsRectangle.Width = 0;
                }
            }
            test.Text = $"{timeSpan.Hours} == {timeSpan.Seconds}\n{gapSlider.Value}";
           
        }

        private void createRectangle(Canvas paperCanvas, SolidColorBrush brushToUse, int x, int y, Rectangle newRectangle )
        {
            newRectangle.Width = x;
            newRectangle.Height = y;
            newRectangle.Stroke = brushToUse;
            newRectangle.Margin = new Thickness(x, y, 0, 0);

            
            paperCanvas.Children.Add(newRectangle);

        }
    }
}

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BeetleGame
{
    public class Beetle
    {
        private double _speed;
        private int _size;
        private Canvas _canvas;
        private double _x;
        private double _y;
        private Ellipse _ellipse;

        public Beetle(double speed, int size, Canvas canvas, double x, double y)
        {
            _speed = speed;
            _size = size;
            _canvas = canvas;
            _x = x;
            _y = y;
            createBeatle();
            
        }

        private void createBeatle()
        {
            _ellipse = new Ellipse();
            _ellipse.Margin = new Thickness(_x, _y, 0, 0);
            _ellipse.Height = _size;
            _ellipse.Width = _size;
            _ellipse.Fill = new SolidColorBrush(Colors.Red);
            _canvas.Children.Add(_ellipse);
        }

        public double speed { get => _speed; set => _speed = value; }

        public void ChangePosition( ref double newValue, ref string direction)
        {
            if (direction.Equals("Up"))
            {
                if (_y > 0)
                {
                    _y -= newValue;
                    _ellipse.Margin = new Thickness(_x, _y, 0, 0);
                }
                else
                {
                    direction = "Down";
                }
                
            }
            else if (direction.Equals("Down"))
            {
                if (y < _canvas.ActualHeight)
                {
                    _y += newValue;
                    _ellipse.Margin = new Thickness(_x, _y, 0, 0);
                }
                else
                {
                    direction = "Up";
                }
                
            }
            else if (direction.Equals("Right"))
            {
                if (_x < _canvas.Width)
                {
                    _x += newValue;
                    _ellipse.Margin = new Thickness(_x, _y, 0, 0);
                }
                else
                {
                    direction = "Left";
                }
                
            }
            else if (direction.Equals("Left"))
            {
                if (_x > 0)
                {
                    _x -= newValue;
                    _ellipse.Margin = new Thickness(_x, _y, 0, 0);
                }
                else
                {
                    direction = "Right";
                }
                
            }

        }

        public double x {get => _x;}

        public double y {get => _y;}

        public Ellipse GetEllipse { get => _ellipse; set => _ellipse = value; }

        public static void destroyBeetle(Beetle beetle) 
        {
            beetle.GetEllipse.Fill = null;
            beetle.GetEllipse = null;
            beetle = null;
        }

        public delegate void moveBeetle(int x, int y);
    }
}

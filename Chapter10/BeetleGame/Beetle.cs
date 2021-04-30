using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BeetleGame
{
    public class Beetle
    {
        private double _beetleSpeed;
        private int _beetleSize;
        private Canvas _canvas;
        private int _x;
        private int _y;
        private Ellipse _ellipse;
        private bool _up;
        private bool _right ;
        private bool _isVisible;

        public Beetle(Canvas canvas, int x, int y, int size)
        {
            
            _beetleSize = size;
            _canvas = canvas;
            X = x - _beetleSize/2;
            Y = y - _beetleSize/2;
            

            Up = true;
            Right = true;
            IsVisible = true;
            createBeatle();
            
        }

        private void createBeatle()
        {
            _ellipse = new Ellipse();
            _ellipse.Margin = new Thickness(_x, _y, 0, 0);
            _ellipse.Height = _beetleSize;
            _ellipse.Width = _beetleSize;
            _ellipse.Fill = new SolidColorBrush(Colors.Red);
            _canvas.Children.Add(_ellipse);
        }

       

        public void ChangePosition()
        {
            if (Speed > 0)
            {

            
                if (Up)
                {
                    if (Y > 0)
                    {
                        _y -= 1;
                        _ellipse.Margin = new Thickness(_x, _y, 0, 0);
                    }
                    else
                    {
                        Up = false;
                    }
                
                }
                else 
                {
                    if (Y < _canvas.ActualHeight)
                    {
                        _y += 1;
                        _ellipse.Margin = new Thickness(_x, _y, 0, 0);
                    }
                    else
                    {
                        Up = true;
                    }
                
                }
                if (Right)
                {
                    if (X < _canvas.Width)
                    {
                    
                        _x += 1;
                        _ellipse.Margin = new Thickness(_x, _y, 0, 0);
                    }
                    else
                    {
                        Right = false;
                    }
                
                }
                else 
                {
                    if (X > 0)
                    {
                        _x -= 1;
                        _ellipse.Margin = new Thickness(_x, _y, 0, 0);
                    }
                    else
                    {
                        Right = true;
                    }
                
                }
            }

        }

        public double Speed {
            get => _beetleSpeed;
            set
            {

                _beetleSpeed = value;
            }


        }
        public int Size
        {
            get => _beetleSize;
            set
            {

                _beetleSize = value;
            }
        }
        public bool Right
        {
            get => _right;
            set
            {
                _right = value;
            }
        }
        public bool IsVisible {
            get => _isVisible;
            set
            {
                _isVisible = value;
                if (!_isVisible)
                {
                    _ellipse.Visibility = Visibility.Hidden;
                }
                else
                {
                    _ellipse.Visibility = Visibility.Visible;
                   
                }
            }
        }
        public bool Up { 
            get=>_up; 
            set {
                _up = value;
            }
        }

        public int X {
            get => _x;
            set => _x = value;
        }

        public int Y { 
            get => _y; 
            set=> _y = value; 
        }

        private Ellipse GetEllipse { get => _ellipse; set => _ellipse = value; }

       // public static void destroyBeetle(Beetle beetle) 
       // {
         //   beetle.GetEllipse.Fill = null;
         //   beetle.GetEllipse = null;
         //   beetle = null;
       // }

       
       
    }
}

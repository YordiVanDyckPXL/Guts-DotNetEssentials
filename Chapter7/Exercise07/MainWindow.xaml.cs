using System.Windows;
using System.Windows.Controls;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Controls;
namespace Exercise07
{
    public partial class MainWindow : Window
    {
        private string _firstOperator = "+";
        private string _previousOperator = ""; 
        private string _number = "";
        private int _previousNumber = 0;
        private int _total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNumberClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            _number += Convert.ToString(button.Content);

    
           
         
            resultTextBlock.Text = _number;


        }

        private void operatorClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Content.Equals("="))
            {
                if (_previousOperator.Equals("+"))
                {
                    _total = _previousNumber + Convert.ToInt32(_number);

                    _previousNumber = _total;


                }
                else if (_previousOperator.Equals("-"))
                {
                    
                     _total = _previousNumber - Convert.ToInt32(_number);

                     _previousNumber = _total;


                    
                }

                _number = Convert.ToString(_previousNumber);
                resultTextBlock.Text = Convert.ToString(_number);

                _previousOperator = "=";
            }
            else if (button.Content.Equals("+"))
            {
                if (!_previousOperator.Equals("="))
                {
                    _total = _previousNumber + Convert.ToInt32(_number);

                    _previousNumber = _total;
                    
                    
                }
                
                 
                
                _number = "";
            }
            else
            {
                if (!_previousOperator.Equals("="))
                {
                    if (_firstOperator.Equals("+"))
                    {
                        _previousNumber =  Convert.ToInt32(_number);
                        
                    }
                    else
                    {
                        _previousNumber = _previousNumber - Convert.ToInt32(_number);
                    }
                   

                    
                    
                }
               
                
            }
            _previousOperator = Convert.ToString(button.Content);

            _number = "";
            _firstOperator = "";
        }
        
    }
}

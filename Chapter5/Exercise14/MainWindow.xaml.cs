using System;
using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string ConvertNumberToBinary(int number)
        {
           
            if (number < 255 || number > 0)
            {
                string converted = "";
                for (int i = 256; i >= 1; i /= 2)
                {
                    if (number - i < 0)
                    {
                        if (i == 256)
                        {
                            converted = "";
                        }
                        else
                        {
                            converted += "0";
                        }


                    }
                    else
                    {

                        number -= i;
                        
                        converted += "1";
                    }
                }

                return converted;

            }
            return "Not a good number";
        }
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            string result = ConvertNumberToBinary(Convert.ToInt32(numberToConvertTextbox.Text));
            convertedNumberTextBlock.Text = result;
        }
    }
}

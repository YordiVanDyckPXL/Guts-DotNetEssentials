using System.Windows;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Exercise01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string removelistitem = Convert.ToString(listBox.SelectedItem);
            for (int n = listBox.Items.Count - 1; n >= 0; --n)
            {
                
                if (listBox.Items[n].ToString().Equals(removelistitem))
                {
                    listBox.Items.RemoveAt(n);
                    break;
                }
            }

            selectedLabel.Content = Convert.ToString(listBox.SelectedItem);
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}

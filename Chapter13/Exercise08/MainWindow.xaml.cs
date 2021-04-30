using System;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Exercise08
{
    public partial class MainWindow : Window
    {
        private List<Person> _listPersons = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            
            Person person1 = new Person("loser", "jef", "male", "uilekot 18", "+324561658", DateTime.Now);
            Person person2 = new Person("aap", "jefke", "male", "uilekot 18", "+324561658", DateTime.Now);
            _listPersons.Add(person2);
            _listPersons.Add(person1);

            foreach (Person person in _listPersons)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = $"{person.FirstName} {person.Name}";
                personsListBox.Items.Add(item);
            }
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void DetailsBUtton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            
            window.Show();
            
        }

        private void PersonsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void personsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

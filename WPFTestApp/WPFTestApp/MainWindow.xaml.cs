using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPFTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CountButtonClick(object sender, RoutedEventArgs e)
        {
            list.Add("Hei");

            ListeBox.Items.Add("Hei");

                //foreach (var line in list)
            //{
            //    ListBoxItem itm = new ListBoxItem();
            //    itm.Content = line;

            //    ListeBox.Items.Add(itm);
            //}
        }
    }
}

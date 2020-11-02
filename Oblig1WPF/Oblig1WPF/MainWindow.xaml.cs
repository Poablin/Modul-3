using System;
using System.Windows;
using Oblig1;

namespace Oblig1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model model = new Model();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowList(object sender, RoutedEventArgs e)
        {
            FamilyAppList.Items.Clear();
            foreach (var person in model.App._people)
            {
                FamilyAppList.Items.Add(person.GetDescription());
            }
        }

        private void ShowId(object sender, RoutedEventArgs e)
        {
            FamilyAppList.Items.Clear();
            int childrenSearchId = 0;
            string str = null;
            var searchId = 0;
            if (IdInput.Text != "") searchId = Convert.ToInt32(IdInput.Text);
            foreach (var person in model.App._people)
            {
                if (person.Id == searchId)
                {
                    str += person.GetDescription();
                    childrenSearchId = person.Id;
                }
            }
            str = model.App.FindChildren(childrenSearchId, str);
            FamilyAppList.Items.Add(str);
        }
    }
}

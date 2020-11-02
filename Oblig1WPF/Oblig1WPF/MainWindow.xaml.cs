using System;
using System.Globalization;
using System.Linq;
using System.Threading;
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
            string str = null;
            var searchId = 0;
            var childrenSearchId = 0;
            var isNumeric = int.TryParse(IdInput.Text, out int n);
            if (isNumeric)
            {
                searchId = n;
            }
            foreach (var person in model.App._people.Where(person => person.Id == searchId))
            {
                str += person.GetDescription();
                childrenSearchId = person.Id;
            }
            str = model.App.FindChildren(childrenSearchId, str);
            FamilyAppList.Items.Add(str);
        }

        private void AddPerson(object sender, RoutedEventArgs e)
        {
            FamilyAppList.Items.Clear();
            var person = new Person{Id = 0,FirstName = NameInput.Text, LastNameInput.Text, BirthYearInput.Text, DeathYearInput};
            model.App._people.Add();
        }
    }
}

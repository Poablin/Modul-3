﻿using System;
using System.Linq;
using System.Windows;
using Oblig1WPF.Model;

namespace Oblig1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Oblig1.Model _model = new Oblig1.Model();
        private int _idCount = 9;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowList(object sender, RoutedEventArgs e)
        {
            FamilyAppList.Items.Clear();
            foreach (var person in _model.App.People)
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
            if (isNumeric) searchId = n;
            foreach (var person in _model.App.People.Where(person => person.Id == searchId))
            {
                str += person.GetDescription();
                childrenSearchId = person.Id;
            }
            str = _model.App.FindChildren(childrenSearchId, str);
            FamilyAppList.Items.Add(str);
        }

        private void AddPerson(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(BirthYearInput.Text, out int n) || !int.TryParse(DeathYearInput.Text, out int n2)) return;
            FamilyAppList.Items.Clear();
            var person = new Person { 
                Id = _idCount, 
                FirstName = NameInput.Text, 
                LastName = LastNameInput.Text, 
                BirthYear = Convert.ToInt32(BirthYearInput.Text), 
                DeathYear = Convert.ToInt32(DeathYearInput.Text) };
            _model.App.People.Add(person);
            _idCount++;
            ShowList(null, null);
        }
    }
}

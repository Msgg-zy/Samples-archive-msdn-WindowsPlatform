﻿using SDKTemplate;
using System.ComponentModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;

namespace DataBinding
{
    public sealed partial class Scenario9
    {

        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        Employee _employee;

        public Scenario9()
        {
            this.InitializeComponent();
            _employee = new Employee();
            _employee.PropertyChanged += employeeChanged;
            Output.DataContext = _employee;
            ScenarioReset(null, null);
        }

        private void ScenarioReset(object sender, RoutedEventArgs e)
        {
            _employee.Name = "Jane Doe";
            _employee.Organization = "Contoso";
            LogMessage("");
        }

        private void employeeChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Name"))
            {
                LogMessage("The property '" + e.PropertyName + "' was changed." + "\n\nNew value: " + _employee.Name);
            }
        }

        private void UpdateDataBtnClick(object sender, RoutedEventArgs e)
        {
            var expression = NameTxtBox.GetBindingExpression(TextBox.TextProperty);
            expression.UpdateSource();
        }

        private void LogMessage(string message)
        {
            if (message.Length > 0)
            {
                LogBorder.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                LogBorder.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            Log.Text = message;
        }
    }
}

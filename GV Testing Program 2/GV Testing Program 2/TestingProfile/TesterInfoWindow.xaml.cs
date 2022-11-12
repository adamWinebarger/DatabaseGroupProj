using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GV_Testing_Program_2
{
    /// <summary>
    /// Interaction logic for TesterInfoWindow.xaml
    /// </summary>
    public partial class TesterInfoWindow : Window
    {
        public TesterInfoWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (allFieldsAreValid())
            {
                Tester tester = new(LastNameTextBox.Text, FirstNameTextBox.Text,
                    MiddleNameTextBox.Text,
                    (MaleRadioButton.IsChecked == true) ? Gender.male : Gender.female,
                    int.Parse(AgeTextBox.Text));
                new TestingMenu(tester).Show();
                this.Close();

            } else
            {
                MessageBox.Show("Error! One or more fields is missing a valid value. At a " +
                    "minimum, you must have input a last name, first name, age (number), " +
                    "and gender", "Invalid value detected");
            }
        }

        private void AgeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!(Regex.IsMatch(AgeTextBox.Text, @"^\d+$") || AgeTextBox.Text == ""))
            {
                MessageBox.Show("Error! Invalid input detected into the age textbox. Please " +
                    "input numeric characters [0-9] only.");
                AgeTextBox.Text = "";
            } 
        }

        bool allFieldsAreValid()
        {
            if (FirstNameTextBox.Text == "" || LastNameTextBox.Text == "")
                return false;

            if (!Regex.IsMatch(AgeTextBox.Text, @"^\d+$"))
                return false;

            if (MaleRadioButton.IsChecked == false && FemaleRadioButton.IsChecked == false)
                return false;
            return true;
        }
    }
}

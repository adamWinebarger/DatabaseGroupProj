using GV_Testing_Program_2.RCMAS_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for TestingMenu.xaml
    /// </summary>
    public partial class TestingMenu : Window
    {
        private Tester currentTester;

        bool[] testTaken = { false, false, false, false };

        public TestingMenu(Tester currentTester)
        {
            InitializeComponent();
            this.currentTester = currentTester;
            toggleTestButtonVisibility();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Content)
            {
                case "CDI":
                    new CDITestingWindow(currentTester).Show();
                    break;
                case "BAI":
                    new BAITestForm(currentTester).Show();
                    break;
                case "RCMAS":
                    new RCMASTestingWindow(currentTester).Show();
                    break;
                case "BDI2":
                    new BDITestingWindow(currentTester).Show();
                    break;
                default:
                    return;
            }
        }

        private void toggleTestButtonVisibility()
        {
            int age = currentTester.age;
            bool isAdult = age >= 19;

            baiButton.Visibility = (isAdult || testTaken[0] ? 
                Visibility.Visible : Visibility.Hidden);
            bdi2Button.Visibility = (isAdult || testTaken[1] ? 
                Visibility.Visible : Visibility.Hidden);
            rcmasButton.Visibility = (age is >= 6 and <= 19) || testTaken[2] ? 
                Visibility.Visible : Visibility.Hidden;
            cdiButton.Visibility = (age is >= 7 and <= 17) || testTaken[3] ? 
                Visibility.Visible : Visibility.Hidden;   
        }
    }
}

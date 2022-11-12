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
using System.IO;

namespace GV_Testing_Program_2.RCMAS_Stuff
{
    /// <summary>
    /// Interaction logic for RCMASTestingWindow.xaml
    /// </summary>
    public partial class RCMASTestingWindow : Window
    {
        private bool[] answers;
        private int count = 0;
        private Tester tester;
        private string[] lines;

        public RCMASTestingWindow(Tester tester)
        {
            InitializeComponent();
            this.tester = tester;
            answers = new bool[49];
            submitButton.Visibility = Visibility.Hidden;
            lines = File.ReadAllLines("Test_Questions\\RCMAS_Questions.txt");
            questionLabel.Text = lines[count];
            
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (yesRadioButton.IsChecked == true)
            {
                answers[count++] = true;
                loadQuestion();
            } else if (noRadioButton.IsChecked == true)
            {
                answers[count++] = false;
                loadQuestion();
            } else
            {
                MessageBox.Show("Error! You must select either yes or no for your answer.", "Response");
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            count--;
            if (submitButton.IsVisible)
            {
                submitButton.Visibility = Visibility.Hidden;
                nextButton.Visibility = Visibility.Visible;
            }
            resetRadioButtons();
            loadQuestion();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            saveAnswers2Database();
            saveResults2Database();
            this.Close();
        }

        void saveAnswers2Database()
        {
            //Store answers here
        }

        void saveResults2Database()
        {
            ScoreRCMAS scoreRCMAS = new(answers, tester.age);

            //Store the result values here
        }

        void loadQuestion()
        {
            if (count < answers.Length)
                questionLabel.Text = lines[count];
            else
            {
                submitButton.Visibility = Visibility.Visible;
                nextButton.Visibility = Visibility.Hidden;
            }
        }

        void resetRadioButtons()
        {
            yesRadioButton.IsChecked = false;
            noRadioButton.IsChecked = false;
        }
    }
}

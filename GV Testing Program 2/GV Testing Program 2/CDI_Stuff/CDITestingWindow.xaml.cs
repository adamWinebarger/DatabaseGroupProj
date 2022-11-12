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

namespace GV_Testing_Program_2
{
    /// <summary>
    /// Interaction logic for CDITestingWindow.xaml
    /// </summary>
    public partial class CDITestingWindow : Window
    {
        private int[] answers;
        private int itemCount = 0, sentenceCount = 0;
        private string[] questions;
        private Tester tester;

        public CDITestingWindow(Tester tester)
        {
            InitializeComponent();
            answers = new int[28];
            questions = File.ReadAllLines("Test_Questions\\CDI_Questions.txt");
            this.tester = tester;

            submitButton.Visibility = Visibility.Hidden;
            resetRadioButtons();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkAnswer() != -1)
            {
                answers[itemCount++] = checkAnswer();

                if (itemCount < answers.Length)
                {
                    sentenceCount += 4;
                    loadQuestions();
                    resetRadioButtons();
                }
                else
                {
                    submitButton.Visibility = Visibility.Visible;
                    nextButton.Visibility = Visibility.Hidden;
                }
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            itemCount -= 1;
            sentenceCount -= 4;
            loadQuestions();
            resetRadioButtons();
            if (nextButton.IsVisible == false)
            {
                nextButton.Visibility = Visibility.Visible;
                submitButton.Visibility = Visibility.Hidden;
            }
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            save2Database(new(answers, tester.age, tester.gender));
        }

        void save2Database(ScoreCDI scoreCDI)
        {

        }

        void resetRadioButtons()
        {
            topRadioButton.IsChecked = false;
            middleRadioButton.IsChecked = false;
            bottomRadioButton.IsChecked = false;
        }

        void loadQuestions()
        {
            questionLabel.Text = questions[sentenceCount];
            topRadioButton.Content = questions[sentenceCount + 1];
            middleRadioButton.Content = questions[sentenceCount + 2];
            bottomRadioButton.Content = questions[sentenceCount + 3];
        }

        int checkAnswer()
        {
            if (topRadioButton.IsChecked == false && middleRadioButton.IsChecked == false && bottomRadioButton.IsChecked == false)
            {
                MessageBox.Show("Error! You must select one of the options before continuing.\nPlease select the sentence that best describes how you have been feeling in the last two weeks", "response");
                return -1;
            }
            else if (middleRadioButton.IsChecked.Equals(true))
            {
                return 1;
            } else
            {
                int[] itemSet1 = { 0, 2, 3, 4, 7, 10, 12, 15, 17, 18, 20, 21, 24, 27 },
                    itemSet2 = { 1, 5, 6, 8, 9, 11, 13, 14, 16, 19, 22, 23, 25, 26 };

                if (Array.Exists(itemSet1, element => element == itemCount))
                {
                    return (topRadioButton.IsChecked == true) ? 0 : 2;
                } else
                {
                    return (topRadioButton.IsChecked == true) ? 2 : 0;
                }
            }
        }
    }
}

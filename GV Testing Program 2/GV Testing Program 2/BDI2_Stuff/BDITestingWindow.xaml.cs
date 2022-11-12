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
    /// Interaction logic for BDITestingWindow.xaml
    /// </summary>
    public partial class BDITestingWindow : Window
    {
        private string[] bdiAnswers, lines;
        private int count = -1, linesCount = 0;
        private Tester tester;
        

        public BDITestingWindow(Tester tester)
        {
            InitializeComponent();
            resetRadioButtons();
            this.tester = tester;
            bdiAnswers = new string[20];
            lines = File.ReadAllLines("Test_Questions\\\\BDI2_Questions.txt");


        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (count < bdiAnswers.Length) //Go back and check this again. might go out of bounds
            {
                bdiAnswers[count] = checkAnswer();
                count++;
                loadQuestions();
            } else
            {
                submitButton.Visibility = Visibility.Visible;
                nextButton.Visibility = Visibility.Hidden;
            }
            
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (count > 0)
            {
                --count;
                linesCount -= (count == 14 || count == 16) ? 6 : 3;
                loadQuestions();
                if (submitButton.IsVisible)
                {
                    submitButton.Visibility = Visibility.Visible;
                    nextButton.Visibility = Visibility.Visible;
                }
            }
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            save2Database(new(bdiAnswers));
        }

        void save2Database(ScoreBDI2 scoreBDI2)
        {

        }
       
        void loadQuestions()
        {
            QuestionLabel.Text = lines[linesCount];

            radioButton0.Content = lines[++linesCount];
            if (toggleRadioButtonVisibility())
            {
                radioButton1a.Content = lines[++linesCount];
                radioButton1b.Content = lines[++linesCount];
                radioButton2a.Content = lines[++linesCount];
                radioButton2b.Content = lines[++linesCount];
                radioButton3a.Content = lines[++linesCount];
                radioButton3b.Content = lines[++linesCount];

            }
            else
            {
                radioButton1a.Content = lines[++linesCount];
                radioButton2a.Content = lines[++linesCount];
                radioButton3a.Content = lines[++linesCount];

            }

            linesCount++;
        }

        void resetRadioButtons()
        {
            toggleRadioButton(radioButton0);
            toggleRadioButton(radioButton1a);
            toggleRadioButton(radioButton1b);
            toggleRadioButton(radioButton2a);
            toggleRadioButton(radioButton2b);
            toggleRadioButton(radioButton3a);
            toggleRadioButton(radioButton3b);
        }

        void toggleRadioButton(RadioButton r)
        {
            r.IsChecked = false;
        }

        bool toggleRadioButtonVisibility()
        {
            if (count == 15 || count == 17)
            {
                radioButton1b.Visibility = Visibility.Visible;
                radioButton2b.Visibility = Visibility.Visible;
                radioButton3b.Visibility = Visibility.Visible;
                return true;
            }
            else
            {
                radioButton1b.Visibility = Visibility.Hidden;
                radioButton2b.Visibility = Visibility.Hidden;
                radioButton3b.Visibility = Visibility.Hidden;
                return false;
            }
        }

        string checkAnswer()
        {
            if (radioButton0.IsChecked == true)
            {
                return "0";
            }

            if (toggleRadioButtonVisibility())
            {
                if (radioButton1a.IsChecked == true)
                {
                    return "1a";
                }
                else if (radioButton1b.IsChecked == true)
                {
                    return "1b";
                }
                else if (radioButton2a.IsChecked == true)
                {
                    return "2a";
                }
                else if (radioButton2b.IsChecked == true)
                {
                    return "2b";
                }
                else if (radioButton3a.IsChecked == true)
                {
                    return "3a";
                }
                else if (radioButton3b.IsChecked == true)
                {
                    return "3b";
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (radioButton1a.IsChecked == true)
                {
                    return "1";
                }
                else if (radioButton2a.IsChecked == true)
                {
                    return "2";
                }
                else if (radioButton3a.IsChecked == true)
                {
                    return "3";
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

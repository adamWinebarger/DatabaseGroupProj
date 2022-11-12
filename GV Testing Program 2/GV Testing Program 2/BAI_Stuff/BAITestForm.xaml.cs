using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// Interaction logic for BAITestForm.xaml
    /// </summary>
    public partial class BAITestForm : Window
    {
        private Tester tester;
        private int[] answers = new int[21];
        private int count = 0;
        private string[] lines;

        public BAITestForm(Tester tester)
        {
            InitializeComponent();
            this.tester = tester;
            lines = File.ReadAllLines("Test_Questions\\BAI_Questions.txt");
            resetButtons();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            loadNewQuestion(1);
            resetButtons();

        }

        private void backButtton_Click(object sender, RoutedEventArgs e)
        {
            loadNewQuestion(-1);
            resetButtons();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            save2Database(new(answers));
        }

        void save2Database(ScoreBAI scoreBAI)
        {

        }

        

        void loadNewQuestion(int crement)
        {
            count += crement;
            count = (count < 0) ? 0 : (count >= answers.Length) ? answers.Length : count;
            QuestionLabel.Text = (count == lines.Length) ? lines[count - 1] : lines[count];
        }


        void resetButtons()
        {
            notAtAllButton.IsChecked = false;
            mildlyButton.IsChecked = false;
            moderatelyButton.IsChecked = false;
            severelyButton.IsChecked = false;

            if (count == 0)
                backButtton.Visibility = Visibility.Hidden;
            if (count == answers.Length)
            {
                nextButton.Visibility = Visibility.Hidden;
                submitButton.Visibility = Visibility.Visible;
            } else
            {
                nextButton.Visibility = Visibility.Hidden;
                submitButton.Visibility = Visibility.Visible;
            }
        }
    }
}

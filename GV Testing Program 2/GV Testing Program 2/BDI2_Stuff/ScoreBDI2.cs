using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV_Testing_Program_2
{
    class ScoreBDI2
    {
        public string[] answers { get; private set; }
        public int totalScore { get; private set; } = 0;

        public ScoreBDI2(string[] answers)
        {
            this.answers = answers;
            scoreTest();
        }

        private void scoreTest()
        {
            foreach (string answer in answers)
            {
                switch (answer[0])
                {
                    case '0' or '1' or '2' or '3':
                        totalScore += answer[0] - '0';
                        break;
                    default:
                        totalScore = -999;
                        return;
                }
            }
        }


    }
}

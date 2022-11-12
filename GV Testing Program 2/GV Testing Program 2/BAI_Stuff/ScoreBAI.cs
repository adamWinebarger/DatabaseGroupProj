using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV_Testing_Program_2
{
    public class ScoreBAI
    {
        public int[] answers { get; private set; }
        public int result { get; private set; } = 0;

        public ScoreBAI(int[] answers)
        {
            this.answers = answers;
            foreach (int answer in answers)
                result += answer;
        }


    }
}

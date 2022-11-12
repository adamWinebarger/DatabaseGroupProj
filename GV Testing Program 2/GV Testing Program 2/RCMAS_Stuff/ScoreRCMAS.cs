using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GV_Testing_Program_2
{
    class ScoreRCMAS
    {
        public bool[] answers { get; private set; }
        private int age;

        //attributes, raw scores
        private int def = 0, phy, wor, soc, tot;

        //attributes, T-scores
        private int defT, phyT, worT, socT, totT;

        //soft-total: scores from the first 10 questions; and inconsistency score
        private int sofTot, inc;

        private int[] phyYesAnswers = { 0, 4, 6, 10, 14, 19, 24, 30, 33, 38, 42, 45 },
            worYesAnswers = { 1, 2, 5, 7, 11, 15, 16, 17, 20, 25, 29, 31, 34, 41, 44, 48 },
            socYesAnswers = { 3, 8, 9, 12, 21, 22, 26, 27, 35, 36, 40, 46 };

        public ScoreRCMAS(bool[] answers, int age)
        {
            this.answers = answers;
            this.age = age;
            scoreDEF();

            phy = scoreRegular(phyYesAnswers);
            wor = scoreRegular(worYesAnswers);
            soc = scoreRegular(socYesAnswers);
            tot = phy + wor + soc;

            defT = scoreDEFT();
            phyT = scorePHYT();
            worT = scoreWORT();
            socT = scoreSOCT();
            totT = scoreTOTT();

            for (int i = 0, sofTot = 0; i < 10; i++)
            {
                if (answers[i])
                    sofTot++;
            }

            scoreINC();
        }

        void scoreDEF()
        {
            int[] defYesAnswers = { 13, 18, 23, 28, 32, 37 },
                defNoAnswers = { 39, 43, 47 };

            foreach (int answer in defYesAnswers)
                if (answers[answer])
                    def++;

            foreach (int answer in defNoAnswers)
                if (!answers[answer])
                    def++;
        }

        int scoreRegular(int[] yesAnswers)
        {
            int value = 0;

            foreach (int answer in yesAnswers)
                if (answers[answer])
                    value++;

            return value;
        }

        int scoreDEFT()
        {
            switch (age)
            {
                case int n when (n >= 6 && n <= 8):
                    return def switch
                    {
                        1 or 2 or 3 or 8 => 4 * def + 30,
                        4 or 5 => 4 * def + 29,
                        6 => 52, 7 => 57, 9 => 71,
                        _ => -999
                    };
                case int n when (n > 8 && n <= 14):
                    return def switch
                    {
                        0 or 1 => 7 * def + 35,
                        >= 2 and <= 4 => 3 * def + 40,
                        > 4 and <= 7 => 4 * def + 36,
                        8 or 9 => 7 * def + 13,
                        _ => -999
                    };
                case int n when (n > 14 && n <= 19):
                    return def switch
                    {
                        0 or 1 => 7 * def + 36,
                        >= 2 and <= 5 => 4 * def + 40,
                        6 or 7 => 4 * def + 41,
                        8 => 4 * def + 42,
                        9 => 81,
                        _ => -999
                    };
                default:
                    return -999;
            }
        }

        int scoreTOTT()
        {
            switch (age)
            {
                case int n when n is >= 6 and <= 8:
                    return tot switch
                    {
                        0 or 1 => 29 + tot,
                        >= 2 and <= 10 => 30 + tot,
                        > 10 and <= 14 => 31 + tot,
                        > 14 and <= 17 => 32 + tot,
                        (>= 18 and <= 20) or (>= 28 and <= 38) => 33 + tot,
                        (> 20 and < 28) or 39 => 34 + tot,
                        40 => 75,
                        _ => -999
                    };
                case int n when n is > 8 and <= 14:
                    return tot switch
                    {
                        0 or 1 => 29 + tot,
                        > 1 and < 5 => 2 * tot + 29,
                        5 => 38,
                        > 5 and < 18 => 34 + tot,
                        18 or 19 => 35 + tot,
                        20 or 21 or (>= 28 and <= 30) => 36 + tot,
                        (> 21 and < 28) or (> 30 and <= 36) => 37 + tot,
                        37 or 38 => 3 * tot - 36,
                        > 38 => 81,
                        _ => -999
                    };
                case int n when n is > 14 and <= 19:
                    return tot switch
                    {
                        0 => 29,
                        1 or 2 => 2 * tot + 30,
                        3 or 4 => 34 + tot,
                        5 or 6 => 35 + tot,
                        > 6 and < 10 => 36 + tot,
                        >= 10 and < 18 => 37 + tot,
                        >= 18 and < 32 => 38 + tot,
                        32 or 33 => 39 + tot,
                        34 or 35 => 40 + tot,
                        36 or 37 => 41 + tot,
                        > 37 => 81,
                        _ => -999
                    };
                default: return -999;
            }
        }

        int scorePHYT()
        {
            switch (age)
            {
                case int n when n is >= 6 and <= 8:
                    return phy switch
                    {
                        0 => 29,
                        > 0 and < 5 => 3 * phy + 32,
                        >= 5 and < 8 => 3 * phy + 33,
                        8 or 9 => 3 * phy + 34,
                        10 or 11 => 3 * phy + 35,
                        12 => 73,
                        _ => -999
                    };
                case int n when n is > 8 and <= 14:
                    return phy switch
                    {
                        0 or 1 => 7 * phy + 29,
                        2 or 3 or 4 => phy * 3 + 34,
                        5 or 6 => 4 * phy + 30,
                        7 => 57,
                        8 or 9 => 3 * phy + 37,
                        10 or 11 or 12 => 4 * phy + 28,
                        _ => -999
                    };
                case int n when n is > 14 and <= 19:
                    return phy switch
                    {
                        0 or 1 or 7 => 6 * phy + 31,
                        2 or 3 => 4 * phy + 33,
                        > 3 and < 7 => 4 * phy + 32,
                        > 7 and < 12 => 3 * phy + 39,
                        12 => 77,
                        _ => -999
                    };
                default: return -999;
            }
        }

        int scoreWORT()
        {
            switch (age)
            {
                case int n when n is >= 6 and <= 8:
                    return wor switch
                    {
                        0 => 29,
                        1 or 2 => 3 * wor + 31,
                        3 or 4 => 2 * wor + 33,
                        5 or 6 => 3 * wor + 29,
                        7 or 8 => 3 * wor + 28,
                        9 or 10 => 3 * wor + 27,
                        > 10 and < 15 => 2 * wor + 37,
                        15 or 16 => 5 * wor - 7,
                        _ => -999
                    };
                case int n when n is > 8 and <= 14:
                    return wor switch
                    {
                        0 => 32,
                        1 or 2 => 2 * wor + 36,
                        > 2 and < 6 => 2 * wor + 37,
                        >= 6 and < 9 => 2 * wor + 38,
                        >= 9 and < 14 => 2 * wor + 39,
                        14 or 15 => 4 * wor + 12,
                        16 => 78,
                        _ => -999
                    };
                case int n when n is > 14 and <= 19:
                    return wor switch
                    {
                        0 => 34,
                        1 or 2 => 4 * wor + 35,
                        >= 3 and < 10 => wor * 2 + 40,
                        10 or 11 => wor * 2 + 41,
                        > 11 and <= 14 => wor * 2 + 42,
                        15 or 16 => 7 * wor - 31,
                        _ => -999
                    };
                default: return -999;
            }
        }

        int scoreSOCT()
        {
            switch (age)
            {
                case int n when n is >= 6 and <= 8:
                    return soc switch
                    {
                        0 => 32,
                        1 or 2 or 11 => 3 * soc + 35,
                        (> 2 and < 5) or (> 5 and < 11) => 3 * soc + 36,
                        5 or 12 => 3 * soc + 37,
                        _ => -999
                    };
                case int n when n is > 8 and <= 14:
                    return soc switch
                    {
                        0 or 1 => 6 * soc + 34,
                        >= 2 and < 10 => 3 * soc + 38,
                        10 or 11 => 3 * soc + 39,
                        12 => 78,
                        _ => -999
                    };
                case int n when n is > 14 and <= 19:
                    return soc switch
                    {
                        0 => 35,
                        1 or 2 => 4 * soc + 37,
                        (> 2 and < 9) or 11 => 3 * soc + 40,
                        9 => 66,
                        10 => 68,
                        12 => 81,
                        _ => -999
                    };
                default: return -999;
            }
        }

        void scoreINC()
        {
            int[] incPairs = { 1, 7, 2, 34, 3, 9, 5, 48, 6, 38, 18, 32, 22, 36, 23, 28 };

            for (int i = 0; i < incPairs.Length; i += 2)
            {
                if (answers[incPairs[i]] != answers[incPairs[i + 1]])
                {
                    inc++;
                }
            }

            if (answers[37] == answers[47])
            {
                inc++;
            }
        }

        public int getScores(string which)
        {
            return which switch
            {
                "DEF" => def, "PHY" => phy, "WOR" => wor, "SOC" => soc, "TOT" => tot,
                "DEFT" => defT, "PHYT" => phyT, "WORT" => worT, "SOCT" => socT, "TOTT" => totT,
                "SOFTOT" => sofTot, "INC" => inc,
                _ => -999
            };
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GV_Testing_Program_2
{
    class ScoreCDI
    {
        public int[] answers { get; private set; }

        private int age;
        private Gender gender;

        //Raw scores
        private int total, emotionalProblems, negativeMoodAndPhysicalSymptoms,
            negativeSelfEsteem, functionalProblems, ineffectiveness, interpersonalProblems;

        //T-Scores
        private int totalT, emotionalProblemsT, negativeMoodT, negativeSelfEsteemT,
            functionalProblemsT, ineffectivenessT, interpersonalProblemsT;

        private int[] negaiveMoodItems = { 0, 8, 9, 14, 15, 16, 17, 25, 26 },
            negativeSelfEsteemItems = { 1, 5, 6, 7, 12, 23 },
            ineffectivenessItems = { 2, 3, 11, 13, 19, 21, 22, 27 },
            interpersonalItems = { 4, 10, 18, 20, 24 };

        public ScoreCDI(int[] answers, int age, Gender gender)
        {
            this.answers = answers;
            this.age = age;
            this.gender = gender;

            negativeMoodAndPhysicalSymptoms = scoreRaw(negaiveMoodItems);
            negativeSelfEsteem = scoreRaw(negativeSelfEsteemItems);
            ineffectiveness = scoreRaw(ineffectivenessItems);
            interpersonalProblems = scoreRaw(interpersonalItems);

            emotionalProblems = negativeMoodAndPhysicalSymptoms + negativeSelfEsteem;
            functionalProblems = ineffectiveness + interpersonalProblems;
            total = emotionalProblems + functionalProblems;



        }

        int scoreRaw(int[] items)
        {
            int val = 0;

            foreach (int item in items)
                val += answers[item];

            return val;
        }

        int scoreTotalT()
        {
            int[] add2Values;

            switch (age, gender)
            {
                case (>= 7 and <= 12, Gender.male):

                    add2Values = new int[] {40, 40, 41, 41, 42, 42, 43, 43, 44, 44, 45, 46, 46,
                        47, 47, 48, 48, 49, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55,
                        56, 56}; 

                    return total switch
                    {
                        >= 0 and < 33 => add2Values[total] + total,
                        >= 33 => 90,
                        _ => -999
                    };
                case ( > 12 and <= 17, Gender.male):

                    add2Values = new int[] { 38, 38, 37, 37, 37, 36, 36, 36, 35, 35, 35, 34, 34,
                            34, 33, 33, 33, 33, 32, 32, 32, 31, 31, 31, 30, 30, 30, 29, 29};

                    return total switch
                    {
                        0 or 1 => 40,
                        > 1 and <= 30 => 2 * total + add2Values[total - 2],
                        > 30 => 90,
                        _ => -999
                    };

                case ( >= 7 and <= 12, Gender.female):

                    return total switch
                    {
                        >= 0 and < 4 => 2 * total + 40,
                        >= 4 and < 9 => 2 * total + 39,
                        >= 9 and < 14 => 2 * total + 38,
                        >= 14 and < 19 => 2 * total + 37,
                        >= 19 and < 25 => 2 * total + 36,
                        >= 25 and < 28 => 2 * total + 35,
                        >= 28 => 90,
                        _ => -999
                    };
                case ( > 12 and <= 17, Gender.female):

                    return total switch
                    {
                        >= 0 and < 4 => total + 40,
                        >= 4 and < 7 => total + 41,
                        >= 7 and < 11 => total + 42,
                        >= 11 and < 14 => total + 43,
                        >= 14 and < 17 => total + 44,
                        >= 17 and < 20 => total + 45,
                        >= 20 and < 24 => total + 46,
                        >= 24 and < 27 => total + 47,
                        >= 27 and < 30 => total + 48,
                        >= 30 and < 33 => total + 49,
                        >= 33 and < 37 => total + 50,
                        >= 37 and < 39 => total + 51,
                        >= 39 => 90,
                        _ => -999
                    };

                default: return -999;
            }
        }

        int scoreEmotionalProblemsT()
        {
            int[] add2Values;

            switch (age, gender)
            {
                case ( >= 7 and <= 12, Gender.male):
                    add2Values = new int[] {42, 42, 41, 41, 41, 40, 40, 40, 39, 39, 39, 38, 38,
                        37, 37, 37, 36, 36};

                    return emotionalProblems switch
                    {
                        >= 0 and < 18 => 3 * emotionalProblems + add2Values[emotionalProblems],
                        >= 18 => 90,
                        _ => -999
                    };
                case ( > 12 and <= 17, Gender.male):
                    return emotionalProblems switch
                    {
                        >= 0 and < 4 => 3 * emotionalProblems + 41,
                        >= 4 and < 16 => 3 * emotionalProblems + 42,
                        >= 16 => 90,
                        _ => -999
                    };

                case ( >= 7 and <= 12, Gender.female):

                    return emotionalProblems switch
                    {
                        >= 0 and < 16 => 3 * emotionalProblems + 42,
                        >= 16 => 90,
                        _ => -999
                    };

                case (> 12 and <= 17, Gender.female):

                    return emotionalProblems switch
                    {
                        0 or 1 or 2 => 2 * emotionalProblems + 41,
                        > 2 and < 9 => 2 * emotionalProblems + 42,
                        9 or 10 => 2 * emotionalProblems + 43,
                        >= 11 and < 22 => 2 * emotionalProblems + 44,
                        22 => 89,
                        >= 23 => 90,
                        _ => -999
                    };

                default: return -999;
            }
        }

        int scoreNegativeMoodAndPhysicalSymptomsT()
        {
            int[] add2Values;

            switch (age, gender)
            {
                case ( >= 7 and <= 12, Gender.male):

                    return negativeMoodAndPhysicalSymptoms switch
                    {
                        >= 0 and < 11 => 4 * negativeMoodAndPhysicalSymptoms + 42,
                        11 => 87,
                        >= 12 => 90,
                        _ => -999
                    };

                case ( > 12 and <= 17, Gender.male):

                    add2Values = new int[] { 41, 41, 40, 40, 39, 39, 39, 38, 38, 37, 37 };

                    return negativeMoodAndPhysicalSymptoms switch
                    {
                        >= 0 and < 11 => 5 * negativeMoodAndPhysicalSymptoms 
                            + add2Values[negativeMoodAndPhysicalSymptoms],
                        >= 11 => 90,
                        _ => -999

                    };

                case ( >= 7 and <= 12, Gender.female):

                    add2Values = new int[] { 42, 42, 43, 43, 40, 40, 39, 39, 38, 38, 38 };

                    return negativeMoodAndPhysicalSymptoms switch
                    {
                        >= 0 and <= 3 => 4 * negativeMoodAndPhysicalSymptoms
                            + add2Values[negativeMoodAndPhysicalSymptoms],
                        > 3 and <= 10 => 5 * negativeMoodAndPhysicalSymptoms
                            + add2Values[negativeMoodAndPhysicalSymptoms],
                        > 10 => 90,
                        _ => -999
                    };

                case ( > 12 and <= 17, Gender.female):

                    return negativeMoodAndPhysicalSymptoms switch
                    {
                        0 or 1 => 3 * negativeMoodAndPhysicalSymptoms + 41,
                        >= 2 and < 8 => 3 * negativeMoodAndPhysicalSymptoms + 42,
                        >= 8 and < 13 => 3 * negativeMoodAndPhysicalSymptoms + 43,
                        >= 13 and < 16 => 3 * negativeMoodAndPhysicalSymptoms + 44,
                        >= 16 => 90,
                        _ => -999
                    };
                
                default: return -999;
                    
            }
        }

    }
}

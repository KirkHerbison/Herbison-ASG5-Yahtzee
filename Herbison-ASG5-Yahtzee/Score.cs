using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbison_ASG5_Yahtzee
{
    class Score
    {
        private int upperTotal;
        private int lowerTotal;
        private int bonus;
        private int gameTotal;

        public int UpperTotal { get => upperTotal; }
        public int LowerTotal { get => lowerTotal;}
        public int Bonus { get => bonus;}
        public int GameTotal { get => gameTotal;}

        public Score()
        {
            upperTotal = 0;
            lowerTotal = 0;
            bonus = 0;
            gameTotal = 0;
        }

        private void checkBonus()
        {
            if (upperTotal > 62 && bonus == 0)
            {
                bonus = 35;
                gameTotal += bonus;
            }
        }

        public int scoreOnes(int[] diceArray)
        {
            int score = 0;
            foreach(int dieValue in diceArray)
            {
                if (dieValue == 1)
                    score++;
            }
            upperTotal += score;
            gameTotal += score;
            checkBonus();
            return score;
        }
        public int scoreTwos(int[] diceArray)
        {
            int score = 0;
            foreach (int dieValue in diceArray)
            {
                if (dieValue == 2)
                    score += 2;
            }
            upperTotal += score;
            gameTotal += score;
            checkBonus();
            return score;
        }

        public int scoreThrees(int[] diceArray)
        {
            int score = 0;
            foreach (int dieValue in diceArray)
            {
                if (dieValue == 3)
                    score += 3;
            }
            upperTotal += score;
            gameTotal += score;
            checkBonus();
            return score;
        }

        public int scoreFours(int[] diceArray)
        {
            int score = 0;
            foreach (int dieValue in diceArray)
            {
                if (dieValue == 4)
                    score += 4;
            }
            upperTotal += score;
            gameTotal += score;
            checkBonus();
            return score;
        }

        public int scoreFives(int[] diceArray)
        {
            int score = 0;
            foreach (int dieValue in diceArray)
            {
                if (dieValue == 5)
                    score += 5;
            }
            upperTotal += score;
            gameTotal += score;
            checkBonus();
            return score;
        }

        public int scoreSixes(int[] diceArray)
        {
            int score = 0;
            foreach (int dieValue in diceArray)
            {
                if (dieValue == 6)
                    score += 6;
            }
            upperTotal += score;
            gameTotal += score;
            checkBonus();
            return score;
        }

        public int scoreChance(int[] diceArray)
        {
            int score = 0;
            foreach(int dieValue in diceArray)
            {
                score += dieValue;
            }
            lowerTotal += score;
            gameTotal += score;
            return score;
        }

        public int scoreYahtzee(int[] diceArray)
        {
            int score = 0;
            Array.Sort(diceArray);
            if (diceArray[0] == diceArray[4])
                score = 50;
            lowerTotal += score;
            gameTotal += score;
            return score;
        }

        public int scoreLargeStraight(int[] diceArray)
        {
            int score = 0;
            Array.Sort(diceArray);
            if (diceArray[0] == 1 && diceArray[1] == 2 && diceArray[2] == 3 && diceArray[3] == 4 && diceArray[4] == 5)
                score = 40;
            if (diceArray[0] == 2 && diceArray[1] == 3 && diceArray[2] == 4 && diceArray[3] == 5 && diceArray[4] == 6)
                score = 40;
            lowerTotal += score;
            gameTotal += score;
            return score;
        }

        public int scoreFourOfAKind(int[] diceArray)
        {
            int score = 0;
            bool fourOfAKind = false;
            Array.Sort(diceArray);

            for (int i = 1; i < 7; i++)
            {
                int count = 0;
                foreach (int dieValue in diceArray)
                {
                    if (dieValue == i)
                        count++;
                    if (count == 4)
                        fourOfAKind = true;
                }
            }
            if (fourOfAKind)
            {
                foreach (int dieValue in diceArray)
                {
                    score += dieValue;
                }
            }
            lowerTotal += score;
            gameTotal += score;
            return score;
        }

        public int scoreThreeOfAKind(int[] diceArray)
        {
            int score = 0;
            bool threeOfAKind = false;
            Array.Sort(diceArray);

            for (int i = 1; i < 7; i++)
            {
                int count = 0;
                foreach (int dieValue in diceArray)
                {
                    if (dieValue == i)
                        count++;
                    if (count == 3)
                        threeOfAKind = true;
                }
            }
            if (threeOfAKind)
            {
                foreach (int dieValue in diceArray)
                {
                    score += dieValue;
                }
            }
            lowerTotal += score;
            gameTotal += score;
            return score;
        }

        public int scoreSmallStraight(int[] diceArray)
        {
            int score = 0;
            Array.Sort(diceArray);

            //1 x 2 3 4
            //x 1 2 3 4
            //1 2 3 4 x
            //1 2 x 3 4
            //1 2 3 x 4
            for (int i = 1; i < 4; i++)
            {
                if (diceArray[0] == (i) && diceArray[2] == (i + 1) && diceArray[3] == (i + 2) && diceArray[4] == (i + 3)
                    || diceArray[1] == (i) && diceArray[2] == (i + 1) && diceArray[3] == (i + 2) && diceArray[4] == (i + 3)
                    || diceArray[0] == (i) && diceArray[1] == (i + 1) && diceArray[2] == (i + 2) && diceArray[3] == (i + 3)
                    || diceArray[0] == (i) && diceArray[1] == (i + 1) && diceArray[3] == (i + 2) && diceArray[4] == (i + 3)
                    || diceArray[0] == (i) && diceArray[1] == (i + 1) && diceArray[2] == (i + 2) && diceArray[4] == (i + 3))
                    score = 30;
            }
            lowerTotal += score;
            gameTotal += score;
            return score;
        }

        public int scoreFullHouse(int[] diceArray)
        {
            int score = 0;
            bool threeOfAKind = false;
            bool twoOfAKind = false;
            int threeOfAKindValue = 0;
            Array.Sort(diceArray);

            for (int i = 1; i < 7; i++)
            {
                int count = 0;
                foreach (int dieValue in diceArray)
                {
                    if (dieValue == i)
                        count ++;
                    if (count == 3)
                    {
                        threeOfAKindValue = i;
                        threeOfAKind = true;
                    }
                }
                int countTwoOfAKind = 0;
                if (threeOfAKindValue != i)
                {
                    foreach (int dieValue in diceArray)
                    {
                        if (dieValue == i)
                            countTwoOfAKind++;
                        if (count == 2)
                            twoOfAKind = true;
                    }
                }
            }

            if (threeOfAKind && twoOfAKind)
                score = 25;

            lowerTotal += score;
            gameTotal += score;
            return score;
        }
    }
}

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
    }
}

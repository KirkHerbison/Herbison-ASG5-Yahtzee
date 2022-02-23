using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herbison_ASG5_Yahtzee
{
    public partial class Form1 : Form
    {
        Hand hand = new Hand();
        Score score = new Score();
        List<String> holdList = new List<String>();
        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void resetGame()
        {
            score = new Score();
            displayScore();
            resetDiceImages();
            resetHoldList();
            resetTextBoxes();
            disableSetButtons();
            buttonRoll.Enabled = true;
        }

        private void displayScore()
        {
            labelUpperTotal.Text = score.UpperTotal.ToString();
            labelBonus.Text = score.Bonus.ToString();
            labelLowerTotal.Text = score.LowerTotal.ToString();
            labelGameTotal.Text = score.GameTotal.ToString();
        }

        private void resetDiceImages()
        {
            pictureBoxDie1.Image = imageListDice.Images[0];
            pictureBoxDie2.Image = imageListDice.Images[0];
            pictureBoxDie3.Image = imageListDice.Images[0];
            pictureBoxDie4.Image = imageListDice.Images[0];
            pictureBoxDie5.Image = imageListDice.Images[0];
        }

        private void displayDiceRoll()
        {
            int[] dieArray = hand.getDieArray();
            pictureBoxDie1.Image = imageListDice.Images[dieArray[0]];
            pictureBoxDie2.Image = imageListDice.Images[dieArray[1]];
            pictureBoxDie3.Image = imageListDice.Images[dieArray[2]];
            pictureBoxDie4.Image = imageListDice.Images[dieArray[3]];
            pictureBoxDie5.Image = imageListDice.Images[dieArray[4]];
        }

        private void resetHoldList()
        {
            holdList.Clear();
            holdList.Add("");
            holdList.Add("");
            holdList.Add("");
            holdList.Add("");
            holdList.Add("");
            labelDie1Hold.Text = holdList[0];
            labelDie2Hold.Text = holdList[1];
            labelDie3Hold.Text = holdList[2];
            labelDie4Hold.Text = holdList[3];
            labelDie5Hold.Text = holdList[4];
        }

        private void displayValue()
        {
            int[] dieArray = hand.getDieArray();
            label1.Text = dieArray[0].ToString();
            label2.Text = dieArray[1].ToString();
            label3.Text = dieArray[2].ToString();
            label4.Text = dieArray[3].ToString();
            label5.Text = dieArray[4].ToString();
        }

        private void enableSetButtons()
        {
            if (textBoxScoreOnes.Text == "")
                buttonSetOnes.Enabled = true;
            if (textBoxScoreTwos.Text == "")
                buttonSetTwos.Enabled = true;
            if (textBoxScoreThrees.Text == "")
                buttonSetThrees.Enabled = true;
            if (textBoxScoreFours.Text == "")
                buttonSetFours.Enabled = true;
            if(textBoxScoreFives.Text == "")
                buttonSetFives.Enabled = true;
            if (textBoxScoreSixes.Text == "")
                buttonSetSixes.Enabled = true;
            if (textBoxScoreThreeOfAKind.Text == "")
                buttonSetThreeOfAKind.Enabled = true;
            if (textBoxScoreFourOfAKind.Text == "")
                buttonSetFourOfAKind.Enabled = true;
            if (textBoxScoreFullHouse.Text == "")
                buttonSetFullHouse.Enabled = true;
            if (textBoxScoreSmallStraight.Text == "")
                buttonSetSmallStraight.Enabled = true;
            if (textBoxScoreLargeStraight.Text == "")
                buttonSetLargeStraight.Enabled = true;
            if(textBoxScoreYahtzee.Text == "")
                buttonSetYahtzee.Enabled = true;
            if (textBoxScoreChance.Text == "")
                buttonSetChance.Enabled = true;
        }

        private void disableSetButtons()
        {
            buttonSetOnes.Enabled = false;
            buttonSetTwos.Enabled = false;
            buttonSetThrees.Enabled = false;
            buttonSetFours.Enabled = false;
            buttonSetFives.Enabled = false;
            buttonSetSixes.Enabled = false;
            buttonSetThreeOfAKind.Enabled = false;
            buttonSetFourOfAKind.Enabled = false;
            buttonSetFullHouse.Enabled = false;
            buttonSetSmallStraight.Enabled = false;
            buttonSetLargeStraight.Enabled = false;
            buttonSetYahtzee.Enabled = false;
            buttonSetChance.Enabled = false;
        }

        private void resetTextBoxes()
        {
            textBoxScoreOnes.Text = "";
            textBoxScoreTwos.Text = "";
            textBoxScoreThrees.Text = "";
            textBoxScoreFours.Text = "";
            textBoxScoreFives.Text = "";
            textBoxScoreSixes.Text = "";
            textBoxScoreThreeOfAKind.Text = "";
            textBoxScoreFourOfAKind.Text = "";
            textBoxScoreFullHouse.Text = "";
            textBoxScoreSmallStraight.Text = "";
            textBoxScoreLargeStraight.Text = "";
            textBoxScoreYahtzee.Text = "";
            textBoxScoreChance.Text = "";
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            hand.rollDice(holdList);
            displayDiceRoll();
            enableSetButtons();
            displayValue();
        }

        private void pictureBoxDie1_Click(object sender, EventArgs e)
        {
            if (labelDie1Hold.Text == "")
                labelDie1Hold.Text = "Hold";
            else
                labelDie1Hold.Text = "";
            holdList[0] = labelDie1Hold.Text;
        }

        private void pictureBoxDie2_Click(object sender, EventArgs e)
        {
            if (labelDie2Hold.Text == "")
                labelDie2Hold.Text = "Hold";
            else
                labelDie2Hold.Text = "";
            holdList[1] = labelDie2Hold.Text;
        }

        private void pictureBoxDie3_Click(object sender, EventArgs e)
        {
            if (labelDie3Hold.Text == "")
                labelDie3Hold.Text = "Hold";
            else
                labelDie3Hold.Text = "";
            holdList[2] = labelDie3Hold.Text;
        }

        private void pictureBoxDie4_Click(object sender, EventArgs e)
        {
            if (labelDie4Hold.Text == "")
                labelDie4Hold.Text = "Hold";
            else
                labelDie4Hold.Text = "";
            holdList[3] = labelDie4Hold.Text;
        }

        private void pictureBoxDie5_Click(object sender, EventArgs e)
        {
            if (labelDie5Hold.Text == "")
                labelDie5Hold.Text = "Hold";
            else
                labelDie5Hold.Text = "";
            holdList[4] = labelDie5Hold.Text;
        }

        private void buttonSetOnes_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreOnes = score.scoreOnes(dieArray);
            textBoxScoreOnes.Text = scoreOnes.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void buttonSetTwos_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreTwos = score.scoreTwos(dieArray);
            textBoxScoreTwos.Text = scoreTwos.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }

        private void buttonSetThrees_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreThrees = score.scoreThrees(dieArray);
            textBoxScoreThrees.Text = scoreThrees.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }

        private void buttonSetFours_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreFours = score.scoreFours(dieArray);
            textBoxScoreFours.Text = scoreFours.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }

        private void buttonSetFives_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreFives = score.scoreFives(dieArray);
            textBoxScoreFives.Text = scoreFives.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }

        private void buttonSetSixes_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreSixes = score.scoreSixes(dieArray);
            textBoxScoreSixes.Text = scoreSixes.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }

        private void buttonSetChance_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreChance = score.scoreChance(dieArray);
            textBoxScoreChance.Text = scoreChance.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }

        private void buttonSetYahtzee_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreYhatzee = score.scoreYahtzee(dieArray);
            textBoxScoreYahtzee.Text = scoreYhatzee.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }

        private void buttonSetLargeStraight_Click(object sender, EventArgs e)
        {
            int[] dieArray = hand.getDieArray();
            int scoreLargeStraight = score.scoreLargeStraight(dieArray);
            textBoxScoreLargeStraight.Text = scoreLargeStraight.ToString();
            buttonRoll.Enabled = true;
            disableSetButtons();
            displayScore();
            resetHoldList();
        }
    }
}

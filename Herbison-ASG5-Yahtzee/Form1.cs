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
        Die die1 = new Die();
        Die die2 = new Die();
        Die die3 = new Die();
        Die die4 = new Die();
        Die die5 = new Die();
        Hand hand = new Hand();
        List<String> holdList = new List<String>();
        public Form1()
        {
            InitializeComponent();
            resetDiceImages();
            resetHoldList();
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

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            hand.rollDice(holdList);
            displayDiceRoll();
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
    }
}

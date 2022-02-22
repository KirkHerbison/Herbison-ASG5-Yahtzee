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
        public Form1()
        {
            InitializeComponent();
            resetDiceImages();
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
            pictureBoxDie1.Image = imageListDice.Images[die1.Value];
            pictureBoxDie2.Image = imageListDice.Images[die2.Value];
            pictureBoxDie3.Image = imageListDice.Images[die3.Value];
            pictureBoxDie4.Image = imageListDice.Images[die4.Value];
            pictureBoxDie5.Image = imageListDice.Images[die5.Value];
        }

        private void displayDiceValue()
        {
            labelDie1Hold.Text = die1.Value.ToString();
            labelDie2Hold.Text = die2.Value.ToString();
            labelDie3Hold.Text = die3.Value.ToString();
            labelDie4Hold.Text = die4.Value.ToString();
            labelDie5Hold.Text = die5.Value.ToString();
        }

        private void rollDice()
        {
            die1.roll();
            die2.roll();
            die3.roll();
            die4.roll();
            die5.roll();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            rollDice();
            displayDiceRoll();
            displayDiceValue();
        }

        private void pictureBoxDie1_Click(object sender, EventArgs e)
        {
            if (labelDie1Hold.Text == "")
                labelDie1Hold.Text = "Hold";
            else
                labelDie1Hold.Text = "";
        }

        private void pictureBoxDie2_Click(object sender, EventArgs e)
        {
            if (labelDie2Hold.Text == "")
                labelDie2Hold.Text = "Hold";
            else
                labelDie2Hold.Text = "";
        }

        private void pictureBoxDie3_Click(object sender, EventArgs e)
        {
            if (labelDie3Hold.Text == "")
                labelDie3Hold.Text = "Hold";
            else
                labelDie3Hold.Text = "";
        }

        private void pictureBoxDie4_Click(object sender, EventArgs e)
        {
            if (labelDie4Hold.Text == "")
                labelDie4Hold.Text = "Hold";
            else
                labelDie4Hold.Text = "";
        }

        private void pictureBoxDie5_Click(object sender, EventArgs e)
        {
            if (labelDie5Hold.Text == "")
                labelDie5Hold.Text = "Hold";
            else
                labelDie5Hold.Text = "";
        }
    }
}

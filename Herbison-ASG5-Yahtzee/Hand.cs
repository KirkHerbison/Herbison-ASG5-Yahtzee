using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herbison_ASG5_Yahtzee
{

    class Hand
    {
        private List<Die> diceList = new List<Die>();

        public Hand()
        {
            resetHand();
        }

        private void resetHand()
        {
            diceList.Clear();
            for(int i = 0; i<5; i++)
            {
                Die die = new Die();
                diceList.Add(die);
            }
        }

        public void rollDice(List<String> holdList)
        {
            int i = 0;
            foreach (Die die in diceList)
            {
                if(holdList[i] == "")
                    die.roll();
                i++;
            }
        }

        public int [] getDieArray()
        {

            int[] dieArray = new int[5];
            for (int i = 0; i < diceList.Count; i++)
            {
                dieArray[i] = diceList[i].Value;
            }
            return dieArray;
        }
    }
}

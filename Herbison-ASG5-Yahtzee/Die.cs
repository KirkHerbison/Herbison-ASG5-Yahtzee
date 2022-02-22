using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbison_ASG5_Yahtzee
{
    class Die
    {

        public int Value { get; set; }

        public void roll()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber = random.Next(1, 7);
            Value = randomNumber;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

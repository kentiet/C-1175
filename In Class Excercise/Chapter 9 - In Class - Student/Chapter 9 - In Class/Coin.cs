using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9___In_Class
{
    class Coin_Toss
    {
        private string sideuUp;
        Random rand = new Random();

        public Coin_Toss()
        {
            sideuUp = "Head";
        }

        public string Toss()
        {
            if (rand.Next(2) == 0)
                sideuUp = "Head";
            else
                sideuUp = "Tails";
            return sideuUp;
        }

        public string GetSideUp()
        {
            return sideuUp;
        }
    }
}

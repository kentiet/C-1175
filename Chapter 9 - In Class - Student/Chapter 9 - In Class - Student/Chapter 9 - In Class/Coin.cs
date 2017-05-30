using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9___In_Class
{
    class Coin_Toss
    {
        private string sideUp;                      // Field to represent the side facing up;
        Random rand = new Random();

        public Coin_Toss()                          // Constructor
        {
            sideUp = "Heads";
        }

        public string Toss()                          // The toss method simulates tossing the coin.
        {       
            if (rand.Next(2) == 0)                  // Use a random number to determine// the side of the coin is facing up.// 0 = Heads, 1 = Tails
                sideUp = "Heads";
            else
                sideUp = "Tails";
            return sideUp;
        }
        
        public string GetSideUp()                   // The GetSideUp method returns the value// of the sideUp field.
        {
            return sideUp;
        }
    }
}

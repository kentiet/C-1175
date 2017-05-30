using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4___Kiet_Tiet
{
    class Coin
    {
        public string coinSide;      //Side of coin
        Random rand = new Random();
        public Coin()             //Contructor
        {
            coinSide = "Heads";
        }

        public string Flip()    //Flip coin method
        {
            int num;
            num = rand.Next(2);

            if (num == 0)
                coinSide = "Heads";
            else
                coinSide = "Tails";

            return coinSide;
        }
        
        public string GetSide()
        {
            return coinSide;
        }
    }
}

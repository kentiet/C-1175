using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9___In_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {

            Coin_Toss myCoin = new Coin_Toss();                 // Create a Coin object.

            outputListBox.Items.Clear();                        // Clear the ListBox.

            for (int count = 0; count < 5; count++)             // Toss the coin five times.
            {
                myCoin.Toss();                                  // Toss the coin.             
                outputListBox.Items.Add(myCoin.GetSideUp());    // Display the side that is up.
            }
        }
    }
}

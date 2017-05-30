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

        // ===================== 9-1 Coin Toss Class =====================================================
        private void tossButton_Click(object sender, EventArgs e)
        {
            Coin_Toss myCoin = new Coin_Toss();
            outputListBox.Items.Clear();
            for (int count = 0; count < 5; count++)
            {
                myCoin.Toss();
                outputListBox.Items.Add(myCoin.GetSideUp());
            }
        }
        // ===================== 9-2 Cell Phone Class =====================================================
        

        // ====================== 9-3 Bank Account Class ==================================================



        // ====================== 9-4 Cell Phone Class - Inventory II =====================================



        // ====================== Exit ====================================================================
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone  = new CellPhone();
            GetPhoneData(myPhone);

            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }

        private void GetPhoneData(CellPhone myPhone)
        {
            decimal price = 0m;
            myPhone.Brand = brandTextBox.Text;
            myPhone.Model = modelTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out price))
                myPhone.Price = price;
            else
                MessageBox.Show("Invalid price");
        }
    }
}

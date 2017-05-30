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

        #region ===================== 9-1 Coin Toss Class =====================================================

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

        #endregion

        #region ===================== 9-2 Cell Phone Class =====================================================

        private void createObjectButton_Click_1(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();                // Create a CellPhone object.

            GetPhoneData(myPhone);                              // Get the phone data.

            brandLabel.Text = myPhone.Brand;                    // Display the phone data.
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }

        private void GetPhoneData(CellPhone myPhone)
        {
            decimal price;                                      // Temporary variable to hold the price.           
            myPhone.Brand = brandTextBox.Text;                  // Get the phone's brand.          
            myPhone.Model = modelTextBox.Text;                  // Get the phone's model.           
            if (decimal.TryParse(priceTextBox.Text, out price)) // Get the phone's price.
                myPhone.Price = price;
            else
                MessageBox.Show("Invalid price");               // Display an error message.
        }

        #endregion

        #region ====================== 9-3 Bank Account Class ==================================================

        private BankAccount account = new BankAccount(1000);        // BankAccount field with a $1000 starting balance 

        private void depositButton_Click_1(object sender, EventArgs e)
        {
            decimal amount;                                         // To hold the amount of deposit           
            if (decimal.TryParse(depositTextBox.Text, out amount))  // Convert the amount to a decimal.
            {
                account.Deposit(amount);                            // Deposit the amount into the account.                
                balanceLabel.Text = account.Balance.ToString("c");  // Display the new balance.                
                depositTextBox.Clear();                             // Clear the text box.
            }
            else
            {
                MessageBox.Show("Invalid amount");                  // Display an error message.
            }
        }

        private void withdrawButton_Click_1(object sender, EventArgs e)
        {
            decimal amount;                                         // To hold the amount of withdrawal           
            if (decimal.TryParse(withdrawTextBox.Text, out amount)) // Convert the amount to a decimal.
            {
                account.Withdraw(amount);                           // Withdraw the amount from the account.                
                balanceLabel.Text = account.Balance.ToString("c");  // Display the new balance.               
                withdrawTextBox.Clear();                            // Clear the text box.
            }
            else
            {
                MessageBox.Show("Invalid amount");                  // Display an error message.
            }
        }

        #endregion

        #region ====================== 9-4 Cell Phone Class - Inventory II =====================================

        List<CellPhone> phoneList = new List<CellPhone>();          // List to hold CellPhone objects

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();                    // Create a CellPhone object.

            GetPhoneData2(myPhone);                                 // Get the phone data.            
            phoneList.Add(myPhone);                                 // Add the CellPhone object to the List.            
            phoneListBox2.Items.Add(myPhone.Brand + " " +            // Add an entry to the list box.
                                   myPhone.Model);

            brandTextBox2.Clear();                                   // Clear the TextBox controls.
            modelTextBox2.Clear();
            priceTextBox2.Clear();
            brandTextBox2.Focus();                                   // Reset the focus.
        }

        private void phoneListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox2.SelectedIndex;                 // Get the index of the selected item.           
            MessageBox.Show(phoneList[index].Price.ToString("c"));  // Display the selected item's price.
        }

        private void GetPhoneData2(CellPhone myPhone)
        {
            decimal price;                                      // Temporary variable to hold the price.           
            myPhone.Brand = brandTextBox2.Text;                  // Get the phone's brand.          
            myPhone.Model = modelTextBox2.Text;                  // Get the phone's model.           
            if (decimal.TryParse(priceTextBox2.Text, out price)) // Get the phone's price.
                myPhone.Price = price;
            else
                MessageBox.Show("Invalid price");               // Display an error message.
        }
        #endregion

        #region ====================== About Box Form ============================+++++=======================

        private void aboutButton_Click_1(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        #endregion

        #region ====================== Exit ====================================================================

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}

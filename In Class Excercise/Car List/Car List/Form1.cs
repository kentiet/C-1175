using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }

    public partial class Form1 : Form
    {
       
        private List<Automobile> carList = new List<Automobile>();  //creates a list for Automobiles 

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {           
            Automobile car = new Automobile();                  // Create an instance of the Automobile structure.        
            GetData(ref car);                                   // Get the data entered by the user.          
            carList.Add(car);                                   // Add the car object to the List.           
            makeTextBox.Clear();                                // Clear the TextBoxes.
            yearTextBox.Clear();
            mileageTextBox.Clear();            
            makeTextBox.Focus();                                // Reset the focus.
        }

        private void GetData(ref Automobile car)
        {
            try
            {
                car.make = makeTextBox.Text;                   // Get the data from the TextBoxes.
                car.year = int.Parse(yearTextBox.Text);
                car.mileage = double.Parse(mileageTextBox.Text);
            }
            catch (Exception ex)
            {               
                MessageBox.Show(ex.Message);                    // Display the exception message.
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string output;                                      // Declare a string to hold a line of output.            
            carListBox.Items.Clear();                           // Clear the ListBox's current contents.            
            foreach (Automobile aCar in carList)                // Display the car info in the ListBox.
            {               
                output = aCar.year + " " + aCar.make +          // Make a line of output.
                    " with " + aCar.mileage + " miles.";               
                carListBox.Items.Add(output);                   // Add the line of output to the ListBox.
            }
        }

    }
}

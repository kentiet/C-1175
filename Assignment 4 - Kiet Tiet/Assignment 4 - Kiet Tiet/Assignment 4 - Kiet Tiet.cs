using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Name: Kiet Tiet 
// Version: 1.0
// Date: 22/11/2016
// This application is intended to modify the Assignment 4
namespace Assignment_4___Kiet_Tiet
{
    public partial class Assigment4Form : Form
    {
        // Field Scope
        List<string> nameList = new List<string>();               // List of players' names
        List<Car> carList = new List<Car>();                        // List of car for Car Inventory
        List<CellPhone> phoneList = new List<CellPhone>(); // List of phone data
        List<PhoneBook> phoneContacts = new List<PhoneBook>(); // List of contacts

        List<Automotive> CustomerList = new List<Automotive>();       // List of customer info
        List<Automotive> CustomerCarList = new List<Automotive>();  // List of customer's car
        List<Automotive> ChargesList = new List<Automotive>();          // List of service charges

        decimal begBalance;                      // beginning balance of bank account
        char dollarSign = '$';                       // '$" delimiter for calculate bank account
        BankAccount myAccount;                  // instance of BankAccount class

        public Assigment4Form()
        {
            InitializeComponent();
            
            // Assign the bank account beginning balance
            decimal.TryParse(BalanceResult.Text.TrimStart(dollarSign), out begBalance);

            // Create myAccount object with the given balance
            myAccount = new BankAccount(begBalance);
        }

        #region ============ PLAYERS ==================
        private void AddPlayersNameButton_Click(object sender, EventArgs e)
        {
            PlayersNameListBox.Items.Clear();            // Clear out the listbox for next use
            AddName(nameList);                              // Add name into list by using AddName method
            NameInputTextBox.Clear();                     // Clear the textbox for users to type the next player
            PlayersNameListBox.SelectedIndex = 0;   // Set the default listbox selection at the first name
        }

        private void AddName(List<string> nameList)
        {
            string name = NameInputTextBox.Text;                   //Get the input name

            nameList.Add(name);

            foreach (string player in nameList)
                PlayersNameListBox.Items.Add(player);       // Display the players' names
        }

        private void SortPlayersNameButton_Click(object sender, EventArgs e)
        {
            SortName(nameList);                                 // Sort name wih SortName method

            PlayersNameListBox.Items.Clear();               // Clear out the unsorted list

            foreach (string player in nameList)
            {
                PlayersNameListBox.Items.Add(player);  // Add the new sorted name in the list
            }
            PlayersNameListBox.SelectedIndex = 0;
        }

        private void SortName(List<string> nameList)
        {
            nameList.Sort();        // Sort name in the list
        }

        private void RemovePlayersNameButton_Click(object sender, EventArgs e)
        {
            RemoveName(nameList);    // Remove name in the list 
            //PlayersNameListBox.SelectedIndex = 0;  // Set the first new name in the default selection
        }

        private void RemoveName(List<string> nameList)
        {
            if (PlayersNameListBox.SelectedIndex != -1)
            {
                int selected = PlayersNameListBox.SelectedIndex;        // get user's selection

                nameList.RemoveAt(selected);                              // Remove name at the selection
                PlayersNameListBox.Items.Clear();

                foreach (string player in nameList)                         // Display the new list
                {
                    PlayersNameListBox.Items.Add(player);
                }
            }
        }
        #endregion

        #region ============== STRING MANIPULATION ====================
        private void SearchButton_Click(object sender, EventArgs e)
        {
            char input = GetInputChar();                      // Get the char from the user's input
            string givenString = GivenString.Text;          // Assign the given string 
            int count = 0;
            foreach (char letter in givenString)                // Loops through the string to find out the same char
            {
                if (input == letter)
                    count++;
            }
            
            // Display the result
            if (count >= 1)
                SearchCharOutput.Text = "Found " + count + " character !";
            else
                SearchCharOutput.Text = "Not Found!";
        }

        private char GetInputChar()
        {
            string input = SearchCharInput.Text;            // Get the input from users
            char inputChar = input[0];                          // Convert the input into Char value

            return inputChar;                                       // Return the char value
        }
        #endregion

        #region =========== PASSWORD ==============
        private void CheckPasswordButton_Click(object sender, EventArgs e)
        {
            string password = GetPassword();     // Get the input from user

            // Applying the modualizing method below
            Check6Char(password);
            CheckFirstLetter(password);
            CheckLastDigit(password);
            CheckHaveDigit(password);
            HaveCapital(password);
            HaveSpace(password);
            NumChar(password);
            NumDigit(password);

            PassSecure();    // check the password strength
        }

        private void PassSecure()
        {
            // Get the background color of each output boxes
            Color backGreenColor = Color.MediumSpringGreen;
            Color backSixChar = SixCharOutput.BackColor;
            Color backFirstChar = FirstLetterOutput.BackColor; ;
            Color backLastChar = LastDigitOutput.BackColor;
            Color bachHaveDigit = HaveDigitOutput.BackColor;
            Color backHaveCapital = CapitalOutput.BackColor;
            Color backHaveSpace = SpacesOutput.BackColor;

            // Set the condition based on the colors to determin the password's strength
            if ((backSixChar == backGreenColor) && (backFirstChar == backGreenColor) && (backLastChar == backGreenColor) &&
                (bachHaveDigit == backGreenColor) && (backHaveCapital == backGreenColor) && (backHaveSpace == Color.Thistle))
                PasswordStrength.Text = "Strong";
            else
                PasswordStrength.Text = "Weak";
        }

        private string GetPassword()
        {
            string password = PasswordInputTextBox.Text; //Get the password input from user

            return password;
        }

        private void Check6Char(string password)
        {
            try
            {
                int count = 0;                              // Initialize a count variable to count the char
                foreach (char a in password)        // Loops the input string and count the char
                    count++;

                if (count >= 6)                              // Condition to check the password met the requirement
                {
                    SixCharOutput.Text = count.ToString();
                    SixCharOutput.BackColor = Color.MediumSpringGreen;  // Change to green color if the password in valid

                }
                else
                {
                    SixCharOutput.Text = count.ToString();
                    SixCharOutput.BackColor = Color.Thistle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckFirstLetter(string password)     // Method to check whether the first char is letter
        {
            try
            {
                char firstLetter;
                firstLetter = password[0];
                FirstLetterOutput.Text = firstLetter.ToString();

                if (char.IsLetter(password[0]))
                {
                    FirstLetterOutput.BackColor = Color.MediumSpringGreen;
                }
                else
                {
                    FirstLetterOutput.BackColor = Color.Thistle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckLastDigit(string password)    // Method to check the last char is digit
        {
            try
            {
                int count = 0;

                foreach (char a in password)
                    count++;

                if (char.IsDigit(password[count - 1]))
                {
                    LastDigitOutput.Text = "Yes";
                    LastDigitOutput.BackColor = Color.MediumSpringGreen;
                }
                else
                {
                    LastDigitOutput.Text = "No";
                    LastDigitOutput.BackColor = Color.Thistle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckHaveDigit(string password)     // Method to loop through the input the check whether have at leat 1 digit
        {
            try
            {
                int digitCount = 0; // declare and initializ the variabke to count for the digit

                foreach (char a in password)
                {
                    if (char.IsDigit(a))
                        digitCount++;
                }

                if (digitCount != 0)
                {
                    HaveDigitOutput.Text = "Yes";
                    HaveDigitOutput.BackColor = Color.MediumSpringGreen;
                }
                else
                {
                    HaveDigitOutput.Text = "No";
                    HaveDigitOutput.BackColor = Color.Thistle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HaveCapital(string password)      // Method to loop through the input the check whether have at leat 1 captital letter
        {
            try
            {
                int capCount = 0; //declare and intialize the variable for counting the capital letter

                foreach (char a in password)
                {
                    if (char.IsUpper(a))
                        capCount++;
                }

                if (capCount != 0)
                {
                    CapitalOutput.Text = "Yes";
                    CapitalOutput.BackColor = Color.MediumSpringGreen;
                }
                else
                {
                    CapitalOutput.Text = "No";
                    CapitalOutput.BackColor = Color.Thistle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HaveSpace(string password)       // Method to check for spaces in password
        {
            try
            {
                int spaceCount = 0;   // declare variable for counting spaces
                foreach (char a in password)
                {
                    if (char.IsWhiteSpace(a))
                        spaceCount++;
                }

                if (spaceCount != 0)     // If the string has spaces, the background color of the box turn red --> unsecure
                {
                    SpacesOutput.Text = "Yes";
                    SpacesOutput.BackColor = Color.OrangeRed;
                }
                else
                {
                    SpacesOutput.Text = "No";
                    SpacesOutput.BackColor = Color.Thistle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumChar(string password)      //Method to calcute the total number of character excluse spaces
        {
            try
            {
                int spaceCount = 0;
                foreach (char a in password)
                {
                    if (char.IsWhiteSpace(a))          // count for spaces
                        spaceCount++;
                }

                int count = 0;
                foreach (char a in password)
                    count++;
                NumberCharOutput.Text = (count - spaceCount).ToString();   //result excludes the spaces
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumDigit(string password)     //Method for counting the total number of digit 
        {
            try
            {
                int count = 0;
                foreach (char a in password)
                {
                    if (char.IsDigit(a))
                        count++;
                }
                NumberDigitOutput.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ========= STUDENT AVERAGE SCORE =============
        private void CSVFileButton_Click(object sender, EventArgs e)
        {
            StudentCSVListBox.Items.Clear();
            ReadFile();
        }

        private void ReadFile()    // Read the selected file
        {
            StreamReader inputFile;
            try
            {
                double average;
                char delimimeter = ',';
                int studentCount = 0;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFile.FileName);   //open file with user's selection

                    string[] lines;  // string array to store values in each lines
                    while (!inputFile.EndOfStream)
                    {
                        List<int> scoresList = new List<int>();     //create the score list to store the score of each student

                        lines = inputFile.ReadLine().Split(delimimeter);  // tokenizing the value with the delimimeter

                        int number;
                        for (int i = 0;  i < lines.Length; i++)
                        {
                            number = int.Parse(lines[i]);  // Parse the string value into int
                            scoresList.Add(number);      // add value into list
                        }
                        studentCount++;          // the  counter for number of student

                        average = Average(scoresList);   // calculate the average score 

                        StudentCSVListBox.Items.Add("The student " + studentCount + " average score is: " + average.ToString("n2"));    // output the result
                    }
                }
            }
            catch (Exception ex) //catch exception
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double Average(List<int> scoresList)    //Method for calculating the average
        {
            int count = 0;
            int accumulator = 0;     
            double average;
            foreach(int score in scoresList)
            {
                count++;
                accumulator += score;
            }
            average = accumulator / (double)count;
            return average;
        }
        #endregion

        #region ======= CAR INVENTORY ================
        struct Car            // create struct for Car
        {
            public string brand;
            public int year;
            public string mileage;
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            CarListBox.Items.Clear();
            LoadToCarList();

            //Output by looping for each car in the car list
            foreach (Car car in carList)
            {
                CarListBox.Items.Add(car.brand + " " + car.year + " with " + car.mileage + " miles");
            }
        }

        private void GetCar(ref Car car)                 // Method to get the input for user
        {
            int year;
            int.TryParse(CarYearComboBox.SelectedItem.ToString(), out year);       // tryparse the selection of year from the combox box
            //Assign the user's selections on brand, year, milages
            car.brand = CarBrandComboBox.SelectedItem.ToString();                  
            car.year = year;
            car.mileage = CarMileageComboBox.SelectedItem.ToString();
        }

        private void LoadToCarList()        //Method to add the object of car in the Car list
        {
            Car car = new Car();

            GetCar(ref car);
            carList.Add(car);
        }
        #endregion

        #region ======== CONTACTS LIST =============
        struct PhoneBook              // Create the PhoneBook struct to hold name, phone and email for each object
        {
            public string name;
            public string phoneNumber;
            public string email;
        }
        private void ReadPhoneList()
        {
            StreamReader inputFile;
            string lineContact;
            char[] delim = { ',' };
            inputFile = File.OpenText("PhoneList.txt");
            while(!inputFile.EndOfStream)
            {
                lineContact = inputFile.ReadLine();

                string[] tokens = lineContact.Split(delim);      // tokenizing each lines and load the value in the an arrays

                PhoneBook contact = new PhoneBook();      // instantiate the contact object

                contact.name = tokens[0];                           // assign the tokened value into name and phone number
                contact.phoneNumber = tokens[1];

                phoneContacts.Add(contact);                      // add the PhoneBook object into the phone contact list
            }
        }

        private void DisplayContacts()
        {
            foreach (PhoneBook contact in phoneContacts)
            {
                ContactListBox.Items.Add(contact.name);                 // Display names in the list box
            }
        }

        private void Assigment4Form_Load(object sender, EventArgs e)         //Form load method
        {
            ReadPhoneList();
            DisplayContacts();
        }

        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e) //Method to get phone and email by index changed
        {
            int index = ContactListBox.SelectedIndex;     // the selected index from users
            string name = phoneContacts[index].name;
            char space = ' ';
            string lastName = "";
            for (int i = 0; i < name.Length; i++)
            {
               if (name[i] == space)
                   lastName = name.Substring(i+1);   //subtring the last name from full name
            }
            PhoneNumberOutput.Text = phoneContacts[index].phoneNumber;    //display phone number 
            EmailOutput.Text = lastName +"_" + name[0] + "@douglas.bc.ca";   // create and display email based on the lastname and first char of first name
        }
        #endregion

        /****************************************
        *                          PART B                              *
        ****************************************/

        #region ======= COIN TOSS =============
        private void TossButton_Click(object sender, EventArgs e)
        {
            CoinListBox.Items.Clear();   //Clear the list for next use
            Coin myCoin = new Coin();  // create a Coin object
            int headCount = 0, tailCount = 0;  //declare variable for counting heads and tails
            for (int i = 0; i < 27; i++)
            {
                myCoin.Flip();        //Flip coin by flip method
                CoinListBox.Items.Add(myCoin.GetSide());     //Get coin's side and add to listbox
                //Counter for heads and tails
                if (myCoin.GetSide() == "Heads")
                    headCount++;
                else
                    tailCount++;
            }

            //Output the counter times
            HeadOutput.Text = headCount.ToString();
            TailsOutput.Text = tailCount.ToString();
        }
        #endregion

        #region ======= CELL PHONE - CLASS ==============
        private void CreateObjectButton_Click(object sender, EventArgs e)
        {
            ObjectDataListBox.Items.Clear();  // Clear the list for next use

            CellPhone myPhone = new CellPhone();    // Create an instance of cell phone class
            GetPhone(myPhone);
            phoneList.Add(GetPhone(myPhone));       // Add phone in the phone list

            PhoneBrandOut.Text = myPhone.GetBrand();    // Get phone brand
            PhoneModelOut.Text = myPhone.GetModel();   // Get phone model
            PhonePriceOut.Text = myPhone.GetPrice().ToString("c");    //Get Phone price

            LoadPhoneList(phoneList);    //Display phones into list
        }

        private CellPhone GetPhone(CellPhone myPhone)         //Get phone method which is pretented to get all the infomation of the phone
        {
            decimal phonePrice = 0m;
            if (decimal.TryParse(PhonePriceTextBox.Text, out phonePrice))
            {
                myPhone.SetBrand(PhoneBrandTextBox.Text);
                myPhone.SetModel(PhoneModelTextBox.Text);
                myPhone.SetPrice(phonePrice);
            }
            else
            {
                MessageBox.Show("The phone price in invaild - Please try agian");
                PhonePriceTextBox.SelectAll();
            }

            myPhone.GetBrand();
            myPhone.GetModel();
            myPhone.GetPrice();

            return myPhone;
        }

        private void LoadPhoneList(List<CellPhone> phoneList)   //Method for display the phones in phone list
        {
            foreach (CellPhone phone in phoneList)
            {
                ObjectDataListBox.Items.Add(phone.GetBrand() + " " + phone.GetModel() + " with " + phone.GetPrice().ToString("C"));
            }
        }
        #endregion

        #region ======= BANK ACCOUNT ============
        private void DepositButton_Click(object sender, EventArgs e)
        {
            decimal deposit;
            if (decimal.TryParse(DepositTextBox.Text, out deposit))
            {

                myAccount.Deposit(deposit);    //calculate the account balance when deposit money
                DepositTextBox.Text = "";
                BalanceResult.Text = myAccount.GetBalance.ToString("C");    //Output the result
            }
            else
            {
                MessageBox.Show("The entered deposit is invalide - Please retry");
                DepositTextBox.SelectAll();
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            decimal withdraw;
            if (decimal.TryParse(WithdrawTextBox.Text, out withdraw))
            {

                myAccount.Withdraw(withdraw);     //calculate the account balance when withdraw money
                WithdrawTextBox.Text = "";
                BalanceResult.Text = myAccount.GetBalance.ToString("C");    //Output the result
            }
            else
            {
                MessageBox.Show("The entered withdraw is invalide - Please retry");
                WithdrawTextBox.SelectAll();

            }
        }
        #endregion

        #region ======== AUTOMOTIVE SHOP =========
        private void ChargeButton_Click(object sender, EventArgs e)
        {
            Automotive customer = new Automotive();   // Create an instance of customer in Automotive class  -- customer
            Automotive customerCar = new Automotive();  //Create an instance of customer's car -- customerCar
            Automotive customerCharge = new Automotive();  // Create an instance of service charge -- customerCharge

            GetCustomer(customer);            // Get customer's info
            GetCarInfo(customerCar);              // Get car's info
            GetService(customerCharge);              // get service's info

            CustomerList.Add(customer);           // Add all the customer's info to the customer list for later keeping track
            CustomerCarList.Add(customerCar);  // Add car's info into customerCar list
            ChargesList.Add(customerCharge);   // Add charges into customerCharge list

            // Calculate charges
            ChargeOutputLabel.Text = customerCharge.CalculateCharge(customerCharge.GetPartCharge, customerCharge.GetLaborCharge, customerCharge.GetTaxRate).ToString("c");
        }

        private Automotive GetCustomer(Automotive myCustomer)   //Method to get customer infomation
        {
            myCustomer.GetCustomerName = CusNameInput.Text;
            myCustomer.GetCustomerAddress = CusAddressInput.Text;
            myCustomer.GetCustomerPhone = CusPhoneInput.Text;
            
            return myCustomer;
        }

        private Automotive GetCarInfo(Automotive myCustomer)        //Method to get the car information
        {
            int year;
            myCustomer.GetBrand = ShopCarBrandInput.Text;
            myCustomer.GetModel = ShopCarModelInput.Text;
            int.TryParse(ShopCarYearInput.Text, out year);
            myCustomer.GetYear = year;

            return myCustomer;
        }

        private Automotive GetService(Automotive myCustomer)        //Method to get service request information
        {
            //declare the varibles for the charges and tax rate
            decimal partCharge;
            decimal laborCharge;
            decimal taxRate;

            //tryparse the part charge, labor charge, and tax  rate
            if (decimal.TryParse(PartChargeTextBox.Text, out partCharge))
            {
                if (decimal.TryParse(LaborChargeTextBox.Text, out laborCharge))
                {
                    if (decimal.TryParse(TaxRateTextBox.Text, out taxRate))
                    {
                        // Get the charges and tax of services
                        myCustomer.GetPartCharge = partCharge;
                        myCustomer.GetLaborCharge = laborCharge;
                        myCustomer.GetTaxRate = taxRate;
                    }
                    else
                    {
                        MessageBox.Show("The tax you entered is not right - Retry");
                    }
                }
                else
                {
                    MessageBox.Show("The labor charge you entered is not right - Retry");
                }
            }
            else
            {
                MessageBox.Show("The part charge you entered is not right - Retry");

            }
            return myCustomer;
        }

        //private void ServiceCharge(Automotive myCustomer)   //method to calculated the total charge
        //{
        //    decimal totalCharge; //declare the total charge variable
            
        //    // Calculate the total charge
        //    totalCharge = (myCustomer.GetPartCharge  + myCustomer.GetLaborCharge) * ((decimal)myCustomer.GetTaxRate + 1);
        //    ChargeOutputLabel.Text = totalCharge.ToString("c");  // Output the charge in currency format
        //}
        #endregion

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close applicaion
        }

        private void AboutButton_Click(object sender, EventArgs e)   //About box
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
    }
}

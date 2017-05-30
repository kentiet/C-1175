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
        List<string> nameList = new List<string>();
        List<Car> carList = new List<Car>();
        List<CellPhone> phoneList = new List<CellPhone>();
        List<PhoneBook> phoneContacts = new List<PhoneBook>();
        decimal begBalance;
        char dollarSign = '$';
        BankAccount myAccount;

        public Assigment4Form()
        {
            InitializeComponent();
            decimal.TryParse(BalanceResult.Text.TrimStart(dollarSign), out begBalance);
            myAccount = new BankAccount(begBalance);
        }

        private void AddPlayersNameButton_Click(object sender, EventArgs e)
        {
            PlayersNameListBox.Items.Clear();
            AddName(nameList);
            NameInputTextBox.Clear();
            PlayersNameListBox.SelectedIndex = 0;
        }

        private void AddName(List<string> nameList)
        {
            string name;
            name = NameInputTextBox.Text;

            nameList.Add(name);

            foreach (string player in nameList)
            {
                PlayersNameListBox.Items.Add(player);
            }
        }

        private void SortPlayersNameButton_Click(object sender, EventArgs e)
        {
            SortName(nameList);
            PlayersNameListBox.Items.Clear();
            foreach (string player in nameList)
            {
                PlayersNameListBox.Items.Add(player);
            }
            PlayersNameListBox.SelectedIndex = 0;
        }

        private void SortName(List<string> nameList)
        {
            nameList.Sort();
        }

        private void RemovePlayersNameButton_Click(object sender, EventArgs e)
        {
            RemoveName(nameList);
            PlayersNameListBox.SelectedIndex = 0;
        }

        private void RemoveName(List<string> nameList)
        {
            if (PlayersNameListBox.SelectedIndex != -1)
            {
                int selected;

                selected = PlayersNameListBox.SelectedIndex;
                nameList.RemoveAt(selected);
                PlayersNameListBox.Items.Clear();
                foreach (string player in nameList)
                {
                    PlayersNameListBox.Items.Add(player);
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            char input = GetInputChar();
            string givenString = GivenString.Text;
            int count = 0;
            foreach (char letter in givenString)
            {
                if (input == letter)
                {
                    count++;
                }
            }

            if (count >= 1)
            {
                SearchCharOutput.Text = "Found " + count + " character !";
            }
            else
            {
                SearchCharOutput.Text = "Not Found!";
            }
        }

        private char GetInputChar()
        {
            
            char inputChar;
            string input;

            input = SearchCharInput.Text;
            inputChar = input[0];
            return inputChar;
        }

        private void CheckPasswordButton_Click(object sender, EventArgs e)
        {
            string password;
            password = GetPassword();
            Check6Char(password);
            CheckFirstLetter(password);
            CheckLastDigit(password);
            CheckHaveDigit(password);
            HaveCapital(password);
            HaveSpace(password);
            NumChar(password);
            NumDigit(password);
            PassSecure();
        }

        private void PassSecure()
        {
            Color backGreenColor = Color.MediumSpringGreen;
            Color backSixChar = SixCharOutput.BackColor;
            Color backFirstChar = FirstLetterOutput.BackColor; ;
            Color backLastChar = LastDigitOutput.BackColor;
            Color bachHaveDigit = HaveDigitOutput.BackColor;
            Color backHaveCapital = CapitalOutput.BackColor;
            Color backHaveSpace = SpacesOutput.BackColor;
            if ((backSixChar == backGreenColor) && (backFirstChar == backGreenColor) && (backLastChar == backGreenColor) &&
                (bachHaveDigit == backGreenColor) && (backHaveCapital == backGreenColor) && (backHaveSpace == Color.Thistle))
            {
                PasswordStrength.Text = "Strong";
            }
            else
            {
                PasswordStrength.Text = "Weak";
            }
        }
        private string GetPassword()
        {
            string password;
            password = PasswordInputTextBox.Text;

            return password;
        }

        private void Check6Char(string password)
        {
            int count = 0;
            foreach (char a in password)
            {
                count++;
            }
            
            if (count >=6)
            {
                SixCharOutput.Text = count.ToString();
                SixCharOutput.BackColor = Color.MediumSpringGreen;
            }
            else
            {
                SixCharOutput.Text = count.ToString();
                SixCharOutput.BackColor = Color.Thistle;
            }
        }

        private void CheckFirstLetter(string password)
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

        private void CheckLastDigit(string password)
        {
            int count = 0;
            foreach (char a in password)
            {
                count++;
            }

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

        private void CheckHaveDigit(string password)
        {
            int digitCount = 0;
            foreach (char a in password)
            { 
               if (char.IsDigit(a))
                {
                    digitCount++;
                }
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
        private void HaveCapital(string password)
        {
            int capCount = 0;
            foreach (char a in password)
            {
                if (char.IsUpper(a))
                {
                    capCount++;
                }
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

        private void HaveSpace(string password)
        {
            int  spaceCount= 0;
            foreach (char a in password)
            {
                if (char.IsWhiteSpace(a))
                {
                    spaceCount++;
                }
            }

            if (spaceCount != 0)
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

        private void NumChar(string password)
        {
            int spaceCount = 0;
            foreach (char a in password)
            {
                if (char.IsWhiteSpace(a))
                {
                    spaceCount++;
                }
            }

            int count = 0;
            foreach (char a in password)
            {
                count++;
            }
            NumberCharOutput.Text = (count - spaceCount).ToString();
        }

        private void NumDigit(string password)
        {
            int count = 0;
            foreach (char a in password)
            {
                if (char.IsDigit(a))
                {
                    count++;
                }
            }
            NumberDigitOutput.Text = count.ToString();
        }

        private void CSVFileButton_Click(object sender, EventArgs e)
        {
            double average;
            List<int> scoresList = new List<int>();
            StudentCSVListBox.Items.Clear();
            scoresList = ReadFile();
            average = Average(scoresList);
            StudentCSVListBox.Items.Add("\n");
            StudentCSVListBox.Items.Add("The student average score is: " + average);
        }

        private List<int> ReadFile()
        {
            StreamReader inputFile;
            List<int> scoresList = new List<int>();
            try
            {
                char delimimeter = ',';
                int accumulator = 0;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFile.FileName);
                    string[] lines;
                    while (!inputFile.EndOfStream)
                    {
                        lines = inputFile.ReadLine().Split(delimimeter);
                        int number;
                        foreach (string item in lines)
                        {
                            StudentCSVListBox.Items.Add(item);
                            number = int.Parse(item);
                            scoresList.Add(number);
                        }
                    }
                }
            }
            catch
            {

            }
            return scoresList;
        }

        private double Average(List<int> scoresList)
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

        struct Car
        {
            public string brand;
            public int year;
            public string mileage;
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            CarListBox.Items.Clear();
            LoadToCarList();
            foreach (Car car in carList)
            {
                CarListBox.Items.Add(car.brand + " " + car.year + " with " + car.mileage + " miles");
            }
        }

        private void GetCar(ref Car car)
        {
            int year;
            int.TryParse(CarYearComboBox.SelectedItem.ToString(), out year);
            car.brand = CarBrandComboBox.SelectedItem.ToString();
            car.year = year;
            car.mileage = CarMileageComboBox.SelectedItem.ToString();
        }

        private void LoadToCarList()
        {
            Car car = new Car();

            GetCar(ref car);
            carList.Add(car);
        }

        struct PhoneBook
        {
            public string name;
            public string phoneNumber;
            public string email;
        }
        private void ReadPhoneList()
        {
            StreamReader inputFile;
            string lineContact;
            char delim = ',';
            inputFile = File.OpenText("PhoneList.txt");
            while(!inputFile.EndOfStream)
            {
                lineContact = inputFile.ReadLine();

                string[] tokens = lineContact.Split(delim);

                PhoneBook contact = new PhoneBook();

                contact.name = tokens[0];
                contact.phoneNumber = tokens[1];

                phoneContacts.Add(contact);
            }
        }

        private void DisplayContacts()
        {
            foreach (PhoneBook contact in phoneContacts)
            {
                ContactListBox.Items.Add(contact.name);
            }
        }

        private void Assigment4Form_Load(object sender, EventArgs e)
        {
            ReadPhoneList();
            DisplayContacts();
        }

        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ContactListBox.SelectedIndex;

            PhoneNumberOutput.Text = phoneContacts[index].phoneNumber;
        }



        /****************************************
        *                          PART B                              *
        ****************************************/
        private void TossButton_Click(object sender, EventArgs e)
        {
            CoinListBox.Items.Clear();
            Coin myCoin = new Coin();
            int headCount = 0, tailCount = 0;
            for (int i = 0; i < 27; i++)
            {
                myCoin.Flip();
                CoinListBox.Items.Add(myCoin.GetSide());
                if (myCoin.GetSide() == "Heads")
                    headCount++;
                else
                    tailCount++;
            }
            HeadOutput.Text = headCount.ToString();
            TailsOutput.Text = tailCount.ToString();
        }

        private void CreateObjectButton_Click(object sender, EventArgs e)
        {
            ObjectDataListBox.Items.Clear();

            CellPhone myPhone = new CellPhone();
            GetPhone(myPhone);
            phoneList.Add(GetPhone(myPhone));

            PhoneBrandOut.Text = myPhone.GetBrand();
            PhoneModelOut.Text = myPhone.GetModel();
            PhonePriceOut.Text = myPhone.GetPrice().ToString("c");
            LoadPhoneList(phoneList);
        }

        private CellPhone GetPhone(CellPhone myPhone)
        {
            decimal phonePrice = 0m;
            decimal.TryParse(PhonePriceTextBox.Text, out phonePrice);
            myPhone.SetBrand(PhoneBrandTextBox.Text);
            myPhone.SetModel(PhoneModelTextBox.Text);
            myPhone.SetPrice(phonePrice);

            myPhone.GetBrand();
            myPhone.GetModel();
            myPhone.GetPrice();

            return myPhone;
        }

        private void LoadPhoneList(List<CellPhone> phoneList)
        {
            foreach (CellPhone phone in phoneList)
            {
                ObjectDataListBox.Items.Add(phone.GetBrand() + " " + phone.GetModel() + " with " + phone.GetPrice().ToString("C"));
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            decimal deposit;
            decimal.TryParse(DepositTextBox.Text, out deposit);

            myAccount.Deposit(deposit);
            DepositTextBox.Text = "";
            BalanceResult.Text = myAccount.GetBalance.ToString("C");
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            decimal withdraw;
            decimal.TryParse(WithdrawTextBox.Text, out withdraw);

            myAccount.Withdraw(withdraw);
            WithdrawTextBox.Text = "";
            BalanceResult.Text = myAccount.GetBalance.ToString("C");

        }


    }
}

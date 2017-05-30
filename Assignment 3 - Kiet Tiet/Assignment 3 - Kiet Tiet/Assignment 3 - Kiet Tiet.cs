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

//Name: Kiet Tiet
//Version: 1.0
//Date: 08/11/2016
//This program is intended to modify assignment 3
namespace Assignment_3___Kiet_Tiet
{
    public partial class Assignment3Form : Form
    {
        //Field Variable
        Random rand = new Random();             // Random Objett
        const int LOTTO_SIZE = 7;                    // constant for the lotto  array
        int[] lottoArray = new int[LOTTO_SIZE]; // create the lotto array
        //three list collections for the grocery program
        List<string> nameCollection = new List<string>();
        List<string> groceriesList = new List<string>();
        List<int> priceList = new List<int>();

        public Assignment3Form()
        {
            InitializeComponent();
        }

        //========================= COIN FACE ================================================
        private void FlipCoinButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            string coinName;

            //Assign the coinName to the button text
            coinName = FlipCoinButton.Text;

            TailOn();

            //Flip the coin with methos
            if (coinName == "Tails")
            {
                HeadOn();
            }
            else
            {
                TailOn();
            }
        }

        private void HeadOn()
        {
            TailPictureBox.SendToBack();
            FlipCoinButton.Text = "Heads";
        }

        private void TailOn()
        {
            HeadPictureBox.SendToBack();
            FlipCoinButton.Text = "Tails";
        }

        //===========================ADD IT UP===========================================================
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Declare 3 variables for 3 numbers
            int num1, num2, num3, total = 0;

            //parse and check the input
            if (int.TryParse(Number1TextBox.Text, out num1)) {
                if (int.TryParse(Number2TextBox.Text, out num2)) {
                    if (int.TryParse(Number3TextBox.Text, out num3)) {

                        total = Sum(num1, num2, num3);
                    }
                    else
                    {
                        MessageBox.Show("Wrong input for number 3");
                        Number3TextBox.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input for number 2");
                    Number2TextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Wrong input for number 1");
                Number1TextBox.SelectAll();
            }

            // output the total
            AdditionOutputLabel.Text = total.ToString();
        }

        private int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        //============================== PICK FRUIT ==============================================================
        private void ShowFruitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare the fruit name for holding the users selection.
                string fruitName;
                if (FruitListBox.SelectedIndex != -1)
                {
                    fruitName = FruitListBox.SelectedItem.ToString();
                    //condition for output
                    switch (fruitName)
                    {
                        case "Apple":
                            ShowApple();
                            break;
                        case "Avocado":
                            ShowAvocado();
                            break;
                        case "Kiwi":
                            ShowKiwi();
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please select a fruit type");
            }
        }

        private void ShowApple()
        {
            ApplePictureBox.Visible = true;
            AvocadoPictureBox.Visible = false;
            KiwiPictureBox.Visible = false;
        }

        private void ShowAvocado()
        {
            AvocadoPictureBox.Visible = true;
            ApplePictureBox.Visible = false;
            ApplePictureBox.Visible = false;
        }

        private void ShowKiwi()
        {
            KiwiPictureBox.Visible = true;
            ApplePictureBox.Visible = false;
            AvocadoPictureBox.Visible = false;
        }

        //==============EVEN OR ODD========================================================
        private void EvenOddButton_Click(object sender, EventArgs e)
        {
            IdentifyEvenOdd();
        }

        private double GetNumber()
        {
            double number;// Declare a number variable
            double.TryParse(EvenOddInput.Text, out number);
            return number;
        }
        private void IdentifyEvenOdd()
        {
            if (GetNumber() % 2 == 0)
            {
                EvenOddOutput.Text = "Even Number";
            }
            else
            {
                EvenOddOutput.Text = "Odd Number";
            }
        }

        //===================== GROCERIES =============================================
        private void MyGroceriesListButton_Click(object sender, EventArgs e)
        {
            ShowLists(groceriesList);

            MoneyOutputLabel.Text = PayAmount(priceList).ToString("C");
        }

        private string GetGroceryName()
        {
            // Declare the varibale for the grocery name
            string grocery;
            grocery = GroceryNameTextBox.Text;
            return grocery;
        }

        private int GetGrocecyPrice()
        {
            // Declare the price of the grocery
            int price;
            int.TryParse(GroceryPriceTextBox.Text, out price);
            return price;
        }

        private void AddToList(List<string> groceriesList)
        {
            // Set conditions for inputs
            if (GetGroceryName() != "")
            {
                if (GetGrocecyPrice() != 0)
                {
                    string grocery;
                    grocery = GetGroceryName();
                    int price;
                    price = GetGrocecyPrice();
                    //Add the inputs into the list
                    groceriesList.Add(grocery + "\t" + price.ToString("C"));
                }
                else
                {
                    MessageBox.Show("Nothing is free - Please check the price you have paid");
                }
            }
            else
            {
                MessageBox.Show("What did you buy? - Enter your grocery name");
            }
        }
        private void AddPrice(List<int> priceList)
        {
            int price;
            price = GetGrocecyPrice();
            priceList.Add(price);
        }
        private void ShowLists(List<string> groceriesList)
        {
            //Show the items in the list to the listbox
            GroceryListBox.Items.Clear();
            foreach (string itemName in groceriesList)
            {
                GroceryListBox.Items.Add(itemName);
            }
        }

        private void AddGroceryButton_Click(object sender, EventArgs e)
        {
            AddToList(groceriesList);
            AddPrice(priceList);
            GroceryNameTextBox.Text = "";
            GroceryPriceTextBox.Text = "";
        }

        private int PayAmount(List<int> priceList)
        {
            // Accumulate the amount need to pay
            int accumlator = 0;
            foreach (int item in priceList)
            {
                accumlator += item;
            }
            return accumlator;
        }

        private void ClearGroceriesButton_Click(object sender, EventArgs e)
        {
            // clear the grocegy program for the next use
            GroceryListBox.Items.Clear();
            MoneyOutputLabel.Text = "$0.00";
            groceriesList.Clear();
            priceList.Clear();
        }

        /********************************************************
         *                                       PART B                                         *
         ********************************************************/

        //================================ Pick and Sort =====================================================
        private void LottoPickButton_Click(object sender, EventArgs e)
        {
            GenerateNumbers(lottoArray);
            SortNumbers(lottoArray);

            //Output the array in order
            PickLabel1.Text = lottoArray[0].ToString();
            PickLabel2.Text = lottoArray[1].ToString();
            PickLabel3.Text = lottoArray[2].ToString();
            PickLabel4.Text = lottoArray[3].ToString();
            PickLabel5.Text = lottoArray[4].ToString();
            PickLabel6.Text = lottoArray[5].ToString();
            PickLabel7.Text = lottoArray[6].ToString();
        }

        private void GenerateNumbers(int[] lottoArray)
        {
            for (int i = 0; i < lottoArray.Length; i++)
            {
                lottoArray[i] = rand.Next(49) + 1;
            }
        }

        private void Swap(ref int num1, ref int num2)
        {
            //Swap the 2 elements
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private void SortNumbers(int[] lottoArray)
        {
            for (int index = 0; index < lottoArray.Length - 1; index++)
            {
                // variables for the smallest index and the value of the smallest index
                int smallestIndex = index;
                int smallestValue = lottoArray[index];
                for (int position = index + 1; position < lottoArray.Length; position++)
                {
                    if (lottoArray[position] < smallestValue)
                    {
                        smallestValue = lottoArray[position];
                        smallestIndex = position;
                    }
                }
                // swap the number for sorting
                Swap(ref lottoArray[smallestIndex], ref lottoArray[index]);
            }
        }

        //====================== CHECK LOTTO===========================================
        private void LottoCheckButton_Click(object sender, EventArgs e)
        {
            CheckNumbers(lottoArray);
        }

        private void CheckNumbers(int[] lottoArray)
        {
            //Set condition for checking the numbers
            if (lottoArray[0] == lottoArray[1] || lottoArray[0] == lottoArray[2] || lottoArray[0] == lottoArray[3] || lottoArray[0] == lottoArray[4] || lottoArray[0] == lottoArray[5] || lottoArray[0] == lottoArray[6]
               || lottoArray[1] == lottoArray[2] || lottoArray[1] == lottoArray[3] || lottoArray[1] == lottoArray[4] || lottoArray[1] == lottoArray[5] || lottoArray[1] == lottoArray[6]
               || lottoArray[2] == lottoArray[3] || lottoArray[2] == lottoArray[4] || lottoArray[2] == lottoArray[5] || lottoArray[2] == lottoArray[6]
               || lottoArray[3] == lottoArray[4] || lottoArray[3] == lottoArray[5] || lottoArray[3] == lottoArray[6]
               || lottoArray[4] == lottoArray[5] || lottoArray[4] == lottoArray[6]
               || lottoArray[5] == lottoArray[6]
                )
            {
                PickOutput.Text = "Pick Again";
            }
            else
            {
                PickOutput.Text = "You can win!!!!!";
            }
        }

        //============================== LOAD LIST ARRAY ===================================
        private void ListArrayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListArrayComboBox.SelectedIndex != -1)
            {
                int selection; // the selection of user
                int.TryParse(ListArrayComboBox.SelectedItem.ToString(), out selection); //convert the selection to integer value

                //Clear out the labels before executing the next use
                LoadArrayFirstOutput.Text = "";
                LoadListOutput.Text = "";

                LoadArray(selection);
                LoadList(selection);
            }
        }

        private void LoadArray(int num)
        {
            // Declare a string to hold the user selectiom
            string item = ListArrayComboBox.SelectedItem.ToString();
            int.TryParse(item, out num);

            // Create an array object
            int[] myArray = new int[num];

            for (int count = 1; count <= myArray.Length; count++)
            {
                LoadArrayFirstOutput.Text += count.ToString() + " ";
                //LoadArraySecondOutput.Text += count.ToString() + " ";
            }
        }
        private void LoadList(int num)
        {
            string item = ListArrayComboBox.SelectedItem.ToString();
            int.TryParse(item, out num);

            //Create a list collection 
            List<int> myList = new List<int>();
            for (int count = 1; count <= num; count++)
            {
                myList.Add(count);
            }
            ShowLoadList(myList);
        }

        private void ShowLoadList(List<int> myList) 
        {
            foreach (int number in myList)
            {
                LoadListOutput.Text += number.ToString() + " ";
            }
        }
        //============================ DAYS FOR ARRAY========================================
        private void ForButton_Click(object sender, EventArgs e)
        {
            // Create and initialize the array for day names in a week
            string[] daysArray = { "Monday", "Tuesday", "Wednesday", "Thurdays", "Friday", "Saturday", "Sunday" };

            // Output day names in the list box by using for loops
            ForDisplayDays(daysArray);
        }

        private void ForDisplayDays(string[] daysArray)
        {
            for (int index = 0; index < daysArray.Length; index++)
            {
                DaysForListBox.Items.Add(daysArray[index]);
            }
        }

        //=========================== DAYS FOREACH ARRAY =======================================
        private void ForEachButton_Click(object sender, EventArgs e)
        {
            // Create and initialize the array for day names in a week
            string[] daysArray = { "Monday", "Tuesday", "Wednesday", "Thurdays", "Friday", "Saturday", "Sunday" };

            // Output day names in the list box by using foreach loops
            ForeachDisplayDays(daysArray);
        }

        private void ForeachDisplayDays(string[] daysArray)
        {
            foreach (string day in daysArray)
            {
                DaysForeachListBox.Items.Add(day);
            }
        }

        //========================== ADD NAME ===============================================
        private void AddNameButton_Click(object sender, EventArgs e)
        {
            int count;// count name in the collection

            // Set a condition to ensure user input a name
            if (GetName() != "")
            {
                LoadNameIn(nameCollection);
                count = CountName(nameCollection);
                MessageBox.Show(count.ToString() + " name(s) in the list");
                ShowName(nameCollection);

            }
            else
            {
                MessageBox.Show("Please enter a name to process");
            }
        }

        private string GetName()
        {
            //Declare a variable to hold the name value
            string name;
            //Assign the name input to the variable
            name = NameInput.Text;

            return name;
        }


        private void LoadNameIn(List<string> nameCollection)
        {
            string name = GetName();

            //Add names into the collection
            nameCollection.Add(name);
        }

        private int CountName(List<string> nameCollection)
        {
            int count;
            count = nameCollection.Count();
            return count;
        }
        private void ShowName(List<string> nameCollection)
        {
            int timeDisplay = 0;
            foreach (string name in nameCollection)
            {
                timeDisplay++;
                MessageBox.Show("Name #" + timeDisplay  + " is: "+ name);
            }
        }

        //======================================= TEST SCORE =================================
        private void TestScoreButton_Click(object sender, EventArgs e)
        {
            // Create the list for the test score
            List<int> scoreList = new List<int>();
            ScoreListBox.Items.Clear();    //Clear the list for next use
            GetScoreList(scoreList);         //Get score
            ShowScore(scoreList);           // Display score

            AverageScoreOutput.Text = Average(scoreList).ToString("N2"); 
            HighestScoreOutput.Text =  highest(scoreList).ToString();
            LowestScoreOutput.Text = lowest(scoreList).ToString();
        }
        private void GetScoreList(List<int> scoreList)
        {
            StreamReader inputFile;

            int score;
            inputFile = File.OpenText("TestScores.txt");

            while (!inputFile.EndOfStream)
            {
                int.TryParse(inputFile.ReadLine(), out score);
                scoreList.Add(score);
            }
            inputFile.Close();
        }

        private void ShowScore(List<int> scoreList)
        {
            foreach (int score in scoreList)
            {
                ScoreListBox.Items.Add(score);
            }
        }

        private double Average(List<int> scoreList)
        {
            int accumulator = 0;
            int count = 0;
            double average;
            foreach (int score in scoreList)
            {
                count++;
                accumulator += score;
            }
            average = (double) accumulator / count;
            return average;
        }

        private int highest(List<int> scoreList)
        {
            int highest = scoreList[0];
            foreach (int score in scoreList)
            {
                if (score > highest)
                {
                    highest = score;
                }
            }
            return highest;
        }

        private int lowest(List<int> scoreList)
        {
            int lowest = scoreList[0];
            foreach (int score in scoreList)
            {
                if (score < lowest)
                {
                    lowest = score;
                }
            }
            return lowest;
        }

        //================================== 2D THEATER SEATING ====================================
        private void PricesButton_Click(object sender, EventArgs e)
        {
            // Create a 2D array for seats
            int[][] seats = new int[3][];
            seats[0] = new int[4] { 100, 110, 110, 100 };
            seats[1] = new int[6] { 80, 90, 90, 90, 90, 80 };
            seats[2] = new int[8] { 70, 60, 60, 60, 60, 60, 60, 70 };

            // Create a 2D array for the buttons
            Button[][] seatButton = new Button[3][];
            seatButton[0] = new Button[4] {A1Button, A2Button, A3Button, A4Button };
            seatButton[1] = new Button[6] {B1Button, B2Button, B3Button, B4Button, B5Button, B6Button };
            seatButton[2] = new Button[8] {C1Button, C2Button, C3Button, C4Button,
                                                            C5Button,C6Button,C7Button,C8Button};

            // Change seats name to money
            AssignMoney(seats, seatButton);
        }
        private void AssignMoney(int[][] seats, Button[][] seatButton)
        {
            // For loops to assgin money to their consisent seat
            for (int row = 0; row < seatButton.Length; row++)
            {
                for (int col = 0; col < seatButton[row].Length; col++)
                {
                    (seatButton[row][col]).Text = (seats[row][col]).ToString("C");
                }
            }
        }

        //======================== CLEAR ALL =====================================
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            HeadPictureBox.BringToFront();
            TailPictureBox.SendToBack();
            FlipCoinButton.Text = "Coin Face";
            Number1TextBox.Text = "";
            Number2TextBox.Text = "";
            Number3TextBox.Text = "";
            AdditionOutputLabel.Text = "0";
            ApplePictureBox.Visible = false;
            KiwiPictureBox.Visible = false;
            AvocadoPictureBox.Visible = false;
            FruitListBox.ClearSelected();
            EvenOddInput.Text = "";
            EvenOddOutput.Text = "";
            GroceryListBox.Items.Clear();
            MoneyOutputLabel.Text = "$0.00";
            groceriesList.Clear();
            priceList.Clear();
            PickLabel1.Text ="";
            PickLabel2.Text ="";
            PickLabel3.Text ="";
            PickLabel4.Text ="";
            PickLabel5.Text ="";
            PickLabel6.Text ="";
            PickLabel7.Text ="";
            PickOutput.Text = "";
            ListArrayComboBox.SelectedIndex = -1;
            LoadArrayFirstOutput.Text = "";
            LoadListOutput.Text = "";
            DaysForListBox.Items.Clear();
            DaysForeachListBox.Items.Clear();
            NameInput.Text = "";
            ScoreListBox.Items.Clear();
            HighestScoreOutput.Text = "";
            LowestScoreOutput.Text = "";
            AverageScoreOutput.Text = "";
            A1Button.Text = "A1";
            A2Button.Text = "A2";
            A3Button.Text = "A3";
            A4Button.Text = "A4";
            B1Button.Text = "B1";
            B2Button.Text = "B2";
            B3Button.Text = "B3";
            B4Button.Text = "B4";
            B5Button.Text = "B5";
            B6Button.Text = "B6";
            C1Button.Text = "C1";
            C2Button.Text = "C2";
            C3Button.Text = "C3";
            C4Button.Text = "C4";
            C5Button.Text = "C5";
            C6Button.Text = "C6";
            C7Button.Text = "C7";
            C8Button.Text = "C8";
        }

        //======================== EXIT =========================================
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;              // name   is a reference data type
            char letter;                             // letter is a value data type    

            for (int index = 0; index < name.Length; index++)
            {
                letter = name[index];
                MessageBox.Show(letter.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            MessageBox.Show(name[1].ToString());    // remember to convert to a string
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            if (char.IsDigit(name[0]))              // char.IsDigit(name,0) 
                MessageBox.Show("first character is a number");
            else
                MessageBox.Show("first character is a letter");


            if (char.IsLetter(name, 0))
                MessageBox.Show("first character is a letter");
            else
                MessageBox.Show("first character is a number");

            if (char.IsLetterOrDigit(name, 0))
                MessageBox.Show("Could be a letter or a number");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (char.IsPunctuation(name, 0))
                MessageBox.Show("first character Is a Punctuation");
            else
                MessageBox.Show("first character is not a Punctuation");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (char.IsLower(name, 0))
                MessageBox.Show("first character Is lower");
            else
                MessageBox.Show("first character is not a lower");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name.Contains("Rhyon"))
                MessageBox.Show("string contains Rhyon");
            else
                MessageBox.Show("string does not contain Rhyon");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int position = name.LastIndexOf("n");
            if (position != -1)
            {
                MessageBox.Show(position.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string name = (textBox1.Text).Trim();            
            MessageBox.Show(name);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string name = (textBox1.Text).Trim();
            name = name.Remove(0,1);
            name = name.Remove(2,1);
            name = name.Remove(4,1);
            name = name.Insert(0, "5");
            MessageBox.Show(name);
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        char[] letters_lower = "abcdefghijklmnopqrstuvwxyz".ToArray();
        char[] letters_upper ="ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] letters_special = "!@#$%^&*()-_+=[]{}|;:'\",.<>?/\\~`".ToCharArray();
        char[] numbers = "0123456789".ToCharArray();

        string output;
        int test;
        int max = 20;
        void generate(int numOfLetters)
        {
            output = null;

            //the case where a single variation of the checkbox is ticked

            // lowercase letters
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox2.Checked && checkBox1.Checked != true && checkBox3.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_lower[rnd.Next(0, letters_lower.Length)];
                }
                textBox1.Text = output;

                //uppercase
            }
            else if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked && checkBox2.Checked != true && checkBox3.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_upper[rnd.Next(0, letters_upper.Length)];
                }
                textBox1.Text = output;

                // numbers
            }
            else if (Convert.ToInt32(textBox2.Text) <= max && checkBox3.Checked && checkBox1.Checked != true && checkBox2.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += numbers[rnd.Next(0, numbers.Length)];
                }
                textBox1.Text = output;
            }
            else if (Convert.ToInt32(textBox2.Text) <= max && checkBox4.Checked && checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_special[rnd.Next(0, letters_special.Length)];
                }
                textBox1.Text = output;

                // all 4 checkboxes -- to do with other scenarios later
            }
            else if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(4); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 2:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                        case 3:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                }
                textBox1.Text = output;
            }
            //Uppercase and Lowercase checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            /* Duplicate
            //Uppercase, Lowercase and Numbers checked
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 2:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            */

            //Uppercase and Numbers checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox3.Checked == true && checkBox2.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }

            //Uppercase and Symbols (Special Characters) checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox4.Checked == true && checkBox2.Checked != true && checkBox3.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Lowercase and Numbers checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox2.Checked == true && checkBox3.Checked == true && checkBox1.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Lowercase and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox2.Checked == true && checkBox4.Checked == true && checkBox1.Checked != true && checkBox3.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Numbers and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox3.Checked == true && checkBox4.Checked == true && checkBox1.Checked != true && checkBox2.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                        case 1:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Uppercase, Lowercase and Numbers checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 2:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Uppercase, Lowercase and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox2.Checked == true && checkBox4.Checked == true && checkBox3.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 2:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Uppercase, Numbers and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox2.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                        case 2:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Lowercase, Numbers and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox1.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                        case 2:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            if (Convert.ToInt32(textBox2.Text)>20) {
                MessageBox.Show("Password Max Lenghth is 20");
            }
            int charactercount = textBox1.Text.Length;
            label2.Text = Convert.ToString(charactercount);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string max_length = textBox2.Text;

              generate(Convert.ToInt32(textBox2.Text));
            
        }
    }
}

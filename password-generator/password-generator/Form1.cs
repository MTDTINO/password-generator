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
        Random rnd2 = new Random(Guid.NewGuid().GetHashCode());
        Random rnd3 = new Random(Guid.NewGuid().GetHashCode());

        char[] letters_lower = "abcdefghijklmnopqrstuvwxyz".ToArray();
        char[] letters_upper ="ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] letters_special = "!@#$%^&*()-_+=[]{}|;:'\",.<>?/\\~`".ToCharArray();
        char[] numbers = "0123456789".ToCharArray();

        string output;
        int test;
        void generate(int numOfLetters)
        {
            output = null;

            //the case where a single variation of the checkbox is ticked

            // lowercase letters
            if (checkBox2.Checked && checkBox1.Checked != true && checkBox3.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_lower[rnd.Next(0, letters_lower.Length)];
                }
                textBox1.Text = output;

                //uppercase
            } else if (checkBox1.Checked && checkBox2.Checked != true && checkBox3.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_upper[rnd.Next(0, letters_upper.Length)];
                }
                textBox1.Text = output;

                // numbers
            } else if (checkBox3.Checked && checkBox1.Checked != true && checkBox2.Checked != true && checkBox4.Checked != true) {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += numbers[rnd.Next(0, numbers.Length)];
                }
                textBox1.Text = output;
            } else if (checkBox4.Checked && checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true) {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_special[rnd.Next(0, letters_special.Length)];
                }
                textBox1.Text = output;

                // all 4 checkboxes -- to do with other scenarios later
            } else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked ) {
                for (int i = 0; i < numOfLetters;i++)
                {
                    output += string.Concat(letters_lower[rnd.Next(0, letters_lower.Length)], letters_upper[rnd2.Next(1, letters_upper.Length)], letters_special[rnd2.Next(2, letters_special.Length)], numbers[rnd2.Next(3, numbers.Length)]);
                }
                textBox1.Text = output;
            }
   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string max_length = textBox2.Text;

              generate(Convert.ToInt32(textBox2.Text));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearEntryButton_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            yTextBox.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (yTextBox.Enabled == false)
            {
             xTextBox.Text += "1";
            } else
            yTextBox.Text +="1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "2";
            }
            else
                yTextBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "3";
            }
            else
                yTextBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "4";
            }
            else
                yTextBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "5";
            }
            else
                yTextBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "6";
            }
            else
                yTextBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "7";
            }
            else
                yTextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "8";
            }
            else
                yTextBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "9";
            }
            else
                yTextBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Text += "0";
            }
            else
                yTextBox.Text += "0";
        }

        private void xFactorButton_Click(object sender, EventArgs e)
        {
            int val1, total = 1;
            int.TryParse(xTextBox.Text, out val1);
            for (int i = val1; i >= 1; i--)
            {
                total *= i;
            }
            listBox1.Items.Add(total);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            int val1, val2, total = 1;
            int.TryParse(xTextBox.Text, out val1);
            int.TryParse(yTextBox.Text,out val2);
            for (int i = 1; i <= val2; i++) { 
                 total *= val1;
            }
           
            listBox1.Items.Add(total);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Exit Confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void yTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This event handler only allows digits, and control characters // The symbol ! means “not”; the symbols && mean “and”. 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                xTextBox.Clear();
            } else { 
                yTextBox.Clear();
                
            }
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            if (yTextBox.Enabled == false)
            {
                string xEntryMinusOne = xTextBox.Text.Substring(0, xTextBox.Text.Length - 1);
                xTextBox.Text = xEntryMinusOne;
            } else {
                string yEntryMinusOne = yTextBox.Text.Substring(0, yTextBox.Text.Length - 1);
                yTextBox.Text = yEntryMinusOne;
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            decimal val1;
            decimal.TryParse(xTextBox.Text, out val1);
            listBox1.Items.Add(1 / val1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int val1, val2;
            int.TryParse(xTextBox.Text, out val1);
            int.TryParse(yTextBox.Text, out val2);
           
            for (int i = val1; i <= val2; i++)
            {
               for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        listBox1.Items.Add(i + " is not a prime number.");
                        i++;
                       
                    }
                    
                }
                listBox1.Items.Add(i + " is a prime number.");
            }

            

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int val1, val2, val1Squared, val2Squared;
            int.TryParse(xTextBox.Text,out val1);
            int.TryParse(yTextBox.Text, out val2);
            val1Squared = val1 * val1;
            val2Squared = val2 * val2;
            listBox1.Items.Add("The number is: " + val1 + ", and its square is: " + val1Squared);
            listBox1.Items.Add("The number is: "+ val2 + ", and its square is: " + val2Squared);
            listBox1.Items.Add("Sum of numbers is: "+ val1 + val2+ ", the sum of sqaures is: "+ (val1Squared + val2Squared));


        }

        private void yTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Validated(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)        {
            //This is the Fibonacci sequence code declare three variables and create an array beginning with 0 and 1
            int val1, val2 = 1, val3 = 1; 
            int[] total = { 0, 1 };
            int.TryParse(xTextBox.Text, out val1);
            //The for loop starts at the total index 2 and adds the previous value (val3) to the current value     
            for(int i = 2; i < val1; i++)
            {
                
                total = total.Concat(new int[] { val2 }).ToArray();
                val3 = total[i - 1];
                val2 += val3;
                
            }
            //String is created to list the values and output into listbox
                string listOfValues = string.Join(" ",total);
                listBox1.Items.Add("Fibonacci sequence for "+ val1 + ": " + listOfValues);
            
            

            
        }

        private void button14_Validated(object sender, EventArgs e)
        {

            int val1, val2;
            int.TryParse(xTextBox.Text, out val1);
            int.TryParse(yTextBox.Text, out val2);
            if ( val2 > 30 && val1 > val2 && val1 < 0)
            {
                return;
            }
        }
    }
}

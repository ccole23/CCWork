/*
 * Chris Cole
 * 3/1/2022
 * Vehicle Loan Calculator - calculates the interest, principle payments and 
 * if the user accepts the loan, the data is temporarily stored to calculate the 
 * total loan and interest
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class MainForm : Form
    {
        //Declared public variables total interest and Loan stores the total of the variables and increments increase the total
        public double totalInterest = 0;
        public double totalLoan = 0;
        public double incrementLoan;
        public double incrementInterest;


        public MainForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //enables the rebate text
            rebateText.Enabled = rebateCheck.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declares variables, clears the listbox if there are contents, resets the increment variables
            double loan, rebate, principalPayment,pmt,rate, interest, intrestTotal = 0, principalTotal = 0, pmtTotal = 0;
            int months;
            listBox1.Items.Clear();
            double.TryParse(loanText.Text, out loan);
            incrementLoan = 0;
            incrementInterest = 0;
            //try catch catches the user when they forget to put in information 
            try
            {
                //if statement for the radio buttons to determine the month
                if (sixRadio.Checked)
                {
                    months = 6;
                }
                else if (twelveRadio.Checked)
                {
                    months = 12;
                }
                else if (eightTeenRadio.Checked)
                {
                    months = 18;
                }
                else if (twoFourRadio.Checked)
                {
                    months = 24;
                }
                else months = 6;
                if (rebateCheck.Checked)
                {
                    double.TryParse(rebateText.Text, out rebate);

                }
                else rebate = 0;
                
                rate = Convert.ToDouble(annualAPR.Text) / 100;
                principalPayment = rate / 12 * ((loan - rebate) + 0 * Math.Pow(1 + rate / 12, months)) / ((Math.Pow(1 + rate / 12, months) - 1) * (1 + rate / 12 * 0));
                
                interest = (loan - rebate) * rate / 12;
                string formatString = "{0,5}{1,12:C}{2,12:C}{3,12:C}{4,12:C}";
                pmt = principalPayment + interest;
                loan = (loan - rebate) - principalPayment;
                for (int monthCounter = 1; monthCounter <= months; monthCounter++)
                {
                    //listbox will list each row until the month counter equals the selected number of months.
                    listBox1.Items.Add(String.Format(formatString, monthCounter, interest, principalPayment, pmt, loan));
                    pmtTotal += pmt;
                    principalTotal += principalPayment;
                    intrestTotal += interest;
                    interest = (loan) * rate / 12;
                    principalPayment = pmt - interest;
                    pmt = principalPayment + interest;
                    loan = (loan) - principalPayment;


                }
               //total is calculated after the loop is complete and increment values are set 
                listBox1.Items.Add("");
                listBox1.Items.Add(String.Format(formatString, "", intrestTotal, principalTotal, pmtTotal, " "));
                incrementInterest = intrestTotal;
                incrementLoan = principalTotal;
            }catch (Exception err){
                MessageBox.Show(err.ToString());
                
            }
            

        }

        private void annualAPR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void acceptLoanButton_Click(object sender, EventArgs e)
        {
            //increment values are added to the total and listbox, and all textboxes are cleared
            totalInterest += incrementInterest;
            totalLoan += incrementLoan;
            listBox1.Items.Clear();
            loanText.Clear();
            annualAPR.Text = null;
            rebateText.Clear();
            rebateCheck.Checked = false;
            sixRadio.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this button will display the total interest and loans in the label
            totalInterestLabel.Text = totalInterest.ToString("c"); 
            totalLoanLabel.Text = totalLoan.ToString("c");
        }
        //if the text is changed in any of the text boxes, the listbox is cleared
        private void loanText_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void annualAPR_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void twelveRadio_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        //limited to only numbers and decimal places
        private void loanText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This event handler only allows digits, control characters, the negative symbol, and the period. // The symbol ! means “not”; the symbols && mean “and”. 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit Confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
                this.Close();
        }
    }
}
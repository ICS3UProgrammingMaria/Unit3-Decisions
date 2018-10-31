/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program...
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

namespace FactorialDoMaria
{
    public partial class frmFactorialDo : Form
    {
        public frmFactorialDo()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            //clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            //initialize the final answer to 1
            factorialAnswer = 1;

            //get the number from the user
            factorialNumber = Convert.ToDouble(this.txtuserAnswer.Text);

            //set the count to 0 
            //factorialAnswer = 0;

            //multiply the counter by the next incremented number until it reaches the users number
            do
            {
                //increment the counter by 1
                factorialNumber = factorialNumber + 1;

                //list the counter number in the listbox for the user


                //multiply the counter by the answer

            } while (  );

            //convert the factorial answer to a string and inset it into the label
            this.lblFactorialAnswer.Text = this.txtuserAnswer.Text + "! = " + Convert.ToString(factorialAnswer);
        }
    }
}

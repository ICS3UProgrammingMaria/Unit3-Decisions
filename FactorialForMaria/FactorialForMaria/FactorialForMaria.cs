/*
 * Created by: Maria
 * Created on: 31-10-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Factorial For Loop
 * This program will display facotrials in a listbox using a For loop
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

namespace FactorialForMaria
{
    public partial class frmFactorialFor : Form
    {
        public frmFactorialFor()
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
            factorialNumber = Convert.ToDouble(this.txtFactorial.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                //list the counter number in the listbox for the user to see
                this.lstFactorialNumbers.Items.Add(factorialCounter);

                //multiply the counter number in the listbox for the user to see
                factorialAnswer = factorialAnswer * factorialCounter;
            }

            //convert the factorialAnswer to a string and insert it in the label to display the answer
            this.lblFactorialAnswer.Text = this.txtFactorial.Text + "! = " + Convert.ToString(factorialAnswer);

        }
    }
}

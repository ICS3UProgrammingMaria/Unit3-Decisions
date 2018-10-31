/*
 * Created by: Maria
 * Created on: 15-10-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program generates a random number between 1 and 10, 
 * then asks the user to enter a number between those peripherals.
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

namespace RandNumberMaria
{
    public partial class RandomNumberForm : Form
    {
        public RandomNumberForm()
        {
            InitializeComponent();
            lblCorrect.Hide();
            picAnswer.Hide();
            lblIncorrect.Hide();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //declare constants and variables
            //creates a minimum and maximum integer to randomly generate
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            int aRandomNumber;
            int numGuess;

            Random randomNumberGenerator = new Random();

            //get the random number
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //assign the random number to the label
            lblNumberAnswer.Text = Convert.ToString(aRandomNumber);

            //get the number from the textbox
            numGuess = int.Parse(txtnumGuess.Text);

            //if the number of students enteres is greater than the max capacity, display
            if (numGuess == aRandomNumber)
            {
                //show chekmark and show correct label
                this.picAnswer.Image = Properties.Resources.checkmark;
                lblCorrect.Show();
                picAnswer.Show();
                lblIncorrect.Hide();
            }

            else
            {
                //show chekmark and show incorrect label
                this.picAnswer.Image = Properties.Resources.red_x;
                lblIncorrect.Show();
                picAnswer.Show();
                lblCorrect.Hide();
            }
        }
    }
}

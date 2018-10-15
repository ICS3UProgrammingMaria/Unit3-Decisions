/*
 * Created by: Maria
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Number Guessing Game
 * This program asks the user to guess a number between 1 and 10
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

namespace GuessGameMaria
{
    public partial class GuessGameForm : Form
    {
        public GuessGameForm()
        {
            InitializeComponent();
            lblCorrect.Hide();
            picAnswer.Hide();
            lblIncorrect.Hide();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //declare constants and variables
            const int CORRECTNUMBER = 7;
            int numGuess;

            //get the number from the textbox
            numGuess = int.Parse(txtnumGuess.Text);

            //if the number of students enteres is greater than the max capacity, display
            if (numGuess == CORRECTNUMBER)
            {
                //show chekmark and show correct label
                this.picAnswer.Image = Properties.Resources.checkmark;
                lblCorrect.Show();
                picAnswer.Show();
            }

            else
            {
                //show chekmark and show incorrect label
                this.picAnswer.Image = Properties.Resources.red_x;
                lblIncorrect.Show();
                picAnswer.Show();
            }
        }
    }
}

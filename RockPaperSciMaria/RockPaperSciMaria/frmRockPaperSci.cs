/*
 * Created by: Maria
 * Created on: Day-Month-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program 
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

namespace RockPaperSciMaria
{
    public partial class frmRockPaperSci : Form
    {
        //declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperSci()
        {
            InitializeComponent();
            //create the random number generator object
            randomNumberGenerator = new Random();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //declare local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            //get the user's selection, if there is no selection set it to 0 
            if (radPlayerRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radPlayerScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }

            //randomly generate a number between 1 and 3, representing ROCK, PAPER or SCISSORS
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //set the radio button for the computer's choice
            if (computerChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }
            else if (computerChoice == SCISSORS)
            {
                this.radComputerScissors.Checked = true;
            }


            if (computerChoice == playerChoice)
            {
                
            }

        }
    }
}

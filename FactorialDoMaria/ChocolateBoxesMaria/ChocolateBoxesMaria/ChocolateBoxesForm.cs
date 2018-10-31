/*
 * Created by: Maria
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program tells the user what prize they recieve
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

namespace ChocolateBoxesMaria
{
    public partial class ChocolateBoxesForm : Form
    {
        public ChocolateBoxesForm()
        {
            InitializeComponent();
        }

        private void btnGetReward_Click(object sender, EventArgs e)
        {
            //declare local variables
            int numBoxes;

            //get the number of boxes sold from user
            numBoxes = int.Parse(txtnumBoxes.Text);

            //determine the type of reward the user recieves an if statement
            if (numBoxes > 20)
            {
                lblRewardAnswer.Text = "You get a Prize";
            }
            else
            {
                if (numBoxes < 10)
                {
                    //display the text in the label
                    lblRewardAnswer.Text = "You get an Honorable Mention";
                }
                else
                {
                    lblRewardAnswer.Text = "You get a Small Prize";
                }
            }
        }
    }
}
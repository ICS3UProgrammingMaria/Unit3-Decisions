﻿/*
 * Created by: Maria
 * Created on: 24-10-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day 22# - Perfect Squares
 * This program displays all the perfect squares in a listbox 
 * (lst) up to the user value
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

namespace PerfectSquaresMaria
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            //set the intitial values
            value = 1;

            //clear all items from the list box
            this.lstPerfectSquares.Items.Clear();

            //get the user's end value selection from the number up-down box
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            //contuinue stating any perfect squares between the minimum value and the user's selected and value
            while (value <= endingValue)
            {
                //take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                //convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                //the only way for both the decimal and thr integer to be equal is if 
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(value + "is a perfect square");
                    //this.lstPerfectSquares.SetSelected(numberOfPerfectSquares);
                    this.Refresh();
                }
                //increments the value by 1
                value = value + 1;
            }
        }
    }
}

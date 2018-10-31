using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder2Maria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMedium.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int pizzaSize;
            int Toppings;

            //get the user's selection from the number up-down box
            pizzaSize = Convert.ToInt32(this.nudpizzaSize.Value);

        }
    }
}

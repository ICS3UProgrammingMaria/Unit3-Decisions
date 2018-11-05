using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedlpMaria
{
    public partial class frmNestedLoop : Form
    {
        public frmNestedLoop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare local variables
            int firstNumber;
            int secondNumber;

            //clear listbix
            this.lstNumbers.Items.Clear();

            //loop through the numbers from 0 to 10
            for (firstNumber = 0; firstNumber <=10; firstNumber++)
            {
                //for each of the numbers above, loop thorugh sagain writing beside it the second number from 0 to 10
                for (secondNumber= 0; secondNumber <=10; secondNumber++)
                {
                    this.lstNumbers.Items.Add(firstNumber + " -> " + secondNumber);
                }
            }
        }
    }
}

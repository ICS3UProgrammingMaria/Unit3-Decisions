namespace PizzaOrder2Maria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudpizzaSize = new System.Windows.Forms.NumericUpDown();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.lblpizzaSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalAnswer = new System.Windows.Forms.Label();
            this.lblPSTAnswer = new System.Windows.Forms.Label();
            this.lblGSTAnswer = new System.Windows.Forms.Label();
            this.lblTotalAnswer = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudpizzaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // nudpizzaSize
            // 
            this.nudpizzaSize.Location = new System.Drawing.Point(360, 52);
            this.nudpizzaSize.Name = "nudpizzaSize";
            this.nudpizzaSize.Size = new System.Drawing.Size(120, 20);
            this.nudpizzaSize.TabIndex = 0;
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(360, 170);
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(120, 20);
            this.nudToppings.TabIndex = 1;
            // 
            // lblpizzaSize
            // 
            this.lblpizzaSize.AutoSize = true;
            this.lblpizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpizzaSize.Location = new System.Drawing.Point(26, 50);
            this.lblpizzaSize.Name = "lblpizzaSize";
            this.lblpizzaSize.Size = new System.Drawing.Size(317, 20);
            this.lblpizzaSize.TabIndex = 2;
            this.lblpizzaSize.Text = "Select the size of pizza you would like:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(57, 167);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(286, 20);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "How many toppings would you like:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(188, 226);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(76, 15);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal = ";
            // 
            // lblPST
            // 
            this.lblPST.AutoSize = true;
            this.lblPST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPST.Location = new System.Drawing.Point(206, 254);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(49, 15);
            this.lblPST.TabIndex = 5;
            this.lblPST.Text = "PST = ";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(205, 283);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(50, 15);
            this.lblGST.TabIndex = 6;
            this.lblGST.Text = "GST = ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(203, 319);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total = ";
            // 
            // lblSubtotalAnswer
            // 
            this.lblSubtotalAnswer.AutoSize = true;
            this.lblSubtotalAnswer.Location = new System.Drawing.Point(306, 226);
            this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
            this.lblSubtotalAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblSubtotalAnswer.TabIndex = 8;
            // 
            // lblPSTAnswer
            // 
            this.lblPSTAnswer.AutoSize = true;
            this.lblPSTAnswer.Location = new System.Drawing.Point(306, 263);
            this.lblPSTAnswer.Name = "lblPSTAnswer";
            this.lblPSTAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblPSTAnswer.TabIndex = 9;
            // 
            // lblGSTAnswer
            // 
            this.lblGSTAnswer.AutoSize = true;
            this.lblGSTAnswer.Location = new System.Drawing.Point(306, 292);
            this.lblGSTAnswer.Name = "lblGSTAnswer";
            this.lblGSTAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblGSTAnswer.TabIndex = 10;
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.AutoSize = true;
            this.lblTotalAnswer.Location = new System.Drawing.Point(306, 319);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAnswer.TabIndex = 11;
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Location = new System.Drawing.Point(147, 95);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(16, 13);
            this.lblMedium.TabIndex = 12;
            this.lblMedium.Text = "...";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Location = new System.Drawing.Point(147, 130);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(16, 13);
            this.lblLarge.TabIndex = 13;
            this.lblLarge.Text = "...";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(179, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 37);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 421);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblTotalAnswer);
            this.Controls.Add(this.lblGSTAnswer);
            this.Controls.Add(this.lblPSTAnswer);
            this.Controls.Add(this.lblSubtotalAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblpizzaSize);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.nudpizzaSize);
            this.Name = "Form1";
            this.Text = "Pizaa Order";
            ((System.ComponentModel.ISupportInitialize)(this.nudpizzaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudpizzaSize;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.Label lblpizzaSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalAnswer;
        private System.Windows.Forms.Label lblPSTAnswer;
        private System.Windows.Forms.Label lblGSTAnswer;
        private System.Windows.Forms.Label lblTotalAnswer;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Button btnCalculate;
    }
}


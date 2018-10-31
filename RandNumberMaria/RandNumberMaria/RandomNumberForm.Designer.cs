namespace RandNumberMaria
{
    partial class RandomNumberForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtnumGuess = new System.Windows.Forms.TextBox();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblNumberAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(94, 175);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(234, 40);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Random Number";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picAnswer
            // 
            this.picAnswer.Image = global::RandNumberMaria.Properties.Resources.red_x;
            this.picAnswer.Location = new System.Drawing.Point(150, 223);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(130, 93);
            this.picAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnswer.TabIndex = 1;
            this.picAnswer.TabStop = false;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(12, 122);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(268, 16);
            this.lblGuess.TabIndex = 2;
            this.lblGuess.Text = "Guess an Integer between 1 and 10:";
            // 
            // txtnumGuess
            // 
            this.txtnumGuess.Location = new System.Drawing.Point(291, 122);
            this.txtnumGuess.Name = "txtnumGuess";
            this.txtnumGuess.Size = new System.Drawing.Size(100, 20);
            this.txtnumGuess.TabIndex = 3;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrect.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Maroon;
            this.lblIncorrect.Location = new System.Drawing.Point(107, 9);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(224, 18);
            this.lblIncorrect.TabIndex = 4;
            this.lblIncorrect.Text = "Sorry, that\'s incorrect ";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Yellow;
            this.lblCorrect.Location = new System.Drawing.Point(98, 9);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(233, 18);
            this.lblCorrect.TabIndex = 5;
            this.lblCorrect.Text = "Good job, that\'s correct!";
            // 
            // lblNumberAnswer
            // 
            this.lblNumberAnswer.AutoSize = true;
            this.lblNumberAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberAnswer.Location = new System.Drawing.Point(195, 59);
            this.lblNumberAnswer.Name = "lblNumberAnswer";
            this.lblNumberAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblNumberAnswer.TabIndex = 6;
            // 
            // RandomNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(422, 326);
            this.Controls.Add(this.lblNumberAnswer);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.txtnumGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.picAnswer);
            this.Controls.Add(this.btnGenerate);
            this.Name = "RandomNumberForm";
            this.Text = "Random Number";
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picAnswer;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtnumGuess;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblNumberAnswer;
    }
}


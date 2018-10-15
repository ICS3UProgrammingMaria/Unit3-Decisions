namespace GuessGameMaria
{
    partial class GuessGameForm
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
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.txtnumGuess = new System.Windows.Forms.TextBox();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(21, 81);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(182, 48);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess an Integer \r\nbetween 1 and 10:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(25, 190);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(101, 37);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(149, 273);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(208, 22);
            this.lblCorrect.TabIndex = 3;
            this.lblCorrect.Text = "Correct, good job!";
            // 
            // txtnumGuess
            // 
            this.txtnumGuess.Location = new System.Drawing.Point(237, 109);
            this.txtnumGuess.Name = "txtnumGuess";
            this.txtnumGuess.Size = new System.Drawing.Size(100, 20);
            this.txtnumGuess.TabIndex = 4;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.Location = new System.Drawing.Point(83, 273);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(274, 22);
            this.lblIncorrect.TabIndex = 5;
            this.lblIncorrect.Text = "Whoops, that\'s incorrect";
            // 
            // picAnswer
            // 
            this.picAnswer.Image = global::GuessGameMaria.Properties.Resources.checkmark;
            this.picAnswer.Location = new System.Drawing.Point(177, 168);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(144, 83);
            this.picAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnswer.TabIndex = 7;
            this.picAnswer.TabStop = false;
            // 
            // GuessGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(369, 304);
            this.Controls.Add(this.picAnswer);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.txtnumGuess);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblGuess);
            this.Name = "GuessGameForm";
            this.Text = "Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.TextBox txtnumGuess;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.PictureBox picAnswer;
    }
}


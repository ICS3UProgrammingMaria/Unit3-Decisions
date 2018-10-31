namespace ChocolateBoxesMaria
{
    partial class ChocolateBoxesForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtnumBoxes = new System.Windows.Forms.TextBox();
            this.btnGetReward = new System.Windows.Forms.Button();
            this.lblRewardAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 109);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(329, 19);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Enter the number of boxes sold: ";
            // 
            // txtnumBoxes
            // 
            this.txtnumBoxes.BackColor = System.Drawing.Color.SkyBlue;
            this.txtnumBoxes.Location = new System.Drawing.Point(347, 108);
            this.txtnumBoxes.Name = "txtnumBoxes";
            this.txtnumBoxes.Size = new System.Drawing.Size(100, 20);
            this.txtnumBoxes.TabIndex = 1;
            // 
            // btnGetReward
            // 
            this.btnGetReward.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetReward.Location = new System.Drawing.Point(202, 198);
            this.btnGetReward.Name = "btnGetReward";
            this.btnGetReward.Size = new System.Drawing.Size(75, 23);
            this.btnGetReward.TabIndex = 2;
            this.btnGetReward.Text = "Get Reward";
            this.btnGetReward.UseVisualStyleBackColor = false;
            this.btnGetReward.Click += new System.EventHandler(this.btnGetReward_Click);
            // 
            // lblRewardAnswer
            // 
            this.lblRewardAnswer.AutoSize = true;
            this.lblRewardAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardAnswer.Location = new System.Drawing.Point(115, 248);
            this.lblRewardAnswer.Name = "lblRewardAnswer";
            this.lblRewardAnswer.Size = new System.Drawing.Size(25, 24);
            this.lblRewardAnswer.TabIndex = 3;
            this.lblRewardAnswer.Text = "...";
            // 
            // ChocolateBoxesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(468, 308);
            this.Controls.Add(this.lblRewardAnswer);
            this.Controls.Add(this.btnGetReward);
            this.Controls.Add(this.txtnumBoxes);
            this.Controls.Add(this.lblQuestion);
            this.Name = "ChocolateBoxesForm";
            this.Text = "Chocolate Boxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtnumBoxes;
        private System.Windows.Forms.Button btnGetReward;
        private System.Windows.Forms.Label lblRewardAnswer;
    }
}


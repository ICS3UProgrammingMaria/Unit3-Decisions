namespace RockPaperSciMaria
{
    partial class frmRockPaperSci
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerScissors = new System.Windows.Forms.RadioButton();
            this.radPlayerScissors = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(225, 285);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 28);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Image = global::RockPaperSciMaria.Properties.Resources.r;
            this.radComputerRock.Location = new System.Drawing.Point(348, 39);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(158, 122);
            this.radComputerRock.TabIndex = 4;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Image = global::RockPaperSciMaria.Properties.Resources.p;
            this.radComputerPaper.Location = new System.Drawing.Point(348, 167);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(158, 122);
            this.radComputerPaper.TabIndex = 5;
            this.radComputerPaper.TabStop = true;
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerScissors
            // 
            this.radComputerScissors.AutoSize = true;
            this.radComputerScissors.Image = global::RockPaperSciMaria.Properties.Resources.s;
            this.radComputerScissors.Location = new System.Drawing.Point(348, 300);
            this.radComputerScissors.Name = "radComputerScissors";
            this.radComputerScissors.Size = new System.Drawing.Size(158, 122);
            this.radComputerScissors.TabIndex = 6;
            this.radComputerScissors.TabStop = true;
            this.radComputerScissors.UseVisualStyleBackColor = true;
            // 
            // radPlayerScissors
            // 
            this.radPlayerScissors.AutoSize = true;
            this.radPlayerScissors.Image = global::RockPaperSciMaria.Properties.Resources.s;
            this.radPlayerScissors.Location = new System.Drawing.Point(55, 300);
            this.radPlayerScissors.Name = "radPlayerScissors";
            this.radPlayerScissors.Size = new System.Drawing.Size(158, 122);
            this.radPlayerScissors.TabIndex = 3;
            this.radPlayerScissors.TabStop = true;
            this.radPlayerScissors.UseVisualStyleBackColor = true;
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Image = global::RockPaperSciMaria.Properties.Resources.p;
            this.radPlayerPaper.Location = new System.Drawing.Point(55, 167);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(158, 122);
            this.radPlayerPaper.TabIndex = 2;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Image = global::RockPaperSciMaria.Properties.Resources.r;
            this.radPlayerRock.Location = new System.Drawing.Point(55, 39);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(158, 122);
            this.radPlayerRock.TabIndex = 1;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotxt_IV50", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(151, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Rock, Paper Scissors";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(269, 167);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(22, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = ".....";
            // 
            // RockPaperSciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 424);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.radComputerScissors);
            this.Controls.Add(this.radComputerPaper);
            this.Controls.Add(this.radComputerRock);
            this.Controls.Add(this.radPlayerScissors);
            this.Controls.Add(this.radPlayerPaper);
            this.Controls.Add(this.radPlayerRock);
            this.Controls.Add(this.btnPlay);
            this.Name = "RockPaperSciForm";
            this.Text = "Rock, Paper, Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radPlayerScissors;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerScissors;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResult;
    }
}


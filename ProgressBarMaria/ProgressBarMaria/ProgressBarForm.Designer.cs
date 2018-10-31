namespace ProgressBarMaria
{
    partial class frmProgressBar
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
            this.prbProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prbProgressBar
            // 
            this.prbProgressBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.prbProgressBar.Location = new System.Drawing.Point(24, 216);
            this.prbProgressBar.Name = "prbProgressBar";
            this.prbProgressBar.Size = new System.Drawing.Size(356, 37);
            this.prbProgressBar.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Location = new System.Drawing.Point(156, 87);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 63);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(401, 309);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.prbProgressBar);
            this.Name = "frmProgressBar";
            this.Text = "Progress Bar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbProgressBar;
        private System.Windows.Forms.Button btnStart;
    }
}


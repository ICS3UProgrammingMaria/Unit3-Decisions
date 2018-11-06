namespace RunningAveMaria
{
    partial class frmRunningAve
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
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblEnterNum = new System.Windows.Forms.Label();
            this.lblexitinfo = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAverage
            // 
            this.btnAverage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAverage.Location = new System.Drawing.Point(178, 249);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(142, 53);
            this.btnAverage.TabIndex = 0;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.AutoSize = true;
            this.lblEnterNum.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterNum.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNum.Location = new System.Drawing.Point(3, 152);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(329, 22);
            this.lblEnterNum.TabIndex = 1;
            this.lblEnterNum.Text = "Enter a number from 0 to 100:";
            // 
            // lblexitinfo
            // 
            this.lblexitinfo.AutoSize = true;
            this.lblexitinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblexitinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexitinfo.Location = new System.Drawing.Point(187, 222);
            this.lblexitinfo.Name = "lblexitinfo";
            this.lblexitinfo.Size = new System.Drawing.Size(124, 16);
            this.lblexitinfo.TabIndex = 2;
            this.lblexitinfo.Text = "(Enter - 1 to exit.)";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(350, 152);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(117, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // frmRunningAve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RunningAveMaria.Properties.Resources.running_image;
            this.ClientSize = new System.Drawing.Size(495, 361);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblexitinfo);
            this.Controls.Add(this.lblEnterNum);
            this.Controls.Add(this.btnAverage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmRunningAve";
            this.Text = "Running Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.Label lblexitinfo;
        private System.Windows.Forms.TextBox txtNumber;
    }
}


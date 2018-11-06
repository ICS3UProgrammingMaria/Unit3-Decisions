namespace ForEachMaria
{
    partial class frmForEach
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
            this.btnCntrlButton = new System.Windows.Forms.Button();
            this.lblCntrlClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCntrlButton
            // 
            this.btnCntrlButton.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCntrlButton.Location = new System.Drawing.Point(76, 110);
            this.btnCntrlButton.Name = "btnCntrlButton";
            this.btnCntrlButton.Size = new System.Drawing.Size(133, 44);
            this.btnCntrlButton.TabIndex = 0;
            this.btnCntrlButton.Text = "Click me";
            this.btnCntrlButton.UseVisualStyleBackColor = true;
            this.btnCntrlButton.Click += new System.EventHandler(this.btnCntrlButton_Click);
            // 
            // lblCntrlClick
            // 
            this.lblCntrlClick.AutoSize = true;
            this.lblCntrlClick.Font = new System.Drawing.Font("Monotxt_IV50", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntrlClick.Location = new System.Drawing.Point(60, 204);
            this.lblCntrlClick.Name = "lblCntrlClick";
            this.lblCntrlClick.Size = new System.Drawing.Size(165, 20);
            this.lblCntrlClick.TabIndex = 1;
            this.lblCntrlClick.Text = "No click me!";
            this.lblCntrlClick.Click += new System.EventHandler(this.lblCntrlClick_Click);
            // 
            // frmForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ForEachMaria.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(280, 278);
            this.Controls.Add(this.lblCntrlClick);
            this.Controls.Add(this.btnCntrlButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmForEach";
            this.Text = "For...Each with Control Objects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCntrlButton;
        private System.Windows.Forms.Label lblCntrlClick;
    }
}


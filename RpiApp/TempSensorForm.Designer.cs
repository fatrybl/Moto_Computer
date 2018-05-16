namespace RpiApp
{
    partial class TempSensorForm
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
            this.TempSensorLabel = new System.Windows.Forms.Label();
            this.PinNumberTextBox = new System.Windows.Forms.TextBox();
            this.TempPinApplyButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TempSensorLabel
            // 
            this.TempSensorLabel.AutoSize = true;
            this.TempSensorLabel.Location = new System.Drawing.Point(195, 107);
            this.TempSensorLabel.Name = "TempSensorLabel";
            this.TempSensorLabel.Size = new System.Drawing.Size(188, 20);
            this.TempSensorLabel.TabIndex = 0;
            this.TempSensorLabel.Text = "Choose pin for temp data";
            this.TempSensorLabel.Click += new System.EventHandler(this.TempSensorLabel_Click);
            // 
            // PinNumberTextBox
            // 
            this.PinNumberTextBox.Location = new System.Drawing.Point(199, 175);
            this.PinNumberTextBox.Name = "PinNumberTextBox";
            this.PinNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.PinNumberTextBox.TabIndex = 1;
            this.PinNumberTextBox.TextChanged += new System.EventHandler(this.PinNumberTextBox_TextChanged);
            // 
            // TempPinApplyButton
            // 
            this.TempPinApplyButton.Location = new System.Drawing.Point(199, 245);
            this.TempPinApplyButton.Name = "TempPinApplyButton";
            this.TempPinApplyButton.Size = new System.Drawing.Size(100, 48);
            this.TempPinApplyButton.TabIndex = 2;
            this.TempPinApplyButton.Text = "Apply";
            this.TempPinApplyButton.UseVisualStyleBackColor = true;
            this.TempPinApplyButton.Click += new System.EventHandler(this.TempPinApplyButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(467, 524);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 42);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TempSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 578);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TempPinApplyButton);
            this.Controls.Add(this.PinNumberTextBox);
            this.Controls.Add(this.TempSensorLabel);
            this.Name = "TempSensorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TempSensorLabel;
        private System.Windows.Forms.TextBox PinNumberTextBox;
        private System.Windows.Forms.Button TempPinApplyButton;
        private System.Windows.Forms.Button ExitButton;
    }
}


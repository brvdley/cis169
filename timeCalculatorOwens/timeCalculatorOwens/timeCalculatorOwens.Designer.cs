namespace timeCalculatorOwens
{
    partial class timeCalculatorOwens
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.borderLabel = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.daysOutputLabel = new System.Windows.Forms.Label();
            this.hoursOutputLabel = new System.Windows.Forms.Label();
            this.minutesOutputLabel = new System.Windows.Forms.Label();
            this.secondsOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(113, 31);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(80, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter Seconds:";
            // 
            // borderLabel
            // 
            this.borderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borderLabel.Location = new System.Drawing.Point(40, 72);
            this.borderLabel.Name = "borderLabel";
            this.borderLabel.Size = new System.Drawing.Size(345, 237);
            this.borderLabel.TabIndex = 1;
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(209, 28);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondsTextBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(69, 356);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(272, 356);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(56, 59);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(45, 13);
            this.resultsLabel.TabIndex = 5;
            this.resultsLabel.Text = "Results:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(110, 105);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(34, 13);
            this.daysLabel.TabIndex = 6;
            this.daysLabel.Text = "Days:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(106, 153);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(38, 13);
            this.hoursLabel.TabIndex = 7;
            this.hoursLabel.Text = "Hours:";
            this.hoursLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(97, 207);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(47, 13);
            this.minutesLabel.TabIndex = 8;
            this.minutesLabel.Text = "Minutes:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(92, 261);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(52, 13);
            this.secondsLabel.TabIndex = 9;
            this.secondsLabel.Text = "Seconds:";
            // 
            // daysOutputLabel
            // 
            this.daysOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysOutputLabel.Location = new System.Drawing.Point(152, 104);
            this.daysOutputLabel.Name = "daysOutputLabel";
            this.daysOutputLabel.Size = new System.Drawing.Size(117, 23);
            this.daysOutputLabel.TabIndex = 10;
            // 
            // hoursOutputLabel
            // 
            this.hoursOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOutputLabel.Location = new System.Drawing.Point(152, 152);
            this.hoursOutputLabel.Name = "hoursOutputLabel";
            this.hoursOutputLabel.Size = new System.Drawing.Size(117, 23);
            this.hoursOutputLabel.TabIndex = 11;
            // 
            // minutesOutputLabel
            // 
            this.minutesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutesOutputLabel.Location = new System.Drawing.Point(152, 207);
            this.minutesOutputLabel.Name = "minutesOutputLabel";
            this.minutesOutputLabel.Size = new System.Drawing.Size(117, 23);
            this.minutesOutputLabel.TabIndex = 12;
            // 
            // secondsOutputLabel
            // 
            this.secondsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondsOutputLabel.Location = new System.Drawing.Point(152, 260);
            this.secondsOutputLabel.Name = "secondsOutputLabel";
            this.secondsOutputLabel.Size = new System.Drawing.Size(117, 23);
            this.secondsOutputLabel.TabIndex = 13;
            // 
            // timeCalculatorOwens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 410);
            this.Controls.Add(this.secondsOutputLabel);
            this.Controls.Add(this.minutesOutputLabel);
            this.Controls.Add(this.hoursOutputLabel);
            this.Controls.Add(this.daysOutputLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.borderLabel);
            this.Controls.Add(this.promptLabel);
            this.Name = "timeCalculatorOwens";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label borderLabel;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label daysOutputLabel;
        private System.Windows.Forms.Label hoursOutputLabel;
        private System.Windows.Forms.Label minutesOutputLabel;
        private System.Windows.Forms.Label secondsOutputLabel;
    }
}


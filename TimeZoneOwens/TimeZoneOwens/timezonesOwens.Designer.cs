namespace TimeZoneOwens
{
    partial class timezonesOwens
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
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.timezoneLabel = new System.Windows.Forms.Label();
            this.timezoneOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityListBox
            // 
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.Items.AddRange(new object[] {
            "Denver",
            "Minneapolis",
            "New York",
            "San Francisco",
            "Honolulu"});
            this.cityListBox.Location = new System.Drawing.Point(114, 65);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(172, 134);
            this.cityListBox.TabIndex = 0;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(86, 21);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(221, 13);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "Select a city and I will give you the time zone.";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(75, 307);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "O&K";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(258, 307);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timezoneLabel
            // 
            this.timezoneLabel.AutoSize = true;
            this.timezoneLabel.Location = new System.Drawing.Point(94, 228);
            this.timezoneLabel.Name = "timezoneLabel";
            this.timezoneLabel.Size = new System.Drawing.Size(56, 13);
            this.timezoneLabel.TabIndex = 4;
            this.timezoneLabel.Text = "Timezone:";
            // 
            // timezoneOutputLabel
            // 
            this.timezoneOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timezoneOutputLabel.Location = new System.Drawing.Point(174, 227);
            this.timezoneOutputLabel.Name = "timezoneOutputLabel";
            this.timezoneOutputLabel.Size = new System.Drawing.Size(112, 26);
            this.timezoneOutputLabel.TabIndex = 5;
            // 
            // timezonesOwens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 387);
            this.Controls.Add(this.timezoneOutputLabel);
            this.Controls.Add(this.timezoneLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.cityListBox);
            this.Name = "timezonesOwens";
            this.Text = "Time Zones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label timezoneLabel;
        private System.Windows.Forms.Label timezoneOutputLabel;
    }
}


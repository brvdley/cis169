namespace HeadsOrTailsOwens
{
    partial class HeadsOrTails
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
            this.showTailsBtn = new System.Windows.Forms.Button();
            this.showHeadsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.headsPic = new System.Windows.Forms.PictureBox();
            this.tailsPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // showTailsBtn
            // 
            this.showTailsBtn.Location = new System.Drawing.Point(33, 208);
            this.showTailsBtn.Name = "showTailsBtn";
            this.showTailsBtn.Size = new System.Drawing.Size(75, 23);
            this.showTailsBtn.TabIndex = 1;
            this.showTailsBtn.Text = "Show &Tails";
            this.showTailsBtn.UseVisualStyleBackColor = true;
            this.showTailsBtn.Click += new System.EventHandler(this.showTailsBtn_Click);
            // 
            // showHeadsBtn
            // 
            this.showHeadsBtn.Location = new System.Drawing.Point(146, 208);
            this.showHeadsBtn.Name = "showHeadsBtn";
            this.showHeadsBtn.Size = new System.Drawing.Size(81, 23);
            this.showHeadsBtn.TabIndex = 2;
            this.showHeadsBtn.Text = "Show &Heads";
            this.showHeadsBtn.UseVisualStyleBackColor = true;
            this.showHeadsBtn.Click += new System.EventHandler(this.showHeadsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(257, 208);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headsPic
            // 
            this.headsPic.Image = global::HeadsOrTailsOwens.Properties.Resources.front;
            this.headsPic.Location = new System.Drawing.Point(232, 68);
            this.headsPic.Name = "headsPic";
            this.headsPic.Size = new System.Drawing.Size(100, 102);
            this.headsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPic.TabIndex = 1;
            this.headsPic.TabStop = false;
            // 
            // tailsPic
            // 
            this.tailsPic.Image = global::HeadsOrTailsOwens.Properties.Resources.tails;
            this.tailsPic.Location = new System.Drawing.Point(33, 68);
            this.tailsPic.Name = "tailsPic";
            this.tailsPic.Size = new System.Drawing.Size(100, 102);
            this.tailsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPic.TabIndex = 0;
            this.tailsPic.TabStop = false;
            this.tailsPic.Visible = false;
            // 
            // HeadsOrTails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 281);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showHeadsBtn);
            this.Controls.Add(this.showTailsBtn);
            this.Controls.Add(this.headsPic);
            this.Controls.Add(this.tailsPic);
            this.Name = "HeadsOrTails";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tailsPic;
        private System.Windows.Forms.PictureBox headsPic;
        private System.Windows.Forms.Button showTailsBtn;
        private System.Windows.Forms.Button showHeadsBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}


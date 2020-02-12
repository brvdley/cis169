namespace Card_Flip
{
    partial class CardFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardFlip));
            this.cardBackPic = new System.Windows.Forms.PictureBox();
            this.cardFacePic = new System.Windows.Forms.PictureBox();
            this.cardBackBtn = new System.Windows.Forms.Button();
            this.cardFaceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePic)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBackPic
            // 
            this.cardBackPic.Image = ((System.Drawing.Image)(resources.GetObject("cardBackPic.Image")));
            this.cardBackPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("cardBackPic.InitialImage")));
            this.cardBackPic.Location = new System.Drawing.Point(242, 30);
            this.cardBackPic.Name = "cardBackPic";
            this.cardBackPic.Size = new System.Drawing.Size(177, 227);
            this.cardBackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackPic.TabIndex = 0;
            this.cardBackPic.TabStop = false;
            // 
            // cardFacePic
            // 
            this.cardFacePic.Image = ((System.Drawing.Image)(resources.GetObject("cardFacePic.Image")));
            this.cardFacePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("cardFacePic.InitialImage")));
            this.cardFacePic.Location = new System.Drawing.Point(12, 30);
            this.cardFacePic.Name = "cardFacePic";
            this.cardFacePic.Size = new System.Drawing.Size(177, 227);
            this.cardFacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacePic.TabIndex = 1;
            this.cardFacePic.TabStop = false;
            this.cardFacePic.Visible = false;
            // 
            // cardBackBtn
            // 
            this.cardBackBtn.Location = new System.Drawing.Point(270, 308);
            this.cardBackBtn.Name = "cardBackBtn";
            this.cardBackBtn.Size = new System.Drawing.Size(116, 56);
            this.cardBackBtn.TabIndex = 2;
            this.cardBackBtn.Text = "Show the card\'s back";
            this.cardBackBtn.UseVisualStyleBackColor = true;
            this.cardBackBtn.Click += new System.EventHandler(this.cardBackBtn_Click);
            // 
            // cardFaceBtn
            // 
            this.cardFaceBtn.Location = new System.Drawing.Point(39, 308);
            this.cardFaceBtn.Name = "cardFaceBtn";
            this.cardFaceBtn.Size = new System.Drawing.Size(116, 56);
            this.cardFaceBtn.TabIndex = 3;
            this.cardFaceBtn.Text = "Show the card\'s face";
            this.cardFaceBtn.UseVisualStyleBackColor = true;
            this.cardFaceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 408);
            this.Controls.Add(this.cardFaceBtn);
            this.Controls.Add(this.cardBackBtn);
            this.Controls.Add(this.cardFacePic);
            this.Controls.Add(this.cardBackPic);
            this.Name = "CardFlip";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackPic;
        private System.Windows.Forms.PictureBox cardFacePic;
        private System.Windows.Forms.Button cardBackBtn;
        private System.Windows.Forms.Button cardFaceBtn;
    }
}


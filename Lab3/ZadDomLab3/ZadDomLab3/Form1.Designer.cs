namespace ZadDomLab3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelUserPassword = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxUserPassword = new System.Windows.Forms.TextBox();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelWithTiltle = new System.Windows.Forms.Label();
            this.LabelLogInTitle = new System.Windows.Forms.Label();
            this.PanelWithLogIn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelWithLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelUserName
            // 
            this.LabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUserName.Location = new System.Drawing.Point(20, 83);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(100, 23);
            this.LabelUserName.TabIndex = 0;
            this.LabelUserName.Text = "UserName";
            this.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUserPassword
            // 
            this.LabelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUserPassword.Location = new System.Drawing.Point(20, 129);
            this.LabelUserPassword.Name = "LabelUserPassword";
            this.LabelUserPassword.Size = new System.Drawing.Size(100, 23);
            this.LabelUserPassword.TabIndex = 1;
            this.LabelUserPassword.Text = "Password";
            this.LabelUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(142, 83);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(129, 20);
            this.TextBoxUserName.TabIndex = 2;
            // 
            // TextBoxUserPassword
            // 
            this.TextBoxUserPassword.Location = new System.Drawing.Point(142, 129);
            this.TextBoxUserPassword.Name = "TextBoxUserPassword";
            this.TextBoxUserPassword.Size = new System.Drawing.Size(129, 20);
            this.TextBoxUserPassword.TabIndex = 3;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.747663F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLogIn.Location = new System.Drawing.Point(84, 181);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(131, 36);
            this.ButtonLogIn.TabIndex = 4;
            this.ButtonLogIn.Text = "LogIn";
            this.ButtonLogIn.UseVisualStyleBackColor = false;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZadDomLab3.Properties.Resources.szkolaImage;
            this.pictureBox1.Location = new System.Drawing.Point(12, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LabelWithTiltle
            // 
            this.LabelWithTiltle.BackColor = System.Drawing.Color.DimGray;
            this.LabelWithTiltle.Font = new System.Drawing.Font("Impact", 22.20561F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWithTiltle.Location = new System.Drawing.Point(48, 106);
            this.LabelWithTiltle.Name = "LabelWithTiltle";
            this.LabelWithTiltle.Size = new System.Drawing.Size(344, 97);
            this.LabelWithTiltle.TabIndex = 6;
            this.LabelWithTiltle.Text = "I Liceum Ogólnokształcące";
            this.LabelWithTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLogInTitle
            // 
            this.LabelLogInTitle.Font = new System.Drawing.Font("Impact", 14.13084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelLogInTitle.Location = new System.Drawing.Point(51, 21);
            this.LabelLogInTitle.Name = "LabelLogInTitle";
            this.LabelLogInTitle.Size = new System.Drawing.Size(195, 59);
            this.LabelLogInTitle.TabIndex = 7;
            this.LabelLogInTitle.Text = "Zaloguj Się";
            this.LabelLogInTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelWithLogIn
            // 
            this.PanelWithLogIn.BackColor = System.Drawing.Color.DimGray;
            this.PanelWithLogIn.Controls.Add(this.LabelUserName);
            this.PanelWithLogIn.Controls.Add(this.LabelLogInTitle);
            this.PanelWithLogIn.Controls.Add(this.LabelUserPassword);
            this.PanelWithLogIn.Controls.Add(this.ButtonLogIn);
            this.PanelWithLogIn.Controls.Add(this.TextBoxUserPassword);
            this.PanelWithLogIn.Controls.Add(this.TextBoxUserName);
            this.PanelWithLogIn.Location = new System.Drawing.Point(463, 25);
            this.PanelWithLogIn.Name = "PanelWithLogIn";
            this.PanelWithLogIn.Size = new System.Drawing.Size(300, 237);
            this.PanelWithLogIn.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(856, 807);
            this.Controls.Add(this.PanelWithLogIn);
            this.Controls.Add(this.LabelWithTiltle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SchoolPlatform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelWithLogIn.ResumeLayout(false);
            this.PanelWithLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label LabelUserPassword;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxUserPassword;
        private System.Windows.Forms.Button ButtonLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelWithTiltle;
        private System.Windows.Forms.Label LabelLogInTitle;
        private System.Windows.Forms.Panel PanelWithLogIn;
    }
}


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
            this.SuspendLayout();
            // 
            // LabelUserName
            // 
            this.LabelUserName.Location = new System.Drawing.Point(463, 100);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(100, 23);
            this.LabelUserName.TabIndex = 0;
            this.LabelUserName.Text = "UserName";
            this.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUserPassword
            // 
            this.LabelUserPassword.Location = new System.Drawing.Point(463, 141);
            this.LabelUserPassword.Name = "LabelUserPassword";
            this.LabelUserPassword.Size = new System.Drawing.Size(100, 23);
            this.LabelUserPassword.TabIndex = 1;
            this.LabelUserPassword.Text = "Password";
            this.LabelUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(569, 102);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(129, 20);
            this.TextBoxUserName.TabIndex = 2;
            // 
            // TextBoxUserPassword
            // 
            this.TextBoxUserPassword.Location = new System.Drawing.Point(569, 141);
            this.TextBoxUserPassword.Name = "TextBoxUserPassword";
            this.TextBoxUserPassword.Size = new System.Drawing.Size(129, 20);
            this.TextBoxUserPassword.TabIndex = 3;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.Location = new System.Drawing.Point(567, 200);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(131, 36);
            this.ButtonLogIn.TabIndex = 4;
            this.ButtonLogIn.Text = "LogIn";
            this.ButtonLogIn.UseVisualStyleBackColor = true;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.TextBoxUserPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.LabelUserPassword);
            this.Controls.Add(this.LabelUserName);
            this.Name = "Form1";
            this.Text = "SchoolPlatform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label LabelUserPassword;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxUserPassword;
        private System.Windows.Forms.Button ButtonLogIn;
    }
}


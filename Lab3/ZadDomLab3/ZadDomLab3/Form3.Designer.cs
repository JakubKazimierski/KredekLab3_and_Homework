namespace ZadDomLab3
{
    partial class FormForStudents
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
            this.GradeLabelTitle = new System.Windows.Forms.Label();
            this.GradeLabelGrade = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleSchoolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GradeLabelTitle
            // 
            this.GradeLabelTitle.Font = new System.Drawing.Font("Elephant", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeLabelTitle.Location = new System.Drawing.Point(150, 181);
            this.GradeLabelTitle.Name = "GradeLabelTitle";
            this.GradeLabelTitle.Size = new System.Drawing.Size(176, 57);
            this.GradeLabelTitle.TabIndex = 0;
            this.GradeLabelTitle.Text = "Twoja Średnia Ocen:";
            this.GradeLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradeLabelGrade
            // 
            this.GradeLabelGrade.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GradeLabelGrade.Location = new System.Drawing.Point(341, 181);
            this.GradeLabelGrade.Name = "GradeLabelGrade";
            this.GradeLabelGrade.Size = new System.Drawing.Size(148, 57);
            this.GradeLabelGrade.TabIndex = 1;
            this.GradeLabelGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZadDomLab3.Properties.Resources.herb;
            this.pictureBox1.Location = new System.Drawing.Point(556, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TitleSchoolLabel
            // 
            this.TitleSchoolLabel.Font = new System.Drawing.Font("Algerian", 14.13084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSchoolLabel.Location = new System.Drawing.Point(98, 23);
            this.TitleSchoolLabel.Name = "TitleSchoolLabel";
            this.TitleSchoolLabel.Size = new System.Drawing.Size(452, 79);
            this.TitleSchoolLabel.TabIndex = 3;
            this.TitleSchoolLabel.Text = "I Liceum Ogólnoksztalcace";
            this.TitleSchoolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormForStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TitleSchoolLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GradeLabelGrade);
            this.Controls.Add(this.GradeLabelTitle);
            this.Name = "FormForStudents";
            this.Text = "SchoolPlatform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GradeLabelTitle;
        private System.Windows.Forms.Label GradeLabelGrade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleSchoolLabel;
    }
}
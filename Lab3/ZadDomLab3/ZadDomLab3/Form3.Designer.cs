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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GradeLabelTitle
            // 
            this.GradeLabelTitle.Location = new System.Drawing.Point(178, 181);
            this.GradeLabelTitle.Name = "GradeLabelTitle";
            this.GradeLabelTitle.Size = new System.Drawing.Size(148, 57);
            this.GradeLabelTitle.TabIndex = 0;
            this.GradeLabelTitle.Text = "Twoja Średnia Ocen:";
            this.GradeLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradeLabelGrade
            // 
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
            // FormForStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
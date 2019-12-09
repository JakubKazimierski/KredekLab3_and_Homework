namespace ZadDomLab3
{
    partial class SecretariatForm
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
            this.SecretariatGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SecretariatLabelSelectInfo = new System.Windows.Forms.Label();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.WorkersRadioButton = new System.Windows.Forms.RadioButton();
            this.RoleRadioButton = new System.Windows.Forms.RadioButton();
            this.StudentsRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SecretariatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SecretariatGridView
            // 
            this.SecretariatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecretariatGridView.Location = new System.Drawing.Point(12, 12);
            this.SecretariatGridView.Name = "SecretariatGridView";
            this.SecretariatGridView.RowHeadersWidth = 46;
            this.SecretariatGridView.Size = new System.Drawing.Size(257, 426);
            this.SecretariatGridView.TabIndex = 0;
            // 
            // SecretariatLabelSelectInfo
            // 
            this.SecretariatLabelSelectInfo.Location = new System.Drawing.Point(319, 12);
            this.SecretariatLabelSelectInfo.Name = "SecretariatLabelSelectInfo";
            this.SecretariatLabelSelectInfo.Size = new System.Drawing.Size(146, 45);
            this.SecretariatLabelSelectInfo.TabIndex = 1;
            this.SecretariatLabelSelectInfo.Text = "Wybierz Tabelę";
            this.SecretariatLabelSelectInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(322, 84);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(65, 17);
            this.SalaryRadioButton.TabIndex = 2;
            this.SalaryRadioButton.TabStop = true;
            this.SalaryRadioButton.Text = "Wypłaty";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            this.SalaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButton_CheckedChanged);
            // 
            // WorkersRadioButton
            // 
            this.WorkersRadioButton.AutoSize = true;
            this.WorkersRadioButton.Location = new System.Drawing.Point(322, 132);
            this.WorkersRadioButton.Name = "WorkersRadioButton";
            this.WorkersRadioButton.Size = new System.Drawing.Size(80, 17);
            this.WorkersRadioButton.TabIndex = 3;
            this.WorkersRadioButton.TabStop = true;
            this.WorkersRadioButton.Text = "Pracownicy";
            this.WorkersRadioButton.UseVisualStyleBackColor = true;
            this.WorkersRadioButton.CheckedChanged += new System.EventHandler(this.WorkersRadioButton_CheckedChanged);
            // 
            // RoleRadioButton
            // 
            this.RoleRadioButton.AutoSize = true;
            this.RoleRadioButton.Location = new System.Drawing.Point(322, 178);
            this.RoleRadioButton.Name = "RoleRadioButton";
            this.RoleRadioButton.Size = new System.Drawing.Size(131, 17);
            this.RoleRadioButton.TabIndex = 4;
            this.RoleRadioButton.TabStop = true;
            this.RoleRadioButton.Text = "Rodzaje Pracowników";
            this.RoleRadioButton.UseVisualStyleBackColor = true;
            this.RoleRadioButton.CheckedChanged += new System.EventHandler(this.RoleRadioButton_CheckedChanged);
            // 
            // StudentsRadioButton
            // 
            this.StudentsRadioButton.AutoSize = true;
            this.StudentsRadioButton.Location = new System.Drawing.Point(322, 223);
            this.StudentsRadioButton.Name = "StudentsRadioButton";
            this.StudentsRadioButton.Size = new System.Drawing.Size(74, 17);
            this.StudentsRadioButton.TabIndex = 5;
            this.StudentsRadioButton.TabStop = true;
            this.StudentsRadioButton.Text = "Uczniowie";
            this.StudentsRadioButton.UseVisualStyleBackColor = true;
            this.StudentsRadioButton.CheckedChanged += new System.EventHandler(this.StudentsRadioButton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZadDomLab3.Properties.Resources.herb;
            this.pictureBox1.Location = new System.Drawing.Point(563, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SecretariatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StudentsRadioButton);
            this.Controls.Add(this.RoleRadioButton);
            this.Controls.Add(this.WorkersRadioButton);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.SecretariatLabelSelectInfo);
            this.Controls.Add(this.SecretariatGridView);
            this.Name = "SecretariatForm";
            this.Text = "SchoolPlatform";
            ((System.ComponentModel.ISupportInitialize)(this.SecretariatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SecretariatGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label SecretariatLabelSelectInfo;
        private System.Windows.Forms.RadioButton SalaryRadioButton;
        private System.Windows.Forms.RadioButton WorkersRadioButton;
        private System.Windows.Forms.RadioButton RoleRadioButton;
        private System.Windows.Forms.RadioButton StudentsRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
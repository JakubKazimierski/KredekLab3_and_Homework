namespace ZadDomLab3
{
    partial class FormForHeadTeacher
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
            this.GriedVieverDataBase = new System.Windows.Forms.DataGridView();
            this.HeadTeacherLabelTableSelect = new System.Windows.Forms.Label();
            this.WorkerRadioButton = new System.Windows.Forms.RadioButton();
            this.StudentsRadioButton = new System.Windows.Forms.RadioButton();
            this.GradesRadioButton = new System.Windows.Forms.RadioButton();
            this.RoleRadioButton = new System.Windows.Forms.RadioButton();
            this.LogInsRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.ClassTeacherRadioButton = new System.Windows.Forms.RadioButton();
            this.WorkerPanel = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PeselLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.PeselTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GriedVieverDataBase)).BeginInit();
            this.WorkerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GriedVieverDataBase
            // 
            this.GriedVieverDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GriedVieverDataBase.Location = new System.Drawing.Point(12, 12);
            this.GriedVieverDataBase.Name = "GriedVieverDataBase";
            this.GriedVieverDataBase.RowHeadersWidth = 46;
            this.GriedVieverDataBase.Size = new System.Drawing.Size(503, 450);
            this.GriedVieverDataBase.TabIndex = 0;
            // 
            // HeadTeacherLabelTableSelect
            // 
            this.HeadTeacherLabelTableSelect.Location = new System.Drawing.Point(541, 12);
            this.HeadTeacherLabelTableSelect.Name = "HeadTeacherLabelTableSelect";
            this.HeadTeacherLabelTableSelect.Size = new System.Drawing.Size(282, 50);
            this.HeadTeacherLabelTableSelect.TabIndex = 1;
            this.HeadTeacherLabelTableSelect.Text = "Wybierz Tabelę";
            this.HeadTeacherLabelTableSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkerRadioButton
            // 
            this.WorkerRadioButton.AutoSize = true;
            this.WorkerRadioButton.Location = new System.Drawing.Point(544, 91);
            this.WorkerRadioButton.Name = "WorkerRadioButton";
            this.WorkerRadioButton.Size = new System.Drawing.Size(80, 17);
            this.WorkerRadioButton.TabIndex = 2;
            this.WorkerRadioButton.TabStop = true;
            this.WorkerRadioButton.Text = "Pracownicy";
            this.WorkerRadioButton.UseVisualStyleBackColor = true;
            this.WorkerRadioButton.CheckedChanged += new System.EventHandler(this.WorkerRadioButton_CheckedChanged);
            // 
            // StudentsRadioButton
            // 
            this.StudentsRadioButton.AutoSize = true;
            this.StudentsRadioButton.Location = new System.Drawing.Point(544, 132);
            this.StudentsRadioButton.Name = "StudentsRadioButton";
            this.StudentsRadioButton.Size = new System.Drawing.Size(74, 17);
            this.StudentsRadioButton.TabIndex = 3;
            this.StudentsRadioButton.TabStop = true;
            this.StudentsRadioButton.Text = "Uczniowie";
            this.StudentsRadioButton.UseVisualStyleBackColor = true;
            this.StudentsRadioButton.CheckedChanged += new System.EventHandler(this.StudentsRadioButton_CheckedChanged);
            // 
            // GradesRadioButton
            // 
            this.GradesRadioButton.AutoSize = true;
            this.GradesRadioButton.Location = new System.Drawing.Point(544, 179);
            this.GradesRadioButton.Name = "GradesRadioButton";
            this.GradesRadioButton.Size = new System.Drawing.Size(100, 17);
            this.GradesRadioButton.TabIndex = 4;
            this.GradesRadioButton.TabStop = true;
            this.GradesRadioButton.Text = "Oceny Uczniów";
            this.GradesRadioButton.UseVisualStyleBackColor = true;
            this.GradesRadioButton.CheckedChanged += new System.EventHandler(this.GradesRadioButton_CheckedChanged);
            // 
            // RoleRadioButton
            // 
            this.RoleRadioButton.AutoSize = true;
            this.RoleRadioButton.Location = new System.Drawing.Point(544, 228);
            this.RoleRadioButton.Name = "RoleRadioButton";
            this.RoleRadioButton.Size = new System.Drawing.Size(131, 17);
            this.RoleRadioButton.TabIndex = 5;
            this.RoleRadioButton.TabStop = true;
            this.RoleRadioButton.Text = "Rodzaje Pracowników";
            this.RoleRadioButton.UseVisualStyleBackColor = true;
            this.RoleRadioButton.CheckedChanged += new System.EventHandler(this.RoleRadioButton_CheckedChanged);
            // 
            // LogInsRadioButton
            // 
            this.LogInsRadioButton.AutoSize = true;
            this.LogInsRadioButton.Location = new System.Drawing.Point(544, 271);
            this.LogInsRadioButton.Name = "LogInsRadioButton";
            this.LogInsRadioButton.Size = new System.Drawing.Size(93, 17);
            this.LogInsRadioButton.TabIndex = 6;
            this.LogInsRadioButton.TabStop = true;
            this.LogInsRadioButton.Text = "Loginy i Hasła";
            this.LogInsRadioButton.UseVisualStyleBackColor = true;
            this.LogInsRadioButton.CheckedChanged += new System.EventHandler(this.LogInsRadioButton_CheckedChanged);
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(544, 312);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(65, 17);
            this.SalaryRadioButton.TabIndex = 7;
            this.SalaryRadioButton.TabStop = true;
            this.SalaryRadioButton.Text = "Wypłaty";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            this.SalaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButton_CheckedChanged);
            // 
            // ClassTeacherRadioButton
            // 
            this.ClassTeacherRadioButton.AutoSize = true;
            this.ClassTeacherRadioButton.Location = new System.Drawing.Point(544, 350);
            this.ClassTeacherRadioButton.Name = "ClassTeacherRadioButton";
            this.ClassTeacherRadioButton.Size = new System.Drawing.Size(124, 17);
            this.ClassTeacherRadioButton.TabIndex = 8;
            this.ClassTeacherRadioButton.TabStop = true;
            this.ClassTeacherRadioButton.Text = "Wychowawcy i klasy";
            this.ClassTeacherRadioButton.UseVisualStyleBackColor = true;
            this.ClassTeacherRadioButton.CheckedChanged += new System.EventHandler(this.ClassTeacherRadioButton_CheckedChanged);
            // 
            // WorkerPanel
            // 
            this.WorkerPanel.Controls.Add(this.PeselTextBox);
            this.WorkerPanel.Controls.Add(this.RoleTextBox);
            this.WorkerPanel.Controls.Add(this.SurnameTextBox);
            this.WorkerPanel.Controls.Add(this.NameTextBox);
            this.WorkerPanel.Controls.Add(this.RoleLabel);
            this.WorkerPanel.Controls.Add(this.PeselLabel);
            this.WorkerPanel.Controls.Add(this.SurnameLabel);
            this.WorkerPanel.Controls.Add(this.NameLabel);
            this.WorkerPanel.Location = new System.Drawing.Point(801, 91);
            this.WorkerPanel.Name = "WorkerPanel";
            this.WorkerPanel.Size = new System.Drawing.Size(253, 238);
            this.WorkerPanel.TabIndex = 9;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(28, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Imię";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Location = new System.Drawing.Point(28, 62);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(100, 23);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Nazwisko";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeselLabel
            // 
            this.PeselLabel.Location = new System.Drawing.Point(28, 103);
            this.PeselLabel.Name = "PeselLabel";
            this.PeselLabel.Size = new System.Drawing.Size(100, 23);
            this.PeselLabel.TabIndex = 2;
            this.PeselLabel.Text = "Pesel";
            this.PeselLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoleLabel
            // 
            this.RoleLabel.Location = new System.Drawing.Point(28, 137);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(100, 23);
            this.RoleLabel.TabIndex = 3;
            this.RoleLabel.Text = "Rola";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(134, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(134, 65);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 5;
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(134, 140);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoleTextBox.TabIndex = 6;
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.Location = new System.Drawing.Point(134, 103);
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeselTextBox.TabIndex = 7;
            // 
            // FormForHeadTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 474);
            this.Controls.Add(this.WorkerPanel);
            this.Controls.Add(this.ClassTeacherRadioButton);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.LogInsRadioButton);
            this.Controls.Add(this.RoleRadioButton);
            this.Controls.Add(this.GradesRadioButton);
            this.Controls.Add(this.StudentsRadioButton);
            this.Controls.Add(this.WorkerRadioButton);
            this.Controls.Add(this.HeadTeacherLabelTableSelect);
            this.Controls.Add(this.GriedVieverDataBase);
            this.Name = "FormForHeadTeacher";
            this.Text = "SchoolPlatform";
            ((System.ComponentModel.ISupportInitialize)(this.GriedVieverDataBase)).EndInit();
            this.WorkerPanel.ResumeLayout(false);
            this.WorkerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GriedVieverDataBase;
        private System.Windows.Forms.Label HeadTeacherLabelTableSelect;
        private System.Windows.Forms.RadioButton WorkerRadioButton;
        private System.Windows.Forms.RadioButton StudentsRadioButton;
        private System.Windows.Forms.RadioButton GradesRadioButton;
        private System.Windows.Forms.RadioButton RoleRadioButton;
        private System.Windows.Forms.RadioButton LogInsRadioButton;
        private System.Windows.Forms.RadioButton SalaryRadioButton;
        private System.Windows.Forms.RadioButton ClassTeacherRadioButton;
        private System.Windows.Forms.Panel WorkerPanel;
        private System.Windows.Forms.Label PeselLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PeselTextBox;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label RoleLabel;
    }
}
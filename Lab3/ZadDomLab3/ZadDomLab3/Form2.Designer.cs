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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.LoginsPanel = new System.Windows.Forms.Panel();
            this.PeselPanel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserPeselTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginsUpdateButton = new System.Windows.Forms.Button();
            this.LoginsInsertButton = new System.Windows.Forms.Button();
            this.LoginsDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GriedVieverDataBase)).BeginInit();
            this.WorkerPanel.SuspendLayout();
            this.LoginsPanel.SuspendLayout();
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
            this.WorkerPanel.Controls.Add(this.SelectButton);
            this.WorkerPanel.Controls.Add(this.InsertButton);
            this.WorkerPanel.Controls.Add(this.UpdateButton);
            this.WorkerPanel.Controls.Add(this.PeselTextBox);
            this.WorkerPanel.Controls.Add(this.RoleTextBox);
            this.WorkerPanel.Controls.Add(this.SurnameTextBox);
            this.WorkerPanel.Controls.Add(this.NameTextBox);
            this.WorkerPanel.Controls.Add(this.RoleLabel);
            this.WorkerPanel.Controls.Add(this.PeselLabel);
            this.WorkerPanel.Controls.Add(this.SurnameLabel);
            this.WorkerPanel.Controls.Add(this.NameLabel);
            this.WorkerPanel.Enabled = false;
            this.WorkerPanel.Location = new System.Drawing.Point(797, 12);
            this.WorkerPanel.Name = "WorkerPanel";
            this.WorkerPanel.Size = new System.Drawing.Size(253, 261);
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
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(31, 177);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(203, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Aktualizuj Dane";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(31, 206);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(203, 23);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Wprowadź Dane";
            this.InsertButton.UseVisualStyleBackColor = true;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(31, 235);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(203, 23);
            this.SelectButton.TabIndex = 10;
            this.SelectButton.Text = "Wyszukaj Pracownika";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // LoginsPanel
            // 
            this.LoginsPanel.Controls.Add(this.LoginsDeleteButton);
            this.LoginsPanel.Controls.Add(this.LoginsInsertButton);
            this.LoginsPanel.Controls.Add(this.LoginsUpdateButton);
            this.LoginsPanel.Controls.Add(this.PasswordTextBox);
            this.LoginsPanel.Controls.Add(this.LoginTextBox);
            this.LoginsPanel.Controls.Add(this.UserPeselTextBox);
            this.LoginsPanel.Controls.Add(this.PasswordLabel);
            this.LoginsPanel.Controls.Add(this.UserNameLabel);
            this.LoginsPanel.Controls.Add(this.PeselPanel);
            this.LoginsPanel.Enabled = false;
            this.LoginsPanel.Location = new System.Drawing.Point(797, 279);
            this.LoginsPanel.Name = "LoginsPanel";
            this.LoginsPanel.Size = new System.Drawing.Size(253, 221);
            this.LoginsPanel.TabIndex = 10;
            // 
            // PeselPanel
            // 
            this.PeselPanel.Location = new System.Drawing.Point(28, 27);
            this.PeselPanel.Name = "PeselPanel";
            this.PeselPanel.Size = new System.Drawing.Size(100, 23);
            this.PeselPanel.TabIndex = 11;
            this.PeselPanel.Text = "Pesel";
            this.PeselPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Location = new System.Drawing.Point(28, 71);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(100, 23);
            this.UserNameLabel.TabIndex = 12;
            this.UserNameLabel.Text = "Login";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(28, 110);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 23);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Hasło";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPeselTextBox
            // 
            this.UserPeselTextBox.Location = new System.Drawing.Point(134, 27);
            this.UserPeselTextBox.Name = "UserPeselTextBox";
            this.UserPeselTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserPeselTextBox.TabIndex = 11;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(134, 74);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 14;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(134, 113);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 15;
            // 
            // LoginsUpdateButton
            // 
            this.LoginsUpdateButton.Location = new System.Drawing.Point(31, 139);
            this.LoginsUpdateButton.Name = "LoginsUpdateButton";
            this.LoginsUpdateButton.Size = new System.Drawing.Size(203, 23);
            this.LoginsUpdateButton.TabIndex = 11;
            this.LoginsUpdateButton.Text = "Aktualizuj Dane";
            this.LoginsUpdateButton.UseVisualStyleBackColor = true;
            // 
            // LoginsInsertButton
            // 
            this.LoginsInsertButton.Location = new System.Drawing.Point(31, 168);
            this.LoginsInsertButton.Name = "LoginsInsertButton";
            this.LoginsInsertButton.Size = new System.Drawing.Size(203, 23);
            this.LoginsInsertButton.TabIndex = 16;
            this.LoginsInsertButton.Text = "Wprowadź Dane";
            this.LoginsInsertButton.UseVisualStyleBackColor = true;
            // 
            // LoginsDeleteButton
            // 
            this.LoginsDeleteButton.Location = new System.Drawing.Point(31, 195);
            this.LoginsDeleteButton.Name = "LoginsDeleteButton";
            this.LoginsDeleteButton.Size = new System.Drawing.Size(203, 23);
            this.LoginsDeleteButton.TabIndex = 17;
            this.LoginsDeleteButton.Text = "Usuń Dane";
            this.LoginsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // FormForHeadTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 550);
            this.Controls.Add(this.LoginsPanel);
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
            this.LoginsPanel.ResumeLayout(false);
            this.LoginsPanel.PerformLayout();
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
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel LoginsPanel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox UserPeselTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PeselPanel;
        private System.Windows.Forms.Button LoginsDeleteButton;
        private System.Windows.Forms.Button LoginsInsertButton;
        private System.Windows.Forms.Button LoginsUpdateButton;
    }
}
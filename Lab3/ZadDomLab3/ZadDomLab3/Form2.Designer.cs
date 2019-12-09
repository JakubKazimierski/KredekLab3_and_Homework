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
            ((System.ComponentModel.ISupportInitialize)(this.GriedVieverDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // GriedVieverDataBase
            // 
            this.GriedVieverDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GriedVieverDataBase.Location = new System.Drawing.Point(12, 12);
            this.GriedVieverDataBase.Name = "GriedVieverDataBase";
            this.GriedVieverDataBase.RowHeadersWidth = 46;
            this.GriedVieverDataBase.Size = new System.Drawing.Size(490, 450);
            this.GriedVieverDataBase.TabIndex = 0;
            // 
            // HeadTeacherLabelTableSelect
            // 
            this.HeadTeacherLabelTableSelect.Location = new System.Drawing.Point(508, 12);
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
            // 
            // FormForHeadTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 474);
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
    }
}
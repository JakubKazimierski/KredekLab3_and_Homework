namespace ZadDomLab3
{
    partial class TeacherForm
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
            this.TeacherTableDataGridViever = new System.Windows.Forms.DataGridView();
            this.StudentsRadioButton = new System.Windows.Forms.RadioButton();
            this.ClassTeacherRadioButton = new System.Windows.Forms.RadioButton();
            this.GradesRadioButton = new System.Windows.Forms.RadioButton();
            this.TeacherLabelSelect = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTableDataGridViever)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherTableDataGridViever
            // 
            this.TeacherTableDataGridViever.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherTableDataGridViever.Location = new System.Drawing.Point(12, 12);
            this.TeacherTableDataGridViever.Name = "TeacherTableDataGridViever";
            this.TeacherTableDataGridViever.RowHeadersWidth = 46;
            this.TeacherTableDataGridViever.Size = new System.Drawing.Size(291, 426);
            this.TeacherTableDataGridViever.TabIndex = 0;
            // 
            // StudentsRadioButton
            // 
            this.StudentsRadioButton.AutoSize = true;
            this.StudentsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.728972F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentsRadioButton.Location = new System.Drawing.Point(373, 118);
            this.StudentsRadioButton.Name = "StudentsRadioButton";
            this.StudentsRadioButton.Size = new System.Drawing.Size(81, 17);
            this.StudentsRadioButton.TabIndex = 1;
            this.StudentsRadioButton.TabStop = true;
            this.StudentsRadioButton.Text = "Uczniowie";
            this.StudentsRadioButton.UseVisualStyleBackColor = true;
            this.StudentsRadioButton.CheckedChanged += new System.EventHandler(this.StudentsRadioButton_CheckedChanged);
            // 
            // ClassTeacherRadioButton
            // 
            this.ClassTeacherRadioButton.AutoSize = true;
            this.ClassTeacherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.728972F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClassTeacherRadioButton.Location = new System.Drawing.Point(373, 160);
            this.ClassTeacherRadioButton.Name = "ClassTeacherRadioButton";
            this.ClassTeacherRadioButton.Size = new System.Drawing.Size(151, 17);
            this.ClassTeacherRadioButton.TabIndex = 2;
            this.ClassTeacherRadioButton.TabStop = true;
            this.ClassTeacherRadioButton.Text = "Wychowawstwa i klasy";
            this.ClassTeacherRadioButton.UseVisualStyleBackColor = true;
            this.ClassTeacherRadioButton.CheckedChanged += new System.EventHandler(this.ClassTeacherRadioButton_CheckedChanged);
            // 
            // GradesRadioButton
            // 
            this.GradesRadioButton.AutoSize = true;
            this.GradesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.728972F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GradesRadioButton.Location = new System.Drawing.Point(373, 201);
            this.GradesRadioButton.Name = "GradesRadioButton";
            this.GradesRadioButton.Size = new System.Drawing.Size(110, 17);
            this.GradesRadioButton.TabIndex = 3;
            this.GradesRadioButton.TabStop = true;
            this.GradesRadioButton.Text = "Oceny Uczniów";
            this.GradesRadioButton.UseVisualStyleBackColor = true;
            this.GradesRadioButton.CheckedChanged += new System.EventHandler(this.GradesRadioButton_CheckedChanged);
            // 
            // TeacherLabelSelect
            // 
            this.TeacherLabelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TeacherLabelSelect.Location = new System.Drawing.Point(348, 49);
            this.TeacherLabelSelect.Name = "TeacherLabelSelect";
            this.TeacherLabelSelect.Size = new System.Drawing.Size(126, 38);
            this.TeacherLabelSelect.TabIndex = 4;
            this.TeacherLabelSelect.Text = "Wybierz Tabelę";
            this.TeacherLabelSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZadDomLab3.Properties.Resources.herb;
            this.pictureBox1.Location = new System.Drawing.Point(573, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TeacherLabelSelect);
            this.Controls.Add(this.GradesRadioButton);
            this.Controls.Add(this.ClassTeacherRadioButton);
            this.Controls.Add(this.StudentsRadioButton);
            this.Controls.Add(this.TeacherTableDataGridViever);
            this.Name = "TeacherForm";
            this.Text = "SchoolPlatform";
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTableDataGridViever)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeacherTableDataGridViever;
        private System.Windows.Forms.RadioButton StudentsRadioButton;
        private System.Windows.Forms.RadioButton ClassTeacherRadioButton;
        private System.Windows.Forms.RadioButton GradesRadioButton;
        private System.Windows.Forms.Label TeacherLabelSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
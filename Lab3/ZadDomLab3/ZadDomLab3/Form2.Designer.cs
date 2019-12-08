namespace ZadDomLab3
{
    partial class AfterLogInForm
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
            ((System.ComponentModel.ISupportInitialize)(this.GriedVieverDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // GriedVieverDataBase
            // 
            this.GriedVieverDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GriedVieverDataBase.Location = new System.Drawing.Point(12, 12);
            this.GriedVieverDataBase.Name = "GriedVieverDataBase";
            this.GriedVieverDataBase.RowHeadersWidth = 46;
            this.GriedVieverDataBase.Size = new System.Drawing.Size(260, 426);
            this.GriedVieverDataBase.TabIndex = 0;
            // 
            // AfterLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GriedVieverDataBase);
            this.Name = "AfterLogInForm";
            this.Text = "SchoolPlatform";
            ((System.ComponentModel.ISupportInitialize)(this.GriedVieverDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GriedVieverDataBase;
    }
}
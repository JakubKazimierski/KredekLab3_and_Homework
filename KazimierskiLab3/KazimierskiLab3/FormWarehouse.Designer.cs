namespace KazimierskiLab3
{
    partial class FormWarehouse
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
            this.DataBaseGridView = new System.Windows.Forms.DataGridView();
            this.ButtonFiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBaseGridView
            // 
            this.DataBaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseGridView.Location = new System.Drawing.Point(126, 129);
            this.DataBaseGridView.Name = "DataBaseGridView";
            this.DataBaseGridView.RowHeadersWidth = 46;
            this.DataBaseGridView.Size = new System.Drawing.Size(445, 267);
            this.DataBaseGridView.TabIndex = 0;
            // 
            // ButtonFiltr
            // 
            this.ButtonFiltr.Location = new System.Drawing.Point(126, 56);
            this.ButtonFiltr.Name = "ButtonFiltr";
            this.ButtonFiltr.Size = new System.Drawing.Size(445, 35);
            this.ButtonFiltr.TabIndex = 1;
            this.ButtonFiltr.Text = "Filtr_Button";
            this.ButtonFiltr.UseVisualStyleBackColor = true;
            this.ButtonFiltr.Click += new System.EventHandler(this.ButtonFiltr_Click);
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonFiltr);
            this.Controls.Add(this.DataBaseGridView);
            this.Name = "FormWarehouse";
            this.Text = "FormWarehouse";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBaseGridView;
        private System.Windows.Forms.Button ButtonFiltr;
    }
}
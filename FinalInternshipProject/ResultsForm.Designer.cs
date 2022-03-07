namespace FinalInternshipProject
{
    partial class ResultsForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(591, 236);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(126, 36);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(110, 17);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Filtered Results:";
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.AllowUserToAddRows = false;
            this.resultsDataGrid.AllowUserToDeleteRows = false;
            this.resultsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Location = new System.Drawing.Point(12, 30);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.ReadOnly = true;
            this.resultsDataGrid.RowTemplate.Height = 24;
            this.resultsDataGrid.Size = new System.Drawing.Size(1265, 200);
            this.resultsDataGrid.TabIndex = 0;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 284);
            this.Controls.Add(this.resultsDataGrid);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.backButton);
            this.Name = "ResultsForm";
            this.Text = "Service Requests";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.DataGridView resultsDataGrid;
    }
}
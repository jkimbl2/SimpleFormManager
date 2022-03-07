namespace FinalInternshipProject
{
    partial class EditForm
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
            this.editDataGrid = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // editDataGrid
            // 
            this.editDataGrid.AllowUserToOrderColumns = true;
            this.editDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.editDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.editDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editDataGrid.Location = new System.Drawing.Point(22, 12);
            this.editDataGrid.Name = "editDataGrid";
            this.editDataGrid.RowTemplate.Height = 24;
            this.editDataGrid.Size = new System.Drawing.Size(1265, 200);
            this.editDataGrid.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(741, 262);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(126, 36);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(443, 262);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(126, 36);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close Request";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(592, 262);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 36);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save and Exit";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 320);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editDataGrid);
            this.Controls.Add(this.backButton);
            this.Name = "EditForm";
            this.Text = "Edit Requests";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView editDataGrid;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
    }
}
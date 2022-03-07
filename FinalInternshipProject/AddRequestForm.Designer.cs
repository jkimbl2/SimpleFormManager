namespace FinalInternshipProject
{
    partial class AddRequestForm
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.technicianTextBox = new System.Windows.Forms.TextBox();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 40);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(134, 40);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(182, 22);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // technicianTextBox
            // 
            this.technicianTextBox.Location = new System.Drawing.Point(134, 82);
            this.technicianTextBox.Name = "technicianTextBox";
            this.technicianTextBox.Size = new System.Drawing.Size(182, 22);
            this.technicianTextBox.TabIndex = 3;
            // 
            // technicianLabel
            // 
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Location = new System.Drawing.Point(12, 82);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Size = new System.Drawing.Size(81, 17);
            this.technicianLabel.TabIndex = 2;
            this.technicianLabel.Text = "Technician:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(134, 124);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(182, 164);
            this.notesTextBox.TabIndex = 5;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(12, 124);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(116, 17);
            this.notesLabel.TabIndex = 4;
            this.notesLabel.Text = "Notes (Optional):";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(38, 326);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 39);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLabel.Location = new System.Drawing.Point(12, 306);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 17);
            this.feedbackLabel.TabIndex = 7;
            this.feedbackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(177, 326);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 39);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 377);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.technicianTextBox);
            this.Controls.Add(this.technicianLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "AddRequestForm";
            this.Text = "Add Request";
            this.Load += new System.EventHandler(this.AddRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox technicianTextBox;
        private System.Windows.Forms.Label technicianLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Button backButton;
    }
}
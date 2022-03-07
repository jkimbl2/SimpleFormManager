namespace FinalInternshipProject
{
    partial class Form1
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
            this.getDataButton = new System.Windows.Forms.Button();
            this.showClosedCheckBox = new System.Windows.Forms.CheckBox();
            this.technicianTextBox = new System.Windows.Forms.TextBox();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.addRequestsButton = new System.Windows.Forms.Button();
            this.exactCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(136, 111);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(175, 39);
            this.getDataButton.TabIndex = 3;
            this.getDataButton.Text = "Show Requests";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // showClosedCheckBox
            // 
            this.showClosedCheckBox.AutoSize = true;
            this.showClosedCheckBox.Location = new System.Drawing.Point(136, 84);
            this.showClosedCheckBox.Name = "showClosedCheckBox";
            this.showClosedCheckBox.Size = new System.Drawing.Size(175, 21);
            this.showClosedCheckBox.TabIndex = 2;
            this.showClosedCheckBox.Text = "Show Closed Requests";
            this.showClosedCheckBox.UseVisualStyleBackColor = true;
            // 
            // technicianTextBox
            // 
            this.technicianTextBox.Location = new System.Drawing.Point(211, 29);
            this.technicianTextBox.Name = "technicianTextBox";
            this.technicianTextBox.Size = new System.Drawing.Size(100, 22);
            this.technicianTextBox.TabIndex = 0;
            // 
            // technicianLabel
            // 
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Location = new System.Drawing.Point(124, 32);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Size = new System.Drawing.Size(81, 17);
            this.technicianLabel.TabIndex = 0;
            this.technicianLabel.Text = "Technician:";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(39, 188);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(106, 39);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(115, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(214, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Help Desk Service Requests";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(162, 188);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 39);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit Requests";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addRequestsButton
            // 
            this.addRequestsButton.Location = new System.Drawing.Point(293, 188);
            this.addRequestsButton.Name = "addRequestsButton";
            this.addRequestsButton.Size = new System.Drawing.Size(113, 39);
            this.addRequestsButton.TabIndex = 6;
            this.addRequestsButton.Text = "Add Requests";
            this.addRequestsButton.UseVisualStyleBackColor = true;
            this.addRequestsButton.Click += new System.EventHandler(this.addRequestsButton_Click);
            // 
            // exactCheckBox
            // 
            this.exactCheckBox.AutoSize = true;
            this.exactCheckBox.Location = new System.Drawing.Point(136, 57);
            this.exactCheckBox.Name = "exactCheckBox";
            this.exactCheckBox.Size = new System.Drawing.Size(154, 21);
            this.exactCheckBox.TabIndex = 1;
            this.exactCheckBox.Text = "Search Exact Name";
            this.exactCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 237);
            this.Controls.Add(this.exactCheckBox);
            this.Controls.Add(this.addRequestsButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.technicianLabel);
            this.Controls.Add(this.technicianTextBox);
            this.Controls.Add(this.showClosedCheckBox);
            this.Controls.Add(this.getDataButton);
            this.Name = "Form1";
            this.Text = "Help Desk Service Requests";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.CheckBox showClosedCheckBox;
        private System.Windows.Forms.TextBox technicianTextBox;
        private System.Windows.Forms.Label technicianLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addRequestsButton;
        private System.Windows.Forms.CheckBox exactCheckBox;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalInternshipProject
{
    public partial class AddRequestForm : Form
    {
        public AddRequestForm()
        {
            InitializeComponent();
        }

        private void AddRequestForm_Load(object sender, EventArgs e)
        {
            //create an instance of a ToolTip to use when the user hovers over certain objects.
            ToolTip addRequestToolTip = new ToolTip();
            addRequestToolTip.SetToolTip(descriptionLabel, "Type a short description of the problem here.");
            addRequestToolTip.SetToolTip(descriptionTextBox, "Type a short description of the problem here.");
            addRequestToolTip.SetToolTip(technicianLabel, "Type the name of the technician assigned to this request.");
            addRequestToolTip.SetToolTip(technicianTextBox, "Type the name of the technician assigned to this request.");
            addRequestToolTip.SetToolTip(notesLabel , "Type any additional info you think would be relevant here.");
            addRequestToolTip.SetToolTip(notesTextBox, "Type any additional info you think would be relevant here.");
            addRequestToolTip.SetToolTip(addButton, "Click this to add your request to the database");
            addRequestToolTip.SetToolTip(backButton, "Click this to close this form.");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //make sure there's a description, if not tell the user
            if (descriptionTextBox.Text == "")
            {
                feedbackLabel.Text = "Please enter a description.";
            }
            //make sure there's an assigned technician, if not tell the user
            else if (technicianTextBox.Text == "")
            {
                feedbackLabel.Text = "Please enter the name of a technician";
            }
            else
            {
                //crate a new list of strings that contain the CSV rows
                List<String> newfile = new List<string>();
                using (StreamReader reader = new StreamReader("files/HelpDesk.csv"))
                {
                    while (reader.EndOfStream == false)
                    {
                        newfile.Add(reader.ReadLine());
                    }
                }
                //get the current date to add to the request
                DateTime dateRequested = DateTime.Today;
                //create a new request based on the given data
                ServiceRequest myRequest = new ServiceRequest(dateRequested.ToShortDateString(),descriptionTextBox.Text,technicianTextBox.Text,"",notesTextBox.Text);
                //add the new request to the list of strings with the data converted to CSV
                newfile.Add(myRequest.ToCSV());
                //overwrite the HelpDesk.csv file with the new list.
                using (StreamWriter writer = new StreamWriter("files/HelpDesk.csv"))
                {
                    newfile.ForEach(r => writer.WriteLine(r));
                }
                feedbackLabel.Text = "Data successfully written to file.";
                descriptionTextBox.Clear();
                technicianTextBox.Clear();
                notesTextBox.Clear();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //close this form.
            this.Close();
        }
    }
}

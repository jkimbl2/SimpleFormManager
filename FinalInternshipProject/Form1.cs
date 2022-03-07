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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create an instance of a ToolTip to use when the user hovers over certain objects.
            ToolTip form1ToolTip = new ToolTip();
            form1ToolTip.SetToolTip(technicianLabel, "Enter the name of a technician to search for here, or leave it blank to show all results.");
            form1ToolTip.SetToolTip(technicianTextBox, "Enter the name of a technician to search for here, or leave it blank to show all results.");
            form1ToolTip.SetToolTip(showClosedCheckBox, "Check this box to allow closed reports to appear in your search as well.");
            form1ToolTip.SetToolTip(exactCheckBox, "Check this box to show only items that fit the exact result of your search");
            form1ToolTip.SetToolTip(getDataButton, "Click this to show the results of your search.");
            form1ToolTip.SetToolTip(helpButton, "Click this to view the help page on how to use this program.");
            form1ToolTip.SetToolTip(editButton, "Click this to get an editable table containing the data from the database.");
            form1ToolTip.SetToolTip(addRequestsButton, "Click this to open a form in which you can add a new request to the database.");

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            //open an instance of the Help Form
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            //Open an instance of the Results Form, filled with data using the ShowResults method
            ResultsForm results = new ResultsForm();
            results.showResults(this.technicianTextBox.Text, showClosedCheckBox.Checked, exactCheckBox.Checked);
            results.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Open an instance of the Edit form
            EditForm edit = new EditForm();
            edit.Show();
        }

        private void addRequestsButton_Click(object sender, EventArgs e)
        {
            //open an instance of the Add Request Form
            AddRequestForm addRequest = new AddRequestForm();
            addRequest.Show();
        }
    }
}

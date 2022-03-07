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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        public void showResults(string filter, bool showClosed, bool exactSearch)
        {
            //use a try/catch statement to ensure that nothing crashes.
            try
            {
                using (StreamReader reader = new StreamReader("files/HelpDesk.csv"))
                {
                    List<ServiceRequest> requests = new List<ServiceRequest>();
                    //until end of stream, get collect results, and add them to the file if they match the filter
                    while (reader.EndOfStream == false)
                    {
                        //create a new servicerequest object by splitting the data from the CSV file
                        ServiceRequest request = new ServiceRequest(reader.ReadLine().Split(','));
                        //if the filter matches or is nonexistent, and the show closed textbox is checked or the time completed is null, add the request to the list.  
                        if (showClosed == true || request.dateCompleted.Trim() == "")
                        {
                            if ((exactSearch == false && (filter == "" || request.assignedTechnician.ToLower().Contains(filter.ToLower())))||(exactSearch == true && request.assignedTechnician == filter)){ requests.Add(request); }
                        }
                    }
                    //add results from the list to the text box
                    resultsDataGrid.DataSource = requests;
                }
            }
            catch(Exception ex)
            {
            }
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            //create an instance of a ToolTip to use when the user hovers over certain objects.
            ToolTip resultsToolTip = new ToolTip();
            resultsToolTip.SetToolTip(backButton, "Click this to close this form.");
            resultsToolTip.SetToolTip(descriptionLabel, "This table contains all results found by the search.");
            resultsToolTip.SetToolTip(resultsDataGrid, "This table contains all results found by the search.");
        }
    }
}

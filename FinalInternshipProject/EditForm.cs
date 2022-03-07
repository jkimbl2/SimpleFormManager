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
    public partial class EditForm : Form
    {
        List<ServiceRequest> requests = new List<ServiceRequest>();
        public EditForm()
        {
            InitializeComponent();
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("files/HelpDesk.csv"))
            {
                //until end of stream, get collect results, and add them to the file if they match the filter
                while (reader.EndOfStream == false)
                {
                    ServiceRequest request = new ServiceRequest(reader.ReadLine().Split(','));
                    requests.Add(request);
                }
                editDataGrid.DataSource = requests;
            }
            //create a new tool tip to display informatiion about items whenthe user hovers over them
            ToolTip editToolTip = new ToolTip();
            editToolTip.SetToolTip(backButton, "Click this to close this form without saving changes.");
            editToolTip.SetToolTip(editDataGrid, "Double click a cell to edit it.");
            editToolTip.SetToolTip(closeButton, "Click on the lefthand side of a row, then click this button to add today's date to the completed date.");
            editToolTip.SetToolTip(saveButton, "Click this to save your changes to the detabase and close this form.");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //when a row or rows are selected, fill in the date completed for them with today's date if they are empty
            foreach (DataGridViewRow r in editDataGrid.SelectedRows)
            {
                if (((String)r.Cells[3].Value).Trim() == "")
                {
                    r.Cells[3].Value = DateTime.Today;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //close this form, without saving changes
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //write the changes to the CSV file, then close the form.
            List<string> newfile = new List<string>();
            requests.ForEach(r => newfile.Add(r.ToCSV()));
            using (StreamWriter writer = new StreamWriter("files/HelpDesk.csv"))
            {
                newfile.ForEach(r => writer.WriteLine(r));
            }
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalInternshipProject
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            //create an instance of a ToolTip to use when the user hovers over certain objects.
            ToolTip helpToolTip = new ToolTip();
            helpToolTip.SetToolTip(backButton, "Click this to close this form.");
        }
    }
}

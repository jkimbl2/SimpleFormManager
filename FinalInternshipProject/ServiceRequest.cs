using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalInternshipProject
{
    class ServiceRequest
    {
        //create a basic class to store the required information in.
        public string dateRequested { get; set; }
        public string description { get; set; }
        public string assignedTechnician { get; set; }
        public string dateCompleted { get; set; }
        public string notes { get; set; }

        //make a constructor to create a new completed ServiceRequest
        public ServiceRequest (string dateRequested, string description, string assignedTechnician, string dateCompleted, string notes)
        {
            this.dateRequested = dateRequested;
            this.description = description;
            this.assignedTechnician = assignedTechnician;
            this.dateCompleted = dateCompleted;
            this.notes = notes;
        }

        //make a constructor to create a new instance of the ServiceRequest using a string array
        public ServiceRequest(string[] request)
        {
            dateRequested = request[0];
            description = request[1];
            assignedTechnician = request[2];
            dateCompleted = request[3];
            if (request.Count() >= 5)
            {
                notes = request[4];
            }
        }

        //return the data as a CSV
        public string ToCSV()
        {
            return (dateRequested + "," + description + "," + assignedTechnician + "," + dateCompleted + "," + notes);
        }

        //create an updated ToString method to return the stored values.
        public override string ToString()
        {
            //check if dateCompleted is null or empty, and make it display "Not Completed" in case it is."
            string stringDateCompleted = dateCompleted.Trim();
            if (stringDateCompleted == "")
            {
                stringDateCompleted = "Not Completed";
            }
            return ("Date Requested: " + dateRequested + " Description: " + description + " Assigned Technician: " + assignedTechnician + " Date Completed: " + stringDateCompleted + " Notes: " + notes);
        }
    }
}

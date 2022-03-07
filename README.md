# SimpleFormManager
A simple program that I wrote based on my Internship. can read and write CSV files to create a local database of sorts. 

**Setup:** the only setup required is unzipping the files into their own folder, opening FinalInternshipProject.sln, and running it from within Visual Studio. In order to not have to worry about a complex setup, I opted to use a CSV file for my database. The csv is located in FinalInternshipProject\bin\Debug\files if you would like to look at it or modify it yourself.

**Important notes:** all pages have fully working tab indexing, as well as tooltips. Sometimes tooltips can be a bit of a pain with items such as Text Boxes and Data grids, so in those instances the label for those items has the same tooltip to ensure the user can read it.

**Main Page:** The main page consists of a text box, two check boxes, and four buttons. The Text box, labeled with Technician is where the user will enter the name of the technician they want to search for. The technicians implemented in the csv are John Doe and Jane Doe. Clicking Show Requests will filter through the records and bring up an instance of the requests form containing all the requests that fit the filter. It will accept partial input (i.e. John), as well as case insensitive input (i.e. jane doe) unless the Search Exact Name text box is checked. It will not list any requests with a closed date, unless the Show Closed Requests check box is checked. The three buttons at the bottom each bring up the other forms. Help brings up the Help Form, Edit Requests brings up the Edit Form, and Add Requests brings up the Add Request Form.

**Requests:** This page consists of a read only Data grid consisting of the results of the filter, as well as a Back Button, which closes the form when clicked.

**Help:** This page contains a much more simplified version of the instructions to this program, as well as a button to go back, closing the form.

**Edit:** This page contains an Editable version of the Data grid and contains the entire CSV file. You can double click on a cell to open it and fill it in with whatever information you want. You can click to the sides to select an entire row.  While selecting an entire row, you can click Close Request to automatically fill in an empty dateCompleted cell with today’s date. Clicking Save and Exit will save the changes you made to the CSV file. Clicking Back will close the file without saving your changes.

**Add Request:** This page contains three text boxes; Description, Technician, and Notes. The Add button will automatically generate a new CSV row and add it to the file, as long as the Description and Technician are filled in. Clicking back will close the form.

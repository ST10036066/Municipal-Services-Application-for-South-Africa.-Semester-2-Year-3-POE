using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services_Application_for_South_Africa
{
    public partial class ServiceReqStatusForm : Form
    {
        private RedBlackTree serviceRequests = new RedBlackTree(); 
        private int requestIdCounter = 0; //The ID acts as the key for the Red-Black Tree node.
        public ServiceReqStatusForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
//-------------------------------------------------------------------------------------------------------------------------------
        //Every request has an identifier to prevent  conflicts in the Red-Black Tree.
        private int GenerateRequestId()
        {
            return ++requestIdCounter; // Increment and return the counter
        }

//-------------------------------------------------------------------------------------------------------------------------------
        //ValidationForUserInput helps the user to enter correct 
        //    expected input. When they enter incorrect input , the user 
        //    must be alerted using a message box and the textbox is cleared
        private void ValidateInput(string ReqLocation, string category, string ReqDescription, DateTimePicker RqdateTimePicker, string RqProgress)
        {
            string validationMessage = string.Empty;

            // Validate event description
            if (string.IsNullOrEmpty(ReqDescription) || ReqDescription.Length < 5)
            {
                validationMessage = string.IsNullOrEmpty(ReqDescription)
                    ? "It looks like some information is missing or incorrect. \nTry this: More bin posts. Our community needs more bins to reduce littering. Please assist us."
                    : "The event description is short and will cause confusion. Try this: More bin posts. Our community needs more bins to reduce littering. Please assist us.";
                ShowValidationMessage(validationMessage, "Invalid Description");
            }
            // Validate category selection
            else if (ServiceReqCategorySelectionListBox.SelectedIndex == -1)
            {
                validationMessage = "It seems like you did not choose a category. \nTry this: Tap the Category box under step 2 (e.g., Water & Sanitation).";
                ShowValidationMessage(validationMessage, "Invalid Category");
            }
            // Validate location
            else if (string.IsNullOrWhiteSpace(ReqLocation) || ReqLocation.Length < 5)
            {
                validationMessage = string.IsNullOrWhiteSpace(ReqLocation)
                    ? "It looks like some information is missing or incorrect. \nTry a location that looks like this: Clarefeather Square 12 ABC River Road."
                    : "Location must be at least 5 characters long. Try this: enter the area or the street location or both.";
                ShowValidationMessage(validationMessage, "Invalid Location");
            }
            // Validate date
            else if (RqdateTimePicker.Value.Date <= DateTime.Today)
            {
                validationMessage = "Please select a future datet. Requests cannot be scheduled for today or the past.";
                ShowValidationMessage(validationMessage, "Invalid Date");
            }
            else
            {
                // All inputs are valid
                MessageBox.Show("All report details are valid!",
                    "Success, Thank you for helping yourself and the community. ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Display the validation message if there are issues
            MessageBox.Show(validationMessage,
                "It seems like you skipped a step while you were requesting for a service. Try this: ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ShowValidationMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SubmitReportButton_Click(object sender, EventArgs e)
        {
          
        }

        private void SubmitReqButton_Click(object sender, EventArgs e)
        {
            //validating input before using graph data structure. 
            //the input is validated by calling the ValidateInput method. 
            //input validation is imortant to ensure the correct data is saved

            int requestId = GenerateRequestId(); // Unique key, e.g., timestamp or counter
            var request = new ServiceRequest
            {
                ServiceLocation= RequestLocationTB.Text, //getting input for the location where the service is required
                ServiceCategory = ServiceReqCategorySelectionListBox.SelectedItem.ToString(),  //getting input for type of service required using category selction in a list box
                ServiceDescription = RequestDescriptionTb.Text, //getting input for the description of what type of service is being requested (getting into detail)
                PreferredDate = ReqDateTimePicker.Value, //getting the preferred date for the service to be fullfiled from the date picker
                ProgressStatus = ReqStatusListBox.SelectedItem.ToString() //stating the progress of the request whether the service request has been addressed, in progress or cancelled (using the list box)
            };

            //each service request has a unique identify followed by a request(look at line 103)
            serviceRequests.Insert(requestId, request);
            MessageBox.Show("Request submitted successfully.");
        }
    }
}

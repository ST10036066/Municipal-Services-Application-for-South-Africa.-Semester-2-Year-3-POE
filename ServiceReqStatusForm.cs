using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services_Application_for_South_Africa
{
    public partial class ServiceReqStatusForm : Form
    {
        private RedBlackTree serviceRequests = new RedBlackTree(); 
        private int requestIdCounter = 0; //The ID acts as the key for the Red-Black Tree node.
        private SortedSet<ServiceRequest> heap = new SortedSet<ServiceRequest>();

        public ServiceReqStatusForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Every request has an identifier to prevent  conflicts in the Red-Black Tree.
        private int GenerateRequestId()
        {
            return ++requestIdCounter; // Increment and return the counter
        }

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
     
        /// <summary>
        /// ValidateInpit helps the user enter the correct details so the correct data is processed. 
        /// when the inccrect details are attempted to be processed, an error message box pops up 
        /// </summary>
        /// <param name="ReqLocation"></param>
        /// <param name="category"></param>
        /// <param name="ReqDescription"></param>
        /// <param name="RqdateTimePicker"></param>
        /// <param name="RqProgress"></param>
        private void ValidateInput(string ReqLocation, string category, string ReqDescription, DateTimePicker RqdateTimePicker, string RqProgress)
        {
            string Validation = string.Empty;
            //.Value/Date picks the actual date chosen and validation is done using .Value.Date
            DateTime ServiceReqDate = RqdateTimePicker.Value.Date;
            // Combining different validation cases 
            switch (true)
            {
                case bool _ when string.IsNullOrEmpty(ReqLocation): // checking for empty location input. 
                    Validation = "It looks like some information is missing or incorrect. " +
                        "\n Try a location that looks like this: \n Clarefeather Square 12 ABC River road"; //an example displays helps understand the expected input from them
                    MessageBox.Show(Validation, "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Warning); //message box serves an alert for the user 
                    break;

                case bool _ when ReqLocation.Length < 5: //most likey most locations are more than 5 lenghts of string
                    Validation = "Location must be at least 5 characters long. Try this: describe how the  area looks or the street location";  //an example displays helps understand the expected input from them
                    MessageBox.Show(Validation, "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case bool _ when string.IsNullOrEmpty(category): //checking if no list option is selected(the empty is the key word)
                    Validation = "It seems like you did not choose a category. \n Try this: Tap the Category box under step 2 (e.g., Water & Sanitation).";  //an example displays helps understand the expected input from them
                    MessageBox.Show(Validation, "Invalid Category chosen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case bool _ when string.IsNullOrEmpty(ReqDescription): //when the input filed is empty, a message box is shown
                    Validation = "It seems like you did not describe the service request. Try this: Type in details such as \n" +
                        "The community of ABC needs more bins. Please add green bins every 500 steps apart to reduce littering"; //an example displays helps understand the expected input from them
                    MessageBox.Show(Validation, "Invalid Description entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case bool _ when ReqDescription.Length < 5: //the <5 rule helps the user avoid entering vague or unspecific service request details
                    Validation = "Description must be at least 5 characters long.\n Try this: Expand on the service delivery request. For example\n 'With more bins, people are able to see where they can dispose their litter instead of dropping it on the ground" +
                         "Right now there are no bins are school children are leaving their containers on the floor. This service is needed"; //an example displays helps understand the expected input from them
                    MessageBox.Show(Validation, "Invalid Description entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
              
                case bool _ when  ServiceReqDate < DateTime.Today:  //even if the service delivery has not been addressed, the user needs to pick a date from the present moment or the future to emphasis the need for the service request
                    Validation = "Please select a todays date or any upcoming days to highlight priority.";
                    MessageBox.Show(Validation, "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case bool _ when string.IsNullOrEmpty(RqProgress): //when there is not listbox item chosen, a message box pops up
                    Validation = "It seems like you did not choose the progress of the service delivery you are requesing. \n Try this: Tap the progress box under step 5 (e.g., Not started)."; //an example displays helps understand the expected input from them
                    MessageBox.Show(Validation, "Invalid Category chosen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    Validation = "All inputs are valid. Your report has been sent"; //in some cases when all input fields are correct, a message box is shown to the user to let them know that they have entered the correct type of details.
                    //this helps with application to user engagement which adds a user-friendly / usability element
                    break;
            }

            // Display the validation message if there are issues
// checks if the Validation variable does not contain the success message "All inputs are valid. Your report has been sent".
//This means if the Validation message is anything other than the success message, there was a problem with the user's input (e.g., missing data, incorrect format).
            if (Validation != "All inputs are valid. Your request has been sent")
            {

                MessageBox.Show("All service delivery request details are valid!", "Success, Thank you for helping yourself and the community. \n Click on Service Request progress tab to view all requests", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Validation, "It seems like you skipped a step while you were requesting for service delivery. Please try again: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
            }
        }

  //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// ClearFields is useful for clearing the input after a user attepts to submit their request while their input is wrong
        /// </summary>
        private void ClearFields()
        {
           RequestLocationTB.Clear(); //clearing the input for the location where the service is required
            ServiceReqCategorySelectionListBox.ClearSelected();  //clearing input for type of service required using category selction in a list box
            RequestDescriptionTb.Clear(); //clearing the  input for the description of what type of service is being requested (getting into detail)
            ReqStatusListBox.ClearSelected();//clearing the progress of the request whether the service request has been addressed, in progress or cancelled (using the list box)

        }
        private void SubmitReportButton_Click(object sender, EventArgs e)
        {
          
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This method handles the submission of a service request when the SubmitReqButton is clicked.
        /// It validates the input provided by the user, generates a unique request ID, and creates a new service request object.
        /// After validation, the request is added:
        /// The red-black tree stores the requests for efficient searching and retrieval, while the heap stores the requests to manage their priority.
        ///
        /// A confirmation message is shown to the user after successful submission.
        /// </summary>
        /// <param name="sender">The object that triggered the event (SubmitReqButton).</param>
        /// <param name="e">The event data.</param>
        private void SubmitReqButton_Click(object sender, EventArgs e)
        {
            //validating input before using  data structure. 
            //the input is validated by calling the ValidateInput method. 
            //input validation is imortant to ensure the correct data is saved

            int requestId = GenerateRequestId(); // Unique key, e.g., timestamp or counter
            
            
            var request = new ServiceRequest
            {
                ServiceLocation= RequestLocationTB.Text, //getting input for the location where the service is required
                ServiceCategory = ServiceReqCategorySelectionListBox.SelectedItem.ToString(),  //getting input for type of service required using category selction in a list box
                ServiceDescription = RequestDescriptionTb.Text, //getting input for the description of what type of service is being requested (getting into detail)
                PreferredDate = ReqDateTimePicker.Value, //getting the preferred date for the service to be fullfiled from the date picker
                ProgressStatus = ReqStatusListBox.SelectedItem.ToString(), //stating the progress of the request whether the service request has been addressed, in progress or cancelled (using the list box)
                Priority = CalculatePriority(ReqDateTimePicker.Value)
            };
            
            // Validating the request
            ValidateInput(request.ServiceLocation, request.ServiceCategory, request.ServiceDescription, ReqDateTimePicker, request.ProgressStatus);

            serviceRequests.Insert(requestId, request);// Inserting the service request into the red-black tree

            heap.Add(request);   // Addig  the service request to the heap based on its priority

            // Showing a success message with the request ID as an element of user engagement 
            MessageBox.Show("Request submitted successfully with ID: {request.RequestId}.");
        }
 //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Calculates the priority of the service request based on the preferred date.
        /// The closer the preferred date is to the current date, the higher the priority.
        /// </summary>
        /// <param name="preferredDate">The preferred date for the service to be fulfilled.</param>
        /// <returns>An integer value representing the priority of the request. A lower value indicates a higher priority.</returns>
        private int CalculatePriority(DateTime preferredDate)
        {
            // Calculating the difference in days between the preferred date and the current date.
           
            int datePriority = (int)(preferredDate - DateTime.Now).TotalDays; //  // The closer the preferred date is to the current date, the higher the priority.

            return datePriority; // then  returning the calculated priority value

        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///ViewReq_Click handles the button click event to display the service requests sorted by priority.
        /// the requests are "extracted" from the heap, sorts them by priority, and binds them to a ListBox for display.
        /// </summary>
        /// <param name="sender">The source of the event (the button that was clicked).</param>
        /// <param name="e">The event data.</param>
        private void ViewReq_Click(object sender, EventArgs e)
        {
            
            var requestList = new List<ServiceRequest>(heap); // Extract and sort requests
           
            // Binding requests to a ListBox (ViewReqListBox)
            ViewReqListBox.DataSource = requestList.OrderBy(r => r.Priority).ToList(); // Displaying in priority order
        }

        private void ServiceReqStatusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
//--------------------------------------------------------------------------------------------------END OF CODE-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
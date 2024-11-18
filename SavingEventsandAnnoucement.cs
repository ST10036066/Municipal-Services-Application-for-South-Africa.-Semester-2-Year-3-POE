using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Municipal_Services_Application_for_South_Africa
{
    //this i swhere the person wants to enter an event or annoucement
    //the event and announcements are viewed @LocalEventsAndAnnoucement form (i think i need to change the name  to avoid confusion)

    //the plan :
    //use queues becuase of the First in First out. For example:
    //    Event 1: Date: October 14, Time: 10:30 AM.
    //Event 2: Date: October 14, Time: 2:00 PM.
    //Event 3: Date: October 15, Time: 11:00 AM.

    //manage events by date and time, you would:

    //Process Event 1 first, because it’s on October 14 and at 10:30 AM.
    //Then process Event 2 on October 14 but at 2:00 PM.
    //Finally, process Event 3, which occurs on October 15.

    //in summary 
    // Add new events to the queue(enqueue).
    //Process upcoming events(dequeue).
    //For a priority queue, ensure that events with higher importance(such as VIP events) are processed before less important ones.

    

    //sets are for the dates because :I can create a set to store unique event categories like music, education, sports. This ensures that each category only appears once
    public partial class SavingEventsandAnnoucement : Form
    {
        // dictionary to store events by date
        public Dictionary<DateTime, string> EventList = new Dictionary<DateTime, string>();

        // sorted set  to store unique dates to avoid more tha one event for one day
        public SortedSet<DateTime> dateSet = new SortedSet<DateTime>();

        //queue will be helpful @LocalEventsAndAnnoucements
        //this was recommened by co-pilot(referecnes will be added in the README file)
        public Queue<Dictionary<DateTime, string>> queueOfEvents = new Queue<Dictionary<DateTime, string>>();

       
        public SavingEventsandAnnoucement()
        {
            InitializeComponent();
        }

        private void EventDescripRTB_TextChanged(object sender, EventArgs e)
        {
            //user is describing the event 

        }
  //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void SubmitEventButton_Click(object sender, EventArgs e)
        {
                string EventDescription = EventDescripRTB.Text; // The event described by the user
                string EventLocation = EventLocationRTB.Text;  // The event location by the user
                DateTime EvdateTime = EventdateTimePicker.Value;

                // Call ValidateInput with the existing DateTimePicker
                ValidateInput(EventDescription, EventLocation, EventdateTimePicker);

                // Combine inputs into a single string
                string combinedEventInput = $"{EventDescription} - {EventLocation} - {EvdateTime.ToString("yyyy-MM-dd")} - {EventCategorySelectionListBox.SelectedItem}";

                // Check if the event date already exists in the dictionary
                if (!EventList.ContainsKey(EvdateTime))
                {
                    // Add the event to the dictionary
                    EventList[EvdateTime] = combinedEventInput;

                    // Enqueue the event dictionary
                    queueOfEvents.Enqueue(new Dictionary<DateTime, string>(EventList));

                    // Show success message
                    MessageBox.Show("Event added successfully! On the top right you can click back to Main Menu");
                }
                else
                {
                    // Show error message if the event date already exists
                    MessageBox.Show("Unfortunately an event on this date already exists. Choose another date.");
                }

                // Add the date to the SortedSet to ensure uniqueness
                if (dateSet.Add(EvdateTime))
                {
                    EventList[EvdateTime] = combinedEventInput;
                }

                // Clear fields after adding the event
                ClearFields();

        }

 //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// /ValidationForUserInput helps the user to enter correct
        /// expected input. When they enter incorrect input , the user 
        ///  must be alerted using a message box and the textbox is cleared
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
    
 //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ShowValidationMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ValidateInput(string EvDescription, string EvLocation, DateTimePicker EvdateTimePicker)
        {
            string Validation = string.Empty;

            //.Value/Date picks the actual date chosen and validation is done using .Value.Date
            DateTime eventDate = EvdateTimePicker.Value.Date;

            
            switch (true)
            {
                //checking if no empty a description entered . If so (IsNullOrEmpty)a warning is shown to user
                case bool _ when string.IsNullOrEmpty(EvDescription) || EvDescription.Length < 5:
                    Validation = string.IsNullOrEmpty(EvDescription)
                        ? "It looks like some information is missing or incorrect. " +
                          "\n For example: City Annual Beach Cleanup. Every year we clean the beach as a community. Join us this year too."
                        : "The event description is short and will cause confusion. Try this: City Annual Beach Cleanup." +
                          " Every year we clean the beach as a community. Join us this year too.";
                    ShowValidationMessage(Validation, "Invalid Description");
                    break;

                //checking whether a category is not picked. If  no date is chosen(=0)then a warning is shown to user
                case bool _ when EventCategorySelectionListBox.SelectedIndex == 0:
                    Validation = "It seems like you did not choose a category. \n Try this: Tap the Category box under step 2 (e.g., Water & Sanitation).";
                    ShowValidationMessage(Validation, "Invalid Category chosen");
                    break;
                //checking for missing location details. If so(IsNullOrWhiteSpace) then a warning message is sent
                case bool _ when string.IsNullOrWhiteSpace(EvLocation) || EvLocation.Length < 5:
                    Validation = string.IsNullOrWhiteSpace(EvLocation)
                        ? "It looks like some information is missing or incorrect. " +
                        "\n Try a location that looks like this: \n Clarefeather Square 12 ABC River Road." 
                    :   "Location must be at least 5 characters long. Try this: enter the area or the street location or both.";
                   
                    ShowValidationMessage(Validation, "Invalid Location");
                    break;

                //checking is the date matches today or yesterday. If so (==, <.DateTime.Today) then a warning is alerted to user
                case bool _ when eventDate == DateTime.Today || eventDate < DateTime.Today:
                    Validation = "Please select a future date for the event. Events cannot be scheduled for today or the past.";
                    ShowValidationMessage(Validation, "Invalid Date");
                    break;

            
                    //if everything is okay then a message is sent to show user all inputs are good to go
                default:
                    Validation = "All inputs are valid. Your report has been sent.";
                    break;
            }

            // Display the validation message if there are issues
            if (Validation != "All inputs are valid. Your report has been sent.")
            {
                //if everything is missing then a warning is still sent to the user
                //checking in every way (to my knowledge) to avoid empty spaces and white spaces
                MessageBox.Show(Validation, "It seems like you skipped a step while you were reporting. Try this: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //eveyrhting is typed in by the user and a message is shown to them 
                MessageBox.Show("All report details are valid!", "Success, Thank you for helping yourself and the community. \n Navigate to the top right for the Main Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
 //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ClearFields() {
            //easy to have a clean textbox when re-typing or entering a new event
          EventDescripRTB.Clear();
            EventLocationRTB.Clear();

        }
 //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void eventAndAnnoucementViewBTN_Click(object sender, EventArgs e)
        {
            //becuase I will need this queue of dictionaries for displayiing in this form
            //therefore the user is taken to this form to see what announcements are there 
            LocalEventsAndAnnouncements viewQueueForm = new LocalEventsAndAnnouncements(queueOfEvents);
            viewQueueForm.Show();
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            //going back to the main menu 
            var MainMenuForm  = new MainMenuForm();
            MainMenuForm.Show();
            this.Hide();
        }

        private void SavingEventsandAnnoucement_Load(object sender, EventArgs e)
        {
            tooltipUsage();
        }

        private void tooltipUsage()
        {
            //because putting pressure on contructor is not good practice using load event is next suggesttion by copilot
            //using a tooltip helps users understand how each component works and what is expected from them
            addEventToolTip.SetToolTip(EventDescripRTB, "You need to describe the event.  Ask yourself, What will you do and how will you do it");
            addEventToolTip.SetToolTip(EventCategorySelectionListBox, "What type of event is it? Is it parks and recreation or community transportation. Give the people an idea");
            addEventToolTip.SetToolTip(EventLocationRTB, "You need to tell the people where this even is taking place. Is it at the town hall or at the beach?");
            addEventToolTip.SetToolTip(EventdateTimePicker, "When is the event? Choose a date so people can be informed :)");
            addEventToolTip.SetToolTip(eventAndAnnoucementViewBTN, "Have a look at the other announcementor the one you just entered. When you click this button you will be taken to a form to see the events :)");
            addEventToolTip.SetToolTip(SubmitEventButton, "When you are done typing all info. Clicking this button adds the events to the annoucement and everyone is able to read it to stay informed:)");
            addEventToolTip.SetToolTip(BackToMainMenuButton, "If you want to go back to the home screen, tapping this button send you back to the starting point. We are not deleting anyting though :)");

            //W3 schools explains that you can customise how long a tooltip can be visible. 
            //"If tooltips block the content users want to see, they will move the mouse to close the tooltip and then see the required information. Ensure the tooltips do not block elements users need to complete their tasks" stated by uxdworld.com
            addEventToolTip.AutoPopDelay = 5000;
            addEventToolTip.InitialDelay = 1000;
            addEventToolTip.ReshowDelay = 500;
            addEventToolTip.ShowAlways = true;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closing app / exiting app
            Application.Exit();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //back to main menu
            //returning to the main menu via menu strip 
            MainMenuForm form = new MainMenuForm();
            form.Show();
           SavingEventsandAnnoucement savingEventsandAnnoucement = new SavingEventsandAnnoucement();
            savingEventsandAnnoucement.Close();
        }
       
    }
    
}
//--------------------------------------------------------------------------------------------------END OF CODE-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Municipal_Services_Application_for_South_Africa
{

    /// <summary>
    /// Initializes the LocalEventsAndAnnouncements form and displays queue data.
    /// </summary>

    public partial class LocalEventsAndAnnouncements : Form
    {

        private Queue<Dictionary<DateTime, string>> queueOfEvents; // Stores a queue of events as dictionaries with DateTime keys and string values
        public LocalEventsAndAnnouncements(Queue<Dictionary<DateTime, string>> queue)
        {
            InitializeComponent();
            queueOfEvents = queue;
            DisplayQueueData(queueOfEvents); // Displays data from the event queue

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Displays event data from the queue in the list view.
        /// </summary>
        /// <param name="queueOfEvents">The queue containing event data.</param>
        private void DisplayQueueData(Queue<Dictionary<DateTime, string>> queueOfEvents)
        {
            viewEventsAndAnnoucements.Items.Clear(); // Clears existing items in the list vie

            
            var tempQueue = new Queue<Dictionary<DateTime, string>>(queueOfEvents);// Temporarily copy the queue to avoid altering the original queue

            while (tempQueue.Count > 0) // Iterates through each dictionary in the queue and adds items to the list view
            {
                var eventDict = tempQueue.Dequeue();
                foreach (var entry in eventDict)
                {
                    viewEventsAndAnnoucements.Items.Add($"{entry.Key.ToString("yyyy-MM-dd")} : {entry.Value}");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //this method is not deleted becuase whne its deleted it shows an error when trying to edit the designer
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //this method is not deleted becuase whne its deleted it shows an error when trying to edit the designer
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Handles the search button click event to search events based on criteria.
        /// </summary>
        private void UpcomingSearchByBtn_Click(object sender, EventArgs e)
        {
            //searching using keyword, or category selected or date chosen typed in by calling the method that deals with searching using words

            string searchCriteria = GetSearchCriteria();

            switch (searchCriteria)
            {
                case "Keyword":
                    SearchByKeyword(keywordSearchTB.Text);
                    break;
                case "Category":
                    SearchByComboBoxOption(searchCategoryCB.SelectedItem.ToString());
                    break;
                case "Date":
                    SearchByDate(searchDateTimePicker1.Value);
                    break;
                default:
                    MessageBox.Show("Please provide valid search criteria.");
                    break;
            }

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Determines the search criteria based on user input.
        /// </summary>
        /// <returns>The selected search criteria as a string.</returns>
        private string GetSearchCriteria()
        {
            //used if statements becuase there is only two of them
            if (!string.IsNullOrWhiteSpace(keywordSearchTB.Text))
            {
                return "Keyword";
            }
            
            if (searchCategoryCB.SelectedItem != null) // Checks if the user has selected a category
            {
                return "Category";
            }

            return "Date"; // Default to searching by date
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Searches events by a specific date and displays the results.
        /// </summary>
        private void SearchByDate(DateTime searchDate)
        {

            
            searchResultsLB.Items.Clear(); // Clear previous search results

            // Using LINQ to search for the date
            var results = from eventDict in queueOfEvents
                          from entry in eventDict
                          where entry.Key.Date == searchDate.Date
                          select $"{entry.Key.ToString("yyyy-MM-dd")} : {entry.Value}";

            
            foreach (var result in results) // then adding the results to the ListBox
            {
                searchResultsLB.Items.Add(result);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Searches events by a keyword and displays the results.
        /// </summary>
        private void SearchByKeyword(string keyword)
        { 
            searchResultsLB.Items.Clear(); // Clears previous search results

            // Finds events containing the keyword using LINQ
            var results = from eventDict in queueOfEvents 
                          from entry in eventDict
                          where (entry.Value.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                select $"{entry.Key.ToString("yyyy-MM-dd")} : {entry.Value}";

            // Adds search results to the list box
            foreach (var result in results)
            {
                searchResultsLB.Items.Add(result);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Searches events by a ComboBox option and displays the results.
        /// </summary>
        private void SearchByComboBoxOption(string option)
        {
           
            searchResultsLB.Items.Clear();  // Clear previous search results

            // Using LINQ to search using the ComboBox selection
            var results = from eventDict in queueOfEvents
                          from entry in eventDict
                          where entry.Value.IndexOf(option, StringComparison.OrdinalIgnoreCase) >= 0
                          select $"{entry.Key.ToString("yyyy-MM-dd")} : {entry.Value}";

           
            foreach (var result in results)  // Adding the results to the ListBox
            {
                searchResultsLB.Items.Add(result);
            }
        }
 //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
       /// <summary>
       /// 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //this method is not deleted becuase whne its deleted it shows an error when trying to edit the designer
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this method is not deleted becuase whne its deleted it shows an error when trying to edit the designer
        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void viewQueueDictBTN_Click(object sender, EventArgs e)
        {
            DisplayQueueData(queueOfEvents); // Refreshes and displays the event queue data

        }
 //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            
            viewEventsAndAnnoucements.ClearSelected(); //clear out listbox content

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Opens the form for adding events and hides the current form.
        /// </summary>
        private void ToSavingEventsandAnouc_Click(object sender, EventArgs e)
        {
            //going back to the form where an event is added
            var SavingEventsandAnnoucements = new SavingEventsandAnnoucement();
            //opens the new form (shows it on the screen).
            //localEventsAndAnnouncements.Show();
            SavingEventsandAnnoucements.Show();
            //hides the current form
            this.Hide();
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //this method is not deleted becuase whne its deleted it shows an error when trying to edit the designer
        }
    }
}
//--------------------------------------------------------------------------------------------------END OF CODE-----------------------------------------------------------------------------------------------------------------------------------
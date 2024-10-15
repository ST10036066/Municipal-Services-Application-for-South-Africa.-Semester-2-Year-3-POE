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
    //use a sorted dictionary , maintain a sorted order of keys while iterating, going with SortedDictionary
    //for fast look ups , considered using Hash tables 

//    Upon selecting "Local Events and Announcements," create a Windows Form with the
//following features: - Display upcoming local events and announcements in an aesthetically pleasing manner. - Implement a search functionality allowing users to efficiently find events based on
//categories and dates. - Utilise advanced data structures, such as sorted dictionaries, to optimise event 
//organisation.

//    Stacks, Queues, Priority Queues(15 Marks): 
// Implement stacks, queues, or priority queues as needed to manage event-related data
//structures effectively. 

//Hash Tables, Dictionaries, Sorted Dictionaries (15 Marks): 
// Utilise hash tables, dictionaries, or sorted dictionaries for organising and retrieving event 
//information. 

//Sets (10 Marks): 
// Incorporate sets to handle unique categories or dates efficiently. 


    public partial class LocalEventsAndAnnouncements : Form
    {

        private Queue<Dictionary<DateTime, string>> queueOfEvents;
        public LocalEventsAndAnnouncements(Queue<Dictionary<DateTime, string>> queue)
        {
            InitializeComponent();
            queueOfEvents = queue;
            DisplayQueueData(queueOfEvents);

        }

        private void DisplayQueueData(Queue<Dictionary<DateTime, string>> queueOfEvents)
        {
            viewEventsAndAnnoucements.Items.Clear();

            // Temporarily copy the queue to avoid altering the original queue
            var tempQueue = new Queue<Dictionary<DateTime, string>>(queueOfEvents);

            while (tempQueue.Count > 0)
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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void upcomingSearchByBtn_Click(object sender, EventArgs e)
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
        private string GetSearchCriteria()
        {
            //used if statements becuase there is only two of them
            if (!string.IsNullOrWhiteSpace(keywordSearchTB.Text))
            {
                return "Keyword";
            }

            if (searchCategoryCB.SelectedItem != null)
            {
                return "Category";
            }

            return "Date";
        }
        private void SearchByDate(DateTime searchDate)
        {

            // Clear previous search results
            searchResultsLB.Items.Clear();

            // Using LINQ to search for the date
            var results = from eventDict in queueOfEvents
                          from entry in eventDict
                          where entry.Key.Date == searchDate.Date
                          select $"{entry.Key.ToString("yyyy-MM-dd")} : {entry.Value}";

            // then adding the results to the ListBox
            foreach (var result in results)
            {
                searchResultsLB.Items.Add(result);
            }
        }

        private void SearchByKeyword(string keyword)
        {
            searchResultsLB.Items.Clear();

            var results = from eventDict in queueOfEvents
                          from entry in eventDict
                          where (entry.Value.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                select $"{entry.Key.ToString("yyyy-MM-dd")} : {entry.Value}";

            foreach (var result in results)
            {
                searchResultsLB.Items.Add(result);
            }
        }

        private void SearchByComboBoxOption(string option)
        {
            // Clear previous search results
            searchResultsLB.Items.Clear();

            // Using LINQ to search using the ComboBox selection
            var results = from eventDict in queueOfEvents
                          from entry in eventDict
                          where entry.Value.IndexOf(option, StringComparison.OrdinalIgnoreCase) >= 0
                          select $"{entry.Key.ToString("yyyy-MM-dd")} : {entry.Value}";

            // Adding the results to the ListBox
            foreach (var result in results)
            {
                searchResultsLB.Items.Add(result);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void viewQueueDictBTN_Click(object sender, EventArgs e)
        {
            DisplayQueueData(queueOfEvents);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear out listbox content
            viewEventsAndAnnoucements.ClearSelected();

        }

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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exiting app

            //back to main menu 
        }
    }
}

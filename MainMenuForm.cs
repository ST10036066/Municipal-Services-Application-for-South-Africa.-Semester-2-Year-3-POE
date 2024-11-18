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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuGreeting_Click(object sender, EventArgs e)
        {

        }

        private void ToReportIssueButton_Click(object sender, EventArgs e)
        {
            //moving to the report issues window
          //Create an instance of the ReportIssuesForm
            var reportIssuesForm = new ReportIssuesForm();
            
            // Show the ReportIssuesForm
            reportIssuesForm.Show();

            //trying to keep one window at a time to avoid panic
            this.Hide();
            //while closing the main menu
            //MainMenuForm form = new MainMenuForm();
            //form. Close(); 
        }

        private void ToLocalEventsButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Oops. Local Events and Announcements is under construction. It will be available soon :).");

            //creates a new instance of the LocalEventsAndAnnouncements form.
          // var localEventsAndAnnouncements = new LocalEventsAndAnnouncements();
            var SavingEventsandAnnoucements = new SavingEventsandAnnoucement();
            //opens the new form (shows it on the screen).
            //localEventsAndAnnouncements.Show();
            SavingEventsandAnnoucements.Show();
            //hides the current form
            this.Hide();
        }

        private void ToServiceReqStatusButton_Click(object sender, EventArgs e)
        {
           
            var ServiceReqStatatusForm = new ServiceReqStatusForm();
            ServiceReqStatatusForm.Show();
            this.Hide();
        }

        private void mainMenuGreetDescrp_Click(object sender, EventArgs e)
        {

        }

        private void exitApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Closing  the application
            Application.Exit();
        }
    }
}
//--------------------------------------------------------------------------------------------------END OF CODE-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

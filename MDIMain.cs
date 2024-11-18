using System;
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
    /// Main MDI container for the application.
    /// Provides a MenuStrip for navigation between different forms
    ///.
    /// </summary>
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Enable MDI container.
            this.WindowState = FormWindowState.Maximized; // Maximize the main window.
            this.Load += MDIMain_Load; // Register the Load event.
        }

        /// <summary>
        /// Initializes the MenuStrip with menu items for navigation.
        /// </summary>
        private void MDIMain_Load(object sender, EventArgs e)
        {
            InitializeMenuStrip();
        }

        /// <summary>
        /// Configures the MenuStrip and its menu items.
        /// </summary>
        private void InitializeMenuStrip()
        { 
            
            // Create a MenuStrip
            MenuStrip navigationMenuStrip = new MenuStrip();

            // Add menu items
            navigationMenuStrip.Items.Add(CreateMenuItem("Local Events and Announcements", OpenLocalEventsAndAnnouncements));
            navigationMenuStrip.Items.Add(CreateMenuItem("Saving Events and Announcement", OpenSavingEventsAndAnnouncement));
            navigationMenuStrip.Items.Add(CreateMenuItem("Main Menu", OpenMainMenu));
            navigationMenuStrip.Items.Add(CreateMenuItem("Report Issues", OpenReportIssues));
            navigationMenuStrip.Items.Add(CreateMenuItem("Service Request ", OpenServiceReqStatus));

            // Add the MenuStrip to the form
            this.MainMenuStrip = navigationMenuStrip;
            this.Controls.Add(navigationMenuStrip);
        }

        /// <summary>
        /// Helper method to create a ToolStripMenuItem with a click event.
        /// </summary>
        private ToolStripMenuItem CreateMenuItem(string text, EventHandler onClick)
        {
            return new ToolStripMenuItem(text, null, onClick);
        }

        /// <summary>
        /// Closes the currently active child form to avoid a puzzle of multiple forms open.
        /// </summary>
        private void CloseActiveChildForm()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        /// <summary>
        /// Opens the Local Events and Announcements form.
        /// In order to fullfil the municipal services for the community, this form 
        /// Display upcoming local events and announcements in an aesthetically pleasing manner.
        /// Implement a search functionality allowing users to efficiently find events based on categories and dates. 
        ///Utilise advanced data structures, such as sorted dictionaries, to optimise event organisation
        ///
        /// The LocalEventsAndAnnouncements class has a special requirement. It requirs a parameter(queue)
        ///of events (Queue<Dictionary<DateTime, string>>) to work properly. 
        /// This queue is used inside the form to show or manage event data.
        /// </summary>
        private void OpenLocalEventsAndAnnouncements(object sender, EventArgs e)
        {
            
            // Create a queue and optionally populate it with data
            Queue<Dictionary<DateTime, string>> eventQueue = new Queue<Dictionary<DateTime, string>>();

           

            // Pass the queue to the constructor
            LocalEventsAndAnnouncements localEventsForm = new LocalEventsAndAnnouncements(eventQueue)
            {
                MdiParent = this
            };

            // Show the form if needed
            localEventsForm.Show();

        }

        /// <summary>
        /// Opens the Saving Events and Announcement form.
        /// 
        /// </summary>
        private void OpenSavingEventsAndAnnouncement(object sender, EventArgs e)
        {
            CloseActiveChildForm();
            SavingEventsandAnnoucement savingEventsForm = new SavingEventsandAnnoucement { MdiParent = this };
            savingEventsForm.Show();
        }

        /// <summary>
        /// Opens the Main Menu form.
        /// </summary>
        private void OpenMainMenu(object sender, EventArgs e)
        {
            CloseActiveChildForm(); // Close the currently active child form
            MainMenuForm mainMenuForm = new MainMenuForm { MdiParent = this };
            mainMenuForm.Show();
        }

        /// <summary>
        /// Opens the Report Issues form.
        /// </summary>
        private void OpenReportIssues(object sender, EventArgs e)
        {
            CloseActiveChildForm(); // Close the currently active child form
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm { MdiParent = this };
            reportIssuesForm.Show();
        }

        /// <summary>
        /// Opens the Service Request Status form.When choosing "Service Request Status," create a Windows Form with the following features: 
        /// Display a well-organised list of submitted service requests, including their status.
        /// Allow users to track the progress of their service requests using unique identifiers.
        /// </summary>
        private void OpenServiceReqStatus(object sender, EventArgs e)
        {
            CloseActiveChildForm(); // Close the currently active child form
            ServiceReqStatusForm serviceReqStatusForm = new ServiceReqStatusForm { MdiParent = this };
            serviceReqStatusForm.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //closing the application completely
            Application.Exit();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //another option to close the application. 
            //it is easier to naviagte where to close the app instead of spending more time looking for this option therefore thee option to exit is within File option menu and Help options
            Application.Exit();
        }
    }
    //------------------------------------------------------------------------END OF CODE------------------------------------------------------------------------------------------------------------------------------------
}

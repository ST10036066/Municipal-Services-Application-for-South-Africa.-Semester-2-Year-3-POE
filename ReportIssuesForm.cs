using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Immutable;
using System.IO;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Municipal_Services_Application_for_South_Africa;

namespace Municipal_Services_Application_for_South_Africa
{
    /// <summary>
    /// plan to iterate through the collection often and want to maintain the insertion order.(for now)
    /// edit me :
    /// so dictionary has a key(location)
    /// 
    /// </summary>
    public partial class ReportIssuesForm : Form
    {
        // private List<IssueReport> ReportedIssues = new List<IssueReport>(); //list of report(will change based on part 2 req)
        private Dictionary<string, string> ReportedIssues = new Dictionary<string, string>();
        private Queue<Dictionary<string, string>> queueOfReports = new Queue<Dictionary<string, string>>();
        List<FileAttachment> FileAttachmentsList = new List<FileAttachment>();//list of file paths
        private List<IFileAttachment> MediaAttachments = new List<IFileAttachment>(); //using the help of the interface
                                                                                      //IssueReport report;

      
        public ReportIssuesForm()
        {
            InitializeComponent();

        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void SubmitReportButton_Click(object sender, EventArgs e)
        {
            // Get input values
            string location = LocationInputTextBox.Text;
            string category = CategorySelectionListBox.SelectedItem.ToString();
            string description = DescriptionBoxRichTextBox.Text;

            // Validate inputs
            ValidateInput(location, category, description);

            // Combine inputs into a single string
            string combinedReportInput = $"{category} - {description}";

            // Convert file paths to FileAttachment objects and add to MediaAttachments list
            foreach (var filePath in FileAttachmentsList) // Replace with your actual list of file paths
            {
                string fileName = Path.GetFileName(filePath.FilePath);
                MediaAttachments.Add(new FileAttachment(fileName, filePath.FilePath, new FileInfo(filePath.FilePath).Length));
            }

            // Add the attachments to the report
            string combinedAttachments = string.Join(", ", MediaAttachments.Select(ma => ma.FileName));

            // Check if the location already exists in the dictionary
            if (!ReportedIssues.ContainsKey(location))
            {
                // Add new report to the dictionary
                ReportedIssues[location] = $"{combinedReportInput} - {combinedAttachments}";

                // Enqueue the report
                queueOfReports.Enqueue(new Dictionary<string, string> { { location, ReportedIssues[location] } });

                // Show success message
                MessageBox.Show("Report submitted successfully!");
            }
            else
            {
                // Show error message if the report already exists for the same location
                MessageBox.Show("A report for this location already exists. Please review your input.");
            }

            // Clear fields after submitting the report
            ClearFields();
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MediaAttachmentDialogButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png|Document Files|*.pdf;*.docx;*.xlsx",
                Multiselect = true
            };

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Define valid extensions for media files
                    var validExtensions = new[] { ".jpg", ".jpeg", ".png", ".pdf", ".docx", ".xlsx" };

                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        var extension = Path.GetExtension(filePath).ToLower();
                        if (validExtensions.Contains(extension))
                        {
                            var fileAttachment = new FileAttachment(
                                Path.GetFileName(filePath),
                                filePath,
                                new FileInfo(filePath).Length
                            );

                            // Validate the file attachment
                            if (fileAttachment.ValidateFileAttachment())
                            {
                                //progress bar feature = adding the selected file into a list of media
                                //EngagementFeatureProgressBar.Value *= 50;

                                EngagementFeatureProgressBar.Value = EngagementFeatureProgressBar.Maximum;
                                FileAttachmentsList.Add(fileAttachment);
                            }
                        }
                    }

                    // Optionally provide feedback to the user
                    MessageBox.Show("Files attached successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while attaching media files: {ex.Message}");
            }
        }


        //-------------------------------------------------------------------------------------------------------------------------------      

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            //back to the main menu
            //creating the instance 
            var MainMenu = new MainMenuForm();
            
            //showing the main menu 
            MainMenu.Show();

            //while closing the report form
            //trying to keep one window at a time to avoid panic
            this.Hide();
            // ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            // reportIssuesForm.Close();-- not worked, still left the other window handing TODO 
        }

        private void CategorySelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //as the user selects a category, the progress bar is shown to them 
            int itemCount = CategorySelectionListBox.Items.Count;
            int selectedCount = CategorySelectionListBox.SelectedItems.Count;
            //the progress bar is an encourgament feature to cheer for the user to continue reporting
            EngagementFeatureProgressBar.Maximum = itemCount;
            EngagementFeatureProgressBar.Value = selectedCount;
            //EngagementFeatureProgressBar.Value *= 50; this does not work 
        }

        private void EngagementFeatureProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void LocationInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionBoxRichTextBox_TextChanged(object sender, EventArgs e)
        {


        }


        //-------------------------------------------------------------------------------------------------------------------------------
        //ValidationForUserInput helps the user to enter correct 
        //    expected input. When they enter incorrect input , the user 
        //    must be alerted using a message box and the textbox is cleared
        private void ValidateInput(string Location, string Category, string Description)
        {
            string Validation = string.Empty;

            // Combine different validation cases 
            switch (true)
            {
                case bool _ when string.IsNullOrEmpty(Location):
                    Validation = "It looks like some information is missing or incorrect. " +
                        "\n Try a location that looks like this: \n Clarefeather Square 12 ABC River road";
                    MessageBox.Show(Validation, "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case bool _ when Location.Length < 5:
                    Validation = "Location must be at least 5 characters long. Try this: enter the area or the street location or both";
                    MessageBox.Show(Validation, "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;


                //case bool _ when Category.SelectedIndex == -1: // No item selected
                //    Validation = "It seems like you did not choose a category. \n Try this: Tap the Category box under step 2 (e.g., Water & Sanitation).";
                //    MessageBox.Show(Validation, "Invalid Category chosen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    break;
                case bool _ when string.IsNullOrEmpty(Category):
                    Validation = "It seems like you did not choose a category. \n Try this: Tap the Category box under step 2 (e.g., Water & Sanitation).";
                    MessageBox.Show(Validation, "Invalid Category chosen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case bool _ when string.IsNullOrEmpty(Description):
                    Validation = "It seems like you did not describe the issue. Try this: Type in details such as \n" +
                        "The water pipe exploded and it is causing the streets to be flooded. This occured at 3pm";
                    MessageBox.Show(Validation, "Invalid Description entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case bool _ when Description.Length < 5:
                    Validation = "Description must be at least 5 characters long.\n Try this: Expand on the issue. For example\n 'The water pipe exploded " +
                         "and it is causing the streets to be flooded. This occured at 3pm";
                    MessageBox.Show(Validation, "Invalid Description entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                default:
                    Validation = "All inputs are valid. Your report has been sent";
                    break;
            }

            // Display the validation message if there are issues
            if (Validation != "All inputs are valid. Your report has been sent")
            {
                MessageBox.Show(Validation, "It seems like you skipped a step while you were reporting. Try this: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("All report details are valid!", "Success, Thank you for helping yourself and the community. \n Navigate to the top right for the Main Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFields()
        {
            LocationInputTextBox.Clear();
            DescriptionBoxRichTextBox.Clear();

        }
        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closing  the application
            Application.Exit();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //returning to the main menu via menu strip 
            MainMenuForm form = new MainMenuForm();
            form.Show();
            ReportIssuesForm report = new ReportIssuesForm();
            report.Close();
        }

        private void ReportIssuesMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}


//-------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------END OF CODE------------------------------------------------------------------------------
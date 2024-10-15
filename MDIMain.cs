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
    /// <summary>
    /// this mdi is used for  for the menu items on top of the form such as navigating to different forms and exiting application
    /// </summary>
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.Load += new EventHandler(MDIMain_Load);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            InitializeMenuStrip();
        }
        private void InitializeMenuStrip()
        {
            // Reference the existing MenuStrip
            MenuStrip menuStrip = navigationMenuStrip;

            // Add "Open MainMenu" menu item
            ToolStripMenuItem openMainMenu = new ToolStripMenuItem("Open MainMenu", null, OpenMainMenu);
            menuStrip.Items.Add(openMainMenu);

            // Add "Open ReportIssues" menu item
            ToolStripMenuItem openReportIssues = new ToolStripMenuItem("Open ReportIssues", null, OpenReportIssues);
            menuStrip.Items.Add(openReportIssues);

            // Add "Open SavingAnnouncement" menu item
            ToolStripMenuItem openSavingAnnouncement = new ToolStripMenuItem("Open SavingAnnouncement", null, OpenSavingAnnouncement);
            menuStrip.Items.Add(openSavingAnnouncement);

            // Add "Exit" menu item
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit", null, ExitToolsStripMenuItem_Click);
            menuStrip.Items.Add(exitMenuItem);

            // Set the MenuStrip to the form
            this.MainMenuStrip = menuStrip;

        }

        private void OpenMainMenu(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.MdiParent = this;
            mainMenuForm.Show();
        }

        private void OpenReportIssues(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.MdiParent = this;
            reportIssuesForm.Show();
        }

        private void OpenSavingAnnouncement(object sender, EventArgs e)
        {
            SavingEventsandAnnoucement savingAnnouncementForm = new SavingEventsandAnnoucement();
            savingAnnouncementForm.MdiParent = this;
            savingAnnouncementForm.Show();
        }

       
         

    }
}

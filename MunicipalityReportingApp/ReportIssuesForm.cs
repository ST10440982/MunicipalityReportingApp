using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalityReportingApp
{
    public partial class ReportIssuesForm : Form
    {
        public event Action<Issue> IssueSubmitted;
        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            lblEngagementMessage.Text = "Please fill out the form to report an issue.";
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png|Documents|*.pdf;*.docx;*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                MessageBox.Show("File selected: " + openFileDialog.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string category = cboCategory.SelectedItem.ToString();
            string description = rtbDescription.Text;
            string attachmentPath = "";

            // Validate input
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            Issue newIssue = new Issue(location, category, description, attachmentPath);

           
            IssueSubmitted?.Invoke(newIssue);

            
            this.Close();
          
            MessageBox.Show("Issue reported successfully!");
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

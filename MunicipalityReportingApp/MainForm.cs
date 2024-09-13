using MunicipalityReportingApp;
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
    public partial class MainForm : Form
    {
        private List<Issue> reportedIssues = new List<Issue>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // To Open the Report Issues form
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.IssueSubmitted += OnIssueSubmitted;
            reportForm.Show();
        }

        private void OnIssueSubmitted(Issue issue)
        {
            reportedIssues.Add(issue);
           
        }
        private void btnLocalEvents_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
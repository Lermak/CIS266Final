using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class frmProjectWork : CIS266Project.NavigatorForm
    {
        public frmProjectWork()
        {
            InitializeComponent();
        }
        private void frmProjectWork_Load(object sender, EventArgs e)
        {
            UpdateSelectedRow();
        }
        protected override void fillControls()
        {
            try
            {
                parent.SetReadyLabel("Loading");

                //Get the index of the row being newly selected
                ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter myProj = parent.GetProjectsAdapter();

                numRows = parent.MyDataSet.Projects.Count;

                //save that index
                int rowID = Int32.Parse(parent.MyDataSet.Projects.Rows[rowIndex][0].ToString());

                //get the fields of the project by the names rather than primary keys
                ProjectTrackingDataSetTableAdapters.getProjectInfoNamesTableAdapter myProjAdapter = new ProjectTrackingDataSetTableAdapters.getProjectInfoNamesTableAdapter();
                myProjAdapter.Fill(parent.MyDataSet.getProjectInfoNames, rowID);

                //put those valuse in the textboxrs
                tbProjectName.Text = parent.MyDataSet.getProjectInfoNames.Rows[0][0].ToString();
                tbProjectStatus.Text = parent.MyDataSet.getProjectInfoNames.Rows[0][1].ToString();
                tbProjectDescription.Text = parent.MyDataSet.getProjectInfoNames.Rows[0][2].ToString();
                
                //get all the work all employees have done based on what project they worked on
                ProjectTrackingDataSetTableAdapters.getEmployeeWorkByProjectTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.getEmployeeWorkByProjectTableAdapter();
                myAdapter.Fill(parent.MyDataSet.getEmployeeWorkByProject, Int32.Parse(parent.MyDataSet.Projects.Rows[rowIndex][0].ToString()));
                //display those employee works
                dgvWork.DataSource = parent.MyDataSet.getEmployeeWorkByProject.Copy();

                ProjectTrackingDataSetTableAdapters.getTotalWorkHoursByProjectTableAdapter myTotal = new ProjectTrackingDataSetTableAdapters.getTotalWorkHoursByProjectTableAdapter();
                myTotal.Fill(parent.MyDataSet.getTotalWorkHoursByProject, Int32.Parse(parent.MyDataSet.Projects.Rows[rowIndex][0].ToString()));
                //set the label to the total hours use [0][0] since the procedure returns a table with one field
                lblTotalHours.Text = parent.MyDataSet.getTotalWorkHoursByProject[0][0].ToString();

                parent.SetReadyLabel("Load Success");
            }
            catch
            {
                parent.SetReadyLabel("Load Failed");
            }
        }
    }
}

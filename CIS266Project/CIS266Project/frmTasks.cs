using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class frmTasks : CIS266Project.NavigatorForm
    {
        public frmTasks()
        {
            InitializeComponent();
        }
        private void frmTasks_Load(object sender, EventArgs e)
        {
            UpdateSelectedRow();
        }
        protected override void fillControls()
        {
            try
            {
                parent.SetReadyLabel("Loading");

                //get all the info from the projects table
                ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter myProjAdapter = parent.GetProjectsAdapter();

                numRows = parent.MyDataSet.Projects.Count;

                //store the project id and name
                tbProjectID.Text = parent.MyDataSet.Projects.Rows[rowIndex][0].ToString();
                tbProjectName.Text = parent.MyDataSet.Projects.Rows[rowIndex][1].ToString();
                //get the data from the tasks by projects procedure
                ProjectTrackingDataSetTableAdapters.getTasksByProjectTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.getTasksByProjectTableAdapter();
                myAdapter.Fill(parent.MyDataSet.getTasksByProject, Int32.Parse(tbProjectID.Text));
                //set the datagridview's data source to show the information
                dgvTasks.DataSource = parent.MyDataSet.getTasksByProject.Copy();

                parent.SetReadyLabel("Load Success");
            }
            catch
            {
                parent.SetReadyLabel("Load Failed");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class frmEditProjectInfo : CIS266Project.tmpEditForm
    {
        public frmEditProjectInfo()
        {
            InitializeComponent();
        }
        private void setTextboxText(string desc, string name, string manager, string status, DateTime start, string end)
        {
            tbDescription.Text = desc;
            tbProjectName.Text = name;
            cbProjectManager.Text = manager;
            cbProjectStatus.Text = status;
            mtbEndDate.Text = end;
            dtpStartDate.Value = start;
        }

        protected override void manageEditingEnables(bool edit)
        {
            base.manageEditingEnables(edit);
            //if not editing or adding don't allow changes
            tbDescription.Enabled = !edit;
            tbProjectName.Enabled = !edit;
            cbProjectManager.Enabled = !edit;
            cbProjectStatus.Enabled = !edit;
            mtbEndDate.Enabled = !edit;
            dtpStartDate.Enabled = !edit;
        }
        protected override void fillControls()
        {
            try
            {
                parent.SetReadyLabel("Loading");
                
                

                ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter();
                myAdapter.Fill(parent.MyDataSet.Projects);

                numRows = parent.MyDataSet.Projects.Count;

                //put the stored values into the conrols
                tbProjectID.Text = parent.MyDataSet.Projects[rowIndex][0].ToString();
                tbProjectName.Text = parent.MyDataSet.Projects[rowIndex][1].ToString();
                cbProjectManager.SelectedValue = parent.MyDataSet.Projects[rowIndex][2];
                cbProjectStatus.SelectedValue = parent.MyDataSet.Projects[rowIndex][3];
                tbDescription.Text = parent.MyDataSet.Projects[rowIndex][4].ToString();

                dtpStartDate.Value = DateTime.Parse(parent.MyDataSet.Projects[rowIndex][5].ToString());

                DateTime endDate = new DateTime();//if the end date is valid
                if (DateTime.TryParse(parent.MyDataSet.Projects[rowIndex][6].ToString(), out endDate))
                    mtbEndDate.Text = endDate.ToShortDateString();//include it
                else
                    mtbEndDate.Text = "";
            }
            catch
            {
                parent.SetReadyLabel("Load Failed");
            }
        }    
        protected override void onEditState()
        {
            base.onEditState();
            try
            {
                parent.SetReadyLabel("Updating");

                DateTime end = new DateTime();
                DateTime? endDate = null;//create a datetime variable to hold the end date
                if (DateTime.TryParse(mtbEndDate.Text, out end))//if the end date is a valid date time include it
                    endDate = end;

                parent.UpdateProjectRow(rowIndex, tbProjectName.Text, Convert.ToInt32(cbProjectManager.SelectedValue), Convert.ToInt32(cbProjectStatus.SelectedValue), tbDescription.Text, dtpStartDate.Value, endDate);

                parent.SetReadyLabel("Update Success");
            }
            catch
            {
                parent.SetReadyLabel("Update Failed");
            }
        }
        protected override void onAddState()
        {
            base.onAddState();
            try
            {
                parent.SetReadyLabel("Saving");

                DateTime end = new DateTime();
                DateTime? endDate = null;//create a datetime variable to hold the end date
                if (DateTime.TryParse(mtbEndDate.Text, out end))//if the end date is a valid date time include it
                    endDate = end;

                parent.InsertProjectsTable(tbProjectName.Text, Convert.ToInt32(cbProjectManager.SelectedValue), Convert.ToInt32(cbProjectStatus.SelectedValue), tbDescription.Text, dtpStartDate.Value, endDate);

                rowIndex = parent.MyDataSet.Projects.Rows.Count;

                parent.SetReadyLabel("Save Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                parent.SetReadyLabel("Save Failed");
            }
        }
        protected override void onDeleteState()
        {
            base.onDeleteState();
            try
            {
                //set the tool strip to say saving in case of long wait times
                parent.SetReadyLabel("Deleting");

                parent.DeleteProjectRow(Int32.Parse(tbProjectID.Text));

                rowIndex = 0;

                setTextboxText("", "", "", "", DateTime.Today, "");

                //change tool strip to say saved after past commands are successful
                parent.SetReadyLabel("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                parent.SetReadyLabel("Delete Failed");//if any command fails set the strip to say save failed
            }
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            base.btnAdd_Click(sender, e);
            setTextboxText("", "", "", "", DateTime.Today, "");
            tbProjectName.Focus();
        }
        private void frmEditProjectInfo_Load(object sender, EventArgs e)
        {
            ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter();
            myAdapter.Fill(parent.MyDataSet.Projects);

            UpdateSelectedRow();
            manageEditingEnables(true);

            FillComboBoxes();

            cbProjectManager.DisplayMember = "FullName";
            cbProjectManager.ValueMember = "EmployeeID";

            cbProjectStatus.ValueMember = "StatusID";
            cbProjectStatus.DisplayMember = "StatusName";
        }

        private void FillComboBoxes()
        {
            //get the data from the status and managers tables
            ProjectTrackingDataSetTableAdapters.LuStatusTableAdapter myStatusAdapter = new ProjectTrackingDataSetTableAdapters.LuStatusTableAdapter();
            myStatusAdapter.Fill(parent.MyDataSet.LuStatus);

            ProjectTrackingDataSetTableAdapters.GetEmployeesFullNamesTableAdapter myNameAdapter = new ProjectTrackingDataSetTableAdapters.GetEmployeesFullNamesTableAdapter();
            myNameAdapter.Fill(parent.MyDataSet.GetEmployeesFullNames);

            //add the list of managers to the manager combobox using thier EmpID as the value member
            cbProjectManager.DataSource = parent.MyDataSet.GetEmployeesFullNames.Copy();

            //add the list of status to the status combobox using the StatusID as the value member
            cbProjectStatus.DataSource = parent.MyDataSet.LuStatus.Copy();
        }

        public override void refresh()
        {
            base.refresh();
            FillComboBoxes();
        }
    }
}

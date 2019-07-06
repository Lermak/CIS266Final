using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class frmEditTaskInfo : CIS266Project.tmpEditForm
    {
        public frmEditTaskInfo()
        {
            InitializeComponent();
        }
        private void setTextboxText(string desc, string name, string projID, string status, DateTime start, string end)
        {
            tbDescription.Text = desc;
            tbTaskName.Text = name;
            tbEndDate.Text = end;
            cbProjectID.Text = projID;
            cbStatus.Text = status;
            dtpStartDate.Value = start;
        }
        protected override void manageEditingEnables(bool edit)
        {
            base.manageEditingEnables(edit);

            tbDescription.Enabled = !edit;
            tbTaskName.Enabled = !edit;
            tbEndDate.Enabled = !edit;
            cbProjectID.Enabled = !edit;
            cbStatus.Enabled = !edit;
            dtpStartDate.Enabled = !edit;
        }

        protected override void fillControls()
        {
            try
            {
                parent.SetReadyLabel("Loading");

                ProjectTrackingDataSetTableAdapters.TasksTableAdapter myAdapter = parent.GetTasksAdapter();
                myAdapter.Fill(parent.MyDataSet.Tasks);

                numRows = parent.MyDataSet.Tasks.Rows.Count;

                //store the values at the row index into the controls
                tbTaskID.Text = parent.MyDataSet.Tasks[rowIndex][0].ToString();
                cbProjectID.SelectedValue = parent.MyDataSet.Tasks[rowIndex][1];
                tbTaskName.Text = parent.MyDataSet.Tasks[rowIndex][2].ToString();
                tbDescription.Text = parent.MyDataSet.Tasks[rowIndex][3].ToString();
                dtpStartDate.Value = DateTime.Parse(parent.MyDataSet.Tasks[rowIndex][4].ToString());
                //check if the enddate is valid
                DateTime endDate = new DateTime();
                if (DateTime.TryParse(parent.MyDataSet.Tasks[rowIndex][5].ToString(), out endDate))//if it is update the control
                    tbEndDate.Text = endDate.ToShortDateString();
                else//otherwise ignore that field and make it blank
                    tbEndDate.Text = "";   
                cbStatus.SelectedValue = parent.MyDataSet.Tasks[rowIndex][6];                               
            }
            catch
            {
                parent.SetReadyLabel("Load Failed");
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
                if (DateTime.TryParse(tbEndDate.Text, out end))//if the end date is a valid date time include it
                    endDate = end;

                parent.InsertTasksTable(Convert.ToInt32(cbProjectID.SelectedValue), tbTaskName.Text, tbDescription.Text, dtpStartDate.Value, endDate, Convert.ToInt32(cbStatus.SelectedValue));

                //move to the last item use Count since the newly added item hasn't been counted by the Rows.Count property yet
                rowIndex = parent.MyDataSet.Tasks.Rows.Count;

                parent.SetReadyLabel("Save Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                parent.SetReadyLabel("Save Failed");
            }
        }
        protected override void onEditState()
        {
            base.onEditState();
            try
            { 
                parent.SetReadyLabel("Editing");

                DateTime end = new DateTime();
                DateTime? endDate = null;//create a nullable datetime since it is optional
                if (DateTime.TryParse(tbEndDate.Text, out end))//if the textbox can parse into a datetime
                    endDate = end;//set the nullable datetime to be the end date

                parent.UpdateTasksRow(rowIndex, Convert.ToInt32(cbProjectID.SelectedValue), tbTaskName.Text, tbDescription.Text, dtpStartDate.Value, endDate, Convert.ToInt32(cbStatus.SelectedValue));

                parent.SetReadyLabel("Edit Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                parent.SetReadyLabel("Edit Failed");
            }
        }
        protected override void onDeleteState()
        {
            base.onDeleteState();
            try
            {
                //set the tool strip to say saving in case of long wait times
                parent.SetReadyLabel("Deleting");

                parent.DeleteTasksRow(Int32.Parse(tbTaskID.Text));

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

        private void frmEditTaskInfo_Load(object sender, EventArgs e)
        {
            ProjectTrackingDataSetTableAdapters.TasksTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.TasksTableAdapter();
            myAdapter.Fill(parent.MyDataSet.Tasks);

            cbProjectID.DisplayMember = "ProjectName";
            cbProjectID.ValueMember = "ProjectID";

            cbStatus.ValueMember = "StatusID";
            cbStatus.DisplayMember = "StatusName";

            FillComboBoxes();

            UpdateSelectedRow();
            manageEditingEnables(true);
        }

        private void FillComboBoxes()
        {
            //gather all table information
            ProjectTrackingDataSetTableAdapters.LuStatusTableAdapter myStatusAdapter = new ProjectTrackingDataSetTableAdapters.LuStatusTableAdapter();
            myStatusAdapter.Fill(parent.MyDataSet.LuStatus);

            ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter myProjectAdapter = new ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter();
            myProjectAdapter.Fill(parent.MyDataSet.Projects);

            //add the list of managers to the manager combobox using thier EmpID as the value member
            cbProjectID.DataSource = parent.MyDataSet.Projects.Copy();//use copy so that a change in one form doesn't affect this

            //add the list of status to the status combobox using the StatusID as the value member
            cbStatus.DataSource = parent.MyDataSet.LuStatus.Copy();
        }

        public override void refresh()
        {
            FillComboBoxes();
            base.refresh();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            base.btnAdd_Click(sender, e);
            setTextboxText("", "", "", "", DateTime.Today, "");
            cbProjectID.Focus();
        }
    }
}

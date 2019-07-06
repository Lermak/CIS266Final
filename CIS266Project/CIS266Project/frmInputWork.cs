using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class frmInputWork : CIS266Project.tmpEditForm
    {
        public frmInputWork()
        {
            InitializeComponent();
        }
        private void setTextboxText(string task, string emp, DateTime day, decimal hours)
        {
            cbTaskID.Text = task;
            cbEmployeeID.Text = emp;
            dtpWorkDate.Value = day;
            workHoursNumericUpDown.Value = hours;
        }

        protected override void manageEditingEnables(bool edit)
        {
            base.manageEditingEnables(edit);

            cbEmployeeID.Enabled = !edit;
            cbTaskID.Enabled = !edit;
            dtpWorkDate.Enabled = !edit;
            workHoursNumericUpDown.Enabled = !edit;
        }
        protected override void fillControls()
        {
            try
            { 
                //gather the data about employee work
                ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter();
                myAdapter.Fill(parent.MyDataSet.EmployeeWork);

                numRows = parent.MyDataSet.EmployeeWork.Rows.Count;

                //store the data at the selected row in the controls
                cbTaskID.SelectedValue = parent.MyDataSet.EmployeeWork[rowIndex][0];
                cbEmployeeID.SelectedValue = parent.MyDataSet.EmployeeWork[rowIndex][1];
                dtpWorkDate.Value = DateTime.Parse(parent.MyDataSet.EmployeeWork[rowIndex][2].ToString());
                workHoursNumericUpDown.Value = Decimal.Parse(parent.MyDataSet.EmployeeWork[rowIndex][3].ToString());                
            }
            catch
            {
                parent.SetReadyLabel("Load Failed");
            }
        }
        //update all controls displays
        protected override void onAddState()
        {
            base.onAddState();
            try
            {
                parent.SetReadyLabel("Saving");

                parent.InsertEmpWorkTable(Convert.ToInt32(cbTaskID.SelectedValue), Convert.ToInt32(cbEmployeeID.SelectedValue), dtpWorkDate.Value, workHoursNumericUpDown.Value);

                //set the index to the end
                rowIndex = parent.MyDataSet.EmployeeWork.Rows.Count;

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
                parent.SetReadyLabel("Updating");

                parent.UpdateEmpWorkRow(rowIndex, Convert.ToInt32(cbTaskID.SelectedValue), Convert.ToInt32(cbEmployeeID.SelectedValue), dtpWorkDate.Value, workHoursNumericUpDown.Value);

                parent.SetReadyLabel("Update Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                parent.SetReadyLabel("Update Failed");
            }
        }
        protected override void onDeleteState()
        {
            base.onDeleteState();
            try
            {
                //set the tool strip to say saving in case of long wait times
                parent.SetReadyLabel("Deleting");

                parent.DeleteEmpWorkRow(Convert.ToInt32(cbTaskID.SelectedValue), Convert.ToInt32(cbEmployeeID.SelectedValue), dtpWorkDate.Value);

                //set rowIndex to beginning
                rowIndex = 0;

                setTextboxText("","",DateTime.Today,0);

                //change tool strip to say saved after past commands are successful
                parent.SetReadyLabel("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                parent.SetReadyLabel("Delete Failed");//if any command fails set the strip to say save failed
            }
        }

        private void frmInputWork_Load(object sender, EventArgs e)
        {
            ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter();
            myAdapter.Fill(parent.MyDataSet.EmployeeWork);

            cbEmployeeID.DisplayMember = "FullName";
            cbEmployeeID.ValueMember = "EmployeeID";

            cbTaskID.ValueMember = "TaskID";
            cbTaskID.DisplayMember = "TaskName";

            FillComboBoxes();

            UpdateSelectedRow();
            manageEditingEnables(true);
        }

        private void FillComboBoxes()
        {
            ProjectTrackingDataSetTableAdapters.GetEmployeesFullNamesTableAdapter myEmpAdapter = new ProjectTrackingDataSetTableAdapters.GetEmployeesFullNamesTableAdapter();
            myEmpAdapter.Fill(parent.MyDataSet.GetEmployeesFullNames);

            ProjectTrackingDataSetTableAdapters.GetUnderwayTasksTableAdapter myTasksAdapter = new ProjectTrackingDataSetTableAdapters.GetUnderwayTasksTableAdapter();
            myTasksAdapter.Fill(parent.MyDataSet.GetUnderwayTasks);

            //add the list of managers to the manager combobox using thier EmpID as the value member
            cbEmployeeID.DataSource = parent.MyDataSet.GetEmployeesFullNames.Copy();

            //add the list of status to the status combobox using the StatusID as the value member
            cbTaskID.DataSource = parent.MyDataSet.GetUnderwayTasks.Copy();

        }

        public override void refresh()
        {
            //FillComboBoxes();
            base.refresh();         
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            base.btnAdd_Click(sender, e);
            setTextboxText("", "", DateTime.Today, 0);
            cbTaskID.Focus();
        }
    }
}

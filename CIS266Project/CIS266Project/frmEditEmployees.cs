using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class frmEditEmployees : CIS266Project.tmpEditForm
    {
        public frmEditEmployees()
        {
            InitializeComponent();
        }
        private void setTextboxText(string id, string first, string last, string title)
        {
            tbEmpID.Text = id;
            tbFirst.Text = first;
            tbLast.Text = last;
            tbTitle.Text = title;
        }

        protected override void fillControls()
        {
            try
            {
                parent.SetReadyLabel("Loading");

                ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter myAdapter = parent.GetEmployeesAdapter();

                numRows = parent.MyDataSet.Employees.Count;
                
                //set the controls display to the values in the Table at the selected row
                setTextboxText(parent.MyDataSet.Employees[rowIndex][0].ToString(),
                    parent.MyDataSet.Employees[rowIndex][1].ToString(),
                    parent.MyDataSet.Employees[rowIndex][2].ToString(),
                    parent.MyDataSet.Employees[rowIndex][3].ToString());

                parent.SetReadyLabel("Load Success");
            }
            catch
            {
                parent.SetReadyLabel("Load Failed");
            }
        }
        protected override void manageEditingEnables(bool edit)
        {
            base.manageEditingEnables(edit);
            tbFirst.Enabled = !edit;
            tbLast.Enabled = !edit;
            tbTitle.Enabled = !edit;
        }      
        protected override void onAddState()
        {
            base.onAddState();
            try
            {
                //set the tool strip to say saving in case of long wait times
                parent.SetReadyLabel("Saving");

                parent.InsertEmployeesTable(tbFirst.Text, tbLast.Text, tbTitle.Text);

                //change tool strip to say saved after past commands are successful
                parent.SetReadyLabel("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                parent.SetReadyLabel("Save Failed");//if any command fails set the strip to say save failed
            }
        }
        protected override void onEditState()
        {
            base.onEditState();
            try
            {
                //set the tool strip to say saving in case of long wait times
                parent.SetReadyLabel("Updating");

                parent.UpdateEmployeeRow(rowIndex, tbFirst.Text, tbLast.Text, tbTitle.Text);

                //change tool strip to say saved after past commands are successful
                parent.SetReadyLabel("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                parent.SetReadyLabel("Update Failed");//if any command fails set the strip to say save failed
            }
        }
        protected override void onDeleteState()
        {
            base.onDeleteState();
            try
            {
                //set the tool strip to say saving in case of long wait times
                parent.SetReadyLabel("Deleting");

                parent.DeleteEmployeeRow(Int32.Parse(tbEmpID.Text));

                //change tool strip to say saved after past commands are successful
                parent.SetReadyLabel("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                parent.SetReadyLabel("Delete Failed");//if any command fails set the strip to say save failed
            }
        }
        

        private void frmEditEmployees_Load(object sender, EventArgs e)
        {
            ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter();
            myAdapter.Fill(parent.MyDataSet.Employees);

            UpdateSelectedRow();
            manageEditingEnables(true);

            tbFirst.Focus();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            base.btnAdd_Click(sender, e);
            setTextboxText("", "", "", "");
            tbFirst.Focus();
        }
    }
}

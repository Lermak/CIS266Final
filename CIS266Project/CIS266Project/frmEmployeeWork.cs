using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class frmEmployeeWork : CIS266Project.NavigatorForm
    {
        public frmEmployeeWork()
        {
            InitializeComponent();
        }
        private void frmEmployeeWork_Load(object sender, EventArgs e)
        {
            UpdateSelectedRow();
        }
        protected override void fillControls()
        {
            try
            {
                parent.SetReadyLabel("Loading");

                ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter myEmpAdapter = parent.GetEmployeesAdapter();

                numRows = parent.MyDataSet.Employees.Count;

                tbEmployeeID.Text = parent.MyDataSet.Employees.Rows[rowIndex][0].ToString();
                tbFirstName.Text = parent.MyDataSet.Employees.Rows[rowIndex][1].ToString();
                tbLastName.Text = parent.MyDataSet.Employees.Rows[rowIndex][2].ToString();
                tbTitle.Text = parent.MyDataSet.Employees.Rows[rowIndex][3].ToString();

                ProjectTrackingDataSetTableAdapters.getTasksByEmployeeTableAdapter myAdapter = new ProjectTrackingDataSetTableAdapters.getTasksByEmployeeTableAdapter();
                myAdapter.Fill(parent.MyDataSet.getTasksByEmployee, Int32.Parse(tbEmployeeID.Text));

                dgvWork.DataSource = parent.MyDataSet.getTasksByEmployee.Copy();

                ProjectTrackingDataSetTableAdapters.getTotalWorkHoursByEmployeeTableAdapter myTotal = new ProjectTrackingDataSetTableAdapters.getTotalWorkHoursByEmployeeTableAdapter();
                myTotal.Fill(parent.MyDataSet.getTotalWorkHoursByEmployee, Int32.Parse(parent.MyDataSet.Employees.Rows[rowIndex][0].ToString()));

                lblTotalHours.Text = parent.MyDataSet.getTotalWorkHoursByEmployee[0][0].ToString();

                parent.SetReadyLabel("Load Success");
            }
            catch
            {
                parent.SetReadyLabel("Load Failed");
            }
        }
    }
}

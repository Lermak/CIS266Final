using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class frmMain : Form
    {
        private int ticks = 0;//used to manage when to refresh the data in all child forms
        private ProjectTrackingDataSet myDataSet;

        //read only property for the dataset
        public ProjectTrackingDataSet MyDataSet
        {
            get { return myDataSet; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        //public method to change the ready label
        public void SetReadyLabel(string input)
        {
            lblReady.Text = input;
        }

        //set the mdi parent of a form to this form and show it
        private void ShowForm(Form toShow)
        {
            toShow.MdiParent = this;
            toShow.Show();
        }

        //setup form and load in dataset
        private void frmMain_Load(object sender, EventArgs e)
        {
            myDataSet = new ProjectTrackingDataSet();
            SetReadyLabel("Ready");
            GetTasksAdapter();
            GetProjectsAdapter();
            GetStatusAdapter();
            GetEmployeesAdapter();
            GetEmpWorkAdapter();
        }

        #region Public methods to retrieve filled table adapters
        public ProjectTrackingDataSetTableAdapters.TasksTableAdapter GetTasksAdapter()
        {
            ProjectTrackingDataSetTableAdapters.TasksTableAdapter tData = new ProjectTrackingDataSetTableAdapters.TasksTableAdapter();
            tData.Fill(myDataSet.Tasks);
            return tData;
        }

        public ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter GetProjectsAdapter()
        {
            ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter pData = new ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter();
            pData.Fill(myDataSet.Projects);
            return pData;
        }

        public ProjectTrackingDataSetTableAdapters.LuStatusTableAdapter GetStatusAdapter()
        {
            ProjectTrackingDataSetTableAdapters.LuStatusTableAdapter sData = new ProjectTrackingDataSetTableAdapters.LuStatusTableAdapter();
            sData.Fill(myDataSet.LuStatus);
            return sData;
        }

        public ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter GetEmployeesAdapter()
        {
            ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter empData = new ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter();
            empData.Fill(myDataSet.Employees);
            return empData;
        }

        public ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter GetEmpWorkAdapter()
        {
            ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter ewData = new ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter();
            ewData.Fill(myDataSet.EmployeeWork);
            return ewData;
        }
        #endregion

        #region public methods to insert data into a table
        public void InsertTasksTable(int project, string name, string desc, DateTime startDate, DateTime? endDate, int status)
        {
            ProjectTrackingDataSetTableAdapters.TasksTableAdapter myAdapter = GetTasksAdapter();
            myAdapter.Insert(project, name, desc, startDate, endDate, status);

            myDataSet.Tasks.AcceptChanges();

            myAdapter.Update(myDataSet.Tasks);
        }
        public void InsertProjectsTable(string name, int manager, int status, string desc, DateTime startDate, DateTime? endDate)
        {

            ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter myAdapter = GetProjectsAdapter();
            myAdapter.Insert(name, manager, status, desc, startDate, endDate);

            myDataSet.Projects.AcceptChanges();

            myAdapter.Update(myDataSet.Projects);
        }
        /*public void InsertStatusTable()
        {
            ProjectTrackingDataSetTableAdapters.LuStatusTableAdapter myAdapter = GetStatusAdapter();
            myAdapter.Insert();
        }*/
        public void InsertEmployeesTable(string first, string last, string title)
        {
            ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter myAdapter = GetEmployeesAdapter();
            myAdapter.Insert(first, last, title);

            myDataSet.AcceptChanges();

            myAdapter.Update(myDataSet.Employees);
        }
        public void InsertEmpWorkTable(int task, int emp, DateTime date, decimal hours)
        {
            ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter myAdapter = GetEmpWorkAdapter();
            myAdapter.Insert(task, emp, date, hours);

            myDataSet.EmployeeWork.AcceptChanges();

            myAdapter.Update(myDataSet.EmployeeWork);
        }
        #endregion

        #region public methods to edit data in a table
        public void UpdateTasksRow(int rowIndex, int project, string name, string desc, DateTime startDate, DateTime? endDate, int status)
        {
            ProjectTrackingDataSetTableAdapters.TasksTableAdapter myAdapter = GetTasksAdapter();

            myDataSet.Tasks[rowIndex][1] = project;
            myDataSet.Tasks[rowIndex][2] = name;
            myDataSet.Tasks[rowIndex][3] = desc;
            myDataSet.Tasks[rowIndex][4] = startDate;
            if(endDate == null)
                myDataSet.Tasks[rowIndex][5] = DBNull.Value;
            else
                myDataSet.Tasks[rowIndex][5] = endDate;
            myDataSet.Tasks[rowIndex][6] = status;

            myAdapter.Update(myDataSet.Tasks);
        }
        public void UpdateProjectRow(int rowIndex, string name, int manager, int status, string desc, DateTime startDate, DateTime? endDate)
        {
            ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter myAdapter = GetProjectsAdapter();

            myDataSet.Projects[rowIndex][1] = name;
            myDataSet.Projects[rowIndex][2] = manager;
            myDataSet.Projects[rowIndex][3] = status;
            myDataSet.Projects[rowIndex][4] = desc;
            myDataSet.Projects[rowIndex][5] = startDate;
            if(endDate == null)
                myDataSet.Projects[rowIndex][6] = DBNull.Value;
            else
                myDataSet.Projects[rowIndex][6] = endDate;

            myAdapter.Update(myDataSet.Projects);
        }
        public void UpdateEmployeeRow(int rowIndex, string first, string last, string title)
        {
            ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter myAdapter = GetEmployeesAdapter();

            myDataSet.Employees[rowIndex][1] = first;
            myDataSet.Employees[rowIndex][2] = last;
            myDataSet.Employees[rowIndex][3] = title;

            myAdapter.Update(myDataSet.Employees);
        }
        public void UpdateEmpWorkRow(int rowIndex, int task, int emp, DateTime date, decimal hours)
        {
            ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter myAdapter = GetEmpWorkAdapter();

            myDataSet.EmployeeWork[rowIndex][1] = emp;
            myDataSet.EmployeeWork[rowIndex][2] = date;
            myDataSet.EmployeeWork[rowIndex][3] = hours;

            myAdapter.Update(myDataSet.EmployeeWork);
        }
        #endregion

        #region public methods to delete data in a table

        public void DeleteTasksRow(int task)
        {
            ProjectTrackingDataSetTableAdapters.TasksTableAdapter myAdapter = GetTasksAdapter();

            myAdapter.Delete(task);

            myDataSet.AcceptChanges();

            myAdapter.Update(myDataSet.Tasks);
        }
        public void DeleteProjectRow(int project)
        {
            ProjectTrackingDataSetTableAdapters.ProjectsTableAdapter myAdapter = GetProjectsAdapter();

            myAdapter.Delete(project);

            myDataSet.Projects.AcceptChanges();

            myAdapter.Update(myDataSet.Projects);
        }
        public void DeleteEmployeeRow(int emp)
        {
            ProjectTrackingDataSetTableAdapters.EmployeesTableAdapter myAdapter = GetEmployeesAdapter();

            myAdapter.Delete(emp);

            myDataSet.AcceptChanges();

            myAdapter.Update(myDataSet.Employees);
        }
        public void DeleteEmpWorkRow(int task, int emp, DateTime work)
        {
            ProjectTrackingDataSetTableAdapters.EmployeeWorkTableAdapter myAdapter = GetEmpWorkAdapter();

            myAdapter.Delete(task, emp, work.ToShortDateString());

            myDataSet.EmployeeWork.AcceptChanges();

            myAdapter.Update(myDataSet.EmployeeWork);
        }

        #endregion

        //update clock every timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (ticks % 60 == 0)
            {
                updateOpenForms();
                ticks = 0;
            }
        }

        //set layout to cascade
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        //set layout to horizontal
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        //set layout to vertical
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        #region Create and show new forms
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmEditEmployees());
        }

        private void workByEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmEmployeeWork());
        }

        private void workByProjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmProjectWork());
        }

        private void tasksByProjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmTasks());
        }

        private void addWorkHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmInputWork());
        }

        private void projectInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmEditProjectInfo());
        }

        private void taskInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmEditTaskInfo());
        }
        #endregion

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Close all open forms in the mdi parent
        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Close();
        }

        //for every form open in this form
        //get the data again and fill it's controlls
        //this ensures data remains up to date on all forms rather 
        //than having to reopen them to get most up to date information
        private void updateOpenForms()
        {
            foreach(NavigatorForm frm in this.MdiChildren)
            {
                if(frm.MyEditState == EditState.viewing)
                    frm.refresh();
            }
        }
    }
}

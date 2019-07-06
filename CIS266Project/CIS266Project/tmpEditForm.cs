using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class tmpEditForm : CIS266Project.NavigatorForm
    {    
        public tmpEditForm()
        {
            InitializeComponent();
        }
        //inheritable method to manage both the navigation buttons and the editing buttons
        //the nav buttons will only be enabled when the editing buttons are
        //i.e. when you can click on edit, delete, or add you can navigate
        //but you can't navigate when you are editing, adding, or deleting
        protected virtual void manageEditingEnables(bool edit)
        {
            //toggle the buttons that edit, delete and Add
            btnEdit.Enabled = edit;
            btnDelete.Enabled = edit;
            btnAdd.Enabled = edit;
            //toggled the saved and cancel buttons
            btnSave.Enabled = !edit;
            btnCancel.Enabled = !edit;

            manageNavigationButtons();
        }
        //the method that will be called when the save button is pressed and the edit state is Add
        protected virtual void onAddState()
        {
            numRows++;
            rowIndex = numRows - 1;
        }
        //the method that will be called when the save button is pressed and the edit state is Edit
        protected virtual void onEditState()
        {
        }
        //the method that will be called when the save button is pressed and the edit state is Delete
        protected virtual void onDeleteState()
        {
            numRows--;
            rowIndex = 0;
        }
        //Setup the form to delete an item from the table
        //focus cancel in case of accedental click
        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {
            manageEditingEnables(false);
            editState = EditState.deleting;
            parent.SetReadyLabel("Verify Delete");
            btnCancel.Focus();
        }
        //Setup the form to add a new item
        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            manageEditingEnables(false);
            setNavigationButtons(false);
            editState = EditState.adding;
            parent.SetReadyLabel("Adding");
        }
        //Setup the form to edit the item currently selected
        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {
            manageEditingEnables(false);
            editState = EditState.updating;
            parent.SetReadyLabel("Editing");
        }
        //setup the form to go back to navigating
        //based on edit state perform the appropriate function
        //update the row
        //Return to the next button of the nav bar
        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                manageEditingEnables(true);
                this.Validate();
                //run the virtual methods based on the edit state of the form
                if (editState == EditState.adding)
                {
                    onAddState();
                }
                else if (editState == EditState.updating)
                {
                    onEditState();
                }
                else if (editState == EditState.deleting)
                {
                    onDeleteState();
                }
                editState = EditState.viewing;
                UpdateSelectedRow();
                btnNext.Focus();
            }
            catch
            {
                parent.SetReadyLabel("Error Occured With Operation");
            }
        }
        //Return to navigation state without implementing any changes
        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            manageEditingEnables(true);
            editState = EditState.viewing;
            UpdateSelectedRow();
            parent.SetReadyLabel("Operation Cancled");
        }
    }
}

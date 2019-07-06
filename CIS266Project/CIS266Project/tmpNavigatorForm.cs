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
    public enum EditState
    {
        viewing,
        adding,
        updating,
        deleting
    }
    public partial class NavigatorForm : Form
    {
        protected EditState editState = EditState.viewing;//my current edit state
        public EditState MyEditState
        { get { return editState; } }

        //the table row that is selected
        protected int rowIndex = 0;
        protected int numRows = 0;
        protected frmMain parent
        { get { return (frmMain)this.MdiParent; } }

        public NavigatorForm()
        {
            InitializeComponent();

            setNavigationButtons(false, false, true, true);
        }
        //set the enabled state of all the buttons indevidually
        protected void setNavigationButtons(bool first, bool prev, bool next, bool last)
        {
            btnFirst.Enabled = first;
            btnPrev.Enabled = prev;
            btnNext.Enabled = next;
            btnLast.Enabled = last;
        }
        //set the enabled state of all the buttons as a group
        protected void setNavigationButtons(bool enabled)
        {
            btnFirst.Enabled = enabled;
            btnPrev.Enabled = enabled;
            btnNext.Enabled = enabled;
            btnLast.Enabled = enabled;
        }
        public virtual void UpdateSelectedRow()
        {
            fillControls();
            manageNavigationButtons();            
        }
        //inheritable method to fill the controls any child may have
        protected virtual void fillControls()
        {

        }

        public virtual void refresh()
        {
            UpdateSelectedRow();          
        }
        //Basic control over all navigation buttons on this form. 
        //This will enable and disable the buttons when the appropriate item
        //in the list of items is reached
        protected void manageNavigationButtons()
        {
            bool first, prev, next, last;
            first = prev = next = last = true;
            //disable the prev and next buttons when the row index is 0
            if (rowIndex <= 0)
            {
                first = prev = false;
            }
            //disable the next and last buttons when there are less than 0 rows or you are at numRows
            if (rowIndex >= numRows - 1)
            {
                rowIndex = numRows - 1;
                next = last = false;                
            }
            if (numRows < 0)
            {
                next = last = false;
            }

            setNavigationButtons(first, prev, next, last);
        }
        //The basic funtionality of the buttons
        //when they are enabled and clicked they will automatically navigate to the appropriate item
        //in the list
        protected virtual void btnFirst_Click(object sender, EventArgs e)
        {
            //go to the first item and update
            rowIndex = 0;
            UpdateSelectedRow();            
        }
        protected virtual void btnPrev_Click(object sender, EventArgs e)
        {
            //go to the previous item, but not below 0 and update
            rowIndex--;
            if (rowIndex < 0)
                rowIndex = 0;
            UpdateSelectedRow();

        }
        protected virtual void btnNext_Click(object sender, EventArgs e)
        {
            //go to the next item, but not above the number of rows and update
            rowIndex++;
            if (rowIndex > numRows - 1)
                rowIndex = numRows - 1;
            UpdateSelectedRow();
        }
        protected virtual void btnLast_Click(object sender, EventArgs e)
        {
            //Go to the last item and update
            rowIndex = numRows - 1;
            UpdateSelectedRow();   
        }
    }
}

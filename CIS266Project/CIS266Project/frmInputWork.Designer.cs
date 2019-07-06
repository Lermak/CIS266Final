namespace CIS266Project
{
    partial class frmInputWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label taskIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label workDateLabel;
            System.Windows.Forms.Label workHoursLabel;
            this.cbTaskID = new System.Windows.Forms.ComboBox();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.workHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            taskIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            workDateLabel = new System.Windows.Forms.Label();
            workHoursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workHoursNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(346, 12);
            this.btnAdd.TabIndex = 12;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(346, 41);
            this.btnEdit.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 70);
            this.btnDelete.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(346, 99);
            this.btnSave.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 128);
            this.btnCancel.TabIndex = 16;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 135);
            this.btnFirst.TabIndex = 8;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(93, 135);
            this.btnPrev.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(174, 135);
            this.btnNext.TabIndex = 10;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(255, 135);
            this.btnLast.TabIndex = 11;
            // 
            // taskIDLabel
            // 
            taskIDLabel.AutoSize = true;
            taskIDLabel.Location = new System.Drawing.Point(17, 15);
            taskIDLabel.Name = "taskIDLabel";
            taskIDLabel.Size = new System.Drawing.Size(48, 13);
            taskIDLabel.TabIndex = 0;
            taskIDLabel.Text = "Task ID:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(17, 42);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 2;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // workDateLabel
            // 
            workDateLabel.AutoSize = true;
            workDateLabel.Location = new System.Drawing.Point(17, 70);
            workDateLabel.Name = "workDateLabel";
            workDateLabel.Size = new System.Drawing.Size(62, 13);
            workDateLabel.TabIndex = 4;
            workDateLabel.Text = "Work Date:";
            // 
            // workHoursLabel
            // 
            workHoursLabel.AutoSize = true;
            workHoursLabel.Location = new System.Drawing.Point(17, 94);
            workHoursLabel.Name = "workHoursLabel";
            workHoursLabel.Size = new System.Drawing.Size(67, 13);
            workHoursLabel.TabIndex = 6;
            workHoursLabel.Text = "Work Hours:";
            // 
            // cbTaskID
            // 
            this.cbTaskID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskID.FormattingEnabled = true;
            this.cbTaskID.Location = new System.Drawing.Point(93, 12);
            this.cbTaskID.Name = "cbTaskID";
            this.cbTaskID.Size = new System.Drawing.Size(200, 21);
            this.cbTaskID.TabIndex = 1;
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(93, 39);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(200, 21);
            this.cbEmployeeID.TabIndex = 3;
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkDate.Location = new System.Drawing.Point(93, 66);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(200, 20);
            this.dtpWorkDate.TabIndex = 5;
            // 
            // workHoursNumericUpDown
            // 
            this.workHoursNumericUpDown.DecimalPlaces = 2;
            this.workHoursNumericUpDown.Location = new System.Drawing.Point(93, 92);
            this.workHoursNumericUpDown.Name = "workHoursNumericUpDown";
            this.workHoursNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.workHoursNumericUpDown.TabIndex = 7;
            // 
            // frmInputWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(435, 171);
            this.Controls.Add(workHoursLabel);
            this.Controls.Add(this.workHoursNumericUpDown);
            this.Controls.Add(taskIDLabel);
            this.Controls.Add(this.cbTaskID);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.cbEmployeeID);
            this.Controls.Add(workDateLabel);
            this.Controls.Add(this.dtpWorkDate);
            this.Name = "frmInputWork";
            this.Text = "Edit Work";
            this.Load += new System.EventHandler(this.frmInputWork_Load);
            this.Controls.SetChildIndex(this.btnFirst, 0);
            this.Controls.SetChildIndex(this.btnPrev, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnLast, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dtpWorkDate, 0);
            this.Controls.SetChildIndex(workDateLabel, 0);
            this.Controls.SetChildIndex(this.cbEmployeeID, 0);
            this.Controls.SetChildIndex(employeeIDLabel, 0);
            this.Controls.SetChildIndex(this.cbTaskID, 0);
            this.Controls.SetChildIndex(taskIDLabel, 0);
            this.Controls.SetChildIndex(this.workHoursNumericUpDown, 0);
            this.Controls.SetChildIndex(workHoursLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.workHoursNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTaskID;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.NumericUpDown workHoursNumericUpDown;
    }
}

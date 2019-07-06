namespace CIS266Project
{
    partial class frmEditTaskInfo
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
            System.Windows.Forms.Label projectIDLabel;
            System.Windows.Forms.Label taskNameLabel;
            System.Windows.Forms.Label taskDescriptionLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label taskStatusLabel;
            System.Windows.Forms.Label projectEndLabel;
            this.tbTaskID = new System.Windows.Forms.TextBox();
            this.cbProjectID = new System.Windows.Forms.ComboBox();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            taskIDLabel = new System.Windows.Forms.Label();
            projectIDLabel = new System.Windows.Forms.Label();
            taskNameLabel = new System.Windows.Forms.Label();
            taskDescriptionLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            taskStatusLabel = new System.Windows.Forms.Label();
            projectEndLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 12);
            this.btnAdd.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(337, 41);
            this.btnEdit.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 70);
            this.btnDelete.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 99);
            this.btnSave.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(337, 128);
            this.btnCancel.TabIndex = 22;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 213);
            this.btnFirst.TabIndex = 14;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(93, 213);
            this.btnPrev.TabIndex = 15;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(174, 213);
            this.btnNext.TabIndex = 16;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(255, 213);
            this.btnLast.TabIndex = 17;
            // 
            // taskIDLabel
            // 
            taskIDLabel.AutoSize = true;
            taskIDLabel.Location = new System.Drawing.Point(14, 14);
            taskIDLabel.Name = "taskIDLabel";
            taskIDLabel.Size = new System.Drawing.Size(48, 13);
            taskIDLabel.TabIndex = 0;
            taskIDLabel.Text = "Task ID:";
            // 
            // projectIDLabel
            // 
            projectIDLabel.AutoSize = true;
            projectIDLabel.Location = new System.Drawing.Point(14, 40);
            projectIDLabel.Name = "projectIDLabel";
            projectIDLabel.Size = new System.Drawing.Size(57, 13);
            projectIDLabel.TabIndex = 2;
            projectIDLabel.Text = "Project ID:";
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.Location = new System.Drawing.Point(14, 67);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new System.Drawing.Size(65, 13);
            taskNameLabel.TabIndex = 4;
            taskNameLabel.Text = "Task Name:";
            // 
            // taskDescriptionLabel
            // 
            taskDescriptionLabel.AutoSize = true;
            taskDescriptionLabel.Location = new System.Drawing.Point(14, 93);
            taskDescriptionLabel.Name = "taskDescriptionLabel";
            taskDescriptionLabel.Size = new System.Drawing.Size(90, 13);
            taskDescriptionLabel.TabIndex = 6;
            taskDescriptionLabel.Text = "Task Description:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(14, 120);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 8;
            startDateLabel.Text = "Start Date:";
            // 
            // taskStatusLabel
            // 
            taskStatusLabel.AutoSize = true;
            taskStatusLabel.Location = new System.Drawing.Point(12, 171);
            taskStatusLabel.Name = "taskStatusLabel";
            taskStatusLabel.Size = new System.Drawing.Size(67, 13);
            taskStatusLabel.TabIndex = 12;
            taskStatusLabel.Text = "Task Status:";
            // 
            // projectEndLabel
            // 
            projectEndLabel.AutoSize = true;
            projectEndLabel.Location = new System.Drawing.Point(12, 145);
            projectEndLabel.Name = "projectEndLabel";
            projectEndLabel.Size = new System.Drawing.Size(55, 13);
            projectEndLabel.TabIndex = 10;
            projectEndLabel.Text = "End Date:";
            // 
            // tbTaskID
            // 
            this.tbTaskID.Enabled = false;
            this.tbTaskID.Location = new System.Drawing.Point(110, 11);
            this.tbTaskID.Name = "tbTaskID";
            this.tbTaskID.Size = new System.Drawing.Size(200, 20);
            this.tbTaskID.TabIndex = 1;
            // 
            // cbProjectID
            // 
            this.cbProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectID.FormattingEnabled = true;
            this.cbProjectID.Location = new System.Drawing.Point(110, 37);
            this.cbProjectID.Name = "cbProjectID";
            this.cbProjectID.Size = new System.Drawing.Size(200, 21);
            this.cbProjectID.TabIndex = 3;
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(110, 64);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(200, 20);
            this.tbTaskName.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(110, 90);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(200, 20);
            this.tbDescription.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(110, 116);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(110, 168);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 21);
            this.cbStatus.TabIndex = 13;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(110, 142);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(200, 20);
            this.tbEndDate.TabIndex = 11;
            // 
            // frmEditTaskInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(426, 249);
            this.Controls.Add(projectEndLabel);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(taskIDLabel);
            this.Controls.Add(this.tbTaskID);
            this.Controls.Add(projectIDLabel);
            this.Controls.Add(this.cbProjectID);
            this.Controls.Add(taskNameLabel);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(taskDescriptionLabel);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(taskStatusLabel);
            this.Controls.Add(this.cbStatus);
            this.Name = "frmEditTaskInfo";
            this.Text = "Edit Tasks";
            this.Load += new System.EventHandler(this.frmEditTaskInfo_Load);
            this.Controls.SetChildIndex(this.btnFirst, 0);
            this.Controls.SetChildIndex(this.btnPrev, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnLast, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.cbStatus, 0);
            this.Controls.SetChildIndex(taskStatusLabel, 0);
            this.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.Controls.SetChildIndex(startDateLabel, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            this.Controls.SetChildIndex(taskDescriptionLabel, 0);
            this.Controls.SetChildIndex(this.tbTaskName, 0);
            this.Controls.SetChildIndex(taskNameLabel, 0);
            this.Controls.SetChildIndex(this.cbProjectID, 0);
            this.Controls.SetChildIndex(projectIDLabel, 0);
            this.Controls.SetChildIndex(this.tbTaskID, 0);
            this.Controls.SetChildIndex(taskIDLabel, 0);
            this.Controls.SetChildIndex(this.tbEndDate, 0);
            this.Controls.SetChildIndex(projectEndLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTaskID;
        private System.Windows.Forms.ComboBox cbProjectID;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbEndDate;
    }
}
